namespace WindowsFormsAppMail
{
    partial class MessageForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.writeMessageControl1 = new WindowsFormsAppMail.WriteMessageControl();
            this.sendMessageControl1 = new WindowsFormsAppMail.SendMessageControl();
            this.SuspendLayout();
            // 
            // writeMessageControl1
            // 
            this.writeMessageControl1.Location = new System.Drawing.Point(13, 10);
            this.writeMessageControl1.Name = "writeMessageControl1";
            this.writeMessageControl1.Size = new System.Drawing.Size(300, 300);
            this.writeMessageControl1.TabIndex = 0;
            // 
            // sendMessageControl1
            // 
            this.sendMessageControl1.Location = new System.Drawing.Point(12, 10);
            this.sendMessageControl1.Name = "sendMessageControl1";
            this.sendMessageControl1.Size = new System.Drawing.Size(300, 300);
            this.sendMessageControl1.TabIndex = 1;
            // 
            // MessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 322);
            this.Controls.Add(this.writeMessageControl1);
            this.Controls.Add(this.sendMessageControl1);
            this.Name = "MessageForm";
            this.Text = "MessageForm";
            this.ResumeLayout(false);

        }

        #endregion

        private WriteMessageControl writeMessageControl1;
        private SendMessageControl sendMessageControl1;
    }
}