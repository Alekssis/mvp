namespace WindowsFormsAppMail
{
    partial class Form1
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
            this.loginUserControl1 = new WindowsFormsAppMail.LoginUserControl();
            this.signUserControl1 = new WindowsFormsAppMail.SignUserControl();
            this.SuspendLayout();
            // 
            // loginUserControl1
            // 
            this.loginUserControl1.Location = new System.Drawing.Point(12, 12);
            this.loginUserControl1.Name = "loginUserControl1";
            this.loginUserControl1.Size = new System.Drawing.Size(200, 300);
            this.loginUserControl1.TabIndex = 0;
            // 
            // signUserControl1
            // 
            this.signUserControl1.Location = new System.Drawing.Point(13, 10);
            this.signUserControl1.Name = "signUserControl1";
            this.signUserControl1.Size = new System.Drawing.Size(200, 300);
            this.signUserControl1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 322);
            this.Controls.Add(this.loginUserControl1);
            this.Controls.Add(this.signUserControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private LoginUserControl loginUserControl1;
        private SignUserControl signUserControl1;
    }
}

