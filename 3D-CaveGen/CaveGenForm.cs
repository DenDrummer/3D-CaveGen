using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace _3D_CaveGen
{
    public partial class CaveGenForm : Form
    {
        bool[,,] world;

        #region --- Generation settings ---
        decimal wallPercentage;
        ushort height;
        ushort width;
        ushort depth;
        #endregion

        #region --- Smoothing settings ---
        byte wallCreationLimit;
        byte wallDeletionLimit;
        bool edgesAreWalls;
        #endregion

        #region --- Display settings ---
        bool showXYSlice;
        bool showXZSlice;
        bool showYZSlice;
        ushort shownSlice;
        #endregion

        public CaveGenForm()
        {
            InitializeComponent();

            #region --- load settings ---
            #region --- Generation settings ---
            wallPercentage = wallPercentageInput.Value;
            height = (ushort)heightInput.Value; // y
            width = (ushort)widthInput.Value;   // x
            depth = (ushort)depthInput.Value;   // z
            #endregion

            #region --- Smoothing settings ---
            wallCreationLimit = (byte)wallCreationInput.Value;
            wallDeletionLimit = (byte)wallDeletionInput.Value;
            edgesAreWalls = edgesAreWallsCheckBox.Checked;
            #endregion

            #region --- Display settings ---
            showXYSlice = showXYSliceButton.Checked;
            showXZSlice = showXZSliceButton.Checked;
            showYZSlice = showYZSliceButton.Checked;
            updateSliceRange();
            shownSlice = (ushort)shownSliceBar.Value;
            #endregion
            #endregion
        }

        #region --- Generation methods ---
        private void generateNewButton_Click(object sender, EventArgs e)
        {
            #region --- update generation settings ---
            wallPercentage = wallPercentageInput.Value;
            height = (ushort)heightInput.Value; // y
            width = (ushort)widthInput.Value;   // x
            depth = (ushort)depthInput.Value;   // z
            #endregion

            // fill the map randomly with either true or false
            Random r = new Random();
            world = new bool[width, height, depth];
            for (int x = 0; x < world.GetLength(0); x++)
            {
                for (int y = 0; y < world.GetLength(1); y++)
                {
                    for (int z = 0; z < world.GetLength(2); z++)
                    {
                        world[x, y, z] = (decimal)r.NextDouble() > wallPercentage / 100;
                    }
                }
            }
            updateSliceRange();
            updatePicture();
        }
        #endregion

        #region --- smoothing methods ---
        private void wallCreationInput_ValueChanged(object sender, EventArgs e)
        {
            wallCreationLimit = (byte)wallCreationInput.Value;
        }

        private void wallDeletionInput_ValueChanged(object sender, EventArgs e)
        {
            wallDeletionLimit = (byte)wallDeletionInput.Value;
        }

        private void edgesAreWallsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            edgesAreWalls = edgesAreWallsCheckBox.Checked;
            if (edgesAreWalls)
            {
                edgesAreWallsCheckBox.Text = "Edges are walls";
            }
            else
            {
                edgesAreWallsCheckBox.Text = "Edges are air";
            }
        }

        private void smoothenButton_Click(object sender, EventArgs e)
        {
            byte[,,] smoothWorld = new byte[world.GetLength(0), world.GetLength(1), world.GetLength(2)];
            bool[,,] newWorld = new bool[world.GetLength(0), world.GetLength(1), world.GetLength(2)];
            byte comparer; // TODO: needs better name
            #region --- smoothen ---
            // for each slice
            for (ushort x = 0; x < world.GetLength(0); x++)
            {
                // for each row
                for (ushort y = 0; y < world.GetLength(1); y++)
                {
                    // for each cell
                    for (ushort z = 0; z < world.GetLength(2); z++)
                    {
                        smoothWorld[x, y, z] = 0;
                        #region --- smooth along XY slice ---
                        comparer = 0;
                        #region --- check surrounding cells ---
                        for (short i = -1; i < 2; i++)
                        {
                            for (short j = -1; j < 2; j++)
                            {
                                // if the cell you're checking is out of bounds
                                if (x + i < 0 ||
                                    x + i >= world.GetLength(0) ||
                                    y + j < 0 ||
                                    y + j >= world.GetLength(1))
                                {
                                    // read as a wall or air depending on settings
                                    if (edgesAreWalls)
                                    {
                                        comparer++;
                                    }
                                }
                                // if it's the center cell
                                else if (i == 0 && j == 0)
                                {
                                    // do nothing
                                }
                                else
                                {
                                    // if the cell is a wall (and thus not air)
                                    if (!world[x + i, y + j, z])
                                    {
                                        comparer++;
                                    }
                                }
                            }
                        }
                        #endregion
                        if (compareCell(x, y, z, comparer))
                        {
                            smoothWorld[x, y, z]++;
                        }
                        #endregion

                        #region --- smooth along XZ slice ---
                        comparer = 0;
                        #region --- check surrounding cells ---
                        for (int i = -1; i < 2; i++)
                        {
                            for (int j = -1; j < 2; j++)
                            {
                                // if the cell you're checking is out of bounds
                                if (x + i < 0 ||
                                    x + i >= world.GetLength(0) ||
                                    z + j < 0 ||
                                    z + j >= world.GetLength(2))
                                {
                                    // read as a wall or air depending on settings
                                    if (edgesAreWalls)
                                    {
                                        comparer++;
                                    }
                                }
                                // if it's the center cell
                                else if (i == 0 && j == 0)
                                {
                                    // do nothing
                                }
                                else
                                {
                                    // if the cell is a wall (and thus not air)
                                    if (!world[x + i, y, z + j])
                                    {
                                        comparer++;
                                    }
                                }
                            }
                        }
                        #endregion
                        if (compareCell(x, y, z, comparer))
                        {
                            smoothWorld[x, y, z]++;
                        }
                        #endregion

                        #region --- smooth along YZ slice ---
                        comparer = 0;
                        #region --- check surrounding cells ---
                        for (int i = -1; i < 2; i++)
                        {
                            for (int j = -1; j < 2; j++)
                            {
                                // if the cell you're checking is out of bounds
                                if (y + i < 0 ||
                                    y + i >= world.GetLength(1) ||
                                    z + j < 0 ||
                                    z + j >= world.GetLength(2))
                                {
                                    // read as a wall or air depending on settings
                                    if (edgesAreWalls)
                                    {
                                        comparer++;
                                    }
                                }
                                // if it's the center cell
                                else if (i == 0 && j == 0)
                                {
                                    // do nothing
                                }
                                else
                                {
                                    // if the cell is a wall (and thus not air)
                                    if (!world[x, y + i, z + j])
                                    {
                                        comparer++;
                                    }
                                }
                            }
                        }
                        #endregion
                        if (compareCell(x, y, z, comparer))
                        {
                            smoothWorld[x, y, z]++;
                        }
                        #endregion

                        #region --- convert back to boolean world ---
                        // if 2 or 3 out of the 3 dimensions say it should be a wall, make it a wall.
                        // otherwise make it air. 
                        newWorld[x, y, z] = smoothWorld[x, y, z] <= 1;
                        #endregion
                    }
                }
            }
            #endregion
            //update world
            world = newWorld;

            updatePicture();
        }

        private bool compareCell(ushort x, ushort y, ushort z, byte comparer)
        {
            // if the cell used to be air but has enough surrounding walls,
            //      mark as wall on this axis
            if (world[x, y, z] && comparer > wallCreationLimit)
            {
                return true;
            }
            // if the cell used to be a wall and has enough surrounding walls,
            //      mark as a wall on this axis
            else if (!world[x, y, z] && comparer >= wallDeletionLimit)
            {
                return true;
            }
            // 
            return false;
        }
        #endregion

        #region --- display methods ---
        private void updateSliceButtons(object sender, EventArgs e)
        {
            updateSliceRange();
            updatePicture();
        }

        private void shownSliceBar_Scroll(object sender, EventArgs e)
        {
            shownSlice = (ushort)shownSliceBar.Value;
            updatePicture();
        }

        private static Bitmap getPicture(bool[,] worldSlice)
        {
            Bitmap picture = new Bitmap(
                worldSlice.GetLength(0),
                worldSlice.GetLength(1),
                PixelFormat.Format32bppRgb);

            for (int x = 0; x < worldSlice.GetLength(0); x++)
            {
                for (int y = 0; y < worldSlice.GetLength(1); y++)
                {
                    if (worldSlice[x, y])
                    {
                        picture.SetPixel(x, y, Color.White);
                    }
                    else
                    {
                        picture.SetPixel(x, y, Color.Black);
                    }
                }
            }

            return picture;
        }

        private void updatePicture()
        {
            bool[,] worldSlice;
            if (showXYSlice)
            {
                worldSlice = new bool[world.GetLength(0), world.GetLength(1)];
                for (int x = 0; x < world.GetLength(0); x++)
                {
                    for (int y = 0; y < world.GetLength(1); y++)
                    {
                        worldSlice[x, y] = world[x, y, shownSlice];
                    }
                }
            }
            else if (showXZSlice)
            {
                worldSlice = new bool[world.GetLength(0), world.GetLength(2)];
                for (int x = 0; x < world.GetLength(0); x++)
                {
                    for (int z = 0; z < world.GetLength(2); z++)
                    {
                        worldSlice[x, z] = world[x, shownSlice, z];
                    }
                }
            }
            else if (showYZSlice)
            {
                worldSlice = new bool[world.GetLength(1), world.GetLength(2)];
                for (int y = 0; y < world.GetLength(1); y++)
                {
                    for (int z = 0; z < world.GetLength(2); z++)
                    {
                        worldSlice[y, z] = world[shownSlice, y, z];
                    }
                }
            }
            else
            {
                return;
            }
            worldSlicePictureBox.Image = getPicture(worldSlice);
        }

        private void updateSliceRange()
        {
            // update settings
            showXYSlice = showXYSliceButton.Checked;
            showXZSlice = showXZSliceButton.Checked;
            showYZSlice = showYZSliceButton.Checked;

            // show the correct slice range
            if (showXYSlice)
            {
                shownSliceBar.Maximum = depth - 1;
            }
            else if (showXZSlice)
            {
                shownSliceBar.Maximum = height - 1;
            }
            else if (showYZSlice)
            {
                shownSliceBar.Maximum = width - 1;
            }

            //move index into range if outside
            if (shownSlice > shownSliceBar.Maximum)
            {
                shownSlice = (ushort)shownSliceBar.Maximum;
            }
        }
        #endregion


    }
}
