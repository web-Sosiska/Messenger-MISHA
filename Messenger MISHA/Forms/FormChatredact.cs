using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Messenger_MISHA.Forms
{
    public partial class FormChatredact : Form
    {
        public FormChatredact()
        {
            InitializeComponent();
        }

        private void button_X4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Ico_chat_avatar2_Click(object sender, EventArgs e)
        {
            // Создаем диалоговое окно выбора файла
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // Настраиваем заголовок
                openFileDialog.Title = "Выберите аватарку";

                // Фильтр только для картинок (png, jpeg, jpg, bmp, gif)
                openFileDialog.Filter = "Изображения (*.png;*.jpeg;*.jpg;*.bmp;*.gif)|*.png;*.jpeg;*.jpg;*.bmp;*.gif|Все файлы (*.*)|*.*";

                // Запоминаем последнюю открытую папку (удобно для пользователя)
                openFileDialog.RestoreDirectory = true;

                // Открываем диалог и проверяем, нажал ли пользователь "ОК"
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Загружаем выбранную картинку в PictureBox
                        // Используем FileStream, чтобы не блокировать файл на диске (лучшая практика)
                        using (FileStream fs = new FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                        {
                            pictureBox1_Avatar_chat2.Image = Image.FromStream(fs);
                        }

                        // Дополнительно: можно поменять SizeMode, чтобы картинка красиво вписалась
                        pictureBox1_Avatar_chat2.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Не удалось загрузить изображение: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void button_save_chat_settings2_Click(object sender, EventArgs e)
        {

        }
    }
}
