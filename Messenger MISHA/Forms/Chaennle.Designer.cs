namespace Messenger_MISHA
{
    partial class Chaennle
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
            textBox_channel_Description = new TextBox();
            pictureBox1_Avatar_channel = new PictureBox();
            label_name_channel = new Label();
            label_channel_groop = new Label();
            button4_Channel = new Button();
            flowLayoutPanel1_channel = new FlowLayoutPanel();
            labelCount = new Label();
            flowLayoutPanelFiles_channel = new FlowLayoutPanel();
            panel1_channel = new Panel();
            button3_Channel = new Button();
            button2_channel = new Button();
            textBox_pisat_channel = new TextBox();
            panel_chapka.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1_Avatar_channel).BeginInit();
            panel1_channel.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(565, 8);
            button1.Name = "button1";
            button1.Size = new Size(30, 30);
            button1.TabIndex = 1;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            // 
            // panel_chapka
            // 
            panel_chapka.Controls.Add(label_channel_groop);
            panel_chapka.Controls.Add(textBox_channel_Description);
            panel_chapka.Controls.Add(pictureBox1_Avatar_channel);
            panel_chapka.Controls.Add(label_name_channel);
            panel_chapka.Location = new Point(12, 12);
            panel_chapka.Name = "panel_chapka";
            panel_chapka.Size = new Size(441, 127);
            panel_chapka.TabIndex = 2;
            // 
            // textBox_channel_Description
            // 
            textBox_channel_Description.BackColor = Color.FromArgb(74, 79, 99);
            textBox_channel_Description.BorderStyle = BorderStyle.None;
            textBox_channel_Description.Cursor = Cursors.IBeam;
            textBox_channel_Description.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox_channel_Description.ForeColor = SystemColors.ScrollBar;
            textBox_channel_Description.Location = new Point(133, 29);
            textBox_channel_Description.Multiline = true;
            textBox_channel_Description.Name = "textBox_channel_Description";
            textBox_channel_Description.Size = new Size(300, 63);
            textBox_channel_Description.TabIndex = 3;
            // 
            // pictureBox1_Avatar_channel
            // 
            pictureBox1_Avatar_channel.ErrorImage = Properties.Resources.image_36;
            pictureBox1_Avatar_channel.Image = Properties.Resources.image_36;
            pictureBox1_Avatar_channel.InitialImage = Properties.Resources.image_36;
            pictureBox1_Avatar_channel.Location = new Point(7, 0);
            pictureBox1_Avatar_channel.Name = "pictureBox1_Avatar_channel";
            pictureBox1_Avatar_channel.Size = new Size(120, 120);
            pictureBox1_Avatar_channel.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1_Avatar_channel.TabIndex = 2;
            pictureBox1_Avatar_channel.TabStop = false;
            // 
            // label_name_channel
            // 
            label_name_channel.AutoSize = true;
            label_name_channel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label_name_channel.ForeColor = SystemColors.ControlLightLight;
            label_name_channel.Location = new Point(133, 5);
            label_name_channel.Name = "label_name_channel";
            label_name_channel.Size = new Size(53, 21);
            label_name_channel.TabIndex = 0;
            label_name_channel.Text = "label1";
            // 
            // label_channel_groop
            // 
            label_channel_groop.AutoSize = true;
            label_channel_groop.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label_channel_groop.ForeColor = SystemColors.ControlLightLight;
            label_channel_groop.Location = new Point(133, 99);
            label_channel_groop.Name = "label_channel_groop";
            label_channel_groop.Size = new Size(53, 21);
            label_channel_groop.TabIndex = 4;
            label_channel_groop.Text = "label1";
            // 
            // button4_Channel
            // 
            button4_Channel.BackColor = SystemColors.InactiveCaption;
            button4_Channel.FlatStyle = FlatStyle.Flat;
            button4_Channel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            button4_Channel.Location = new Point(459, 79);
            button4_Channel.Name = "button4_Channel";
            button4_Channel.Size = new Size(136, 60);
            button4_Channel.TabIndex = 5;
            button4_Channel.Text = "Изменить канал";
            button4_Channel.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel1_channel
            // 
            flowLayoutPanel1_channel.BackColor = Color.FromArgb(74, 79, 99);
            flowLayoutPanel1_channel.Location = new Point(12, 145);
            flowLayoutPanel1_channel.Name = "flowLayoutPanel1_channel";
            flowLayoutPanel1_channel.Size = new Size(583, 494);
            flowLayoutPanel1_channel.TabIndex = 6;
            // 
            // labelCount
            // 
            labelCount.AutoSize = true;
            labelCount.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelCount.ForeColor = SystemColors.ButtonHighlight;
            labelCount.Location = new Point(12, 658);
            labelCount.Name = "labelCount";
            labelCount.Size = new Size(134, 20);
            labelCount.TabIndex = 10;
            labelCount.Text = "Выбрано файлов ";
            labelCount.Click += labelCount_Click;
            // 
            // flowLayoutPanelFiles_channel
            // 
            flowLayoutPanelFiles_channel.AutoScroll = true;
            flowLayoutPanelFiles_channel.BackColor = Color.FromArgb(74, 79, 99);
            flowLayoutPanelFiles_channel.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanelFiles_channel.Location = new Point(152, 645);
            flowLayoutPanelFiles_channel.Name = "flowLayoutPanelFiles_channel";
            flowLayoutPanelFiles_channel.Padding = new Padding(10);
            flowLayoutPanelFiles_channel.Size = new Size(443, 46);
            flowLayoutPanelFiles_channel.TabIndex = 9;
            flowLayoutPanelFiles_channel.WrapContents = false;
            // 
            // panel1_channel
            // 
            panel1_channel.BackColor = Color.FromArgb(74, 79, 99);
            panel1_channel.Controls.Add(button3_Channel);
            panel1_channel.Controls.Add(button2_channel);
            panel1_channel.Controls.Add(textBox_pisat_channel);
            panel1_channel.Location = new Point(12, 697);
            panel1_channel.Name = "panel1_channel";
            panel1_channel.Size = new Size(583, 45);
            panel1_channel.TabIndex = 8;
            // 
            // button3_Channel
            // 
            button3_Channel.BackColor = SystemColors.InactiveCaption;
            button3_Channel.FlatStyle = FlatStyle.Flat;
            button3_Channel.ForeColor = SystemColors.ButtonHighlight;
            button3_Channel.Image = Properties.Resources.image_57;
            button3_Channel.Location = new Point(30, 5);
            button3_Channel.Name = "button3_Channel";
            button3_Channel.Size = new Size(28, 33);
            button3_Channel.TabIndex = 2;
            button3_Channel.UseVisualStyleBackColor = false;
            // 
            // button2_channel
            // 
            button2_channel.BackColor = SystemColors.InactiveCaption;
            button2_channel.FlatStyle = FlatStyle.Flat;
            button2_channel.ForeColor = SystemColors.ActiveCaptionText;
            button2_channel.Location = new Point(483, 5);
            button2_channel.Name = "button2_channel";
            button2_channel.Size = new Size(97, 33);
            button2_channel.TabIndex = 1;
            button2_channel.Text = "Отправить";
            button2_channel.UseVisualStyleBackColor = false;
            // 
            // textBox_pisat_channel
            // 
            textBox_pisat_channel.BackColor = SystemColors.InactiveCaption;
            textBox_pisat_channel.BorderStyle = BorderStyle.None;
            textBox_pisat_channel.Location = new Point(64, 5);
            textBox_pisat_channel.MaxLength = 2000;
            textBox_pisat_channel.Multiline = true;
            textBox_pisat_channel.Name = "textBox_pisat_channel";
            textBox_pisat_channel.Size = new Size(413, 33);
            textBox_pisat_channel.TabIndex = 0;
            // 
            // Chaennle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(600, 750);
            Controls.Add(labelCount);
            Controls.Add(flowLayoutPanelFiles_channel);
            Controls.Add(panel1_channel);
            Controls.Add(flowLayoutPanel1_channel);
            Controls.Add(button4_Channel);
            Controls.Add(panel_chapka);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Chaennle";
            Text = "Chaennle";
            panel_chapka.ResumeLayout(false);
            panel_chapka.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1_Avatar_channel).EndInit();
            panel1_channel.ResumeLayout(false);
            panel1_channel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Panel panel_chapka;
        private Label label_channel_groop;
        private TextBox textBox_channel_Description;
        private PictureBox pictureBox1_Avatar_channel;
        private Label label_name_channel;
        private Button button4_Channel;
        private FlowLayoutPanel flowLayoutPanel1_channel;
        private Label labelCount;
        private FlowLayoutPanel flowLayoutPanelFiles_channel;
        private Panel panel1_channel;
        private Button button3_Channel;
        private Button button2_channel;
        private TextBox textBox_pisat_channel;
    }
}