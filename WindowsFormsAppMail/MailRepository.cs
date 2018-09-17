using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppMail
{
    class MailRepository
    {
        string connectionString = @"Data Source=HPTIMKA;Initial Catalog=Mail;Integrated Security=True";

        public bool Register(User user)
        {
            Encryption.Salt = new byte[8] { 100, 200, 50, 25, 100, 200, 50, 25 };
            var passwordHash = Encryption.GetPasswordHash(user.Password);
            var passwordKey = Encryption.GetSalt();
            var success = false;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.CommandText = $"insert into Account values(N'{user.Name}', N'{user.Surname}', N'{user.Login}', N'{passwordHash}', N'{passwordKey}')";
                command.Connection = connection;

                if (command.ExecuteNonQuery() != 0)
                    success = true;
            }

            return success;
        }

        public bool Messages(Messaged message)
        {
            var success1 = false;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.CommandText = $"insert into Message values('{message.Theme}','{message.Text}','{message.SenderId}')";
                command.Connection = connection;

                if (command.ExecuteNonQuery() != 0)
                    success1 = true;
            }

            return success1;
        }

        public bool Messageses(Messageded message)
        {
            var success1 = false;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.CommandText = $"insert into MessageAccounts values('{message.MessageID}','{message.ReceiverID}')";
                command.Connection = connection;

                if (command.ExecuteNonQuery() != 0)
                    success1 = true;
            }

            return success1;
        }

        public int LogIn(string login, string password)
        {
            Encryption.Salt = new byte[8] { 100, 200, 50, 25, 100, 200, 50, 25 };
            var passwordHash = Encryption.GetPasswordHash(password);
            var id = -1;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.CommandText = $"select PasswordKey, Id from Account where Login = '{login}'";
                command.Connection = connection;
                var reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    //reader.GetChars(0, 0, salt, 0, 16);
                    id = reader.GetInt32(1);
                    reader.Close();
                    command.Dispose();
                }
                if (id != -1)
                {
                    SqlCommand command2 = new SqlCommand();
                    command2.CommandText = $"select * from Account where Login = '{login}' and PasswordHash = '{passwordHash}'";
                    command2.Connection = connection;
                    var reader2 = command.ExecuteReader();
                    if (!reader2.HasRows)
                        id = -1;
                }
            }

            return id;
        }
    }
}
