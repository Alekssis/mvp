using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppMail
{
    public partial class WriteMessageControl : UserControl
    {
        public WriteMessageControl()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            SendToBack();
           // MessageForm.ActiveForm.Close();
            //Hide(); ---> For Send Message window
        }

        private void buttonWriteMess_Click(object sender, EventArgs e)
        {
            var message = new Messaged();

            message.Theme = TB_MessageTheme.Text;
            message.Text = RTB_MessageText.Text;
            message.SenderId = TB_SenderID.Text;
            
            var mailRepository = new MailRepository();
            if (mailRepository.Messages(message))
            {
                MessageBox.Show("Success!");
                this.SendToBack();
            }
            else
                MessageBox.Show("Error!");
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            MessageForm.ActiveForm.Close();
        }
    }
}
