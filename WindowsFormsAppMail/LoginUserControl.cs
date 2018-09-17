using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace WindowsFormsAppMail
{
    public partial class LoginUserControl : UserControl
    {
        public LoginUserControl()
        {
            InitializeComponent();
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            this.SendToBack();
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            string login = textBoxLogin.Text;
            string password = textBoxPassword.Text;

            var mailRepository = new MailRepository();
            var id = mailRepository.LogIn(login, password);
            if (id != -1)
            {
                MessageBox.Show("Success!");
                var wnd = new MailForm(id,login);
                wnd.Show();
                (this.Parent as Form1).Close();
            }
            else
                MessageBox.Show("Error!");
        }
    }
}
