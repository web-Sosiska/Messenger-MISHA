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
    public partial class CreateChannel : Form
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
        public CreateChannel()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void CreateChannel_Load(object sender, EventArgs e)
        {

        }

        private void button_X4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label_temm_name_Click(object sender, EventArgs e)
        {

        }
    }
}
