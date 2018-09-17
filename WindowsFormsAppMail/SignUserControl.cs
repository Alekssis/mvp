using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsAppMail
{
    public partial class SignUserControl : UserControl
    {
        public SignUserControl()
        {
            InitializeComponent();
            
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.SendToBack();
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            var user = new User();

            user.Name = textBoxName.Text;
            user.Surname = textBoxSurname.Text;
            user.Login = textBoxLogin.Text;
            user.Password = textBoxPassword.Text;

            var mailRepository = new MailRepository();
            if (mailRepository.Register(user))
            { 
                MessageBox.Show("Success!");
                this.SendToBack();
            }
            else
                MessageBox.Show("Error!");
        }
    }
}








//var salt = new byte[8] { 100, 200, 50, 25, 100, 200, 50, 25 };
////var salt = new byte[16];
////var crypt = new RNGCryptoServiceProvider();
////crypt.GetBytes(salt);

//var hashFunc = new Rfc2898DeriveBytes(password, salt, 10);
//var hash = hashFunc.GetBytes(20);

//var passwordHash = System.Text.Encoding.Default.GetString(hash);
//var key = System.Text.Encoding.Default.GetString(salt);