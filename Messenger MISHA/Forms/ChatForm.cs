using Messenger_MISHA.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using static Messenger_MISHA.Body;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace Messenger_MISHA
{
    public partial class ChatForm : Form
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

        public ChatForm()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_Ico_Click(object sender, EventArgs e)
        {
            CreateChat CreateChatForm = new CreateChat(this);
            CreateChatForm.Show();


        }

        private void ChatForm_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel_chat_Paint(object sender, PaintEventArgs e)
        {

        }
        public void AddChatPanelWithButton(string chatName, Image avatarImage = null, string description = "")
        {
            // Создаем панель
            Panel newPanel = new Panel
            {
                Name = $"Chat_{DateTime.Now.Ticks}",
                Size = new Size(745, 42),
                BackColor = Color.FromArgb(74, 79, 99),
                Margin = new Padding(0, 0, 0, 2)
            };

            // Создаем Label с названием чата
            Label label = new Label
            {
                Text = chatName,
                Location = new Point(10, 9),
                AutoSize = true,
                Font = new Font("Times New Roman", 14.25F, FontStyle.Bold),
                ForeColor = Color.White
            };
            newPanel.Controls.Add(label);

            // Создаем кнопку "Открыть чат"
            Button openChatButton = new Button
            {
                Text = "Открыть чат",
                Size = new Size(120, 25),
                Location = new Point(newPanel.Width - 130, newPanel.Height - 30),
                BackColor = Color.FromArgb(0, 126, 249),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Times New Roman", 9.75F, FontStyle.Bold),
                Cursor = Cursors.Hand
            };
            openChatButton.FlatAppearance.BorderSize = 0;

            // ✅ Сохраняем данные в локальные переменные для использования в замыкании
            string name = chatName;
            Image avatar = avatarImage;
            string desc = description;

            openChatButton.Click += (sender, e) =>
            {
                // Создаем форму Chat с переданными данными
                Chat chatForm = new Chat(avatar, name, desc);
                chatForm.Show();
            };

            newPanel.Controls.Add(openChatButton);

            // Добавляем панель в flowLayoutPanel
            flowLayoutPanel_chat.Controls.Add(newPanel);
            flowLayoutPanel_chat.Refresh();
        }
        public void AddChatPanelWithButton(string chatName)
        {
            AddChatPanelWithButton(chatName, null, "");
        }


        // Перегрузка для более гибкого добавления
        public void AddChatPanel(string panelName, string panelText)
        {
            Panel newPanel = new Panel
            {
                Name = panelName,
                Size = new Size(200, 100),
                BackColor = Color.LightBlue,
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(5)
            };

            Label label = new Label
            {
                Text = panelText,
                Location = new Point(10, 10),
                AutoSize = true
            };
            newPanel.Controls.Add(label);

            flowLayoutPanel_chat.Controls.Add(newPanel);
            flowLayoutPanel_chat.Refresh();
        }
    }
}
