using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Messenger_MISHA
{
    public partial class Picture_Changing : Form
    {
        private PictureBox selectedPictureBox = null;
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
        int nLeftRect,     // x верхнего левого угла
        int nTopRect,      // y верхнего левого угла
        int nRightRect,    // x нижнего правого угла
        int nBottomRect,   // y нижнего правого угла
        int nWidthEllipse, // ширина эллипса (радиус по X)
        int nHeightEllipse // высота эллипса (радиус по Y)
    );

        public Picture_Changing()
        {
            InitializeComponent();
            pictureBox1.MouseClick += PictureBox_MouseClick;
            pictureBox2.MouseClick += PictureBox_MouseClick;
            pictureBox3.MouseClick += PictureBox_MouseClick;
            pictureBox4.MouseClick += PictureBox_MouseClick;
            pictureBox5.MouseClick += PictureBox_MouseClick;
            pictureBox6.MouseClick += PictureBox_MouseClick;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        public class picture_MouseClic
        {

        }


        
        private void PictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            var clickedBox = sender as PictureBox;
            if (clickedBox == null) return;

            // Снимаем выделение со всех pictureBox
            foreach (var pb in new[] { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6 })
            {
                pb.BorderStyle = BorderStyle.None;
                pb.Padding = new Padding(0);
            }

            // Выделяем текущий pictureBox
            clickedBox.BorderStyle = BorderStyle.FixedSingle;
            clickedBox.Padding = new Padding(2);

            // Запоминаем выбранный pictureBox
            selectedPictureBox = clickedBox;
        }
        //private void pictureBox6_MouseClick(object sender, MouseEventArgs e)
        //{
        //    foreach (var pb in new[] { pictureBox2, pictureBox1, pictureBox3, pictureBox5, pictureBox4 }) pb.BorderStyle = BorderStyle.None;

        //    // Выделяем текущий pictureBox
        //    pictureBox6.BorderStyle = BorderStyle.FixedSingle;
        //    pictureBox6.Padding = new Padding(2);

        //}

        //private void pictureBox5_MouseClick(object sender, MouseEventArgs e)
        //{
        //    foreach (var pb in new[] { pictureBox2, pictureBox1, pictureBox3, pictureBox4, pictureBox6 }) pb.BorderStyle = BorderStyle.None;

        //    // Выделяем текущий pictureBox
        //    pictureBox5.BorderStyle = BorderStyle.FixedSingle;
        //    pictureBox5.Padding = new Padding(2);
        //}


        //private void pictureBox4_MouseClick(object sender, MouseEventArgs e)
        //{
        //    foreach (var pb in new[] { pictureBox2, pictureBox1, pictureBox3, pictureBox5, pictureBox6 }) pb.BorderStyle = BorderStyle.None;

        //    // Выделяем текущий pictureBox
        //    pictureBox4.BorderStyle = BorderStyle.FixedSingle;
        //    pictureBox4.Padding = new Padding(2);
        //}

        //private void pictureBox3_MouseClick(object sender, MouseEventArgs e)
        //{
        //    foreach (var pb in new[] { pictureBox2, pictureBox1, pictureBox4, pictureBox5, pictureBox6 }) pb.BorderStyle = BorderStyle.None;

        //    // Выделяем текущий pictureBox
        //    pictureBox3.BorderStyle = BorderStyle.FixedSingle;
        //    pictureBox3.Padding = new Padding(2);
        //}

        //private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        //{
        //    // Снимаем выделение с других pictureBox (если нужно)
        //    foreach (var pb in new[] { pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6 }) pb.BorderStyle = BorderStyle.None;

        //    // Выделяем текущий pictureBox
        //    pictureBox1.BorderStyle = BorderStyle.FixedSingle;
        //    pictureBox1.Padding = new Padding(2);
        //}

        //private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        //{
        //    // Снимаем выделение с других pictureBox (если нужно)
        //    foreach (var pb in new[] { pictureBox1, pictureBox3, pictureBox4, pictureBox5, pictureBox6 }) pb.BorderStyle = BorderStyle.None;

        //    // Выделяем текущий pictureBox
        //    pictureBox2.BorderStyle = BorderStyle.FixedSingle;
        //    pictureBox2.Padding = new Padding(2);
        //}

        private void button_X2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (selectedPictureBox != null && selectedPictureBox.Image != null)
            {
                // Сохраняем изображение из выбранного pictureBox
                Image selectedImage = selectedPictureBox.Image;

                // Применяем к pictureBox2
                ((AccauntForm)Application.OpenForms["AccauntForm"]).pictureBox2.Image = selectedImage;

                // Опционально: снимаем выделение после применения
                selectedPictureBox.BorderStyle = BorderStyle.None;
                selectedPictureBox.Padding = new Padding(0);
                selectedPictureBox = null;
                MessageBox.Show("Изображение изменено!");
                
            }
            else
            {
                MessageBox.Show("Пожалуйста, сначала выберите изображение!", "Предупреждение",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Picture_Changing_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files(*.BMP; *.JPG; *.PNG; *.GIF;) | *.BMP; *.JPG; *.PNG; *.GIF; | ALL Files(*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Находим открытую форму AccauntForm
                    AccauntForm accForm = Application.OpenForms["AccauntForm"] as AccauntForm;

                    if (accForm != null)
                    {
                        // Вызываем публичный метод
                        accForm.UpdatePicture(ofd.FileName);
                    }
                    else
                    {
                        MessageBox.Show("Форма AccauntForm не найдена!", "Ошибка",
                                      MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    MessageBox.Show("Изображение изменено!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error); 
                }
            }
        }
    }
}
