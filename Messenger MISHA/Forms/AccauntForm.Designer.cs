namespace Messenger_MISHA
{
    partial class AccauntForm
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
            panel3 = new Panel();
            textBox_frends = new TextBox();
            panel4 = new Panel();
            textBox1 = new TextBox();
            pictureBox3 = new PictureBox();
            panel_day_registration = new Panel();
            textBox_date = new TextBox();
            pictureBox4 = new PictureBox();
            panel_registration = new Panel();
            button_save_info = new Button();
            textBox_Name = new TextBox();
            pictureBox2 = new PictureBox();
            textBox_password = new TextBox();
            button_Ico = new Button();
            textBox_info = new TextBox();
            textBox_Email = new TextBox();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel_day_registration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel_registration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(37, 42, 64);
            panel3.Controls.Add(textBox_frends);
            panel3.Location = new Point(347, 359);
            panel3.Name = "panel3";
            panel3.Size = new Size(411, 133);
            panel3.TabIndex = 26;
            // 
            // textBox_frends
            // 
            textBox_frends.BackColor = Color.FromArgb(37, 42, 64);
            textBox_frends.BorderStyle = BorderStyle.None;
            textBox_frends.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox_frends.ForeColor = SystemColors.ScrollBar;
            textBox_frends.Location = new Point(15, 15);
            textBox_frends.Multiline = true;
            textBox_frends.Name = "textBox_frends";
            textBox_frends.ReadOnly = true;
            textBox_frends.Size = new Size(105, 23);
            textBox_frends.TabIndex = 2;
            textBox_frends.Text = "Ваши друзья";
            textBox_frends.TextChanged += textBox_frends_TextChanged;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(37, 42, 64);
            panel4.Controls.Add(textBox1);
            panel4.Controls.Add(pictureBox3);
            panel4.Location = new Point(12, 359);
            panel4.Name = "panel4";
            panel4.Size = new Size(317, 133);
            panel4.TabIndex = 25;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(37, 42, 64);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.ForeColor = SystemColors.ScrollBar;
            textBox1.Location = new Point(142, 15);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(172, 44);
            textBox1.TabIndex = 1;
            textBox1.Text = "Время проведенное в аккаунте";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.image_40__2_;
            pictureBox3.Location = new Point(31, 15);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(90, 90);
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // panel_day_registration
            // 
            panel_day_registration.BackColor = Color.FromArgb(37, 42, 64);
            panel_day_registration.Controls.Add(textBox_date);
            panel_day_registration.Controls.Add(pictureBox4);
            panel_day_registration.Location = new Point(602, 12);
            panel_day_registration.Name = "panel_day_registration";
            panel_day_registration.Size = new Size(156, 341);
            panel_day_registration.TabIndex = 24;
            // 
            // textBox_date
            // 
            textBox_date.BackColor = Color.FromArgb(37, 42, 64);
            textBox_date.BorderStyle = BorderStyle.None;
            textBox_date.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBox_date.ForeColor = SystemColors.ScrollBar;
            textBox_date.Location = new Point(0, 116);
            textBox_date.Multiline = true;
            textBox_date.Name = "textBox_date";
            textBox_date.ReadOnly = true;
            textBox_date.Size = new Size(156, 69);
            textBox_date.TabIndex = 1;
            textBox_date.Text = "Дата регистрации            аккаунта";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.image_41;
            pictureBox4.Location = new Point(33, 20);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(90, 90);
            pictureBox4.TabIndex = 0;
            pictureBox4.TabStop = false;
            // 
            // panel_registration
            // 
            panel_registration.BackColor = Color.FromArgb(37, 42, 64);
            panel_registration.Controls.Add(button_save_info);
            panel_registration.Controls.Add(textBox_Name);
            panel_registration.Controls.Add(pictureBox2);
            panel_registration.Controls.Add(textBox_password);
            panel_registration.Controls.Add(button_Ico);
            panel_registration.Controls.Add(textBox_info);
            panel_registration.Controls.Add(textBox_Email);
            panel_registration.Location = new Point(12, 12);
            panel_registration.Name = "panel_registration";
            panel_registration.Size = new Size(572, 341);
            panel_registration.TabIndex = 23;
            // 
            // button_save_info
            // 
            button_save_info.BackColor = Color.FromArgb(24, 30, 54);
            button_save_info.FlatAppearance.BorderColor = Color.Silver;
            button_save_info.FlatAppearance.BorderSize = 0;
            button_save_info.FlatStyle = FlatStyle.Flat;
            button_save_info.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_save_info.ForeColor = Color.FromArgb(0, 126, 249);
            button_save_info.Location = new Point(189, 294);
            button_save_info.Name = "button_save_info";
            button_save_info.Size = new Size(195, 35);
            button_save_info.TabIndex = 9;
            button_save_info.Text = "Сохранить";
            button_save_info.UseVisualStyleBackColor = false;
            button_save_info.Click += button_save_info_Click;
            // 
            // textBox_Name
            // 
            textBox_Name.BackColor = Color.FromArgb(74, 79, 99);
            textBox_Name.BorderStyle = BorderStyle.None;
            textBox_Name.Cursor = Cursors.IBeam;
            textBox_Name.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox_Name.ForeColor = SystemColors.ScrollBar;
            textBox_Name.Location = new Point(189, 20);
            textBox_Name.Multiline = true;
            textBox_Name.Name = "textBox_Name";
            textBox_Name.Size = new Size(364, 25);
            textBox_Name.TabIndex = 4;
            textBox_Name.TextChanged += textBox_Name_TextChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.image_36;
            pictureBox2.Location = new Point(19, 20);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(120, 120);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // textBox_password
            // 
            textBox_password.BackColor = Color.FromArgb(74, 79, 99);
            textBox_password.BorderStyle = BorderStyle.None;
            textBox_password.Cursor = Cursors.IBeam;
            textBox_password.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox_password.ForeColor = SystemColors.ScrollBar;
            textBox_password.Location = new Point(189, 67);
            textBox_password.Multiline = true;
            textBox_password.Name = "textBox_password";
            textBox_password.Size = new Size(364, 25);
            textBox_password.TabIndex = 5;
            textBox_password.TextChanged += textBox_password_TextChanged_1;
            // 
            // button_Ico
            // 
            button_Ico.BackColor = Color.FromArgb(24, 30, 54);
            button_Ico.FlatAppearance.BorderSize = 0;
            button_Ico.FlatStyle = FlatStyle.Flat;
            button_Ico.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button_Ico.ForeColor = Color.FromArgb(0, 126, 249);
            button_Ico.Location = new Point(19, 146);
            button_Ico.Name = "button_Ico";
            button_Ico.Size = new Size(120, 25);
            button_Ico.TabIndex = 8;
            button_Ico.Text = "Сменить аватар";
            button_Ico.UseVisualStyleBackColor = false;
            button_Ico.Click += button_Ico_Click;
            // 
            // textBox_info
            // 
            textBox_info.BackColor = Color.FromArgb(74, 79, 99);
            textBox_info.BorderStyle = BorderStyle.None;
            textBox_info.Cursor = Cursors.IBeam;
            textBox_info.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox_info.ForeColor = SystemColors.ScrollBar;
            textBox_info.Location = new Point(19, 187);
            textBox_info.Multiline = true;
            textBox_info.Name = "textBox_info";
            textBox_info.Size = new Size(534, 101);
            textBox_info.TabIndex = 7;
            textBox_info.Text = "О себе";
            // 
            // textBox_Email
            // 
            textBox_Email.BackColor = Color.FromArgb(74, 79, 99);
            textBox_Email.BorderStyle = BorderStyle.None;
            textBox_Email.Cursor = Cursors.IBeam;
            textBox_Email.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox_Email.ForeColor = SystemColors.ScrollBar;
            textBox_Email.Location = new Point(189, 115);
            textBox_Email.Multiline = true;
            textBox_Email.Name = "textBox_Email";
            textBox_Email.Size = new Size(364, 25);
            textBox_Email.TabIndex = 6;
            textBox_Email.TextChanged += textBox_Email_TextChanged;
            // 
            // AccauntForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(770, 500);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(panel_day_registration);
            Controls.Add(panel_registration);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AccauntForm";
            Text = "AccauntForm";
            Load += AccauntForm_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel_day_registration.ResumeLayout(false);
            panel_day_registration.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel_registration.ResumeLayout(false);
            panel_registration.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Panel panel4;
        private TextBox textBox1;
        private PictureBox pictureBox3;
        private Panel panel_day_registration;
        private TextBox textBox_date;
        private PictureBox pictureBox4;
        private Panel panel_registration;
        private Button button_save_info;
        private TextBox textBox_Name;
        public PictureBox pictureBox2;
        private TextBox textBox_password;
        private TextBox textBox_info;
        private TextBox textBox_Email;
        private Button button_Ico;
        private TextBox textBox_frends;
    }
}