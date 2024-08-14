namespace PrintLabel
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.txtAccount = new Sunny.UI.UITextBox();
            this.txtPassword = new Sunny.UI.UITextBox();
            this.btnLogin = new Sunny.UI.UISymbolButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.uiMarkLabel1 = new Sunny.UI.UIMarkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAccount
            // 
            this.txtAccount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtAccount.Location = new System.Drawing.Point(49, 126);
            this.txtAccount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAccount.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Padding = new System.Windows.Forms.Padding(5);
            this.txtAccount.RectColor = System.Drawing.Color.Silver;
            this.txtAccount.ShowText = false;
            this.txtAccount.Size = new System.Drawing.Size(223, 29);
            this.txtAccount.Symbol = 62141;
            this.txtAccount.TabIndex = 1;
            this.txtAccount.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtAccount.Watermark = "Tài khoản";
            this.txtAccount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // txtPassword
            // 
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPassword.Location = new System.Drawing.Point(49, 175);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassword.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Padding = new System.Windows.Forms.Padding(5);
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.RectColor = System.Drawing.Color.Silver;
            this.txtPassword.ShowText = false;
            this.txtPassword.Size = new System.Drawing.Size(223, 29);
            this.txtPassword.Symbol = 61758;
            this.txtPassword.TabIndex = 2;
            this.txtPassword.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtPassword.Watermark = "Mật khẩu";
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // btnLogin
            // 
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnLogin.Location = new System.Drawing.Point(49, 259);
            this.btnLogin.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(223, 35);
            this.btnLogin.Symbol = 61584;
            this.btnLogin.TabIndex = 3;
            this.btnLogin.TabStop = false;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(104, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 53);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // uiMarkLabel1
            // 
            this.uiMarkLabel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.uiMarkLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiMarkLabel1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiMarkLabel1.ForeColor = System.Drawing.Color.Black;
            this.uiMarkLabel1.Location = new System.Drawing.Point(0, 0);
            this.uiMarkLabel1.MarkPos = Sunny.UI.UIMarkLabel.UIMarkPos.Bottom;
            this.uiMarkLabel1.Name = "uiMarkLabel1";
            this.uiMarkLabel1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.uiMarkLabel1.Size = new System.Drawing.Size(317, 39);
            this.uiMarkLabel1.TabIndex = 9;
            this.uiMarkLabel1.Text = "PRINT LABEL";
            this.uiMarkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(317, 323);
            this.Controls.Add(this.uiMarkLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtAccount);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Shown += new System.EventHandler(this.FormLogin_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UITextBox txtAccount;
        private Sunny.UI.UITextBox txtPassword;
        private Sunny.UI.UISymbolButton btnLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Sunny.UI.UIMarkLabel uiMarkLabel1;
    }
}