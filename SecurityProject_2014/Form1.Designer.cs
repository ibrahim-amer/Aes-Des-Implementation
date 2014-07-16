namespace SecurityProject_2014
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GetText_Button = new System.Windows.Forms.Button();
            this.Decrypt_Button = new System.Windows.Forms.Button();
            this.Hide_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PlainText_textBox = new System.Windows.Forms.TextBox();
            this.Encrypt_Button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.CipherText_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Choises_comboBox = new System.Windows.Forms.ComboBox();
            this.FromPath_label = new System.Windows.Forms.Label();
            this.FromPath_textBox = new System.Windows.Forms.TextBox();
            this.FromPath_radioButton = new System.Windows.Forms.RadioButton();
            this.Input_radiobutton = new System.Windows.Forms.RadioButton();
            this.Defualt_radioButton = new System.Windows.Forms.RadioButton();
            this.StegoImage_picbox = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StegoImage_picbox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1595, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveImageToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(155, 24);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenImage_Click);
            // 
            // saveImageToolStripMenuItem
            // 
            this.saveImageToolStripMenuItem.Name = "saveImageToolStripMenuItem";
            this.saveImageToolStripMenuItem.Size = new System.Drawing.Size(155, 24);
            this.saveImageToolStripMenuItem.Text = "Save Image";
            this.saveImageToolStripMenuItem.Click += new System.EventHandler(this.SaveImage_Click);
            // 
            // GetText_Button
            // 
            this.GetText_Button.Location = new System.Drawing.Point(309, 593);
            this.GetText_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GetText_Button.Name = "GetText_Button";
            this.GetText_Button.Size = new System.Drawing.Size(75, 71);
            this.GetText_Button.TabIndex = 21;
            this.GetText_Button.Text = "Extract Cipher Text";
            this.GetText_Button.UseVisualStyleBackColor = true;
            this.GetText_Button.Click += new System.EventHandler(this.GetText_Button_Click);
            // 
            // Decrypt_Button
            // 
            this.Decrypt_Button.Location = new System.Drawing.Point(837, 620);
            this.Decrypt_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Decrypt_Button.Name = "Decrypt_Button";
            this.Decrypt_Button.Size = new System.Drawing.Size(75, 43);
            this.Decrypt_Button.TabIndex = 20;
            this.Decrypt_Button.Text = "Decrypt";
            this.Decrypt_Button.UseVisualStyleBackColor = true;
            this.Decrypt_Button.Click += new System.EventHandler(this.Decrypt_Button_Click);
            // 
            // Hide_Button
            // 
            this.Hide_Button.Location = new System.Drawing.Point(151, 593);
            this.Hide_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Hide_Button.Name = "Hide_Button";
            this.Hide_Button.Size = new System.Drawing.Size(75, 71);
            this.Hide_Button.TabIndex = 19;
            this.Hide_Button.Text = "Hide Cipher Text";
            this.Hide_Button.UseVisualStyleBackColor = true;
            this.Hide_Button.Click += new System.EventHandler(this.Hide_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(933, 542);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Plain Text";
            // 
            // PlainText_textBox
            // 
            this.PlainText_textBox.Location = new System.Drawing.Point(939, 400);
            this.PlainText_textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PlainText_textBox.Multiline = true;
            this.PlainText_textBox.Name = "PlainText_textBox";
            this.PlainText_textBox.Size = new System.Drawing.Size(439, 139);
            this.PlainText_textBox.TabIndex = 17;
            // 
            // Encrypt_Button
            // 
            this.Encrypt_Button.Location = new System.Drawing.Point(837, 572);
            this.Encrypt_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Encrypt_Button.Name = "Encrypt_Button";
            this.Encrypt_Button.Size = new System.Drawing.Size(75, 43);
            this.Encrypt_Button.TabIndex = 16;
            this.Encrypt_Button.Text = "Encrypt";
            this.Encrypt_Button.UseVisualStyleBackColor = true;
            this.Encrypt_Button.Click += new System.EventHandler(this.Encrypt_Button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(933, 667);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Cipher Text";
            // 
            // CipherText_textBox
            // 
            this.CipherText_textBox.Location = new System.Drawing.Point(936, 570);
            this.CipherText_textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CipherText_textBox.Multiline = true;
            this.CipherText_textBox.Name = "CipherText_textBox";
            this.CipherText_textBox.Size = new System.Drawing.Size(427, 94);
            this.CipherText_textBox.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 572);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Stego Image";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.Choises_comboBox);
            this.groupBox2.Controls.Add(this.FromPath_label);
            this.groupBox2.Controls.Add(this.FromPath_textBox);
            this.groupBox2.Controls.Add(this.FromPath_radioButton);
            this.groupBox2.Controls.Add(this.Input_radiobutton);
            this.groupBox2.Controls.Add(this.Defualt_radioButton);
            this.groupBox2.Location = new System.Drawing.Point(941, 110);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(523, 272);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Choose Cipher Key";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 197);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 17);
            this.label8.TabIndex = 5;
            this.label8.Text = "Algorithm";
            // 
            // Choises_comboBox
            // 
            this.Choises_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Choises_comboBox.FormattingEnabled = true;
            this.Choises_comboBox.Location = new System.Drawing.Point(93, 193);
            this.Choises_comboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Choises_comboBox.Name = "Choises_comboBox";
            this.Choises_comboBox.Size = new System.Drawing.Size(121, 24);
            this.Choises_comboBox.TabIndex = 3;
            this.Choises_comboBox.SelectedIndexChanged += new System.EventHandler(this.Choises_comboBox_SelectedIndexChanged);
            // 
            // FromPath_label
            // 
            this.FromPath_label.AutoSize = true;
            this.FromPath_label.Location = new System.Drawing.Point(20, 127);
            this.FromPath_label.Name = "FromPath_label";
            this.FromPath_label.Size = new System.Drawing.Size(73, 17);
            this.FromPath_label.TabIndex = 4;
            this.FromPath_label.Text = "Path / Key";
            // 
            // FromPath_textBox
            // 
            this.FromPath_textBox.Location = new System.Drawing.Point(101, 123);
            this.FromPath_textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FromPath_textBox.Name = "FromPath_textBox";
            this.FromPath_textBox.Size = new System.Drawing.Size(352, 22);
            this.FromPath_textBox.TabIndex = 3;
            // 
            // FromPath_radioButton
            // 
            this.FromPath_radioButton.AutoSize = true;
            this.FromPath_radioButton.Location = new System.Drawing.Point(109, 37);
            this.FromPath_radioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FromPath_radioButton.Name = "FromPath_radioButton";
            this.FromPath_radioButton.Size = new System.Drawing.Size(94, 21);
            this.FromPath_radioButton.TabIndex = 2;
            this.FromPath_radioButton.TabStop = true;
            this.FromPath_radioButton.Text = "From Path";
            this.FromPath_radioButton.UseVisualStyleBackColor = true;
            // 
            // Input_radiobutton
            // 
            this.Input_radiobutton.AutoSize = true;
            this.Input_radiobutton.Location = new System.Drawing.Point(213, 37);
            this.Input_radiobutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Input_radiobutton.Name = "Input_radiobutton";
            this.Input_radiobutton.Size = new System.Drawing.Size(60, 21);
            this.Input_radiobutton.TabIndex = 1;
            this.Input_radiobutton.TabStop = true;
            this.Input_radiobutton.Text = "Input";
            this.Input_radiobutton.UseVisualStyleBackColor = true;
            this.Input_radiobutton.CheckedChanged += new System.EventHandler(this.Input_radiobutton_CheckedChanged);
            // 
            // Defualt_radioButton
            // 
            this.Defualt_radioButton.AutoSize = true;
            this.Defualt_radioButton.Location = new System.Drawing.Point(7, 37);
            this.Defualt_radioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Defualt_radioButton.Name = "Defualt_radioButton";
            this.Defualt_radioButton.Size = new System.Drawing.Size(74, 21);
            this.Defualt_radioButton.TabIndex = 0;
            this.Defualt_radioButton.TabStop = true;
            this.Defualt_radioButton.Text = "Defualt";
            this.Defualt_radioButton.UseVisualStyleBackColor = true;
            // 
            // StegoImage_picbox
            // 
            this.StegoImage_picbox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.StegoImage_picbox.Location = new System.Drawing.Point(15, 66);
            this.StegoImage_picbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StegoImage_picbox.Name = "StegoImage_picbox";
            this.StegoImage_picbox.Size = new System.Drawing.Size(824, 502);
            this.StegoImage_picbox.TabIndex = 11;
            this.StegoImage_picbox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1595, 750);
            this.Controls.Add(this.GetText_Button);
            this.Controls.Add(this.Decrypt_Button);
            this.Controls.Add(this.Hide_Button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PlainText_textBox);
            this.Controls.Add(this.Encrypt_Button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CipherText_textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.StegoImage_picbox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StegoImage_picbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveImageToolStripMenuItem;
        private System.Windows.Forms.Button GetText_Button;
        private System.Windows.Forms.Button Decrypt_Button;
        private System.Windows.Forms.Button Hide_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PlainText_textBox;
        private System.Windows.Forms.Button Encrypt_Button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CipherText_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox Choises_comboBox;
        private System.Windows.Forms.Label FromPath_label;
        private System.Windows.Forms.TextBox FromPath_textBox;
        private System.Windows.Forms.RadioButton FromPath_radioButton;
        private System.Windows.Forms.RadioButton Input_radiobutton;
        private System.Windows.Forms.RadioButton Defualt_radioButton;
        private System.Windows.Forms.PictureBox StegoImage_picbox;
    }
}

