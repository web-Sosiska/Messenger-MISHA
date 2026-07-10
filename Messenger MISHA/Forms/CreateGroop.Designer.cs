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
            panel_groop_create = new Panel();
            button_X3 = new Button();
            panel_groop_create2 = new Panel();
            SuspendLayout();
            // 
            // panel_groop_create
            // 
            panel_groop_create.BackColor = Color.FromArgb(37, 42, 64);
            panel_groop_create.Location = new Point(12, 12);
            panel_groop_create.Name = "panel_groop_create";
            panel_groop_create.Size = new Size(225, 410);
            panel_groop_create.TabIndex = 37;
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
            panel_groop_create2.Location = new Point(252, 12);
            panel_groop_create2.Name = "panel_groop_create2";
            panel_groop_create2.Size = new Size(485, 410);
            panel_groop_create2.TabIndex = 38;
            // 
            // CreateGroop
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(776, 450);
            Controls.Add(panel_groop_create2);
            Controls.Add(button_X3);
            Controls.Add(panel_groop_create);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CreateGroop";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CreateGroop";
            Load += CreateGroop_Load;
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_groop_create;
        private Button button_X3;
        private Panel panel_groop_create2;
    }
}