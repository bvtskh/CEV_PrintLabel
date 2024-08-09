namespace PrintLabel
{
    partial class FormConfirm
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
            this.btnLogin = new Sunny.UI.UISymbolButton();
            this.txtPassword = new Sunny.UI.UITextBox();
            this.txtAccount = new Sunny.UI.UITextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnLogin.Location = new System.Drawing.Point(54, 135);
            this.btnLogin.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(223, 35);
            this.btnLogin.Symbol = 61584;
            this.btnLogin.TabIndex = 6;
            this.btnLogin.TabStop = false;
            this.btnLogin.Text = "Xác nhận";
            this.btnLogin.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPassword.Location = new System.Drawing.Point(54, 91);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassword.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Padding = new System.Windows.Forms.Padding(5);
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.RectColor = System.Drawing.Color.Silver;
            this.txtPassword.ShowText = false;
            this.txtPassword.Size = new System.Drawing.Size(223, 29);
            this.txtPassword.Symbol = 61758;
            this.txtPassword.TabIndex = 5;
            this.txtPassword.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtPassword.Watermark = "Mật khẩu";
            // 
            // txtAccount
            // 
            this.txtAccount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtAccount.Location = new System.Drawing.Point(54, 55);
            this.txtAccount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAccount.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Padding = new System.Windows.Forms.Padding(5);
            this.txtAccount.RectColor = System.Drawing.Color.Silver;
            this.txtAccount.ShowText = false;
            this.txtAccount.Size = new System.Drawing.Size(223, 29);
            this.txtAccount.Symbol = 62141;
            this.txtAccount.TabIndex = 4;
            this.txtAccount.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtAccount.Watermark = "Tài khoản";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Đăng nhập tài khoản có quyền Admin";
            // 
            // FormConfirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 191);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtAccount);
            this.Name = "FormConfirm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormConfirm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sunny.UI.UISymbolButton btnLogin;
        private Sunny.UI.UITextBox txtPassword;
        private Sunny.UI.UITextBox txtAccount;
        private System.Windows.Forms.Label label1;
    }
}