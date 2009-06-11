namespace OATH_wm6
{
    partial class formMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMain));
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.menuItemFile = new System.Windows.Forms.MenuItem();
            this.menuItemKeys = new System.Windows.Forms.MenuItem();
            this.menuItemNew = new System.Windows.Forms.MenuItem();
            this.menuItemOpen = new System.Windows.Forms.MenuItem();
            this.menuItemAdvanced = new System.Windows.Forms.MenuItem();
            this.menuItemAbout = new System.Windows.Forms.MenuItem();
            this.menuItemExit = new System.Windows.Forms.MenuItem();
            this.pictureBoxBackground = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelKey = new System.Windows.Forms.Label();
            this.panelAdvanced = new System.Windows.Forms.Panel();
            this.textBoxFactor = new System.Windows.Forms.TextBox();
            this.checkBoxChecksum = new System.Windows.Forms.CheckBox();
            this.numericUpDownOffset = new System.Windows.Forms.NumericUpDown();
            this.labelOffset = new System.Windows.Forms.Label();
            this.numericUpDownLength = new System.Windows.Forms.NumericUpDown();
            this.labelLength = new System.Windows.Forms.Label();
            this.labelFactor = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.timerGenerate = new System.Windows.Forms.Timer();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.panelAdvanced.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.menuItemFile);
            this.mainMenu1.MenuItems.Add(this.menuItemAbout);
            // 
            // menuItemFile
            // 
            this.menuItemFile.MenuItems.Add(this.menuItemKeys);
            this.menuItemFile.MenuItems.Add(this.menuItemAdvanced);
            this.menuItemFile.MenuItems.Add(this.menuItemExit);
            this.menuItemFile.Text = "&File";
            // 
            // menuItemKeys
            // 
            this.menuItemKeys.MenuItems.Add(this.menuItemNew);
            this.menuItemKeys.MenuItems.Add(this.menuItemOpen);
            this.menuItemKeys.Text = "&Keys";
            // 
            // menuItemNew
            // 
            this.menuItemNew.Text = "&New";
            this.menuItemNew.Click += new System.EventHandler(this.menuItemNew_Click);
            // 
            // menuItemOpen
            // 
            this.menuItemOpen.Text = "&Open";
            this.menuItemOpen.Click += new System.EventHandler(this.menuItemOpen_Click);
            // 
            // menuItemAdvanced
            // 
            this.menuItemAdvanced.Text = "&Advanced";
            this.menuItemAdvanced.Click += new System.EventHandler(this.menuItemAdvanced_Click);
            // 
            // menuItemAbout
            // 
            this.menuItemAbout.Text = "Abou&t";
            this.menuItemAbout.Click += new System.EventHandler(this.menuItemAbout_Click);
            // 
            // menuItemExit
            // 
            this.menuItemExit.Text = "E&xit";
            this.menuItemExit.Click += new System.EventHandler(this.menuItemExit_Click);
            // 
            // pictureBoxBackground
            // 
            this.pictureBoxBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxBackground.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBackground.Image")));
            this.pictureBoxBackground.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxBackground.Name = "pictureBoxBackground";
            this.pictureBoxBackground.Size = new System.Drawing.Size(240, 268);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(96, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            // 
            // labelKey
            // 
            this.labelKey.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular);
            this.labelKey.Location = new System.Drawing.Point(3, 118);
            this.labelKey.Name = "labelKey";
            this.labelKey.Size = new System.Drawing.Size(234, 30);
            this.labelKey.Text = "000000";
            this.labelKey.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelAdvanced
            // 
            this.panelAdvanced.Controls.Add(this.buttonGenerate);
            this.panelAdvanced.Controls.Add(this.textBoxFactor);
            this.panelAdvanced.Controls.Add(this.checkBoxChecksum);
            this.panelAdvanced.Controls.Add(this.numericUpDownOffset);
            this.panelAdvanced.Controls.Add(this.labelOffset);
            this.panelAdvanced.Controls.Add(this.numericUpDownLength);
            this.panelAdvanced.Controls.Add(this.labelLength);
            this.panelAdvanced.Controls.Add(this.labelFactor);
            this.panelAdvanced.Location = new System.Drawing.Point(3, 167);
            this.panelAdvanced.Name = "panelAdvanced";
            this.panelAdvanced.Size = new System.Drawing.Size(234, 88);
            this.panelAdvanced.Visible = false;
            // 
            // textBoxFactor
            // 
            this.textBoxFactor.Location = new System.Drawing.Point(52, 4);
            this.textBoxFactor.Name = "textBoxFactor";
            this.textBoxFactor.Size = new System.Drawing.Size(179, 21);
            this.textBoxFactor.TabIndex = 31;
            // 
            // checkBoxChecksum
            // 
            this.checkBoxChecksum.Location = new System.Drawing.Point(125, 33);
            this.checkBoxChecksum.Name = "checkBoxChecksum";
            this.checkBoxChecksum.Size = new System.Drawing.Size(106, 20);
            this.checkBoxChecksum.TabIndex = 27;
            this.checkBoxChecksum.Text = "Checksum";
            // 
            // numericUpDownOffset
            // 
            this.numericUpDownOffset.Location = new System.Drawing.Point(52, 61);
            this.numericUpDownOffset.Name = "numericUpDownOffset";
            this.numericUpDownOffset.Size = new System.Drawing.Size(67, 22);
            this.numericUpDownOffset.TabIndex = 23;
            // 
            // labelOffset
            // 
            this.labelOffset.Location = new System.Drawing.Point(3, 63);
            this.labelOffset.Name = "labelOffset";
            this.labelOffset.Size = new System.Drawing.Size(43, 20);
            this.labelOffset.Text = "Offset";
            // 
            // numericUpDownLength
            // 
            this.numericUpDownLength.Location = new System.Drawing.Point(52, 33);
            this.numericUpDownLength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownLength.Name = "numericUpDownLength";
            this.numericUpDownLength.Size = new System.Drawing.Size(67, 22);
            this.numericUpDownLength.TabIndex = 22;
            this.numericUpDownLength.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // labelLength
            // 
            this.labelLength.Location = new System.Drawing.Point(3, 35);
            this.labelLength.Name = "labelLength";
            this.labelLength.Size = new System.Drawing.Size(43, 20);
            this.labelLength.Text = "Length";
            // 
            // labelFactor
            // 
            this.labelFactor.Location = new System.Drawing.Point(3, 5);
            this.labelFactor.Name = "labelFactor";
            this.labelFactor.Size = new System.Drawing.Size(43, 20);
            this.labelFactor.Text = "Factor";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "oath.key";
            this.openFileDialog1.Filter = "Key files|*.key|All files|*.*";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "oath.key";
            this.saveFileDialog1.Filter = "Key files|*.key|All files|*.*";
            // 
            // timerGenerate
            // 
            this.timerGenerate.Interval = 1000;
            this.timerGenerate.Tick += new System.EventHandler(this.timerGenerate_Tick);
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(143, 63);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(72, 20);
            this.buttonGenerate.TabIndex = 35;
            this.buttonGenerate.Text = "Generate";
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.panelAdvanced);
            this.Controls.Add(this.labelKey);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBoxBackground);
            this.Menu = this.mainMenu1;
            this.Name = "formMain";
            this.Text = "OATH";
            this.Load += new System.EventHandler(this.formMain_Load);
            this.panelAdvanced.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxBackground;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuItem menuItemFile;
        private System.Windows.Forms.MenuItem menuItemKeys;
        private System.Windows.Forms.MenuItem menuItemNew;
        private System.Windows.Forms.MenuItem menuItemOpen;
        private System.Windows.Forms.MenuItem menuItemAdvanced;
        private System.Windows.Forms.MenuItem menuItemAbout;
        private System.Windows.Forms.MenuItem menuItemExit;
        private System.Windows.Forms.Label labelKey;
        private System.Windows.Forms.Panel panelAdvanced;
        private System.Windows.Forms.CheckBox checkBoxChecksum;
        private System.Windows.Forms.NumericUpDown numericUpDownOffset;
        private System.Windows.Forms.Label labelOffset;
        private System.Windows.Forms.NumericUpDown numericUpDownLength;
        private System.Windows.Forms.Label labelLength;
        private System.Windows.Forms.Label labelFactor;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Timer timerGenerate;
        private System.Windows.Forms.TextBox textBoxFactor;
        private System.Windows.Forms.Button buttonGenerate;
    }
}

