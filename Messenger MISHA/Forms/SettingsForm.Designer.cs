namespace Messenger_MISHA
{
    partial class SettingsForm
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
            panel_settings_vid = new Panel();
            panel1 = new Panel();
            panel2 = new Panel();
            label_name_pannel_settings = new Label();
            label1 = new Label();
            panel_settings_vid.SuspendLayout();
            SuspendLayout();
            // 
            // panel_settings_vid
            // 
            panel_settings_vid.BackColor = Color.FromArgb(37, 42, 64);
            panel_settings_vid.Controls.Add(label1);
            panel_settings_vid.Controls.Add(label_name_pannel_settings);
            panel_settings_vid.Controls.Add(panel2);
            panel_settings_vid.Controls.Add(panel1);
            panel_settings_vid.Location = new Point(12, 26);
            panel_settings_vid.Name = "panel_settings_vid";
            panel_settings_vid.Size = new Size(746, 462);
            panel_settings_vid.TabIndex = 39;
            panel_settings_vid.Paint += panel_settings_vid_Paint;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(74, 79, 99);
            panel1.Location = new Point(99, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(644, 47);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(74, 79, 99);
            panel2.Location = new Point(99, 56);
            panel2.Name = "panel2";
            panel2.Size = new Size(644, 47);
            panel2.TabIndex = 1;
            // 
            // label_name_pannel_settings
            // 
            label_name_pannel_settings.AutoSize = true;
            label_name_pannel_settings.BackColor = Color.FromArgb(46, 51, 73);
            label_name_pannel_settings.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label_name_pannel_settings.ForeColor = Color.FromArgb(158, 161, 176);
            label_name_pannel_settings.Location = new Point(17, 15);
            label_name_pannel_settings.Name = "label_name_pannel_settings";
            label_name_pannel_settings.Size = new Size(66, 24);
            label_name_pannel_settings.TabIndex = 1;
            label_name_pannel_settings.Text = " Язык";
            label_name_pannel_settings.Click += label_name_pannel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(46, 51, 73);
            label1.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.FromArgb(158, 161, 176);
            label1.Location = new Point(17, 68);
            label1.Name = "label1";
            label1.Size = new Size(62, 24);
            label1.TabIndex = 2;
            label1.Text = " Тема";
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(770, 500);
            Controls.Add(panel_settings_vid);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SettingsForm";
            Text = "SettingsForm";
            panel_settings_vid.ResumeLayout(false);
            panel_settings_vid.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_settings_vid;
        private Panel panel1;
        private Panel panel2;
        private Label label_name_pannel_settings;
        private Label label1;
    }
}