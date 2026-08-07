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

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_pisat.Text))
                return;

            // Создаем панель
            Panel messagePanel = new Panel();
            messagePanel.AutoSize = true;
            messagePanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            messagePanel.Margin = new Padding(5, 3, 5, 3);
            messagePanel.MaximumSize = new Size(flowLayoutPanel_sam_chat.Width - 20, 0);
            messagePanel.MinimumSize = new Size(flowLayoutPanel_sam_chat.Width - 20, 0); // Фиксируем ширину

            // Создаем лейбл
            Label messageLabel = new Label();
            messageLabel.Text = textBox_pisat.Text;
            messageLabel.AutoSize = true;
            messageLabel.MaximumSize = new Size(400, 0);
            messageLabel.Font = new Font("Segoe UI", 10);
            messageLabel.BackColor = Color.FromArgb(55, 132, 149);
            messageLabel.ForeColor = Color.White;
            messageLabel.Padding = new Padding(10, 5, 10, 5);

            // ТОЛЬКО Anchor (убираем Location)
            messageLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;

            // Добавляем лейбл в панель
            messagePanel.Controls.Add(messageLabel);

            // Добавляем панель в FlowLayoutPanel
            flowLayoutPanel_sam_chat.Controls.Add(messagePanel);

            // Очищаем поле ввода
            textBox_pisat.Clear();

            // Прокрутка
            flowLayoutPanel_sam_chat.ScrollControlIntoView(messagePanel);
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
            CreateChat CreateChatForm = new CreateChat();
            CreateChatForm.Show();
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
