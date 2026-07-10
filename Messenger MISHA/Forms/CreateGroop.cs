using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Messenger_MISHA.Forms
{
    public partial class CreateGroop : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
  int nLeftRect,     // x верхнего левого угла
  int nTopRect,      // y верхнего левого угла
  int nRightRect,    // x нижнего правого угла
  int nBottomRect,   // y нижнего правого угла
  int nWidthEllipse, // ширина эллипса (радиус по X)
  int nHeightEllipse // высота эллипса (радиус по Y)
);
        public CreateGroop()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void panel_create_groop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_X3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreateGroop_Load(object sender, EventArgs e)
        {

        }
    }
}
