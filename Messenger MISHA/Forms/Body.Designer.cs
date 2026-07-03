namespace Messenger_MISHA
{
    partial class Body
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
            BodyPannel1 = new Panel();
            panelNow = new Panel();
            BtnChannel = new Button();
            Setting = new Button();
            BtnGroop = new Button();
            BtnChat = new Button();
            BtnAccaunt = new Button();
            panel2 = new Panel();
            labelInfo = new Label();
            labelName = new Label();
            pictureBox1 = new PictureBox();
            Osn_pannel = new Panel();
            PnlFormLoader = new Panel();
            button_X = new Button();
            textBox_serch = new TextBox();
            label_name_pannel = new Label();
            BodyPannel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            Osn_pannel.SuspendLayout();
            SuspendLayout();
            // 
            // BodyPannel1
            // 
            BodyPannel1.BackColor = Color.FromArgb(24, 30, 54);
            BodyPannel1.Controls.Add(panelNow);
            BodyPannel1.Controls.Add(BtnChannel);
            BodyPannel1.Controls.Add(Setting);
            BodyPannel1.Controls.Add(BtnGroop);
            BodyPannel1.Controls.Add(BtnChat);
            BodyPannel1.Controls.Add(BtnAccaunt);
            BodyPannel1.Controls.Add(panel2);
            BodyPannel1.Dock = DockStyle.Left;
            BodyPannel1.Font = new Font("Segoe UI", 9F);
            BodyPannel1.Location = new Point(0, 0);
            BodyPannel1.Name = "BodyPannel1";
            BodyPannel1.Size = new Size(186, 577);
            BodyPannel1.TabIndex = 0;
            // 
            // panelNow
            // 
            panelNow.BackColor = Color.FromArgb(0, 126, 249);
            panelNow.Location = new Point(0, 193);
            panelNow.Name = "panelNow";
            panelNow.Size = new Size(3, 100);
            panelNow.TabIndex = 6;
            // 
            // BtnChannel
            // 
            BtnChannel.Dock = DockStyle.Top;
            BtnChannel.FlatAppearance.BorderSize = 0;
            BtnChannel.FlatStyle = FlatStyle.Flat;
            BtnChannel.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            BtnChannel.ForeColor = Color.FromArgb(0, 126, 249);
            BtnChannel.Image = Properties.Resources.image_38;
            BtnChannel.Location = new Point(0, 296);
            BtnChannel.Name = "BtnChannel";
            BtnChannel.RightToLeft = RightToLeft.No;
            BtnChannel.Size = new Size(186, 42);
            BtnChannel.TabIndex = 5;
            BtnChannel.Text = "Канал";
            BtnChannel.TextImageRelation = TextImageRelation.TextBeforeImage;
            BtnChannel.UseVisualStyleBackColor = true;
            BtnChannel.Click += BtnChannel_Click;
            BtnChannel.Leave += BtnChannel_Leave;
            // 
            // Setting
            // 
            Setting.Dock = DockStyle.Bottom;
            Setting.FlatAppearance.BorderSize = 0;
            Setting.FlatStyle = FlatStyle.Flat;
            Setting.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Setting.ForeColor = Color.FromArgb(0, 126, 249);
            Setting.Image = Properties.Resources.image_39;
            Setting.Location = new Point(0, 535);
            Setting.Name = "Setting";
            Setting.RightToLeft = RightToLeft.No;
            Setting.Size = new Size(186, 42);
            Setting.TabIndex = 4;
            Setting.Text = "Настройки";
            Setting.TextImageRelation = TextImageRelation.TextBeforeImage;
            Setting.UseVisualStyleBackColor = true;
            Setting.Click += Setting_Click;
            Setting.Leave += Setting_Leave;
            // 
            // BtnGroop
            // 
            BtnGroop.Dock = DockStyle.Top;
            BtnGroop.FlatAppearance.BorderSize = 0;
            BtnGroop.FlatStyle = FlatStyle.Flat;
            BtnGroop.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            BtnGroop.ForeColor = Color.FromArgb(0, 126, 249);
            BtnGroop.Image = Properties.Resources.image_37;
            BtnGroop.Location = new Point(0, 254);
            BtnGroop.Name = "BtnGroop";
            BtnGroop.RightToLeft = RightToLeft.No;
            BtnGroop.Size = new Size(186, 42);
            BtnGroop.TabIndex = 3;
            BtnGroop.Text = "Группа";
            BtnGroop.TextImageRelation = TextImageRelation.TextBeforeImage;
            BtnGroop.UseVisualStyleBackColor = true;
            BtnGroop.Click += BtnGroop_Click;
            BtnGroop.Leave += BtnGroop_Leave;
            // 
            // BtnChat
            // 
            BtnChat.AutoEllipsis = true;
            BtnChat.Dock = DockStyle.Top;
            BtnChat.FlatAppearance.BorderSize = 0;
            BtnChat.FlatStyle = FlatStyle.Flat;
            BtnChat.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            BtnChat.ForeColor = Color.FromArgb(0, 126, 249);
            BtnChat.Image = Properties.Resources.image_35__1_;
            BtnChat.Location = new Point(0, 212);
            BtnChat.Name = "BtnChat";
            BtnChat.Size = new Size(186, 42);
            BtnChat.TabIndex = 2;
            BtnChat.Text = "Чат       ";
            BtnChat.TextImageRelation = TextImageRelation.TextBeforeImage;
            BtnChat.UseVisualStyleBackColor = true;
            BtnChat.Click += BtnChat_Click;
            BtnChat.Leave += BtnChat_Leave;
            // 
            // BtnAccaunt
            // 
            BtnAccaunt.Dock = DockStyle.Top;
            BtnAccaunt.FlatAppearance.BorderSize = 0;
            BtnAccaunt.FlatStyle = FlatStyle.Flat;
            BtnAccaunt.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            BtnAccaunt.ForeColor = Color.FromArgb(0, 126, 249);
            BtnAccaunt.Image = Properties.Resources.image_36__2_;
            BtnAccaunt.Location = new Point(0, 170);
            BtnAccaunt.Name = "BtnAccaunt";
            BtnAccaunt.Size = new Size(186, 42);
            BtnAccaunt.TabIndex = 1;
            BtnAccaunt.Text = "Аккаунт";
            BtnAccaunt.TextImageRelation = TextImageRelation.TextBeforeImage;
            BtnAccaunt.UseVisualStyleBackColor = true;
            BtnAccaunt.Click += BtnAccaunt_Click;
            BtnAccaunt.Leave += BtnAccaunt_Leave;
            // 
            // panel2
            // 
            panel2.Controls.Add(labelInfo);
            panel2.Controls.Add(labelName);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(186, 170);
            panel2.TabIndex = 0;
            // 
            // labelInfo
            // 
            labelInfo.AutoSize = true;
            labelInfo.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelInfo.ForeColor = Color.FromArgb(158, 161, 176);
            labelInfo.Location = new Point(21, 125);
            labelInfo.Name = "labelInfo";
            labelInfo.Size = new Size(52, 17);
            labelInfo.TabIndex = 2;
            labelInfo.Text = "О себе";
            labelInfo.Click += label2_Click;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelName.ForeColor = Color.FromArgb(0, 126, 249);
            labelName.Location = new Point(21, 96);
            labelName.Name = "labelName";
            labelName.Size = new Size(144, 19);
            labelName.TabIndex = 1;
            labelName.Text = "Имя пользователя";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.image_36;
            pictureBox1.Location = new Point(60, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(63, 63);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Osn_pannel
            // 
            Osn_pannel.Controls.Add(PnlFormLoader);
            Osn_pannel.Controls.Add(button_X);
            Osn_pannel.Controls.Add(textBox_serch);
            Osn_pannel.Controls.Add(label_name_pannel);
            Osn_pannel.Font = new Font("Algerian", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Osn_pannel.Location = new Point(185, 0);
            Osn_pannel.Name = "Osn_pannel";
            Osn_pannel.Size = new Size(767, 577);
            Osn_pannel.TabIndex = 1;
            Osn_pannel.Paint += Osn_pannel_Paint;
            // 
            // PnlFormLoader
            // 
            PnlFormLoader.Dock = DockStyle.Bottom;
            PnlFormLoader.Location = new Point(0, 74);
            PnlFormLoader.Name = "PnlFormLoader";
            PnlFormLoader.Size = new Size(767, 503);
            PnlFormLoader.TabIndex = 11;
            PnlFormLoader.Paint += PnlFormLoader_Paint;
            // 
            // button_X
            // 
            button_X.FlatAppearance.BorderSize = 0;
            button_X.FlatStyle = FlatStyle.Flat;
            button_X.Font = new Font("Arial Narrow", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button_X.ForeColor = Color.White;
            button_X.Location = new Point(729, 24);
            button_X.Name = "button_X";
            button_X.Size = new Size(25, 25);
            button_X.TabIndex = 10;
            button_X.Text = "X";
            button_X.UseVisualStyleBackColor = true;
            button_X.Click += button_X_Click;
            // 
            // textBox_serch
            // 
            textBox_serch.BackColor = Color.FromArgb(74, 79, 99);
            textBox_serch.BorderStyle = BorderStyle.None;
            textBox_serch.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBox_serch.ForeColor = SystemColors.ScrollBar;
            textBox_serch.Location = new Point(431, 24);
            textBox_serch.Multiline = true;
            textBox_serch.Name = "textBox_serch";
            textBox_serch.Size = new Size(292, 25);
            textBox_serch.TabIndex = 9;
            textBox_serch.Text = "Поисковая строка ...";
            // 
            // label_name_pannel
            // 
            label_name_pannel.AutoSize = true;
            label_name_pannel.BackColor = Color.FromArgb(46, 51, 73);
            label_name_pannel.Font = new Font("Times New Roman", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label_name_pannel.ForeColor = Color.FromArgb(158, 161, 176);
            label_name_pannel.Location = new Point(20, 17);
            label_name_pannel.Name = "label_name_pannel";
            label_name_pannel.Size = new Size(126, 32);
            label_name_pannel.TabIndex = 0;
            label_name_pannel.Text = "Аккаунт";
            // 
            // Body
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(951, 577);
            Controls.Add(Osn_pannel);
            Controls.Add(BodyPannel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Body";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Body";
            Load += Body_Load;
            BodyPannel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            Osn_pannel.ResumeLayout(false);
            Osn_pannel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel BodyPannel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label labelInfo;
        private Label labelName;
        private Button BtnAccaunt;
        private Button BtnChannel;
        private Button Setting;
        private Button BtnGroop;
        private Button BtnChat;
        private Panel panelNow;
        private Panel Osn_pannel;
        private Label label_name_pannel;
        private TextBox textBox_serch;
        private Button button_X;
        private Panel PnlFormLoader;
    }
}