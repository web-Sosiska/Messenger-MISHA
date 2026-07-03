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
            SuspendLayout();
            // 
            // panel_settings_vid
            // 
            panel_settings_vid.BackColor = Color.FromArgb(37, 42, 64);
            panel_settings_vid.Location = new Point(12, 26);
            panel_settings_vid.Name = "panel_settings_vid";
            panel_settings_vid.Size = new Size(746, 462);
            panel_settings_vid.TabIndex = 39;
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
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_settings_vid;
    }
}