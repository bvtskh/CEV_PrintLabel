namespace PrintLabel
{
    partial class FormConfigPath
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
            this.txtBartender = new Sunny.UI.UITextBox();
            this.txtDatabase = new Sunny.UI.UITextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnOpenBar = new Sunny.UI.UISymbolButton();
            this.btnOpenDB = new Sunny.UI.UISymbolButton();
            this.uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            this.btnConfirm = new Sunny.UI.UISymbolButton();
            this.cbbModel = new Sunny.UI.UIComboBox();
            this.cbbDest = new Sunny.UI.UIComboBox();
            this.cbbPrintType = new Sunny.UI.UIComboBox();
            this.SuspendLayout();
            // 
            // txtBartender
            // 
            this.txtBartender.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBartender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBartender.Location = new System.Drawing.Point(157, 143);
            this.txtBartender.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBartender.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtBartender.Name = "txtBartender";
            this.txtBartender.Padding = new System.Windows.Forms.Padding(5);
            this.txtBartender.ReadOnly = true;
            this.txtBartender.RectColor = System.Drawing.Color.Silver;
            this.txtBartender.ShowText = false;
            this.txtBartender.Size = new System.Drawing.Size(412, 29);
            this.txtBartender.Symbol = 61481;
            this.txtBartender.TabIndex = 0;
            this.txtBartender.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtBartender.Watermark = "";
            // 
            // txtDatabase
            // 
            this.txtDatabase.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDatabase.Location = new System.Drawing.Point(157, 181);
            this.txtDatabase.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDatabase.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Padding = new System.Windows.Forms.Padding(5);
            this.txtDatabase.ReadOnly = true;
            this.txtDatabase.RectColor = System.Drawing.Color.Silver;
            this.txtDatabase.ShowText = false;
            this.txtDatabase.Size = new System.Drawing.Size(412, 29);
            this.txtDatabase.Symbol = 61686;
            this.txtDatabase.TabIndex = 1;
            this.txtDatabase.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtDatabase.Watermark = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Thị trường";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kiểu in";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Bartender file:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "Database file(.txt):";
            // 
            // btnOpenBar
            // 
            this.btnOpenBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenBar.FillColor = System.Drawing.Color.Transparent;
            this.btnOpenBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnOpenBar.Location = new System.Drawing.Point(576, 147);
            this.btnOpenBar.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnOpenBar.Name = "btnOpenBar";
            this.btnOpenBar.RectColor = System.Drawing.Color.Transparent;
            this.btnOpenBar.Size = new System.Drawing.Size(27, 27);
            this.btnOpenBar.Symbol = 61563;
            this.btnOpenBar.SymbolColor = System.Drawing.Color.DarkOrange;
            this.btnOpenBar.SymbolHoverColor = System.Drawing.Color.Blue;
            this.btnOpenBar.SymbolSize = 32;
            this.btnOpenBar.TabIndex = 3;
            this.btnOpenBar.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnOpenBar.Click += new System.EventHandler(this.btnOpenBar_Click);
            // 
            // btnOpenDB
            // 
            this.btnOpenDB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenDB.FillColor = System.Drawing.Color.Transparent;
            this.btnOpenDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnOpenDB.Location = new System.Drawing.Point(576, 185);
            this.btnOpenDB.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnOpenDB.Name = "btnOpenDB";
            this.btnOpenDB.RectColor = System.Drawing.Color.Transparent;
            this.btnOpenDB.Size = new System.Drawing.Size(27, 27);
            this.btnOpenDB.Symbol = 61563;
            this.btnOpenDB.SymbolColor = System.Drawing.Color.DarkOrange;
            this.btnOpenDB.SymbolHoverColor = System.Drawing.Color.Blue;
            this.btnOpenDB.SymbolSize = 32;
            this.btnOpenDB.TabIndex = 3;
            this.btnOpenDB.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnOpenDB.Click += new System.EventHandler(this.btnOpenDB_Click);
            // 
            // uiSymbolLabel1
            // 
            this.uiSymbolLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiSymbolLabel1.Location = new System.Drawing.Point(424, 12);
            this.uiSymbolLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel1.Name = "uiSymbolLabel1";
            this.uiSymbolLabel1.Size = new System.Drawing.Size(145, 122);
            this.uiSymbolLabel1.Symbol = 57397;
            this.uiSymbolLabel1.SymbolColor = System.Drawing.SystemColors.ControlText;
            this.uiSymbolLabel1.SymbolSize = 128;
            this.uiSymbolLabel1.TabIndex = 4;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirm.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(111)))));
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnConfirm.Location = new System.Drawing.Point(448, 223);
            this.btnConfirm.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Radius = 15;
            this.btnConfirm.RectColor = System.Drawing.Color.Transparent;
            this.btnConfirm.Size = new System.Drawing.Size(121, 42);
            this.btnConfirm.TabIndex = 5;
            this.btnConfirm.Text = "Xác nhận";
            this.btnConfirm.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // cbbModel
            // 
            this.cbbModel.DataSource = null;
            this.cbbModel.FillColor = System.Drawing.Color.White;
            this.cbbModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbbModel.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cbbModel.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cbbModel.Location = new System.Drawing.Point(157, 25);
            this.cbbModel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbbModel.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbbModel.Name = "cbbModel";
            this.cbbModel.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbbModel.RectColor = System.Drawing.Color.Silver;
            this.cbbModel.Size = new System.Drawing.Size(240, 29);
            this.cbbModel.SymbolSize = 24;
            this.cbbModel.TabIndex = 6;
            this.cbbModel.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbbModel.Watermark = "";
            this.cbbModel.SelectedIndexChanged += new System.EventHandler(this.cbbModel_SelectedIndexChanged);
            // 
            // cbbDest
            // 
            this.cbbDest.DataSource = null;
            this.cbbDest.FillColor = System.Drawing.Color.White;
            this.cbbDest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbbDest.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cbbDest.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cbbDest.Location = new System.Drawing.Point(157, 61);
            this.cbbDest.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbbDest.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbbDest.Name = "cbbDest";
            this.cbbDest.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbbDest.RectColor = System.Drawing.Color.Silver;
            this.cbbDest.Size = new System.Drawing.Size(240, 29);
            this.cbbDest.SymbolSize = 24;
            this.cbbDest.TabIndex = 6;
            this.cbbDest.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbbDest.Watermark = "";
            this.cbbDest.SelectedIndexChanged += new System.EventHandler(this.cbbDest_SelectedIndexChanged);
            // 
            // cbbPrintType
            // 
            this.cbbPrintType.DataSource = null;
            this.cbbPrintType.FillColor = System.Drawing.Color.White;
            this.cbbPrintType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbbPrintType.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cbbPrintType.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cbbPrintType.Location = new System.Drawing.Point(157, 97);
            this.cbbPrintType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbbPrintType.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbbPrintType.Name = "cbbPrintType";
            this.cbbPrintType.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbbPrintType.RectColor = System.Drawing.Color.Silver;
            this.cbbPrintType.Size = new System.Drawing.Size(240, 29);
            this.cbbPrintType.SymbolSize = 24;
            this.cbbPrintType.TabIndex = 6;
            this.cbbPrintType.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbbPrintType.Watermark = "";
            this.cbbPrintType.SelectedIndexChanged += new System.EventHandler(this.cbbPrintType_SelectedIndexChanged);
            // 
            // FormConfigPath
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(617, 277);
            this.Controls.Add(this.cbbPrintType);
            this.Controls.Add(this.cbbDest);
            this.Controls.Add(this.cbbModel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.uiSymbolLabel1);
            this.Controls.Add(this.btnOpenDB);
            this.Controls.Add(this.btnOpenBar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDatabase);
            this.Controls.Add(this.txtBartender);
            this.MinimizeBox = false;
            this.Name = "FormConfigPath";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormConfigPath";
            this.Load += new System.EventHandler(this.FormConfigPath_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sunny.UI.UITextBox txtBartender;
        private Sunny.UI.UITextBox txtDatabase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Sunny.UI.UISymbolButton btnOpenBar;
        private Sunny.UI.UISymbolButton btnOpenDB;
        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
        private Sunny.UI.UISymbolButton btnConfirm;
        private Sunny.UI.UIComboBox cbbModel;
        private Sunny.UI.UIComboBox cbbDest;
        private Sunny.UI.UIComboBox cbbPrintType;
    }
}