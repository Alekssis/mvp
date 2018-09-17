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
    public partial class SendMessageControl : UserControl
    {
        public SendMessageControl()
        {
            InitializeComponent();
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            var messages = new Messageded();

            messages.MessageID = TB_MessageID.Text;
            messages.ReceiverID = TB_ReceiverID.Text;


            var mailRepository = new MailRepository();
            if (mailRepository.Messageses(messages))
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

        private void buttonBack_Click(object sender, EventArgs e)
        {
            SendToBack();
        }
    }
}
