namespace Messenger_MISHA.Forms
{
    partial class CreateGroop
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
            panel_groop_create_name = new Panel();
            label1 = new Label();
            button_X3 = new Button();
            panel_groop_create2 = new Panel();
            textBox_Name = new TextBox();
            panel_Groop_avatar = new Panel();
            button_Ico_groop_avatar = new Button();
            pictureBox1_Avatar_groop = new PictureBox();
            label2_Create_AVATAR_groop = new Label();
            panel_groop_Description = new Panel();
            label_name_Description = new Label();
            textBox_groop_Description = new TextBox();
            panel_Temm_groop = new Panel();
            checkedListBox_groop_tem = new CheckedListBox();
            label_temm_name = new Label();
            panel_serch_groop_personal = new Panel();
            button_add_frends = new Button();
            label_freend_name = new Label();
            panel_save_settings = new Panel();
            button_save_groop_settings = new Button();
            label_save_settings_name = new Label();
            panel_groop_create_name.SuspendLayout();
            panel_groop_create2.SuspendLayout();
            panel_Groop_avatar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1_Avatar_groop).BeginInit();
            panel_groop_Description.SuspendLayout();
            panel_Temm_groop.SuspendLayout();
            panel_serch_groop_personal.SuspendLayout();
            panel_save_settings.SuspendLayout();
            SuspendLayout();
            // 
            // panel_groop_create_name
            // 
            panel_groop_create_name.BackColor = Color.FromArgb(37, 42, 64);
            panel_groop_create_name.Controls.Add(label1);
            panel_groop_create_name.Location = new Point(12, 12);
            panel_groop_create_name.Name = "panel_groop_create_name";
            panel_groop_create_name.Size = new Size(234, 46);
            panel_groop_create_name.TabIndex = 37;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = SystemColors.AppWorkspace;
            label1.Location = new Point(38, 12);
            label1.Name = "label1";
            label1.Size = new Size(163, 22);
            label1.TabIndex = 0;
            label1.Text = "Название группы";
            // 
            // button_X3
            // 
            button_X3.FlatAppearance.BorderSize = 0;
            button_X3.FlatStyle = FlatStyle.Flat;
            button_X3.Font = new Font("Arial Narrow", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button_X3.ForeColor = Color.White;
            button_X3.Location = new Point(743, 12);
            button_X3.Name = "button_X3";
            button_X3.Size = new Size(25, 25);
            button_X3.TabIndex = 38;
            button_X3.Text = "X";
            button_X3.UseVisualStyleBackColor = true;
            button_X3.Click += button_X3_Click;
            // 
            // panel_groop_create2
            // 
            panel_groop_create2.BackColor = Color.FromArgb(37, 42, 64);
            panel_groop_create2.Controls.Add(textBox_Name);
            panel_groop_create2.Location = new Point(252, 12);
            panel_groop_create2.Name = "panel_groop_create2";
            panel_groop_create2.Size = new Size(485, 46);
            panel_groop_create2.TabIndex = 38;
            // 
            // textBox_Name
            // 
            textBox_Name.BackColor = Color.FromArgb(74, 79, 99);
            textBox_Name.BorderStyle = BorderStyle.None;
            textBox_Name.Cursor = Cursors.IBeam;
            textBox_Name.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox_Name.ForeColor = SystemColors.ScrollBar;
            textBox_Name.Location = new Point(13, 9);
            textBox_Name.Multiline = true;
            textBox_Name.Name = "textBox_Name";
            textBox_Name.Size = new Size(458, 25);
            textBox_Name.TabIndex = 1;
            // 
            // panel_Groop_avatar
            // 
            panel_Groop_avatar.BackColor = Color.FromArgb(37, 42, 64);
            panel_Groop_avatar.Controls.Add(button_Ico_groop_avatar);
            panel_Groop_avatar.Controls.Add(pictureBox1_Avatar_groop);
            panel_Groop_avatar.Controls.Add(label2_Create_AVATAR_groop);
            panel_Groop_avatar.Location = new Point(12, 64);
            panel_Groop_avatar.Name = "panel_Groop_avatar";
            panel_Groop_avatar.Size = new Size(234, 203);
            panel_Groop_avatar.TabIndex = 38;
            // 
            // button_Ico_groop_avatar
            // 
            button_Ico_groop_avatar.BackColor = Color.FromArgb(24, 30, 54);
            button_Ico_groop_avatar.FlatAppearance.BorderSize = 0;
            button_Ico_groop_avatar.FlatStyle = FlatStyle.Flat;
            button_Ico_groop_avatar.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button_Ico_groop_avatar.ForeColor = Color.FromArgb(0, 126, 249);
            button_Ico_groop_avatar.Location = new Point(55, 163);
            button_Ico_groop_avatar.Name = "button_Ico_groop_avatar";
            button_Ico_groop_avatar.Size = new Size(120, 25);
            button_Ico_groop_avatar.TabIndex = 3;
            button_Ico_groop_avatar.Text = "Сменить аватар";
            button_Ico_groop_avatar.UseVisualStyleBackColor = false;
            // 
            // pictureBox1_Avatar_groop
            // 
            pictureBox1_Avatar_groop.ErrorImage = Properties.Resources.image_36;
            pictureBox1_Avatar_groop.Image = Properties.Resources.image_36;
            pictureBox1_Avatar_groop.InitialImage = Properties.Resources.image_36;
            pictureBox1_Avatar_groop.Location = new Point(55, 37);
            pictureBox1_Avatar_groop.Name = "pictureBox1_Avatar_groop";
            pictureBox1_Avatar_groop.Size = new Size(120, 120);
            pictureBox1_Avatar_groop.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1_Avatar_groop.TabIndex = 1;
            pictureBox1_Avatar_groop.TabStop = false;
            // 
            // label2_Create_AVATAR_groop
            // 
            label2_Create_AVATAR_groop.AutoSize = true;
            label2_Create_AVATAR_groop.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2_Create_AVATAR_groop.ForeColor = SystemColors.AppWorkspace;
            label2_Create_AVATAR_groop.Location = new Point(38, 12);
            label2_Create_AVATAR_groop.Name = "label2_Create_AVATAR_groop";
            label2_Create_AVATAR_groop.Size = new Size(165, 22);
            label2_Create_AVATAR_groop.TabIndex = 0;
            label2_Create_AVATAR_groop.Text = "Выберите аватар ";
            // 
            // panel_groop_Description
            // 
            panel_groop_Description.BackColor = Color.FromArgb(37, 42, 64);
            panel_groop_Description.Controls.Add(label_name_Description);
            panel_groop_Description.Controls.Add(textBox_groop_Description);
            panel_groop_Description.Location = new Point(252, 64);
            panel_groop_Description.Name = "panel_groop_Description";
            panel_groop_Description.Size = new Size(485, 203);
            panel_groop_Description.TabIndex = 39;
            // 
            // label_name_Description
            // 
            label_name_Description.AutoSize = true;
            label_name_Description.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label_name_Description.ForeColor = SystemColors.AppWorkspace;
            label_name_Description.Location = new Point(13, 12);
            label_name_Description.Name = "label_name_Description";
            label_name_Description.Size = new Size(208, 22);
            label_name_Description.TabIndex = 7;
            label_name_Description.Text = "Придумайте описание ";
            // 
            // textBox_groop_Description
            // 
            textBox_groop_Description.BackColor = Color.FromArgb(74, 79, 99);
            textBox_groop_Description.BorderStyle = BorderStyle.None;
            textBox_groop_Description.Cursor = Cursors.IBeam;
            textBox_groop_Description.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox_groop_Description.ForeColor = SystemColors.ScrollBar;
            textBox_groop_Description.Location = new Point(13, 37);
            textBox_groop_Description.Multiline = true;
            textBox_groop_Description.Name = "textBox_groop_Description";
            textBox_groop_Description.Size = new Size(458, 151);
            textBox_groop_Description.TabIndex = 2;
            // 
            // panel_Temm_groop
            // 
            panel_Temm_groop.BackColor = Color.FromArgb(37, 42, 64);
            panel_Temm_groop.Controls.Add(checkedListBox_groop_tem);
            panel_Temm_groop.Controls.Add(label_temm_name);
            panel_Temm_groop.Location = new Point(12, 273);
            panel_Temm_groop.Name = "panel_Temm_groop";
            panel_Temm_groop.Size = new Size(234, 165);
            panel_Temm_groop.TabIndex = 40;
            // 
            // checkedListBox_groop_tem
            // 
            checkedListBox_groop_tem.BackColor = Color.FromArgb(37, 42, 64);
            checkedListBox_groop_tem.BorderStyle = BorderStyle.None;
            checkedListBox_groop_tem.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            checkedListBox_groop_tem.ForeColor = SystemColors.Window;
            checkedListBox_groop_tem.FormattingEnabled = true;
            checkedListBox_groop_tem.Items.AddRange(new object[] { "Образование", "Исскуство ", "Политика", "Игры", "Сторисы", "Бизнес" });
            checkedListBox_groop_tem.Location = new Point(55, 35);
            checkedListBox_groop_tem.Name = "checkedListBox_groop_tem";
            checkedListBox_groop_tem.Size = new Size(120, 120);
            checkedListBox_groop_tem.TabIndex = 5;
            // 
            // label_temm_name
            // 
            label_temm_name.AutoSize = true;
            label_temm_name.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label_temm_name.ForeColor = SystemColors.AppWorkspace;
            label_temm_name.Location = new Point(13, 10);
            label_temm_name.Name = "label_temm_name";
            label_temm_name.Size = new Size(211, 22);
            label_temm_name.TabIndex = 1;
            label_temm_name.Text = "Выберите тему группы";
            // 
            // panel_serch_groop_personal
            // 
            panel_serch_groop_personal.BackColor = Color.FromArgb(37, 42, 64);
            panel_serch_groop_personal.Controls.Add(button_add_frends);
            panel_serch_groop_personal.Controls.Add(label_freend_name);
            panel_serch_groop_personal.Location = new Point(252, 273);
            panel_serch_groop_personal.Name = "panel_serch_groop_personal";
            panel_serch_groop_personal.Size = new Size(485, 44);
            panel_serch_groop_personal.TabIndex = 41;
            // 
            // button_add_frends
            // 
            button_add_frends.BackColor = Color.FromArgb(24, 30, 54);
            button_add_frends.FlatAppearance.BorderSize = 0;
            button_add_frends.FlatStyle = FlatStyle.Flat;
            button_add_frends.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button_add_frends.ForeColor = Color.FromArgb(0, 126, 249);
            button_add_frends.Location = new Point(351, 10);
            button_add_frends.Name = "button_add_frends";
            button_add_frends.Size = new Size(120, 25);
            button_add_frends.TabIndex = 4;
            button_add_frends.Text = "Добавить ";
            button_add_frends.UseVisualStyleBackColor = false;
            // 
            // label_freend_name
            // 
            label_freend_name.AutoSize = true;
            label_freend_name.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label_freend_name.ForeColor = SystemColors.AppWorkspace;
            label_freend_name.Location = new Point(13, 10);
            label_freend_name.Name = "label_freend_name";
            label_freend_name.Size = new Size(134, 22);
            label_freend_name.TabIndex = 2;
            label_freend_name.Text = "Добавте друга";
            // 
            // panel_save_settings
            // 
            panel_save_settings.BackColor = Color.FromArgb(37, 42, 64);
            panel_save_settings.Controls.Add(button_save_groop_settings);
            panel_save_settings.Controls.Add(label_save_settings_name);
            panel_save_settings.Location = new Point(252, 323);
            panel_save_settings.Name = "panel_save_settings";
            panel_save_settings.Size = new Size(485, 115);
            panel_save_settings.TabIndex = 42;
            // 
            // button_save_groop_settings
            // 
            button_save_groop_settings.BackColor = Color.FromArgb(24, 30, 54);
            button_save_groop_settings.FlatAppearance.BorderSize = 0;
            button_save_groop_settings.FlatStyle = FlatStyle.Flat;
            button_save_groop_settings.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button_save_groop_settings.ForeColor = Color.FromArgb(0, 126, 249);
            button_save_groop_settings.Location = new Point(155, 55);
            button_save_groop_settings.Name = "button_save_groop_settings";
            button_save_groop_settings.Size = new Size(140, 40);
            button_save_groop_settings.TabIndex = 6;
            button_save_groop_settings.Text = "Сохранить ";
            button_save_groop_settings.UseVisualStyleBackColor = false;
            // 
            // label_save_settings_name
            // 
            label_save_settings_name.AutoSize = true;
            label_save_settings_name.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label_save_settings_name.ForeColor = SystemColors.AppWorkspace;
            label_save_settings_name.Location = new Point(13, 10);
            label_save_settings_name.Name = "label_save_settings_name";
            label_save_settings_name.Size = new Size(390, 22);
            label_save_settings_name.TabIndex = 2;
            label_save_settings_name.Text = "После всех настроек не забудьте сохранить!";
            // 
            // CreateGroop
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(776, 450);
            Controls.Add(panel_save_settings);
            Controls.Add(panel_serch_groop_personal);
            Controls.Add(panel_Temm_groop);
            Controls.Add(panel_groop_Description);
            Controls.Add(panel_Groop_avatar);
            Controls.Add(panel_groop_create2);
            Controls.Add(button_X3);
            Controls.Add(panel_groop_create_name);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CreateGroop";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CreateGroop";
            Load += CreateGroop_Load;
            panel_groop_create_name.ResumeLayout(false);
            panel_groop_create_name.PerformLayout();
            panel_groop_create2.ResumeLayout(false);
            panel_groop_create2.PerformLayout();
            panel_Groop_avatar.ResumeLayout(false);
            panel_Groop_avatar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1_Avatar_groop).EndInit();
            panel_groop_Description.ResumeLayout(false);
            panel_groop_Description.PerformLayout();
            panel_Temm_groop.ResumeLayout(false);
            panel_Temm_groop.PerformLayout();
            panel_serch_groop_personal.ResumeLayout(false);
            panel_serch_groop_personal.PerformLayout();
            panel_save_settings.ResumeLayout(false);
            panel_save_settings.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_groop_create_name;
        private Button button_X3;
        private Panel panel_groop_create2;
        private Label label1;
        private Panel panel_Groop_avatar;
        private Label label2_Create_AVATAR_groop;
        private PictureBox pictureBox1_Avatar_groop;
        private Button button_Ico_groop_avatar;
        private TextBox textBox_Name;
        private Panel panel_groop_Description;
        private Label label_name_Description;
        private TextBox textBox_groop_Description;
        private Panel panel_Temm_groop;
        private Label label_temm_name;
        private Panel panel_serch_groop_personal;
        private Label label_freend_name;
        private Panel panel_save_settings;
        private Button button_save_groop_settings;
        private Label label_save_settings_name;
        private Button button_add_frends;
        private CheckedListBox checkedListBox_groop_tem;
    }
}