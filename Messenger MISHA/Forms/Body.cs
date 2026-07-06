using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Messenger_MISHA
{


    public partial class Body : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]


        private static extern IntPtr CreateRoundRectRgn(
        int nLeftRect,
        int nTopRect,
        int nRightRect,
        int nBottomRect,
        int nWidthEllipse,
        int nHeightEllipse
        );
        public Body()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            panelNow.Height = BtnAccaunt.Height;
            panelNow.Top = BtnAccaunt.Top;
            panelNow.Left = BtnAccaunt.Left;
            BtnAccaunt.BackColor = Color.FromArgb(46, 51, 7);

            label_name_pannel.Text = "Аккаунт";
            this.PnlFormLoader.Controls.Clear();
            AccauntForm FrmDashboard_Vrb = new AccauntForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(FrmDashboard_Vrb);
            FrmDashboard_Vrb.Show();
        }

        private void Body_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnAccaunt_Click(object sender, EventArgs e)
        {
            panelNow.Height = BtnAccaunt.Height;
            panelNow.Top = BtnAccaunt.Top;
            panelNow.Left = BtnAccaunt.Left;
            BtnAccaunt.BackColor = Color.FromArgb(46, 51, 73);

            label_name_pannel.Text = "Аккаунт";
            this.PnlFormLoader.Controls.Clear();
            AccauntForm FrmDashboard_Vrb = new AccauntForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(FrmDashboard_Vrb);
            FrmDashboard_Vrb.Show();
        }

        private void BtnChat_Click(object sender, EventArgs e)
        {
            panelNow.Height = BtnChat.Height;
            panelNow.Top = BtnChat.Top;
            BtnChat.BackColor = Color.FromArgb(46, 51, 73);

            label_name_pannel.Text = "Чат";
            this.PnlFormLoader.Controls.Clear();
            ChatForm FrmDashboard_Vrb = new ChatForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(FrmDashboard_Vrb);
            FrmDashboard_Vrb.Show();
        }

        private void BtnGroop_Click(object sender, EventArgs e)
        {
            panelNow.Height = BtnGroop.Height;
            panelNow.Top = BtnGroop.Top;
            BtnGroop.BackColor = Color.FromArgb(46, 51, 73);

            label_name_pannel.Text = "Группа";
            this.PnlFormLoader.Controls.Clear();
            GroopForm FrmDashboard_Vrb = new GroopForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(FrmDashboard_Vrb);
            FrmDashboard_Vrb.Show();
        }

        private void BtnChannel_Click(object sender, EventArgs e)
        {
            panelNow.Height = BtnChannel.Height;
            panelNow.Top = BtnChannel.Top;
            BtnChannel.BackColor = Color.FromArgb(46, 51, 73);

            label_name_pannel.Text = "Канал";
            this.PnlFormLoader.Controls.Clear();
            ChannelForm FrmDashboard_Vrb = new ChannelForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(FrmDashboard_Vrb);
            FrmDashboard_Vrb.Show();

        }

        private void Setting_Click(object sender, EventArgs e)
        {
            panelNow.Height = Setting.Height;
            panelNow.Top = Setting.Top;
            Setting.BackColor = Color.FromArgb(46, 51, 73);

            label_name_pannel.Text = "Настройки";
            this.PnlFormLoader.Controls.Clear();
            SettingsForm FrmDashboard_Vrb = new SettingsForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(FrmDashboard_Vrb);
            FrmDashboard_Vrb.Show();
        }

        private void BtnAccaunt_Leave(object sender, EventArgs e)
        {
            BtnAccaunt.BackColor = Color.FromArgb(24, 30, 54);

        }

        private void BtnChat_Leave(object sender, EventArgs e)
        {
            BtnChat.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void BtnGroop_Leave(object sender, EventArgs e)
        {
            BtnGroop.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void BtnChannel_Leave(object sender, EventArgs e)
        {
            BtnChannel.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void Setting_Leave(object sender, EventArgs e)
        {
            Setting.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_NameChanged(object sender, EventArgs e)
        {

        }

        private void panel_accaunt_fon_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_accaunt_fon_2_Paint(object sender, PaintEventArgs e)
        {

        }

        //private void button_Ico_Click(object sender, EventArgs e)
        //{
        //    button_Ico.BackColor = Color.FromArgb(24, 30, 54);
        //}

        //private void button_save_info_Click(object sender, EventArgs e)
        //{
        //    button_save_info.BackColor = Color.FromArgb(24, 30, 54);
        //}

        private void Osn_pannel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PnlFormLoader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_X_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label_name_pannel_Click(object sender, EventArgs e)
        {

        }
    }
}
