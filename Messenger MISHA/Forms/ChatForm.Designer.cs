namespace Messenger_MISHA
{
    partial class ChatForm
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
            panel_create_chat = new Panel();
            button_create_chat = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            textBox_info4 = new TextBox();
            textBox_Info3 = new TextBox();
            flowLayoutPanel_chat = new FlowLayoutPanel();
            panel_create_chat.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel_create_chat
            // 
            panel_create_chat.BackColor = Color.FromArgb(37, 42, 64);
            panel_create_chat.Controls.Add(button_create_chat);
            panel_create_chat.Location = new Point(12, 12);
            panel_create_chat.Name = "panel_create_chat";
            panel_create_chat.Size = new Size(192, 48);
            panel_create_chat.TabIndex = 30;
            // 
            // button_create_chat
            // 
            button_create_chat.BackColor = Color.FromArgb(24, 30, 54);
            button_create_chat.FlatAppearance.BorderSize = 0;
            button_create_chat.FlatStyle = FlatStyle.Flat;
            button_create_chat.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button_create_chat.ForeColor = Color.FromArgb(0, 126, 249);
            button_create_chat.Location = new Point(19, 6);
            button_create_chat.Name = "button_create_chat";
            button_create_chat.Size = new Size(157, 34);
            button_create_chat.TabIndex = 9;
            button_create_chat.Text = "Создать чат";
            button_create_chat.UseVisualStyleBackColor = false;
            button_create_chat.Click += button_Ico_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(37, 42, 64);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(textBox_info4);
            panel1.Controls.Add(textBox_Info3);
            panel1.Location = new Point(225, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(532, 48);
            panel1.TabIndex = 31;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.image_35__1_;
            pictureBox1.Location = new Point(11, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(28, 28);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // textBox_info4
            // 
            textBox_info4.BackColor = Color.FromArgb(37, 42, 64);
            textBox_info4.BorderStyle = BorderStyle.None;
            textBox_info4.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBox_info4.ForeColor = SystemColors.ScrollBar;
            textBox_info4.Location = new Point(461, 12);
            textBox_info4.Multiline = true;
            textBox_info4.Name = "textBox_info4";
            textBox_info4.ReadOnly = true;
            textBox_info4.Size = new Size(68, 28);
            textBox_info4.TabIndex = 3;
            textBox_info4.Text = "чатов!";
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
            textBox_Info3.Text = " У вас на аккаунте ";
            // 
            // flowLayoutPanel_chat
            // 
            flowLayoutPanel_chat.BackColor = Color.FromArgb(37, 42, 64);
            flowLayoutPanel_chat.Location = new Point(12, 66);
            flowLayoutPanel_chat.Name = "flowLayoutPanel_chat";
            flowLayoutPanel_chat.Size = new Size(745, 422);
            flowLayoutPanel_chat.TabIndex = 32;
            flowLayoutPanel_chat.Paint += flowLayoutPanel_chat_Paint;
            // 
            // ChatForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(784, 500);
            Controls.Add(flowLayoutPanel_chat);
            Controls.Add(panel1);
            Controls.Add(panel_create_chat);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ChatForm";
            Text = "ChatForm";
            Load += ChatForm_Load;
            panel_create_chat.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_create_chat;
        private Panel panel1;
        private Button button_create_chat;
        private TextBox textBox_Info3;
        private TextBox textBox_info4;
        private PictureBox pictureBox1;
        private FlowLayoutPanel flowLayoutPanel_chat;
    }
}