namespace PrintLabel
{
    partial class FormCheck
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
            this.uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            this.txtDes = new Sunny.UI.UITextBox();
            this.txtRule = new Sunny.UI.UITextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnApproval = new Sunny.UI.UISymbolButton();
            this.SuspendLayout();
            // 
            // uiSymbolLabel1
            // 
            this.uiSymbolLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiSymbolLabel1.Location = new System.Drawing.Point(6, 38);
            this.uiSymbolLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel1.Name = "uiSymbolLabel1";
            this.uiSymbolLabel1.Size = new System.Drawing.Size(109, 117);
            this.uiSymbolLabel1.Symbol = 61546;
            this.uiSymbolLabel1.SymbolColor = System.Drawing.Color.Blue;
            this.uiSymbolLabel1.SymbolSize = 128;
            this.uiSymbolLabel1.TabIndex = 0;
            // 
            // txtDes
            // 
            this.txtDes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDes.Location = new System.Drawing.Point(227, 63);
            this.txtDes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDes.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtDes.Name = "txtDes";
            this.txtDes.Padding = new System.Windows.Forms.Padding(5);
            this.txtDes.ReadOnly = true;
            this.txtDes.RectColor = System.Drawing.Color.Silver;
            this.txtDes.ShowText = false;
            this.txtDes.Size = new System.Drawing.Size(245, 29);
            this.txtDes.TabIndex = 1;
            this.txtDes.TabStop = false;
            this.txtDes.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtDes.Watermark = "";
            // 
            // txtRule
            // 
            this.txtRule.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtRule.Location = new System.Drawing.Point(227, 102);
            this.txtRule.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRule.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtRule.Name = "txtRule";
            this.txtRule.Padding = new System.Windows.Forms.Padding(5);
            this.txtRule.ReadOnly = true;
            this.txtRule.RectColor = System.Drawing.Color.Silver;
            this.txtRule.ShowText = false;
            this.txtRule.Size = new System.Drawing.Size(245, 29);
            this.txtRule.TabIndex = 1;
            this.txtRule.TabStop = false;
            this.txtRule.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtRule.Watermark = "";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkOrange;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(485, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "Xác nhận thông tin";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(127, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Thị trường";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(119, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ký tự đầu mã";
            // 
            // btnApproval
            // 
            this.btnApproval.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApproval.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(115)))));
            this.btnApproval.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnApproval.Location = new System.Drawing.Point(292, 141);
            this.btnApproval.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnApproval.Name = "btnApproval";
            this.btnApproval.Size = new System.Drawing.Size(136, 47);
            this.btnApproval.Symbol = 261796;
            this.btnApproval.SymbolSize = 28;
            this.btnApproval.TabIndex = 4;
            this.btnApproval.Text = "Xác nhận";
            this.btnApproval.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnApproval.Click += new System.EventHandler(this.btnApproval_Click);
            // 
            // FormCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 198);
            this.Controls.Add(this.btnApproval);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRule);
            this.Controls.Add(this.txtDes);
            this.Controls.Add(this.uiSymbolLabel1);
            this.MinimizeBox = false;
            this.Name = "FormCheck";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCheck";
            this.Load += new System.EventHandler(this.FormCheck_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
        private Sunny.UI.UITextBox txtDes;
        private Sunny.UI.UITextBox txtRule;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Sunny.UI.UISymbolButton btnApproval;
    }
}