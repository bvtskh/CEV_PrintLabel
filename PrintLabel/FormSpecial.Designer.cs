namespace PrintLabel
{
    partial class FormSpecial
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
            this.btnOpenBar = new Sunny.UI.UISymbolButton();
            this.lbTitle = new Sunny.UI.UIMarkLabel();
            this.btnSave = new Sunny.UI.UISymbolButton();
            this.btnOpenDb = new Sunny.UI.UISymbolButton();
            this.cbbPrintType = new Sunny.UI.UIComboBox();
            this.txtDatabase = new Sunny.UI.UITextBox();
            this.txtNumber = new Sunny.UI.UITextBox();
            this.txtBartender = new Sunny.UI.UITextBox();
            this.txtStartcode = new Sunny.UI.UITextBox();
            this.txtDest = new Sunny.UI.UITextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCell = new Sunny.UI.UITextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtprintedTotal = new Sunny.UI.UITextBox();
            this.txtModel = new Sunny.UI.UITextBox();
            this.SuspendLayout();
            // 
            // btnOpenBar
            // 
            this.btnOpenBar.BackColor = System.Drawing.Color.Transparent;
            this.btnOpenBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenBar.FillColor = System.Drawing.Color.Transparent;
            this.btnOpenBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnOpenBar.Location = new System.Drawing.Point(323, 343);
            this.btnOpenBar.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnOpenBar.Name = "btnOpenBar";
            this.btnOpenBar.RectColor = System.Drawing.Color.Transparent;
            this.btnOpenBar.Size = new System.Drawing.Size(33, 29);
            this.btnOpenBar.Symbol = 57436;
            this.btnOpenBar.SymbolColor = System.Drawing.Color.DodgerBlue;
            this.btnOpenBar.SymbolSize = 29;
            this.btnOpenBar.TabIndex = 25;
            this.btnOpenBar.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            // 
            // lbTitle
            // 
            this.lbTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.Red;
            this.lbTitle.Location = new System.Drawing.Point(0, 0);
            this.lbTitle.MarkPos = Sunny.UI.UIMarkLabel.UIMarkPos.Bottom;
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lbTitle.Size = new System.Drawing.Size(389, 41);
            this.lbTitle.TabIndex = 26;
            this.lbTitle.Text = "Thêm mới";
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(10)))), ((int)(((byte)(55)))));
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSave.Location = new System.Drawing.Point(243, 454);
            this.btnSave.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSave.Name = "btnSave";
            this.btnSave.RectColor = System.Drawing.Color.Transparent;
            this.btnSave.Size = new System.Drawing.Size(101, 40);
            this.btnSave.Symbol = 61452;
            this.btnSave.TabIndex = 24;
            this.btnSave.Text = "Save";
            this.btnSave.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnOpenDb
            // 
            this.btnOpenDb.BackColor = System.Drawing.Color.Transparent;
            this.btnOpenDb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenDb.FillColor = System.Drawing.Color.Transparent;
            this.btnOpenDb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnOpenDb.Location = new System.Drawing.Point(323, 405);
            this.btnOpenDb.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnOpenDb.Name = "btnOpenDb";
            this.btnOpenDb.RectColor = System.Drawing.Color.Transparent;
            this.btnOpenDb.Size = new System.Drawing.Size(33, 29);
            this.btnOpenDb.Symbol = 57436;
            this.btnOpenDb.SymbolColor = System.Drawing.Color.DodgerBlue;
            this.btnOpenDb.SymbolSize = 29;
            this.btnOpenDb.TabIndex = 23;
            this.btnOpenDb.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            // 
            // cbbPrintType
            // 
            this.cbbPrintType.DataSource = null;
            this.cbbPrintType.FillColor = System.Drawing.Color.White;
            this.cbbPrintType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbbPrintType.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cbbPrintType.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cbbPrintType.Location = new System.Drawing.Point(201, 226);
            this.cbbPrintType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbbPrintType.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbbPrintType.Name = "cbbPrintType";
            this.cbbPrintType.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbbPrintType.RectColor = System.Drawing.Color.Gray;
            this.cbbPrintType.Size = new System.Drawing.Size(157, 29);
            this.cbbPrintType.SymbolSize = 24;
            this.cbbPrintType.TabIndex = 22;
            this.cbbPrintType.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbbPrintType.Watermark = "";
            // 
            // txtDatabase
            // 
            this.txtDatabase.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDatabase.Location = new System.Drawing.Point(12, 405);
            this.txtDatabase.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDatabase.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Padding = new System.Windows.Forms.Padding(5);
            this.txtDatabase.ReadOnly = true;
            this.txtDatabase.RectColor = System.Drawing.Color.Gray;
            this.txtDatabase.ShowText = false;
            this.txtDatabase.Size = new System.Drawing.Size(304, 29);
            this.txtDatabase.TabIndex = 19;
            this.txtDatabase.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtDatabase.Watermark = "";
            // 
            // txtNumber
            // 
            this.txtNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNumber.Location = new System.Drawing.Point(14, 226);
            this.txtNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNumber.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Padding = new System.Windows.Forms.Padding(5);
            this.txtNumber.RectColor = System.Drawing.Color.Gray;
            this.txtNumber.ShowText = false;
            this.txtNumber.Size = new System.Drawing.Size(164, 29);
            this.txtNumber.TabIndex = 15;
            this.txtNumber.Text = "0";
            this.txtNumber.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtNumber.Type = Sunny.UI.UITextBox.UIEditType.Integer;
            this.txtNumber.Watermark = "";
            // 
            // txtBartender
            // 
            this.txtBartender.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBartender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBartender.Location = new System.Drawing.Point(12, 343);
            this.txtBartender.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBartender.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtBartender.Name = "txtBartender";
            this.txtBartender.Padding = new System.Windows.Forms.Padding(5);
            this.txtBartender.ReadOnly = true;
            this.txtBartender.RectColor = System.Drawing.Color.Gray;
            this.txtBartender.ShowText = false;
            this.txtBartender.Size = new System.Drawing.Size(304, 29);
            this.txtBartender.TabIndex = 20;
            this.txtBartender.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtBartender.Watermark = "";
            // 
            // txtStartcode
            // 
            this.txtStartcode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStartcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtStartcode.Location = new System.Drawing.Point(201, 161);
            this.txtStartcode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtStartcode.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtStartcode.Name = "txtStartcode";
            this.txtStartcode.Padding = new System.Windows.Forms.Padding(5);
            this.txtStartcode.RectColor = System.Drawing.Color.Gray;
            this.txtStartcode.ShowText = false;
            this.txtStartcode.Size = new System.Drawing.Size(157, 29);
            this.txtStartcode.TabIndex = 18;
            this.txtStartcode.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtStartcode.Watermark = "";
            // 
            // txtDest
            // 
            this.txtDest.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDest.Location = new System.Drawing.Point(14, 161);
            this.txtDest.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDest.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtDest.Name = "txtDest";
            this.txtDest.Padding = new System.Windows.Forms.Padding(5);
            this.txtDest.RectColor = System.Drawing.Color.Gray;
            this.txtDest.ShowText = false;
            this.txtDest.Size = new System.Drawing.Size(164, 29);
            this.txtDest.TabIndex = 17;
            this.txtDest.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtDest.Watermark = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(127, 386);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Database file";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(254, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Kiểu in";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Số lượng ký tự";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(127, 324);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Bartender file";
            // 
            // txtCell
            // 
            this.txtCell.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCell.Location = new System.Drawing.Point(201, 94);
            this.txtCell.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCell.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtCell.Name = "txtCell";
            this.txtCell.Padding = new System.Windows.Forms.Padding(5);
            this.txtCell.RectColor = System.Drawing.Color.Gray;
            this.txtCell.ShowText = false;
            this.txtCell.Size = new System.Drawing.Size(157, 29);
            this.txtCell.TabIndex = 16;
            this.txtCell.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtCell.Watermark = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(230, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ký tự đầu mã";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Thị trường";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(259, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cell";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Model";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(123, 263);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(102, 16);
            this.label15.TabIndex = 7;
            this.label15.Text = "Tổng số đã in";
            // 
            // txtprintedTotal
            // 
            this.txtprintedTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtprintedTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtprintedTotal.Location = new System.Drawing.Point(92, 285);
            this.txtprintedTotal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtprintedTotal.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtprintedTotal.Name = "txtprintedTotal";
            this.txtprintedTotal.Padding = new System.Windows.Forms.Padding(5);
            this.txtprintedTotal.RectColor = System.Drawing.Color.Gray;
            this.txtprintedTotal.ShowText = false;
            this.txtprintedTotal.Size = new System.Drawing.Size(164, 29);
            this.txtprintedTotal.TabIndex = 15;
            this.txtprintedTotal.Text = "0";
            this.txtprintedTotal.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtprintedTotal.Type = Sunny.UI.UITextBox.UIEditType.Integer;
            this.txtprintedTotal.Watermark = "";
            // 
            // txtModel
            // 
            this.txtModel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtModel.Location = new System.Drawing.Point(14, 94);
            this.txtModel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtModel.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtModel.Name = "txtModel";
            this.txtModel.Padding = new System.Windows.Forms.Padding(5);
            this.txtModel.RectColor = System.Drawing.Color.Gray;
            this.txtModel.ShowText = false;
            this.txtModel.Size = new System.Drawing.Size(164, 29);
            this.txtModel.TabIndex = 17;
            this.txtModel.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtModel.Watermark = "";
            // 
            // FormSpecial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 502);
            this.Controls.Add(this.btnOpenBar);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnOpenDb);
            this.Controls.Add(this.cbbPrintType);
            this.Controls.Add(this.txtDatabase);
            this.Controls.Add(this.txtprintedTotal);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.txtBartender);
            this.Controls.Add(this.txtStartcode);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtDest);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCell);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormSpecial";
            this.Text = "FormSpecial";
            this.Load += new System.EventHandler(this.FormSpecial_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Sunny.UI.UISymbolButton btnOpenBar;
        private Sunny.UI.UIMarkLabel lbTitle;
        private Sunny.UI.UISymbolButton btnSave;
        private Sunny.UI.UISymbolButton btnOpenDb;
        private Sunny.UI.UIComboBox cbbPrintType;
        private Sunny.UI.UITextBox txtDatabase;
        private Sunny.UI.UITextBox txtNumber;
        private Sunny.UI.UITextBox txtBartender;
        private Sunny.UI.UITextBox txtStartcode;
        private Sunny.UI.UITextBox txtDest;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private Sunny.UI.UITextBox txtCell;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label15;
        private Sunny.UI.UITextBox txtprintedTotal;
        private Sunny.UI.UITextBox txtModel;
    }
}