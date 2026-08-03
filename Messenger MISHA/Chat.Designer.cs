namespace Messenger_MISHA
{
    partial class Chat
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
            button1 = new Button();
            panel_chapka = new Panel();
            textBox_chat_Description_2 = new TextBox();
            pictureBox1_Avatar_chat_2 = new PictureBox();
            label_name_chat = new Label();
            flowLayoutPanel_sam_chat = new FlowLayoutPanel();
            panel1 = new Panel();
            button3 = new Button();
            button2 = new Button();
            textBox_pisat = new TextBox();
            panel_chapka.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1_Avatar_chat_2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(558, 12);
            button1.Name = "button1";
            button1.Size = new Size(30, 30);
            button1.TabIndex = 0;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel_chapka
            // 
            panel_chapka.Controls.Add(textBox_chat_Description_2);
            panel_chapka.Controls.Add(pictureBox1_Avatar_chat_2);
            panel_chapka.Controls.Add(label_name_chat);
            panel_chapka.Location = new Point(5, 12);
            panel_chapka.Name = "panel_chapka";
            panel_chapka.Size = new Size(553, 127);
            panel_chapka.TabIndex = 1;
            // 
            // textBox_chat_Description_2
            // 
            textBox_chat_Description_2.BackColor = Color.FromArgb(74, 79, 99);
            textBox_chat_Description_2.BorderStyle = BorderStyle.None;
            textBox_chat_Description_2.Cursor = Cursors.IBeam;
            textBox_chat_Description_2.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox_chat_Description_2.ForeColor = SystemColors.ScrollBar;
            textBox_chat_Description_2.Location = new Point(133, 36);
            textBox_chat_Description_2.Multiline = true;
            textBox_chat_Description_2.Name = "textBox_chat_Description_2";
            textBox_chat_Description_2.Size = new Size(411, 84);
            textBox_chat_Description_2.TabIndex = 3;
            // 
            // pictureBox1_Avatar_chat_2
            // 
            pictureBox1_Avatar_chat_2.ErrorImage = Properties.Resources.image_36;
            pictureBox1_Avatar_chat_2.Image = Properties.Resources.image_36;
            pictureBox1_Avatar_chat_2.InitialImage = Properties.Resources.image_36;
            pictureBox1_Avatar_chat_2.Location = new Point(7, 0);
            pictureBox1_Avatar_chat_2.Name = "pictureBox1_Avatar_chat_2";
            pictureBox1_Avatar_chat_2.Size = new Size(120, 120);
            pictureBox1_Avatar_chat_2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1_Avatar_chat_2.TabIndex = 2;
            pictureBox1_Avatar_chat_2.TabStop = false;
            // 
            // label_name_chat
            // 
            label_name_chat.AutoSize = true;
            label_name_chat.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label_name_chat.ForeColor = SystemColors.ControlLightLight;
            label_name_chat.Location = new Point(133, 9);
            label_name_chat.Name = "label_name_chat";
            label_name_chat.Size = new Size(53, 21);
            label_name_chat.TabIndex = 0;
            label_name_chat.Text = "label1";
            // 
            // flowLayoutPanel_sam_chat
            // 
            flowLayoutPanel_sam_chat.AutoScroll = true;
            flowLayoutPanel_sam_chat.BackColor = Color.FromArgb(74, 79, 99);
            flowLayoutPanel_sam_chat.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel_sam_chat.Location = new Point(5, 145);
            flowLayoutPanel_sam_chat.Name = "flowLayoutPanel_sam_chat";
            flowLayoutPanel_sam_chat.Size = new Size(583, 540);
            flowLayoutPanel_sam_chat.TabIndex = 2;
            flowLayoutPanel_sam_chat.WrapContents = false;
            flowLayoutPanel_sam_chat.Paint += flowLayoutPanel_sam_chat_Paint;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(74, 79, 99);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(textBox_pisat);
            panel1.Location = new Point(5, 693);
            panel1.Name = "panel1";
            panel1.Size = new Size(583, 45);
            panel1.TabIndex = 3;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.InactiveCaption;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Image = Properties.Resources.image_57;
            button3.Location = new Point(30, 5);
            button3.Name = "button3";
            button3.Size = new Size(28, 33);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.InactiveCaption;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(483, 5);
            button2.Name = "button2";
            button2.Size = new Size(97, 33);
            button2.TabIndex = 1;
            button2.Text = "Отправить";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // textBox_pisat
            // 
            textBox_pisat.BackColor = SystemColors.InactiveCaption;
            textBox_pisat.BorderStyle = BorderStyle.None;
            textBox_pisat.Location = new Point(64, 5);
            textBox_pisat.MaxLength = 2000;
            textBox_pisat.Multiline = true;
            textBox_pisat.Name = "textBox_pisat";
            textBox_pisat.Size = new Size(413, 33);
            textBox_pisat.TabIndex = 0;
            textBox_pisat.TextChanged += textBox1_TextChanged;
            // 
            // Chat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(600, 750);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel_sam_chat);
            Controls.Add(panel_chapka);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Chat";
            Text = "Chat";
            panel_chapka.ResumeLayout(false);
            panel_chapka.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1_Avatar_chat_2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Panel panel_chapka;
        private Label label_name_chat;
        private PictureBox pictureBox1_Avatar_chat_2;
        private TextBox textBox_chat_Description_2;
        private FlowLayoutPanel flowLayoutPanel_sam_chat;
        private Panel panel1;
        private Button button3;
        private Button button2;
        private TextBox textBox_pisat;
    }
}