namespace WindowsFormsAppMail
{
    partial class MailForm
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
            this.components = new System.ComponentModel.Container();
            this.listBoxMessages = new System.Windows.Forms.ListBox();
            this.AccName = new System.Windows.Forms.Label();
            this.AccIndex = new System.Windows.Forms.Label();
            this.buttonWriteMess = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.accountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxMessages
            // 
            this.listBoxMessages.FormattingEnabled = true;
            this.listBoxMessages.Location = new System.Drawing.Point(12, 12);
            this.listBoxMessages.Name = "listBoxMessages";
            this.listBoxMessages.Size = new System.Drawing.Size(206, 56);
            this.listBoxMessages.TabIndex = 0;
            // 
            // AccName
            // 
            this.AccName.AutoSize = true;
            this.AccName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AccName.Location = new System.Drawing.Point(291, 12);
            this.AccName.Name = "AccName";
            this.AccName.Size = new System.Drawing.Size(132, 31);
            this.AccName.TabIndex = 2;
            this.AccName.Text = "AccName";
            // 
            // AccIndex
            // 
            this.AccIndex.AutoSize = true;
            this.AccIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AccIndex.Location = new System.Drawing.Point(239, 25);
            this.AccIndex.Name = "AccIndex";
            this.AccIndex.Size = new System.Drawing.Size(44, 17);
            this.AccIndex.TabIndex = 2;
            this.AccIndex.Text = "AccID";
            // 
            // buttonWriteMess
            // 
            this.buttonWriteMess.Location = new System.Drawing.Point(282, 243);
            this.buttonWriteMess.Name = "buttonWriteMess";
            this.buttonWriteMess.Size = new System.Drawing.Size(122, 23);
            this.buttonWriteMess.TabIndex = 3;
            this.buttonWriteMess.Text = "Write Message";
            this.buttonWriteMess.UseVisualStyleBackColor = true;
            this.buttonWriteMess.Click += new System.EventHandler(this.buttonWriteMess_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(440, 243);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 4;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // accountBindingSource
            // 
            this.accountBindingSource.DataMember = "Account";
            // 
            // MailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 275);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonWriteMess);
            this.Controls.Add(this.AccIndex);
            this.Controls.Add(this.AccName);
            this.Controls.Add(this.listBoxMessages);
            this.Name = "MailForm";
            this.Text = "MailForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MailForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxMessages;
        private System.Windows.Forms.Label AccName;
        private System.Windows.Forms.Label AccIndex;
        private System.Windows.Forms.Button buttonWriteMess;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.BindingSource accountBindingSource;
    }
}