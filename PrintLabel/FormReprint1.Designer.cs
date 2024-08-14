namespace PrintLabel
{
    partial class FormReprint1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEndBodyNo = new Sunny.UI.UITextBox();
            this.txtEndNumber = new Sunny.UI.UITextBox();
            this.lb99 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtModel = new Sunny.UI.UITextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCell = new Sunny.UI.UITextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDest = new Sunny.UI.UITextBox();
            this.lbPrinter = new System.Windows.Forms.Label();
            this.lbPrintType = new System.Windows.Forms.Label();
            this.lbCharNumber = new System.Windows.Forms.Label();
            this.lbPrintedTotal = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbbReason = new Sunny.UI.UIComboBox();
            this.txtStartBodyNo = new Sunny.UI.UITextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNumberPrint = new Sunny.UI.UITextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtChecker = new Sunny.UI.UITextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkCyan;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(717, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "REPRINT";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Printer:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(435, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Print Type:";
            // 
            // txtEndBodyNo
            // 
            this.txtEndBodyNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEndBodyNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtEndBodyNo.Location = new System.Drawing.Point(125, 361);
            this.txtEndBodyNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEndBodyNo.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtEndBodyNo.Name = "txtEndBodyNo";
            this.txtEndBodyNo.Padding = new System.Windows.Forms.Padding(5);
            this.txtEndBodyNo.ReadOnly = true;
            this.txtEndBodyNo.RectColor = System.Drawing.Color.Silver;
            this.txtEndBodyNo.RectSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)(((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.txtEndBodyNo.ShowText = false;
            this.txtEndBodyNo.Size = new System.Drawing.Size(273, 29);
            this.txtEndBodyNo.TabIndex = 2;
            this.txtEndBodyNo.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtEndBodyNo.Watermark = "";
            // 
            // txtEndNumber
            // 
            this.txtEndNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEndNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtEndNumber.Location = new System.Drawing.Point(270, 322);
            this.txtEndNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEndNumber.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtEndNumber.Name = "txtEndNumber";
            this.txtEndNumber.Padding = new System.Windows.Forms.Padding(5);
            this.txtEndNumber.RectColor = System.Drawing.Color.Silver;
            this.txtEndNumber.RectSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)(((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.txtEndNumber.ShowText = false;
            this.txtEndNumber.Size = new System.Drawing.Size(128, 29);
            this.txtEndNumber.TabIndex = 3;
            this.txtEndNumber.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtEndNumber.Watermark = "";
            this.txtEndNumber.Click += new System.EventHandler(this.txtFrom_Click);
            this.txtEndNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEndNumber_KeyDown);
            // 
            // lb99
            // 
            this.lb99.AutoSize = true;
            this.lb99.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb99.ForeColor = System.Drawing.Color.Red;
            this.lb99.Location = new System.Drawing.Point(435, 129);
            this.lb99.Name = "lb99";
            this.lb99.Size = new System.Drawing.Size(98, 16);
            this.lb99.TabIndex = 7;
            this.lb99.Text = "Char number:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 370);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "End Body No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(435, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Printed Total:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Model";
            // 
            // txtModel
            // 
            this.txtModel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtModel.Location = new System.Drawing.Point(125, 78);
            this.txtModel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtModel.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtModel.Name = "txtModel";
            this.txtModel.Padding = new System.Windows.Forms.Padding(5);
            this.txtModel.ReadOnly = true;
            this.txtModel.RectColor = System.Drawing.Color.Silver;
            this.txtModel.RectSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)(((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.txtModel.ShowText = false;
            this.txtModel.Size = new System.Drawing.Size(273, 29);
            this.txtModel.TabIndex = 2;
            this.txtModel.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtModel.Watermark = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Cell";
            // 
            // txtCell
            // 
            this.txtCell.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCell.Location = new System.Drawing.Point(125, 120);
            this.txtCell.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCell.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtCell.Name = "txtCell";
            this.txtCell.Padding = new System.Windows.Forms.Padding(5);
            this.txtCell.ReadOnly = true;
            this.txtCell.RectColor = System.Drawing.Color.Silver;
            this.txtCell.RectSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)(((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.txtCell.ShowText = false;
            this.txtCell.Size = new System.Drawing.Size(273, 29);
            this.txtCell.TabIndex = 2;
            this.txtCell.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtCell.Watermark = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(14, 171);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 16);
            this.label10.TabIndex = 9;
            this.label10.Text = "Destination";
            // 
            // txtDest
            // 
            this.txtDest.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDest.Location = new System.Drawing.Point(125, 162);
            this.txtDest.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDest.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtDest.Name = "txtDest";
            this.txtDest.Padding = new System.Windows.Forms.Padding(5);
            this.txtDest.ReadOnly = true;
            this.txtDest.RectColor = System.Drawing.Color.Silver;
            this.txtDest.RectSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)(((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.txtDest.ShowText = false;
            this.txtDest.Size = new System.Drawing.Size(273, 29);
            this.txtDest.TabIndex = 2;
            this.txtDest.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtDest.Watermark = "";
            // 
            // lbPrinter
            // 
            this.lbPrinter.AutoSize = true;
            this.lbPrinter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrinter.Location = new System.Drawing.Point(122, 211);
            this.lbPrinter.Name = "lbPrinter";
            this.lbPrinter.Size = new System.Drawing.Size(0, 20);
            this.lbPrinter.TabIndex = 1;
            // 
            // lbPrintType
            // 
            this.lbPrintType.AutoSize = true;
            this.lbPrintType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrintType.Location = new System.Drawing.Point(523, 87);
            this.lbPrintType.Name = "lbPrintType";
            this.lbPrintType.Size = new System.Drawing.Size(0, 18);
            this.lbPrintType.TabIndex = 1;
            // 
            // lbCharNumber
            // 
            this.lbCharNumber.AutoSize = true;
            this.lbCharNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCharNumber.ForeColor = System.Drawing.Color.Red;
            this.lbCharNumber.Location = new System.Drawing.Point(546, 132);
            this.lbCharNumber.Name = "lbCharNumber";
            this.lbCharNumber.Size = new System.Drawing.Size(0, 16);
            this.lbCharNumber.TabIndex = 7;
            // 
            // lbPrintedTotal
            // 
            this.lbPrintedTotal.AutoSize = true;
            this.lbPrintedTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrintedTotal.ForeColor = System.Drawing.Color.Red;
            this.lbPrintedTotal.Location = new System.Drawing.Point(545, 172);
            this.lbPrintedTotal.Name = "lbPrintedTotal";
            this.lbPrintedTotal.Size = new System.Drawing.Size(0, 16);
            this.lbPrintedTotal.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(16, 289);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 16);
            this.label11.TabIndex = 6;
            this.label11.Text = "Reason:";
            // 
            // cbbReason
            // 
            this.cbbReason.DataSource = null;
            this.cbbReason.FillColor = System.Drawing.Color.White;
            this.cbbReason.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbbReason.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cbbReason.Items.AddRange(new object[] {
            "In thiếu",
            "In lỗi",
            "Label rách, hỏng, mờ"});
            this.cbbReason.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cbbReason.Location = new System.Drawing.Point(125, 282);
            this.cbbReason.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbbReason.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbbReason.Name = "cbbReason";
            this.cbbReason.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbbReason.RectColor = System.Drawing.Color.Silver;
            this.cbbReason.Size = new System.Drawing.Size(273, 27);
            this.cbbReason.SymbolSize = 24;
            this.cbbReason.TabIndex = 12;
            this.cbbReason.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbbReason.Watermark = "";
            this.cbbReason.SelectedIndexChanged += new System.EventHandler(this.cbbReason_SelectedIndexChanged);
            this.cbbReason.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbbReason_KeyDown);
            // 
            // txtStartBodyNo
            // 
            this.txtStartBodyNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStartBodyNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtStartBodyNo.Location = new System.Drawing.Point(125, 322);
            this.txtStartBodyNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtStartBodyNo.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtStartBodyNo.Name = "txtStartBodyNo";
            this.txtStartBodyNo.Padding = new System.Windows.Forms.Padding(5);
            this.txtStartBodyNo.ReadOnly = true;
            this.txtStartBodyNo.RectColor = System.Drawing.Color.Silver;
            this.txtStartBodyNo.RectSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)(((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.txtStartBodyNo.ShowText = false;
            this.txtStartBodyNo.Size = new System.Drawing.Size(137, 29);
            this.txtStartBodyNo.TabIndex = 5;
            this.txtStartBodyNo.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtStartBodyNo.Watermark = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 332);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Start Body No";
            // 
            // txtNumberPrint
            // 
            this.txtNumberPrint.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNumberPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNumberPrint.Location = new System.Drawing.Point(438, 322);
            this.txtNumberPrint.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNumberPrint.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtNumberPrint.Name = "txtNumberPrint";
            this.txtNumberPrint.Padding = new System.Windows.Forms.Padding(5);
            this.txtNumberPrint.RectColor = System.Drawing.Color.Silver;
            this.txtNumberPrint.RectSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)(((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.txtNumberPrint.ShowText = false;
            this.txtNumberPrint.Size = new System.Drawing.Size(105, 29);
            this.txtNumberPrint.TabIndex = 3;
            this.txtNumberPrint.Text = "0";
            this.txtNumberPrint.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtNumberPrint.Type = Sunny.UI.UITextBox.UIEditType.Integer;
            this.txtNumberPrint.Watermark = "Số lượng in";
            this.txtNumberPrint.Click += new System.EventHandler(this.txtFrom_Click);
            this.txtNumberPrint.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNumberPrint_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(446, 299);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 18);
            this.label9.TabIndex = 1;
            this.label9.Text = "Serialzation";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(14, 252);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 16);
            this.label12.TabIndex = 9;
            this.label12.Text = "Checker";
            // 
            // txtChecker
            // 
            this.txtChecker.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtChecker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtChecker.Location = new System.Drawing.Point(125, 243);
            this.txtChecker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtChecker.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtChecker.Name = "txtChecker";
            this.txtChecker.Padding = new System.Windows.Forms.Padding(5);
            this.txtChecker.RectColor = System.Drawing.Color.Silver;
            this.txtChecker.RectSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)(((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.txtChecker.ShowText = false;
            this.txtChecker.Size = new System.Drawing.Size(273, 29);
            this.txtChecker.TabIndex = 2;
            this.txtChecker.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtChecker.Watermark = "";
            this.txtChecker.Click += new System.EventHandler(this.txtFrom_Click);
            this.txtChecker.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtChecker_KeyDown);
            // 
            // FormReprint1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 417);
            this.Controls.Add(this.cbbReason);
            this.Controls.Add(this.txtChecker);
            this.Controls.Add(this.txtDest);
            this.Controls.Add(this.txtCell);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtEndBodyNo);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNumberPrint);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtEndNumber);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lbPrintedTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbCharNumber);
            this.Controls.Add(this.lb99);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtStartBodyNo);
            this.Controls.Add(this.lbPrintType);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbPrinter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MinimizeBox = false;
            this.Name = "FormReprint1";
            this.Text = "FormReprint";
            this.Load += new System.EventHandler(this.FormReprint_Load);
            this.Shown += new System.EventHandler(this.FormReprint_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Sunny.UI.UITextBox txtEndBodyNo;
        private Sunny.UI.UITextBox txtEndNumber;
        private System.Windows.Forms.Label lb99;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Sunny.UI.UITextBox txtModel;
        private System.Windows.Forms.Label label6;
        private Sunny.UI.UITextBox txtCell;
        private System.Windows.Forms.Label label10;
        private Sunny.UI.UITextBox txtDest;
        private System.Windows.Forms.Label lbPrinter;
        private System.Windows.Forms.Label lbPrintType;
        private System.Windows.Forms.Label lbCharNumber;
        private System.Windows.Forms.Label lbPrintedTotal;
        private System.Windows.Forms.Label label11;
        private Sunny.UI.UIComboBox cbbReason;
        private Sunny.UI.UITextBox txtStartBodyNo;
        private System.Windows.Forms.Label label7;
        private Sunny.UI.UITextBox txtNumberPrint;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private Sunny.UI.UITextBox txtChecker;
    }
}