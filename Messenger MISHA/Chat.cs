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
    }
}
