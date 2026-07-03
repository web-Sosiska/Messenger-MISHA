using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Messenger_MISHA
{
    public partial class Picture_Changing : Form
    {
        public Picture_Changing()
        {
            InitializeComponent();

        }

        public class picture_MouseClic
        {

        }



        private void pictureBox6_MouseClick(object sender, MouseEventArgs e)
        {
            foreach (var pb in new[] { pictureBox2, pictureBox1, pictureBox3, pictureBox5, pictureBox4 }) pb.BorderStyle = BorderStyle.None;

            // Выделяем текущий pictureBox
            pictureBox6.BorderStyle = BorderStyle.FixedSingle;
            pictureBox6.Padding = new Padding(2);

        }

        private void pictureBox5_MouseClick(object sender, MouseEventArgs e)
        {
            foreach (var pb in new[] { pictureBox2, pictureBox1, pictureBox3, pictureBox4, pictureBox6 }) pb.BorderStyle = BorderStyle.None;

            // Выделяем текущий pictureBox
            pictureBox5.BorderStyle = BorderStyle.FixedSingle;
            pictureBox5.Padding = new Padding(2);
        }


        private void pictureBox4_MouseClick(object sender, MouseEventArgs e)
        {
            foreach (var pb in new[] { pictureBox2, pictureBox1, pictureBox3, pictureBox5, pictureBox6 }) pb.BorderStyle = BorderStyle.None;

            // Выделяем текущий pictureBox
            pictureBox4.BorderStyle = BorderStyle.FixedSingle;
            pictureBox4.Padding = new Padding(2);
        }

        private void pictureBox3_MouseClick(object sender, MouseEventArgs e)
        {
            foreach (var pb in new[] { pictureBox2, pictureBox1, pictureBox4, pictureBox5, pictureBox6 }) pb.BorderStyle = BorderStyle.None;

            // Выделяем текущий pictureBox
            pictureBox3.BorderStyle = BorderStyle.FixedSingle;
            pictureBox3.Padding = new Padding(2);
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            // Снимаем выделение с других pictureBox (если нужно)
            foreach (var pb in new[] { pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6 }) pb.BorderStyle = BorderStyle.None;

            // Выделяем текущий pictureBox
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Padding = new Padding(2);
        }

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            // Снимаем выделение с других pictureBox (если нужно)
            foreach (var pb in new[] { pictureBox1, pictureBox3, pictureBox4, pictureBox5, pictureBox6 }) pb.BorderStyle = BorderStyle.None;

            // Выделяем текущий pictureBox
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Padding = new Padding(2);
        }

        private void button_X2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

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
