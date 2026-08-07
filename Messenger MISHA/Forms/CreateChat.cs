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
    public partial class CreateChat : Form

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
        private ChatForm chatForm; // Ссылка на главную форму
        public CreateChat()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));

        }
        public CreateChat(ChatForm chatForm) : this() // Вызываем конструктор по умолчанию
        {
            this.chatForm = chatForm; // ✅ Сохраняем переданную ссылку
        }
        private void CreateChat_Load(object sender, EventArgs e)
        {

        }

        private void button_X4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_save_chat_settings_Click(object sender, EventArgs e)
        {
            // Проверяем, что форма ChatForm существует
            if (chatForm == null || chatForm.IsDisposed)
            {
                MessageBox.Show("Главная форма не найдена! Убедитесь, что форма чата открыта.",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Проверяем, что название чата введено
            string chatName = textBox_Name.Text.Trim();
            if (string.IsNullOrWhiteSpace(chatName))
            {
                MessageBox.Show("Введите название чата!", "Предупреждение",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Получаем данные из формы CreateChat
            Image avatarImage = pictureBox1_Avatar_chat.Image;
            string description = textBox_chat_Description.Text.Trim();

            // ✅ Используем метод из ChatForm для создания панели с кнопкой
            // Передаем все необходимые данные для открытия Chat формы
            chatForm.AddChatPanelWithButton(chatName, avatarImage, description);

            // Закрываем текущую форму (CreateChat)
            this.Close();




        }

        private void textBox_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Ico_chat_avatar_Click(object sender, EventArgs e)
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
                            pictureBox1_Avatar_chat.Image = Image.FromStream(fs);
                        }

                        // Дополнительно: можно поменять SizeMode, чтобы картинка красиво вписалась
                        pictureBox1_Avatar_chat.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Не удалось загрузить изображение: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void pictureBox1_Avatar_chat_Click(object sender, EventArgs e)
        {

        }
    }
}
