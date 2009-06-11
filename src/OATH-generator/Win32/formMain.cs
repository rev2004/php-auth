using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Xml;
using System.Resources;
using System.IO;

namespace OATH_win32
{
    public partial class formMain : Form
    {
        private byte[] secret;

        public formMain()
        {
            InitializeComponent();
        }

        private void formMain_Load(object sender, EventArgs e)
        {
            string filename = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetModules()[0].FullyQualifiedName);
            filename = filename + "\\oath.key";
            if (File.Exists(filename))
            {
                LoadFile(filename);
            } 
            
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RandomNumberGenerator rng = RandomNumberGenerator.Create();
            byte[] key = new Byte[20];
            rng.GetBytes(key);
            string Base64key = Convert.ToBase64String(key);
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (XmlWriter writer = XmlWriter.Create(saveFileDialog1.FileName))
                {
                    writer.WriteStartElement("oath");
                    writer.WriteElementString("key", Base64key);
                    writer.WriteEndElement();
                    writer.Flush();
                }
                LoadFile(saveFileDialog1.FileName);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                LoadFile(openFileDialog1.FileName);
            }
        }

        private void advancedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switch (panelAdvanced.Visible)
            {
                case true:
                    panelAdvanced.Visible = false;
                    advancedToolStripMenuItem.Checked = false;
                    if (this.secret != null)
                    {
                        timerGenerate.Enabled = true;
                    }
                    buttonGenerate.Enabled = false;
                    break;
                case false:
                    panelAdvanced.Visible = true;
                    advancedToolStripMenuItem.Checked = true;
                    timerGenerate.Enabled = false;
                    buttonGenerate.Enabled = true;
                    break;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string MessageBoxText = "Version " + AppDetails.Get(AppDetails.AttributeType.Version) + "\r\n" +
                                   AppDetails.Get(AppDetails.AttributeType.Copyright) + "\r\n\r\n" +
                                   AppDetails.Get(AppDetails.AttributeType.Description) + "\r\n\r\n";
            string MessageBoxCaption = AppDetails.Get(AppDetails.AttributeType.Title);
            MessageBox.Show(MessageBoxText, MessageBoxCaption, MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1);
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            if (this.secret != null)
            {
                textBoxKey.Text = GenerateOtp((long)numericUpDownFactor.Value);
            }
        }

        private void timerGenerate_Tick(object sender, EventArgs e)
        {
            long CurrentTime = (long)((DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0)).TotalSeconds/60);
            textBoxKey.Text = GenerateOtp(CurrentTime);
        }

        private void LoadFile(string filename)
        {
            using (XmlReader reader = XmlReader.Create(filename))
            {
                reader.ReadStartElement();
                this.secret = Convert.FromBase64String(reader.ReadElementString("key"));
            }
            if (panelAdvanced.Visible != true)
            {
                timerGenerate.Enabled = true;
                timerGenerate_Tick((object)timerGenerate, EventArgs.Empty);
            }
        }

        private string GenerateOtp(long Factor)
        {
            return OneTimePassword.generateOTP(secret, Factor, (int)numericUpDownLength.Value, checkBoxChecksum.Checked, (int)numericUpDownOffset.Value);
        }






    }
}
