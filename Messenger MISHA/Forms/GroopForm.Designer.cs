namespace Messenger_MISHA
{
    partial class GroopForm
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
            pictureBox1 = new PictureBox();
            textBox_info6 = new TextBox();
            textBox_Info5 = new TextBox();
            panel_groop_vid = new Panel();
            panel_create_chat = new Panel();
            button_groop_create = new Button();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            textBox_info4 = new TextBox();
            textBox_Info3 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel_create_chat.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.image_36__2_;
            pictureBox1.Location = new Point(10, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(28, 28);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // textBox_info6
            // 
            textBox_info6.BackColor = Color.FromArgb(37, 42, 64);
            textBox_info6.BorderStyle = BorderStyle.None;
            textBox_info6.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBox_info6.ForeColor = SystemColors.ScrollBar;
            textBox_info6.Location = new Point(437, 12);
            textBox_info6.Multiline = true;
            textBox_info6.Name = "textBox_info6";
            textBox_info6.ReadOnly = true;
            textBox_info6.Size = new Size(85, 28);
            textBox_info6.TabIndex = 3;
            textBox_info6.Text = "группах!";
            // 
            // textBox_Info5
            // 
            textBox_Info5.BackColor = Color.FromArgb(37, 42, 64);
            textBox_Info5.BorderStyle = BorderStyle.None;
            textBox_Info5.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBox_Info5.ForeColor = SystemColors.ScrollBar;
            textBox_Info5.Location = new Point(255, 12);
            textBox_Info5.Multiline = true;
            textBox_Info5.Name = "textBox_Info5";
            textBox_Info5.ReadOnly = true;
            textBox_Info5.Size = new Size(138, 24);
            textBox_Info5.TabIndex = 2;
            textBox_Info5.Text = "Вы состоите в";
            // 
            // panel_groop_vid
            // 
            panel_groop_vid.BackColor = Color.FromArgb(37, 42, 64);
            panel_groop_vid.Location = new Point(12, 78);
            panel_groop_vid.Name = "panel_groop_vid";
            panel_groop_vid.Size = new Size(746, 410);
            panel_groop_vid.TabIndex = 36;
            // 
            // panel_create_chat
            // 
            panel_create_chat.BackColor = Color.FromArgb(37, 42, 64);
            panel_create_chat.Controls.Add(button_groop_create);
            panel_create_chat.Location = new Point(12, 12);
            panel_create_chat.Name = "panel_create_chat";
            panel_create_chat.Size = new Size(200, 48);
            panel_create_chat.TabIndex = 35;
            panel_create_chat.Paint += panel_create_chat_Paint;
            // 
            // button_groop_create
            // 
            button_groop_create.BackColor = Color.FromArgb(24, 30, 54);
            button_groop_create.FlatAppearance.BorderSize = 0;
            button_groop_create.FlatStyle = FlatStyle.Flat;
            button_groop_create.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button_groop_create.ForeColor = Color.FromArgb(0, 126, 249);
            button_groop_create.Location = new Point(19, 6);
            button_groop_create.Name = "button_groop_create";
            button_groop_create.Size = new Size(157, 34);
            button_groop_create.TabIndex = 9;
            button_groop_create.Text = "Создать группу";
            button_groop_create.UseVisualStyleBackColor = false;
            button_groop_create.Click += button_groop_create_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(37, 42, 64);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(textBox_info4);
            panel2.Controls.Add(textBox_Info3);
            panel2.Location = new Point(226, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(532, 48);
            panel2.TabIndex = 37;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.image_37;
            pictureBox2.Location = new Point(11, 9);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(28, 28);
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // textBox_info4
            // 
            textBox_info4.BackColor = Color.FromArgb(37, 42, 64);
            textBox_info4.BorderStyle = BorderStyle.None;
            textBox_info4.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBox_info4.ForeColor = SystemColors.ScrollBar;
            textBox_info4.Location = new Point(444, 12);
            textBox_info4.Multiline = true;
            textBox_info4.Name = "textBox_info4";
            textBox_info4.ReadOnly = true;
            textBox_info4.Size = new Size(85, 28);
            textBox_info4.TabIndex = 3;
            textBox_info4.Text = "группах!";
            // 
            // textBox_Info3
            // 
            textBox_Info3.BackColor = Color.FromArgb(37, 42, 64);
            textBox_Info3.BorderStyle = BorderStyle.None;
            textBox_Info3.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBox_Info3.ForeColor = SystemColors.ScrollBar;
            textBox_Info3.Location = new Point(236, 12);
            textBox_Info3.Multiline = true;
            textBox_Info3.Name = "textBox_Info3";
            textBox_Info3.ReadOnly = true;
            textBox_Info3.Size = new Size(177, 24);
            textBox_Info3.TabIndex = 2;
            textBox_Info3.Text = "Вы находитесь в";
            textBox_Info3.TextChanged += textBox_Info3_TextChanged;
            // 
            // GroopForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(770, 500);
            Controls.Add(panel2);
            Controls.Add(panel_groop_vid);
            Controls.Add(panel_create_chat);
            FormBorderStyle = FormBorderStyle.None;
            Name = "GroopForm";
            Text = "GroopForm";
            Load += GroopForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel_create_chat.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TextBox textBox_info6;
        private TextBox textBox_Info5;
        private Panel panel_groop_vid;
        private Panel panel_create_chat;
        private Button button_groop_create;
        private PictureBox pictureBox1;
        private Panel panel2;
        private PictureBox pictureBox2;
        private TextBox textBox_info4;
        private TextBox textBox_Info3;
    }
}