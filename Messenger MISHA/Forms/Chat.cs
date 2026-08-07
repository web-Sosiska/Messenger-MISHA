using Messenger_MISHA.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Messenger_MISHA
{
    public partial class Chat : Form
    {
        public Chat()
        {
            InitializeComponent();


        }
        private void DownloadFile(string filePath)
        {
            // Спрашиваем пользователя, куда сохранить
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.FileName = Path.GetFileName(filePath); // Имя файла по умолчанию
                saveFileDialog.Filter = "Все файлы (*.*)|*.*";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Просто копируем файл в выбранное место (если он реально существует)
                        // В реальном мессенджере тут была бы загрузка по сети
                        File.Copy(filePath, saveFileDialog.FileName, true);
                        MessageBox.Show("Файл успешно сохранен!", "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка при сохранении файла: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            bool isSent = false;

            // =========== 1. Отправляем текст ===========
            if (!string.IsNullOrWhiteSpace(textBox_pisat.Text))
            {
                AddTextMessage(textBox_pisat.Text); // Переименовал метод, чтобы не путать
                textBox_pisat.Clear();
                isSent = true;
            }

            // =========== 2. Отправляем файлы (уже не текстом, а блоками) ===========
            if (flowLayoutPanelFiles.Controls.Count > 0)
            {
                // Перебираем файлы в нижней панели
                foreach (Control fileControl in flowLayoutPanelFiles.Controls)
                {
                    if (fileControl is Panel filePanel)
                    {
                        Label fileNameLabel = filePanel.Controls.OfType<Label>().FirstOrDefault();

                        if (fileNameLabel != null && !string.IsNullOrWhiteSpace(fileNameLabel.Text))
                        {
                            // ВАЖНО: Чтобы скачать файл, нам нужно знать его ПОЛНЫЙ путь.
                            // Допустим, мы храним путь в Tag самой панельки.
                            // Сейчас добавляем логику: отправляем визуальный блок файла
                            AddFileMessage(fileNameLabel.Text, "Путь_к_файлу_заглушка");
                            isSent = true;
                        }
                    }
                }

                flowLayoutPanelFiles.Controls.Clear();
                UpdateFileCount();
            }

            if (!isSent) return;

            // Прокрутка
            if (flowLayoutPanel_sam_chat.Controls.Count > 0)
            {
                flowLayoutPanel_sam_chat.ScrollControlIntoView(flowLayoutPanel_sam_chat.Controls[flowLayoutPanel_sam_chat.Controls.Count - 1]);
            }

        }
        private void AddTextMessage(string messageText)
        {
            Panel messagePanel = new Panel();
            messagePanel.AutoSize = true;
            messagePanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            messagePanel.Margin = new Padding(5, 3, 5, 3);
            messagePanel.MaximumSize = new Size(flowLayoutPanel_sam_chat.Width - 20, 0);
            messagePanel.MinimumSize = new Size(flowLayoutPanel_sam_chat.Width - 20, 0);

            Label messageLabel = new Label();
            messageLabel.Text = messageText;
            messageLabel.AutoSize = true;
            messageLabel.MaximumSize = new Size(400, 0);
            messageLabel.Font = new Font("Segoe UI", 10);
            messageLabel.BackColor = Color.FromArgb(55, 132, 149);
            messageLabel.ForeColor = Color.White;
            messageLabel.Padding = new Padding(10, 5, 10, 5);
            messageLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            //messageLabel.Location = new Point(messagePanel.Width - messageLabel.PreferredWidth - 10, 0);

            messagePanel.Controls.Add(messageLabel);
            flowLayoutPanel_sam_chat.Controls.Add(messagePanel);
        }

        // Метод для файлов (будет выглядеть как кнопка, по которой можно кликнуть)
        private void AddFileMessage(string fileName, string filePath)
        {
            Panel messagePanel = new Panel();
            messagePanel.AutoSize = true;
            messagePanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            messagePanel.Margin = new Padding(5, 3, 5, 3);
            messagePanel.MaximumSize = new Size(flowLayoutPanel_sam_chat.Width - 20, 0);
            messagePanel.MinimumSize = new Size(flowLayoutPanel_sam_chat.Width - 20, 0);

            // Создаем кнопку, которая выглядит как сообщение
            Button fileButton = new Button();
            fileButton.Text = $"📂 {fileName}";
            fileButton.AutoSize = true;
            fileButton.AutoSizeMode = AutoSizeMode.GrowAndShrink; // Кнопка подстраивается под текст
            fileButton.Font = new Font("Segoe UI", 10);
            fileButton.BackColor = Color.FromArgb(55, 132, 149);
            fileButton.ForeColor = Color.White;
            fileButton.FlatStyle = FlatStyle.Flat;
            fileButton.FlatAppearance.BorderSize = 0;
            fileButton.Padding = new Padding(10, 5, 10, 5);
            fileButton.TextAlign = ContentAlignment.MiddleCenter; // Текст по центру
                                                                  // Anchor убран, чтобы AutoSize работал корректно
                                                                  //fileButton.Location = new Point(messagePanel.Width - fileButton.PreferredWidth - 10, 0);

            // !!! ВАЖНО: Вешаем событие нажатия на кнопку !!!
            fileButton.Click += (s, e) =>
            {
                DownloadFile(filePath); // Вызываем скачивание по клику
            };

            messagePanel.Controls.Add(fileButton);
            flowLayoutPanel_sam_chat.Controls.Add(messagePanel);
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel_sam_chat_Paint(object sender, PaintEventArgs e)
        {

        }
        public Chat(Image avatar, string name, string description)
        {
            InitializeComponent();

            // Передаем данные в элементы управления
            pictureBox1_Avatar_chat_2.Image = avatar;
            label_name_chat.Text = name;
            textBox_chat_Description_2.Text = description;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormChatredact FormChatredact = new FormChatredact();
            FormChatredact.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Выберите файлы";
                openFileDialog.Multiselect = true;
                openFileDialog.Filter = "Все файлы (*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    flowLayoutPanelFiles.Controls.Clear();

                    foreach (string filePath in openFileDialog.FileNames)
                    {
                        // Создаем панель для каждого файла
                        Panel filePanel = new Panel();
                        filePanel.Size = new Size(200, 30);
                        filePanel.Margin = new Padding(0);
                        filePanel.BackColor = SystemColors.InactiveCaption;
                        filePanel.BorderStyle = BorderStyle.None;

                        // Метка с именем файла
                        Label fileLabel = new Label();
                        fileLabel.Text = Path.GetFileName(filePath);
                        fileLabel.Location = new Point(5, 5);
                        fileLabel.AutoSize = true;
                        fileLabel.Name = "fileNameLabel";

                        // Кнопка удаления
                        Button removeBtn = new Button();
                        removeBtn.Text = "✕";
                        removeBtn.Size = new Size(25, 25);
                        removeBtn.Location = new Point(175, 5);
                        removeBtn.FlatStyle = FlatStyle.Flat;
                        removeBtn.Click += (s, e) =>
                        {
                            flowLayoutPanelFiles.Controls.Remove(filePanel);
                            UpdateFileCount();
                        };

                        filePanel.Controls.Add(fileLabel);
                        filePanel.Controls.Add(removeBtn);
                        flowLayoutPanelFiles.Controls.Add(filePanel);
                    }

                    UpdateFileCount();
                }
            }
        }

        private void UpdateFileCount()
        {
            labelCount.Text = $"Файлов: {flowLayoutPanelFiles.Controls.Count}";
        }
    }
    
}
