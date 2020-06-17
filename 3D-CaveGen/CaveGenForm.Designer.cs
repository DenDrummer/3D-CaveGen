namespace _3D_CaveGen
{
    partial class CaveGenForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.worldSlicePictureBox = new System.Windows.Forms.PictureBox();
            this.smoothenButton = new System.Windows.Forms.Button();
            this.generateNewButton = new System.Windows.Forms.Button();
            this.wallPercentageInput = new System.Windows.Forms.NumericUpDown();
            this.wallPercentageLabel = new System.Windows.Forms.Label();
            this.wallCreationInput = new System.Windows.Forms.NumericUpDown();
            this.wallDeletionInput = new System.Windows.Forms.NumericUpDown();
            this.wallCreationLabel = new System.Windows.Forms.Label();
            this.edgesAreWallsCheckBox = new System.Windows.Forms.CheckBox();
            this.wallDeletionLabel = new System.Windows.Forms.Label();
            this.GenerationSettings = new System.Windows.Forms.GroupBox();
            this.heightInput = new System.Windows.Forms.NumericUpDown();
            this.widthInput = new System.Windows.Forms.NumericUpDown();
            this.depthLabel = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.depthInput = new System.Windows.Forms.NumericUpDown();
            this.SmoothingSettings = new System.Windows.Forms.GroupBox();
            this.displaySettings = new System.Windows.Forms.GroupBox();
            this.shownSliceBar = new System.Windows.Forms.TrackBar();
            this.showYZSliceButton = new System.Windows.Forms.RadioButton();
            this.showXZSliceButton = new System.Windows.Forms.RadioButton();
            this.showXYSliceButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.worldSlicePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wallPercentageInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wallCreationInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wallDeletionInput)).BeginInit();
            this.GenerationSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.heightInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depthInput)).BeginInit();
            this.SmoothingSettings.SuspendLayout();
            this.displaySettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shownSliceBar)).BeginInit();
            this.SuspendLayout();
            // 
            // worldSlicePictureBox
            // 
            this.worldSlicePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.worldSlicePictureBox.Location = new System.Drawing.Point(12, 12);
            this.worldSlicePictureBox.Name = "worldSlicePictureBox";
            this.worldSlicePictureBox.Size = new System.Drawing.Size(459, 257);
            this.worldSlicePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.worldSlicePictureBox.TabIndex = 0;
            this.worldSlicePictureBox.TabStop = false;
            // 
            // smoothenButton
            // 
            this.smoothenButton.Location = new System.Drawing.Point(165, 48);
            this.smoothenButton.Name = "smoothenButton";
            this.smoothenButton.Size = new System.Drawing.Size(134, 27);
            this.smoothenButton.TabIndex = 6;
            this.smoothenButton.Text = "Smoothen";
            this.smoothenButton.UseVisualStyleBackColor = true;
            this.smoothenButton.Click += new System.EventHandler(this.smoothenButton_Click);
            // 
            // generateNewButton
            // 
            this.generateNewButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.generateNewButton.Location = new System.Drawing.Point(6, 136);
            this.generateNewButton.Name = "generateNewButton";
            this.generateNewButton.Size = new System.Drawing.Size(136, 45);
            this.generateNewButton.TabIndex = 5;
            this.generateNewButton.Text = "Generate New";
            this.generateNewButton.UseVisualStyleBackColor = true;
            this.generateNewButton.Click += new System.EventHandler(this.generateNewButton_Click);
            // 
            // wallPercentageInput
            // 
            this.wallPercentageInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.wallPercentageInput.Location = new System.Drawing.Point(97, 14);
            this.wallPercentageInput.Name = "wallPercentageInput";
            this.wallPercentageInput.Size = new System.Drawing.Size(45, 20);
            this.wallPercentageInput.TabIndex = 1;
            this.wallPercentageInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.wallPercentageInput.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // wallPercentageLabel
            // 
            this.wallPercentageLabel.AutoSize = true;
            this.wallPercentageLabel.Location = new System.Drawing.Point(6, 16);
            this.wallPercentageLabel.Name = "wallPercentageLabel";
            this.wallPercentageLabel.Size = new System.Drawing.Size(85, 13);
            this.wallPercentageLabel.TabIndex = 0;
            this.wallPercentageLabel.Text = "Wall percentage";
            // 
            // wallCreationInput
            // 
            this.wallCreationInput.Location = new System.Drawing.Point(98, 19);
            this.wallCreationInput.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.wallCreationInput.Name = "wallCreationInput";
            this.wallCreationInput.Size = new System.Drawing.Size(42, 20);
            this.wallCreationInput.TabIndex = 3;
            this.wallCreationInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.wallCreationInput.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.wallCreationInput.ValueChanged += new System.EventHandler(this.wallCreationInput_ValueChanged);
            // 
            // wallDeletionInput
            // 
            this.wallDeletionInput.Location = new System.Drawing.Point(98, 55);
            this.wallDeletionInput.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.wallDeletionInput.Name = "wallDeletionInput";
            this.wallDeletionInput.Size = new System.Drawing.Size(42, 20);
            this.wallDeletionInput.TabIndex = 4;
            this.wallDeletionInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.wallDeletionInput.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.wallDeletionInput.ValueChanged += new System.EventHandler(this.wallDeletionInput_ValueChanged);
            // 
            // wallCreationLabel
            // 
            this.wallCreationLabel.AutoSize = true;
            this.wallCreationLabel.Location = new System.Drawing.Point(6, 21);
            this.wallCreationLabel.Name = "wallCreationLabel";
            this.wallCreationLabel.Size = new System.Drawing.Size(89, 13);
            this.wallCreationLabel.TabIndex = 0;
            this.wallCreationLabel.Text = "Wall creation limit";
            // 
            // edgesAreWallsCheckBox
            // 
            this.edgesAreWallsCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.edgesAreWallsCheckBox.Checked = true;
            this.edgesAreWallsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.edgesAreWallsCheckBox.Location = new System.Drawing.Point(165, 19);
            this.edgesAreWallsCheckBox.Name = "edgesAreWallsCheckBox";
            this.edgesAreWallsCheckBox.Size = new System.Drawing.Size(134, 23);
            this.edgesAreWallsCheckBox.TabIndex = 1;
            this.edgesAreWallsCheckBox.Text = "Edges are walls";
            this.edgesAreWallsCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.edgesAreWallsCheckBox.UseVisualStyleBackColor = true;
            this.edgesAreWallsCheckBox.CheckedChanged += new System.EventHandler(this.edgesAreWallsCheckBox_CheckedChanged);
            // 
            // wallDeletionLabel
            // 
            this.wallDeletionLabel.AutoSize = true;
            this.wallDeletionLabel.Location = new System.Drawing.Point(6, 57);
            this.wallDeletionLabel.Name = "wallDeletionLabel";
            this.wallDeletionLabel.Size = new System.Drawing.Size(88, 13);
            this.wallDeletionLabel.TabIndex = 0;
            this.wallDeletionLabel.Text = "Wall deletion limit";
            // 
            // GenerationSettings
            // 
            this.GenerationSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.GenerationSettings.Controls.Add(this.heightInput);
            this.GenerationSettings.Controls.Add(this.widthInput);
            this.GenerationSettings.Controls.Add(this.depthLabel);
            this.GenerationSettings.Controls.Add(this.widthLabel);
            this.GenerationSettings.Controls.Add(this.heightLabel);
            this.GenerationSettings.Controls.Add(this.depthInput);
            this.GenerationSettings.Controls.Add(this.wallPercentageLabel);
            this.GenerationSettings.Controls.Add(this.wallPercentageInput);
            this.GenerationSettings.Controls.Add(this.generateNewButton);
            this.GenerationSettings.Location = new System.Drawing.Point(12, 275);
            this.GenerationSettings.Name = "GenerationSettings";
            this.GenerationSettings.Size = new System.Drawing.Size(148, 200);
            this.GenerationSettings.TabIndex = 7;
            this.GenerationSettings.TabStop = false;
            this.GenerationSettings.Text = "Generation settings";
            // 
            // heightInput
            // 
            this.heightInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.heightInput.Location = new System.Drawing.Point(50, 66);
            this.heightInput.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.heightInput.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.heightInput.Name = "heightInput";
            this.heightInput.Size = new System.Drawing.Size(92, 20);
            this.heightInput.TabIndex = 2;
            this.heightInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.heightInput.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // widthInput
            // 
            this.widthInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.widthInput.Location = new System.Drawing.Point(50, 40);
            this.widthInput.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.widthInput.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.widthInput.Name = "widthInput";
            this.widthInput.Size = new System.Drawing.Size(92, 20);
            this.widthInput.TabIndex = 3;
            this.widthInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.widthInput.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // depthLabel
            // 
            this.depthLabel.AutoSize = true;
            this.depthLabel.Location = new System.Drawing.Point(6, 94);
            this.depthLabel.Name = "depthLabel";
            this.depthLabel.Size = new System.Drawing.Size(36, 13);
            this.depthLabel.TabIndex = 8;
            this.depthLabel.Text = "Depth";
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Location = new System.Drawing.Point(6, 42);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(35, 13);
            this.widthLabel.TabIndex = 7;
            this.widthLabel.Text = "Width";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(6, 68);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(38, 13);
            this.heightLabel.TabIndex = 6;
            this.heightLabel.Text = "Height";
            // 
            // depthInput
            // 
            this.depthInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.depthInput.Location = new System.Drawing.Point(50, 92);
            this.depthInput.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.depthInput.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.depthInput.Name = "depthInput";
            this.depthInput.Size = new System.Drawing.Size(92, 20);
            this.depthInput.TabIndex = 4;
            this.depthInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.depthInput.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // SmoothingSettings
            // 
            this.SmoothingSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SmoothingSettings.Controls.Add(this.wallCreationLabel);
            this.SmoothingSettings.Controls.Add(this.wallCreationInput);
            this.SmoothingSettings.Controls.Add(this.smoothenButton);
            this.SmoothingSettings.Controls.Add(this.edgesAreWallsCheckBox);
            this.SmoothingSettings.Controls.Add(this.wallDeletionLabel);
            this.SmoothingSettings.Controls.Add(this.wallDeletionInput);
            this.SmoothingSettings.Location = new System.Drawing.Point(166, 275);
            this.SmoothingSettings.Name = "SmoothingSettings";
            this.SmoothingSettings.Size = new System.Drawing.Size(305, 81);
            this.SmoothingSettings.TabIndex = 8;
            this.SmoothingSettings.TabStop = false;
            this.SmoothingSettings.Text = "Smoothng settings";
            // 
            // displaySettings
            // 
            this.displaySettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.displaySettings.Controls.Add(this.shownSliceBar);
            this.displaySettings.Controls.Add(this.showYZSliceButton);
            this.displaySettings.Controls.Add(this.showXZSliceButton);
            this.displaySettings.Controls.Add(this.showXYSliceButton);
            this.displaySettings.Location = new System.Drawing.Point(166, 362);
            this.displaySettings.Name = "displaySettings";
            this.displaySettings.Size = new System.Drawing.Size(305, 113);
            this.displaySettings.TabIndex = 9;
            this.displaySettings.TabStop = false;
            this.displaySettings.Text = "Display settings";
            // 
            // shownSliceBar
            // 
            this.shownSliceBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.shownSliceBar.Location = new System.Drawing.Point(6, 49);
            this.shownSliceBar.Name = "shownSliceBar";
            this.shownSliceBar.Size = new System.Drawing.Size(293, 45);
            this.shownSliceBar.TabIndex = 3;
            this.shownSliceBar.Scroll += new System.EventHandler(this.shownSliceBar_Scroll);
            // 
            // showYZSliceButton
            // 
            this.showYZSliceButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.showYZSliceButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.showYZSliceButton.Location = new System.Drawing.Point(208, 19);
            this.showYZSliceButton.Name = "showYZSliceButton";
            this.showYZSliceButton.Size = new System.Drawing.Size(91, 24);
            this.showYZSliceButton.TabIndex = 2;
            this.showYZSliceButton.Text = "Show YZ slice";
            this.showYZSliceButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.showYZSliceButton.UseVisualStyleBackColor = true;
            this.showYZSliceButton.CheckedChanged += new System.EventHandler(this.showYZSliceButton_CheckedChanged);
            // 
            // showXZSliceButton
            // 
            this.showXZSliceButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.showXZSliceButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.showXZSliceButton.Location = new System.Drawing.Point(103, 19);
            this.showXZSliceButton.Name = "showXZSliceButton";
            this.showXZSliceButton.Size = new System.Drawing.Size(99, 24);
            this.showXZSliceButton.TabIndex = 1;
            this.showXZSliceButton.Text = "Show XZ slice";
            this.showXZSliceButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.showXZSliceButton.UseVisualStyleBackColor = true;
            this.showXZSliceButton.CheckedChanged += new System.EventHandler(this.showXZSliceButton_CheckedChanged);
            // 
            // showXYSliceButton
            // 
            this.showXYSliceButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.showXYSliceButton.Checked = true;
            this.showXYSliceButton.Location = new System.Drawing.Point(6, 19);
            this.showXYSliceButton.Name = "showXYSliceButton";
            this.showXYSliceButton.Size = new System.Drawing.Size(91, 24);
            this.showXYSliceButton.TabIndex = 0;
            this.showXYSliceButton.TabStop = true;
            this.showXYSliceButton.Text = "Show XY slice";
            this.showXYSliceButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.showXYSliceButton.UseVisualStyleBackColor = true;
            this.showXYSliceButton.CheckedChanged += new System.EventHandler(this.showXYSliceButton_CheckedChanged);
            // 
            // CaveGenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 487);
            this.Controls.Add(this.displaySettings);
            this.Controls.Add(this.SmoothingSettings);
            this.Controls.Add(this.GenerationSettings);
            this.Controls.Add(this.worldSlicePictureBox);
            this.Name = "CaveGenForm";
            this.Text = "3D Cave Generator";
            ((System.ComponentModel.ISupportInitialize)(this.worldSlicePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wallPercentageInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wallCreationInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wallDeletionInput)).EndInit();
            this.GenerationSettings.ResumeLayout(false);
            this.GenerationSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.heightInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depthInput)).EndInit();
            this.SmoothingSettings.ResumeLayout(false);
            this.SmoothingSettings.PerformLayout();
            this.displaySettings.ResumeLayout(false);
            this.displaySettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shownSliceBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox worldSlicePictureBox;
        private System.Windows.Forms.Button smoothenButton;
        private System.Windows.Forms.Button generateNewButton;
        private System.Windows.Forms.NumericUpDown wallPercentageInput;
        private System.Windows.Forms.Label wallPercentageLabel;
        private System.Windows.Forms.NumericUpDown wallCreationInput;
        private System.Windows.Forms.NumericUpDown wallDeletionInput;
        private System.Windows.Forms.Label wallCreationLabel;
        private System.Windows.Forms.CheckBox edgesAreWallsCheckBox;
        private System.Windows.Forms.Label wallDeletionLabel;
        private System.Windows.Forms.GroupBox GenerationSettings;
        private System.Windows.Forms.NumericUpDown heightInput;
        private System.Windows.Forms.NumericUpDown widthInput;
        private System.Windows.Forms.Label depthLabel;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.NumericUpDown depthInput;
        private System.Windows.Forms.GroupBox SmoothingSettings;
        private System.Windows.Forms.GroupBox displaySettings;
        private System.Windows.Forms.RadioButton showYZSliceButton;
        private System.Windows.Forms.RadioButton showXZSliceButton;
        private System.Windows.Forms.RadioButton showXYSliceButton;
        private System.Windows.Forms.TrackBar shownSliceBar;
    }
}

