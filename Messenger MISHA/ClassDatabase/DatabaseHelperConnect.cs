using Npgsql;
using System;
using System.Collections.Generic;
using System.Text;

namespace Messenger_MISHA.ClassDatabase
{
    public class DatabaseHelperConnect
    {
        // Строка подключения для PostgreSQL
        NpgsqlConnection npgsqlConnection = new NpgsqlConnection(
            "Host=localhost; Port=5432; Database=Messenger_database; Username=Messenger_database; Password=postgres"
        );

        public void openConnection()
        {
            if (npgsqlConnection.State == System.Data.ConnectionState.Closed)
            {
                npgsqlConnection.Open();
            }
        }

        public void CloseConnection()
        {
            if (npgsqlConnection.State == System.Data.ConnectionState.Open)
            {
                npgsqlConnection.Close();
            }
        }

        public NpgsqlConnection getConnection()
        {
            return npgsqlConnection;
        }
    }
    public class DatabaseTables
    {
        private DatabaseHelperConnect dbHelper;

        public DatabaseTables(DatabaseHelperConnect helper)
        {
            dbHelper = helper;
            LoadAllTables();
        }

        // СВОЙСТВА ДЛЯ ДОСТУПА К КЛАССАМ-ЗАПОЛНИТЕЛЯМ ТАБЛИЦ
        public List<ChatRole> ChatRoles { get; set; }
        public List<TypeContent> TypeContents { get; set; }
        public List<ChatType> ChatTypes { get; set; }
        public List<Registration> Registrations { get; set; }
        public List<Account> Accounts { get; set; }
        public List<Chat> Chats { get; set; }
        public List<Messedge> Messedges { get; set; }
        public List<Membership> Memberships { get; set; }
        public List<TypeMessege> TypeMesseges { get; set; }

        // Методы для работы с таблицами
        public void LoadAllTables()
        {
            ChatRoles = new List<ChatRole>();
            TypeContents = new List<TypeContent>();
            ChatTypes = new List<ChatType>();
            Registrations = new List<Registration>();
            Accounts = new List<Account>();
            Chats = new List<Chat>();
            Messedges = new List<Messedge>();
            Memberships = new List<Membership>();
            TypeMesseges = new List<TypeMessege>();
        }

        public void ClearAllTables()
        {
            ChatRoles?.Clear();
            TypeContents?.Clear();
            ChatTypes?.Clear();
            Registrations?.Clear();
            Accounts?.Clear();
            Chats?.Clear();
            Messedges?.Clear();
            Memberships?.Clear();
            TypeMesseges?.Clear();
        }

        // КЛАССЫ ТАБЛИЦ (ENTITY CLASSES)

        // 1. Таблица Chat_role
        public class ChatRole
        {
            public int ID { get; set; }
            public string Owner { get; set; }
            public string Admin { get; set; }
            public string Moderator { get; set; }
            public string Member { get; set; }
            public string Banned { get; set; }
            public string Muted { get; set; }
        }

        // 2. Таблица Tipe_content
        public class TypeContent
        {
            public int ID { get; set; }
            public string Text { get; set; }
            public byte[] Image { get; set; }
            public string Video { get; set; }
            public string Audio { get; set; }
            public string File { get; set; }
            public string Sticker { get; set; }
            public string Gif { get; set; }
            public string Voice { get; set; }
        }

        // 3. Таблица Chat_tipe
        public class ChatType
        {
            public int ID { get; set; }
            public string Private { get; set; }
            public string Group { get; set; }
            public string Channel { get; set; }
        }

        // 4. Таблица Registration
        public class Registration
        {
            public int ID { get; set; }
            public string Nikname { get; set; }
            public string Email { get; set; }
            public string Password { get; set; }
        }

        // 5. Таблица Account
        public class Account
        {
            public int ID { get; set; }
            public int Registration { get; set; }
            public string About_me { get; set; }
            public TimeSpan Time_last_session { get; set; }
            public byte[] Avatar { get; set; }
            public DateTime Date_registration { get; set; }

            // Навигационное свойство
            public Registration RegistrationInfo { get; set; }
        }

        // 6. Таблица Chat
        public class Chat
        {
            public int ID { get; set; }
            public string Display_Name { get; set; }
            public int Chat_Type { get; set; }
            public DateTime Creation_Timestamp { get; set; }
            public string Description { get; set; }
            public byte[] Avatar { get; set; }

            // Навигационное свойство
            public ChatType ChatTypeInfo { get; set; }
        }

        // 7. Таблица Messedge
        public class Messedge
        {
            public int ID { get; set; }
            public int Link_to_user { get; set; }
            public int Tipe_content { get; set; }
            public string Link_to_message { get; set; }
            public string Text_message { get; set; }
            public DateTime Shipping_time { get; set; }
            public DateTime Edding_time { get; set; }
            public DateTime? Delition_time { get; set; }
            public string Link_content { get; set; }

            // Навигационные свойства
            public Account User { get; set; }
            public TypeContent Content { get; set; }
        }

        // 8. Таблица Membership
        public class Membership
        {
            public int ID { get; set; }
            public int Account { get; set; }
            public int Chat { get; set; }
            public string Invited_by_user_id { get; set; }
            public int Chat_role { get; set; }
            public DateTime Join_at { get; set; }

            // Навигационные свойства
            public Account AccountInfo { get; set; }
            public Chat ChatInfo { get; set; }
            public ChatRole Role { get; set; }
        }

        // 9. Таблица Tipe_messege
        public class TypeMessege
        {
            public int ID { get; set; }
            public int Chat { get; set; }
            public int Messege { get; set; }

            // Навигационные свойства
            public Chat ChatInfo { get; set; }
            public Messedge MessedgeInfo { get; set; }
        }
    }
}

