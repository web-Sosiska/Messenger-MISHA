namespace Messenger_MISHA
{
    partial class ChannelForm
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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            textBox_info2 = new TextBox();
            textBox_Info1 = new TextBox();
            panel_channel_vid = new Panel();
            panel_create_chat = new Panel();
            button_channel_create = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel_create_chat.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(37, 42, 64);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(textBox_info2);
            panel1.Controls.Add(textBox_Info1);
            panel1.Location = new Point(233, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(525, 48);
            panel1.TabIndex = 34;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.image_38;
            pictureBox1.Location = new Point(11, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(28, 28);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // textBox_info2
            // 
            textBox_info2.BackColor = Color.FromArgb(37, 42, 64);
            textBox_info2.BorderStyle = BorderStyle.None;
            textBox_info2.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBox_info2.ForeColor = SystemColors.ScrollBar;
            textBox_info2.Location = new Point(433, 12);
            textBox_info2.Multiline = true;
            textBox_info2.Name = "textBox_info2";
            textBox_info2.ReadOnly = true;
            textBox_info2.Size = new Size(89, 28);
            textBox_info2.TabIndex = 3;
            textBox_info2.Text = "каналов!";
            textBox_info2.TextChanged += textBox_info2_TextChanged;
            // 
            // textBox_Info1
            // 
            textBox_Info1.BackColor = Color.FromArgb(37, 42, 64);
            textBox_Info1.BorderStyle = BorderStyle.None;
            textBox_Info1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBox_Info1.ForeColor = SystemColors.ScrollBar;
            textBox_Info1.Location = new Point(127, 12);
            textBox_Info1.Multiline = true;
            textBox_Info1.Name = "textBox_Info1";
            textBox_Info1.ReadOnly = true;
            textBox_Info1.Size = new Size(272, 24);
            textBox_Info1.TabIndex = 2;
            textBox_Info1.Text = "Вы создали и подписались на";
            // 
            // panel_channel_vid
            // 
            panel_channel_vid.BackColor = Color.FromArgb(37, 42, 64);
            panel_channel_vid.Location = new Point(12, 78);
            panel_channel_vid.Name = "panel_channel_vid";
            panel_channel_vid.Size = new Size(746, 410);
            panel_channel_vid.TabIndex = 33;
            // 
            // panel_create_chat
            // 
            panel_create_chat.BackColor = Color.FromArgb(37, 42, 64);
            panel_create_chat.Controls.Add(button_channel_create);
            panel_create_chat.Location = new Point(12, 12);
            panel_create_chat.Name = "panel_create_chat";
            panel_create_chat.Size = new Size(200, 48);
            panel_create_chat.TabIndex = 32;
            // 
            // button_channel_create
            // 
            button_channel_create.BackColor = Color.FromArgb(24, 30, 54);
            button_channel_create.FlatAppearance.BorderSize = 0;
            button_channel_create.FlatStyle = FlatStyle.Flat;
            button_channel_create.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button_channel_create.ForeColor = Color.FromArgb(0, 126, 249);
            button_channel_create.Location = new Point(19, 6);
            button_channel_create.Name = "button_channel_create";
            button_channel_create.Size = new Size(157, 34);
            button_channel_create.TabIndex = 9;
            button_channel_create.Text = "Создать канал";
            button_channel_create.UseVisualStyleBackColor = false;
            button_channel_create.Click += button_Ico_Click_1;
            // 
            // ChannelForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(770, 500);
            Controls.Add(panel1);
            Controls.Add(panel_channel_vid);
            Controls.Add(panel_create_chat);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ChannelForm";
            Text = "ChannelForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel_create_chat.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox textBox_info2;
        private TextBox textBox_Info1;
        private Panel panel_channel_vid;
        private Panel panel_create_chat;
        private Button button_channel_create;
        private PictureBox pictureBox1;
    }
}