using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Messenger_MISHA
{
    public partial class AccauntForm : Form
    {
        public AccauntForm()
        {
            InitializeComponent();
            this.Load += AccauntForm_Load;

            // События для поля Имя
            textBox_Name.Enter += textBox_Name_Enter;
            textBox_Name.Leave += textBox_Name_Leave;
            textBox_Name.KeyPress += textBox_Name_KeyPress;
            textBox_Name.TextChanged += textBox_Name_Text1Changed;

            // События для поля Пароль
            textBox_password.Enter += textBox_Password_Enter;
            textBox_password.Leave += textBox_Password_Leave;
            textBox_password.KeyPress += textBox_Password_KeyPress;
            textBox_password.TextChanged += textBox_Password_TextChanged;

            // События для поля Email
            textBox_Email.Enter += textBox_Email_Enter;
            textBox_Email.Leave += textBox_Email_Leave;
            textBox_Email.KeyPress += textBox_Email_KeyPress;
            textBox_Email.TextChanged += textBox_EmailChanged;
        }

        // Поля класса
        private string defaultText = "Введите имя...";
        private string defaultPasswordText = "Введите пароль...";
        private string defaultEmailText = "Введите email...";
        private PictureBox pictureBoxStatusTag;
        private PictureBox pictureBoxStatusPasswordTag;
        private PictureBox pictureBoxStatusEmailTag;
        public void UpdatePicture(string imagePath)
        {
            try
            {
                if (pictureBox2.Image != null)
                    pictureBox2.Image.Dispose();

                pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox2.Image = new Bitmap(imagePath);
                pictureBox2.Refresh();
            }
            catch
            {
                MessageBox.Show("Невозможно открыть выбранный файл!", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void AccauntForm_Load(object sender, EventArgs e)
        {
            // Настройка поля для ИМЕНИ
            textBox_Name.Text = defaultText;
            textBox_Name.ForeColor = Color.Gray;

            // Создаем PictureBox для отображения галочки имени
            PictureBox pictureBoxStatus = new PictureBox();
            pictureBoxStatus.Size = new Size(20, 20);
            pictureBoxStatus.Location = new Point(textBox_Name.Location.X + textBox_Name.Width - 10,
                                                   textBox_Name.Location.Y + textBox_Name.Height - 11);
            pictureBoxStatus.BackColor = Color.Transparent;
            pictureBoxStatus.Image = null;
            pictureBoxStatus.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxStatus.Name = "pictureBoxStatus";
            this.Controls.Add(pictureBoxStatus);
            pictureBoxStatus.BringToFront();
            pictureBoxStatusTag = pictureBoxStatus;

            // Настройка поля для ПАРОЛЯ
            textBox_password.Text = defaultPasswordText;
            textBox_password.ForeColor = Color.Gray;
            textBox_password.UseSystemPasswordChar = false;

            // Создаем PictureBox для отображения галочки пароля
            PictureBox pictureBoxStatusPassword = new PictureBox();
            pictureBoxStatusPassword.Size = new Size(20, 20);
            pictureBoxStatusPassword.Location = new Point(textBox_password.Location.X + textBox_password.Width - 10,
                                                           textBox_password.Location.Y + textBox_password.Height - 11);
            pictureBoxStatusPassword.BackColor = Color.Transparent;
            pictureBoxStatusPassword.Image = null;
            pictureBoxStatusPassword.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxStatusPassword.Name = "pictureBoxStatusPassword";
            pictureBoxStatusPassword.Visible = true;
            this.Controls.Add(pictureBoxStatusPassword);
            pictureBoxStatusPassword.BringToFront();
            pictureBoxStatusPasswordTag = pictureBoxStatusPassword;

            textBox_Email.Text = defaultEmailText;
            textBox_Email.ForeColor = Color.Gray;

            // Создаем PictureBox для отображения галочки email
            PictureBox pictureBoxStatusEmail = new PictureBox();
            pictureBoxStatusEmail.Size = new Size(20, 20);
            pictureBoxStatusEmail.Location = new Point(textBox_Email.Location.X + textBox_Email.Width - 10,
                                                       textBox_Email.Location.Y + textBox_Email.Height - 11);
            pictureBoxStatusEmail.BackColor = Color.Transparent;
            pictureBoxStatusEmail.Image = null;
            pictureBoxStatusEmail.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxStatusEmail.Name = "pictureBoxStatusEmail";
            pictureBoxStatusEmail.Visible = true;
            this.Controls.Add(pictureBoxStatusEmail);
            pictureBoxStatusEmail.BringToFront();
            pictureBoxStatusEmailTag = pictureBoxStatusEmail;
        }

        // ==================== МЕТОДЫ ДЛЯ ПОЛЯ ИМЯ ====================

        private void textBox_Name_Enter(object sender, EventArgs e)
        {
            if (textBox_Name.Text == defaultText)
            {
                textBox_Name.Clear();
                textBox_Name.ForeColor = Color.White;
            }
        }

        private void textBox_Name_Text1Changed(object sender, EventArgs e)
        {
            if (textBox_Name.Text != defaultText && !string.IsNullOrWhiteSpace(textBox_Name.Text))
            {
                if (IsValidName(textBox_Name.Text, out string errorMessage))
                {
                    ShowStatusIcon(true);
                }
                else
                {
                    ShowStatusIcon(false);
                }
            }
            else
            {
                HideStatusIcon();
            }
        }

        private void textBox_Name_Leave(object sender, EventArgs e)
        {
            if (textBox_Name.Text == defaultText)
            {
                HideStatusIcon();
                return;
            }

            if (!IsValidName(textBox_Name.Text, out string errorMessage))
            {
                MessageBox.Show(errorMessage, "Ошибка ввода имени",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ShowStatusIcon(false);
                textBox_Name.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox_Name.Text))
            {
                textBox_Name.Text = defaultText;
                textBox_Name.ForeColor = Color.Gray;
                HideStatusIcon();
            }
            else
            {
                ShowStatusIcon(true);
            }
        }

        private void textBox_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;

                if (textBox_Name.Text == defaultText)
                {
                    textBox_Name.Clear();
                    textBox_Name.ForeColor = Color.Black;
                }

                if (IsValidName(textBox_Name.Text, out string errorMessage))
                {
                    ShowStatusIcon(true);
                    this.SelectNextControl(textBox_Name, true, true, true, true);
                }
                else
                {
                    MessageBox.Show(errorMessage, "Ошибка ввода имени",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ShowStatusIcon(false);
                    textBox_Name.Focus();
                }
            }
        }

        // ==================== МЕТОДЫ ДЛЯ ПОЛЯ ПАРОЛЬ ====================

        private void textBox_Password_Enter(object sender, EventArgs e)
        {
            if (textBox_password.Text == defaultPasswordText)
            {
                textBox_password.Clear();
                textBox_password.ForeColor = Color.White;
                textBox_password.UseSystemPasswordChar = true;
            }
        }

        private void textBox_Password_TextChanged(object sender, EventArgs e)
        {
            if (textBox_password.Text != defaultPasswordText && !string.IsNullOrWhiteSpace(textBox_password.Text))
            {
                if (IsValidPassword(textBox_password.Text, out string errorMessage))
                {
                    ShowPasswordStatusIcon(true);
                }
                else
                {
                    ShowPasswordStatusIcon(false);
                }
            }
            else
            {
                HidePasswordStatusIcon();
            }
        }

        private void textBox_Password_Leave(object sender, EventArgs e)
        {
            if (textBox_password.Text == defaultPasswordText)
            {
                HidePasswordStatusIcon();
                return;
            }

            if (!IsValidPassword(textBox_password.Text, out string errorMessage))
            {
                MessageBox.Show(errorMessage, "Ошибка ввода пароля",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ShowPasswordStatusIcon(false);
                textBox_password.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox_password.Text))
            {
                textBox_password.Text = defaultPasswordText;
                textBox_password.ForeColor = Color.Gray;
                textBox_password.UseSystemPasswordChar = false;
                HidePasswordStatusIcon();
            }
            else
            {
                ShowPasswordStatusIcon(true);
            }
        }
        // ==================== МЕТОДЫ ДЛЯ ПОЛЯ EMAIL ====================

        private void textBox_Email_Enter(object sender, EventArgs e)
        {
            if (textBox_Email.Text == defaultEmailText)
            {
                textBox_Email.Clear();
                textBox_Email.ForeColor = Color.White;
            }
        }

        private void textBox_EmailChanged(object sender, EventArgs e)
        {
            if (textBox_Email.Text != defaultEmailText && !string.IsNullOrWhiteSpace(textBox_Email.Text))
            {
                if (IsValidEmail(textBox_Email.Text, out string errorMessage))
                {
                    ShowEmailStatusIcon(true);
                }
                else
                {
                    ShowEmailStatusIcon(false);
                }
            }
            else
            {
                HideEmailStatusIcon();
            }
        }

        private void textBox_Email_Leave(object sender, EventArgs e)
        {
            if (textBox_Email.Text == defaultEmailText)
            {
                HideEmailStatusIcon();
                return;
            }

            if (!IsValidEmail(textBox_Email.Text, out string errorMessage))
            {
                MessageBox.Show(errorMessage, "Ошибка ввода email",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ShowEmailStatusIcon(false);
                textBox_Email.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox_Email.Text))
            {
                textBox_Email.Text = defaultEmailText;
                textBox_Email.ForeColor = Color.Gray;
                HideEmailStatusIcon();
            }
            else
            {
                ShowEmailStatusIcon(true);
            }
        }

        private void textBox_Email_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;

                if (textBox_Email.Text == defaultEmailText)
                {
                    textBox_Email.Clear();
                    textBox_Email.ForeColor = Color.Black;
                }

                if (IsValidEmail(textBox_Email.Text, out string errorMessage))
                {
                    ShowEmailStatusIcon(true);
                    this.SelectNextControl(textBox_Email, true, true, true, true);
                }
                else
                {
                    MessageBox.Show(errorMessage, "Ошибка ввода email",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ShowEmailStatusIcon(false);
                    textBox_Email.Focus();
                }
            }
        }

        private void textBox_Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;

                if (textBox_password.Text == defaultPasswordText)
                {
                    textBox_password.Clear();
                    textBox_password.ForeColor = Color.Black;
                    textBox_password.UseSystemPasswordChar = true;
                }

                if (IsValidPassword(textBox_password.Text, out string errorMessage))
                {
                    ShowPasswordStatusIcon(true);
                    this.SelectNextControl(textBox_password, true, true, true, true);
                }
                else
                {
                    MessageBox.Show(errorMessage, "Ошибка ввода пароля",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ShowPasswordStatusIcon(false);
                    textBox_password.Focus();
                }
            }
        }

        // ==================== МЕТОДЫ ДЛЯ ИКОНОК ====================

        private void ShowStatusIcon(bool isValid)
        {
            if (pictureBoxStatusTag == null) return;

            try
            {
                if (isValid)
                {
                    pictureBoxStatusTag.Image = Properties.Resources.image_43;
                    if (pictureBoxStatusTag.Image == null)
                    {
                        pictureBoxStatusTag.Image = CreateCheckMarkImage(true);
                    }
                }
                else
                {
                    pictureBoxStatusTag.Image = Properties.Resources.image_42;
                    if (pictureBoxStatusTag.Image == null)
                    {
                        pictureBoxStatusTag.Image = CreateCheckMarkImage(false);
                    }
                }
                pictureBoxStatusTag.Visible = true;
            }
            catch
            {
                pictureBoxStatusTag.Image = CreateCheckMarkImage(isValid);
                pictureBoxStatusTag.Visible = true;
            }
        }

        private void HideStatusIcon()
        {
            if (pictureBoxStatusTag != null)
            {
                pictureBoxStatusTag.Image = null;
                pictureBoxStatusTag.Visible = false;
            }
        }

        private void ShowPasswordStatusIcon(bool isValid)
        {
            if (pictureBoxStatusPasswordTag == null) return;

            try
            {
                if (isValid)
                {
                    pictureBoxStatusPasswordTag.Image = Properties.Resources.image_43;
                    if (pictureBoxStatusPasswordTag.Image == null)
                    {
                        pictureBoxStatusPasswordTag.Image = CreateCheckMarkImage(true);
                    }
                }
                else
                {
                    pictureBoxStatusPasswordTag.Image = Properties.Resources.image_42;
                    if (pictureBoxStatusPasswordTag.Image == null)
                    {
                        pictureBoxStatusPasswordTag.Image = CreateCheckMarkImage(false);
                    }
                }
                pictureBoxStatusPasswordTag.Visible = true;
            }
            catch
            {
                pictureBoxStatusPasswordTag.Image = CreateCheckMarkImage(isValid);
                pictureBoxStatusPasswordTag.Visible = true;
            }
        }

        private void HidePasswordStatusIcon()
        {
            if (pictureBoxStatusPasswordTag != null)
            {
                pictureBoxStatusPasswordTag.Image = null;
                pictureBoxStatusPasswordTag.Visible = false;
            }
        }

        // Создание иконки галочки/крестика динамически
        private Image CreateCheckMarkImage(bool isCheck)
        {
            Bitmap bmp = new Bitmap(20, 20);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.Transparent);

                if (isCheck)
                {
                    using (Pen greenPen = new Pen(Color.Green, 3))
                    {
                        g.DrawLine(greenPen, 2, 10, 8, 16);
                        g.DrawLine(greenPen, 8, 16, 18, 4);
                    }
                }
                else
                {
                    using (Pen redPen = new Pen(Color.Red, 3))
                    {
                        g.DrawLine(redPen, 3, 3, 17, 17);
                        g.DrawLine(redPen, 17, 3, 3, 17);
                    }
                }
            }
            return bmp;
        }
        private void ShowEmailStatusIcon(bool isValid)
        {
            if (pictureBoxStatusEmailTag == null) return;

            try
            {
                if (isValid)
                {
                    pictureBoxStatusEmailTag.Image = Properties.Resources.image_43;
                    if (pictureBoxStatusEmailTag.Image == null)
                    {
                        pictureBoxStatusEmailTag.Image = CreateCheckMarkImage(true);
                    }
                }
                else
                {
                    pictureBoxStatusEmailTag.Image = Properties.Resources.image_42;
                    if (pictureBoxStatusEmailTag.Image == null)
                    {
                        pictureBoxStatusEmailTag.Image = CreateCheckMarkImage(false);
                    }
                }
                pictureBoxStatusEmailTag.Visible = true;
            }
            catch
            {
                pictureBoxStatusEmailTag.Image = CreateCheckMarkImage(isValid);
                pictureBoxStatusEmailTag.Visible = true;
            }
        }

        private void HideEmailStatusIcon()
        {
            if (pictureBoxStatusEmailTag != null)
            {
                pictureBoxStatusEmailTag.Image = null;
                pictureBoxStatusEmailTag.Visible = false;
            }
        }

        // ==================== МЕТОДЫ ПРОВЕРКИ ====================

        private bool IsValidName(string name, out string errorMessage)
        {
            errorMessage = string.Empty;

            if (string.IsNullOrWhiteSpace(name))
            {
                errorMessage = "Имя не может быть пустым!";
                return false;
            }

            if (name.Length > 50)
            {
                errorMessage = "Имя не может превышать 50 символов!\n" +
                               $"Текущая длина: {name.Length} символов.";
                return false;
            }

            string invalidChars = "@#№$%^&*()+=-[]{}|\\/<>`~!?";

            foreach (char c in name)
            {
                if (invalidChars.Contains(c))
                {
                    errorMessage = $"Имя содержит недопустимый символ: '{c}'\n\n" +
                                   "Разрешенные символы:\n" +
                                   "- Буквы (A-Z, А-Я)\n" +
                                   "- Цифры (0-9)\n" +
                                   "- Пробел, дефис (-), точка (.), апостроф (')";
                    return false;
                }
            }

            if (name.All(char.IsDigit))
            {
                errorMessage = "Имя не может состоять только из цифр!";
                return false;
            }

            return true;
        }

        private bool IsValidPassword(string password, out string errorMessage)
        {
            errorMessage = string.Empty;

            if (string.IsNullOrWhiteSpace(password))
            {
                errorMessage = "Пароль не может быть пустым!";
                return false;
            }

            if (password.Length > 12)
            {
                errorMessage = "Пароль не может превышать 12 символов!\n" +
                               $"Текущая длина: {password.Length} символов.";
                return false;
            }

            if (password.Length < 6)
            {
                errorMessage = "Пароль должен содержать минимум 6 символов!\n" +
                               $"Текущая длина: {password.Length} символов.";
                return false;
            }

            if (password.All(char.IsWhiteSpace))
            {
                errorMessage = "Пароль не может состоять только из пробелов!";
                return false;
            }

            if (!string.IsNullOrEmpty(textBox_Name.Text) &&
                textBox_Name.Text != defaultText &&
                password.Equals(textBox_Name.Text, StringComparison.OrdinalIgnoreCase))
            {
                errorMessage = "Пароль не должен совпадать с именем!";
                return false;
            }

            return true;
        }
        private bool IsValidEmail(string email, out string errorMessage)
        {
            errorMessage = string.Empty;

            if (string.IsNullOrWhiteSpace(email))
            {
                errorMessage = "Email не может быть пустым!";
                return false;
            }

            if (email.Length > 255)
            {
                errorMessage = $"Email не может превышать 255 символов!\nТекущая длина: {email.Length} символов.";
                return false;
            }

            if (email.Length < 5)
            {
                errorMessage = "Email слишком короткий! Минимальная длина: 5 символов.";
                return false;
            }

            // Проверка на наличие символа @
            if (!email.Contains("@"))
            {
                errorMessage = "Email должен содержать символ '@'!";
                return false;
            }

            // Проверка на наличие точки после @
            int atIndex = email.IndexOf('@');
            if (atIndex == email.Length - 1)
            {
                errorMessage = "После символа '@' должна следовать доменная часть!";
                return false;
            }

            if (!email.Substring(atIndex + 1).Contains("."))
            {
                errorMessage = "Доменная часть email должна содержать точку (например: domain.com)!";
                return false;
            }

            // Проверка на недопустимые символы
            string invalidChars = " !\"#$%&'()*+,/:;<=>?[\\]^`{|}~";
            foreach (char c in email)
            {
                if (invalidChars.Contains(c))
                {
                    errorMessage = $"Email содержит недопустимый символ: '{c}'";
                    return false;
                }
            }

            // Проверка на несколько символов @
            if (email.Count(c => c == '@') > 1)
            {
                errorMessage = "Email не может содержать более одного символа '@'!";
                return false;
            }

            // Проверка на пробелы
            if (email.Contains(" "))
            {
                errorMessage = "Email не должен содержать пробелов!";
                return false;
            }

            return true;
        }

        // ==================== ДРУГИЕ МЕТОДЫ ФОРМЫ ====================

        private void textBox_frends_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_save_info_Click(object sender, EventArgs e)
        {

        }

        private void button_Ico_Click(object sender, EventArgs e)
        {
            Picture_Changing Picture_ChangingForm = new Picture_Changing();
            Picture_ChangingForm.Show();
        }
        private void textBox_Name_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox_password_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox_Email_TextChanged(object sender, EventArgs e)
        {

        }

        public void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
