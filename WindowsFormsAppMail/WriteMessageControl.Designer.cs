namespace WindowsFormsAppMail
{
    partial class WriteMessageControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_MessageTheme = new System.Windows.Forms.TextBox();
            this.TB_SenderID = new System.Windows.Forms.TextBox();
            this.RTB_MessageText = new System.Windows.Forms.RichTextBox();
            this.buttonWriteMess = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Theme";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Text";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "SenderID";
            // 
            // TB_MessageTheme
            // 
            this.TB_MessageTheme.Location = new System.Drawing.Point(25, 31);
            this.TB_MessageTheme.Name = "TB_MessageTheme";
            this.TB_MessageTheme.Size = new System.Drawing.Size(245, 20);
            this.TB_MessageTheme.TabIndex = 3;
            // 
            // TB_SenderID
            // 
            this.TB_SenderID.Location = new System.Drawing.Point(25, 206);
            this.TB_SenderID.Name = "TB_SenderID";
            this.TB_SenderID.Size = new System.Drawing.Size(245, 20);
            this.TB_SenderID.TabIndex = 4;
            // 
            // RTB_MessageText
            // 
            this.RTB_MessageText.Location = new System.Drawing.Point(25, 95);
            this.RTB_MessageText.Name = "RTB_MessageText";
            this.RTB_MessageText.Size = new System.Drawing.Size(245, 76);
            this.RTB_MessageText.TabIndex = 5;
            this.RTB_MessageText.Text = "";
            // 
            // buttonWriteMess
            // 
            this.buttonWriteMess.Location = new System.Drawing.Point(25, 258);
            this.buttonWriteMess.Name = "buttonWriteMess";
            this.buttonWriteMess.Size = new System.Drawing.Size(75, 23);
            this.buttonWriteMess.TabIndex = 6;
            this.buttonWriteMess.Text = "Write";
            this.buttonWriteMess.UseVisualStyleBackColor = true;
            this.buttonWriteMess.Click += new System.EventHandler(this.buttonWriteMess_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(124, 258);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 7;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(230, 258);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(40, 23);
            this.buttonExit.TabIndex = 8;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // WriteMessageControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonWriteMess);
            this.Controls.Add(this.RTB_MessageText);
            this.Controls.Add(this.TB_SenderID);
            this.Controls.Add(this.TB_MessageTheme);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "WriteMessageControl";
            this.Size = new System.Drawing.Size(300, 300);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_MessageTheme;
        private System.Windows.Forms.TextBox TB_SenderID;
        private System.Windows.Forms.RichTextBox RTB_MessageText;
        private System.Windows.Forms.Button buttonWriteMess;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonExit;
    }
}
