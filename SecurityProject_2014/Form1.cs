namespace SecurityProject_2014
{
    using SecurityProject_2014.Steganography;
    using System;
    using System.Drawing;
    using System.Drawing.Imaging;
    using System.IO;
    using System.Windows.Forms;
    using MathWorks.MATLAB.NET.Arrays;
    using MathWorks.MATLAB.NET.Utility;

    public partial class Form1 : Form
    {
        Bitmap bmp;
        TextHider th;
        IEncryption encryptionDecriptionObj;
        MWNumericArray CipherKey;
        char[] ciphermsg;
        public Form1()
        {
            InitializeComponent();
            this.Choises_comboBox.Items.Add("AES");
            this.Choises_comboBox.Items.Add("DES");
            this.FromPath_label.Visible = false;
            this.FromPath_textBox.Visible = false;
        }

        

        private void OpenImage_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\Libraries\\Pictures";
            openFileDialog1.Filter = "*.BMP;*.PPM;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {

                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        string ext = Path.GetExtension(openFileDialog1.FileName);

                        using (myStream)
                        {

                            this.bmp = new Bitmap(myStream);
                            this.StegoImage_picbox.Image = bmp;

                            th = new TextHider(bmp);

                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void SaveImage_Click(object sender, EventArgs e)
        {
            Bitmap bm = new Bitmap(this.bmp);
            SaveFileDialog SFD = new SaveFileDialog();
            SFD.Filter = "Images|*.png;*.bmp;*.jpg";
            ImageFormat format = ImageFormat.Png;
            if (SFD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string ext = System.IO.Path.GetExtension(SFD.FileName);
                switch (ext)
                {
                    case ".jpg":
                        format = ImageFormat.Jpeg;
                        break;
                    case ".bmp":
                        format = ImageFormat.Bmp;
                        break;
                }
                //  Thread.Sleep(30);
                bm.Save(SFD.FileName, format);
            }
        }

        private void Choises_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = this.Choises_comboBox.SelectedIndex;
            string choosedalgo = this.Choises_comboBox.Items[i].ToString();
            if (choosedalgo.Equals("AES"))
            {
                if (this.Defualt_radioButton.Checked)
                    this.encryptionDecriptionObj = new AESSteg();
                else
                {
                    this.CipherKey = UIHelperFunctions.GetCipherKey(this.FromPath_textBox.Text);
                    this.encryptionDecriptionObj = new AESSteg(this.CipherKey);
                }
            }
            else
            {
                this.encryptionDecriptionObj = new DES(this.FromPath_textBox.Text);
            }
        }

        private void Encrypt_Button_Click(object sender, EventArgs e)
        {
            char[]chars = this.ciphermsg = this.encryptionDecriptionObj.Encrypt(this.PlainText_textBox.Text);
            for (int i = 0; i < chars.Length; i++) this.CipherText_textBox.Text += chars[i];
        }

        private void Hide_Button_Click(object sender, EventArgs e)
        {
            //string s = this.CipherText_textBox.Text;
            //this.StegoImage_picbox.Image = this.bmp = th.HideText(s);
            th.HideText(this.ciphermsg);
        }

        private void GetText_Button_Click(object sender, EventArgs e)
        {
            this.ciphermsg = this.th.GetText();
           // this.CipherText_textBox.Text = new string(ciphermsg);
           for (int i = 0; i < this.ciphermsg.Length; i++) this.CipherText_textBox.Text += this.ciphermsg[i];
        }

        private void Decrypt_Button_Click(object sender, EventArgs e)
        {
            char[]chars = this.encryptionDecriptionObj.Decrypt(this.ciphermsg);
            //this.PlainText_textBox.Text = new string(chars);
            for (int i = 0; i < chars.Length; i++) this.PlainText_textBox.Text += chars[i];
        }

        private void Defualt_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.FromPath_label.Visible = false;
            this.FromPath_textBox.Visible = false;
        }

        private void FromPath_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.FromPath_label.Visible = true;
            this.FromPath_textBox.Visible = true;
        }

        private void Input_radiobutton_CheckedChanged(object sender, EventArgs e)
        {
            this.FromPath_label.Visible = true;
            this.FromPath_textBox.Visible = true;
        }
    }
}
