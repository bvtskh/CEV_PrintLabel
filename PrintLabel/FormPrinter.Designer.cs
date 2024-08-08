﻿namespace PrintLabel
{
    partial class FormPrinter
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.uiMarkLabel1 = new Sunny.UI.UIMarkLabel();
            this.dgvDes = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbCell = new Sunny.UI.UIComboBox();
            this.cbbModel = new Sunny.UI.UIComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbPrintType = new System.Windows.Forms.Label();
            this.btnException = new Sunny.UI.UISymbolButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelSystem = new System.Windows.Forms.Panel();
            this.txtPrinter = new Sunny.UI.UITextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.uiTextBox2 = new Sunny.UI.UITextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEndBodyNo = new Sunny.UI.UITextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPrintNumbers = new Sunny.UI.UITextBox();
            this.lbCharNumber = new System.Windows.Forms.Label();
            this.txtNumberLastPrint = new Sunny.UI.UITextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtStartBodyNo = new Sunny.UI.UITextBox();
            this.txtPart = new Sunny.UI.UITextBox();
            this.lbAlarm = new System.Windows.Forms.Label();
            this.txtPathFile = new Sunny.UI.UITextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDes)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelSystem.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.uiMarkLabel1);
            this.panel1.Controls.Add(this.dgvDes);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbbCell);
            this.panel1.Controls.Add(this.cbbModel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(299, 443);
            this.panel1.TabIndex = 0;
            // 
            // uiMarkLabel1
            // 
            this.uiMarkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiMarkLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiMarkLabel1.Location = new System.Drawing.Point(0, 134);
            this.uiMarkLabel1.MarkPos = Sunny.UI.UIMarkLabel.UIMarkPos.Bottom;
            this.uiMarkLabel1.Name = "uiMarkLabel1";
            this.uiMarkLabel1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.uiMarkLabel1.Size = new System.Drawing.Size(299, 23);
            this.uiMarkLabel1.TabIndex = 0;
            this.uiMarkLabel1.Text = "Destination";
            // 
            // dgvDes
            // 
            this.dgvDes.AllowUserToAddRows = false;
            this.dgvDes.AllowUserToDeleteRows = false;
            this.dgvDes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvDes.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.Cornsilk;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvDes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDes.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgvDes.EnableHeadersVisualStyles = false;
            this.dgvDes.Location = new System.Drawing.Point(36, 170);
            this.dgvDes.Name = "dgvDes";
            this.dgvDes.RowHeadersVisible = false;
            this.dgvDes.Size = new System.Drawing.Size(225, 255);
            this.dgvDes.TabIndex = 0;
            this.dgvDes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDes_CellClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Destination";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cell";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Model";
            // 
            // cbbCell
            // 
            this.cbbCell.DataSource = null;
            this.cbbCell.FillColor = System.Drawing.Color.White;
            this.cbbCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbbCell.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cbbCell.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cbbCell.Location = new System.Drawing.Point(48, 98);
            this.cbbCell.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbbCell.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbbCell.Name = "cbbCell";
            this.cbbCell.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbbCell.RectColor = System.Drawing.Color.Silver;
            this.cbbCell.Size = new System.Drawing.Size(201, 29);
            this.cbbCell.SymbolSize = 24;
            this.cbbCell.TabIndex = 0;
            this.cbbCell.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbbCell.Watermark = "";
            this.cbbCell.SelectedIndexChanged += new System.EventHandler(this.cbbCell_SelectedIndexChanged);
            // 
            // cbbModel
            // 
            this.cbbModel.DataSource = null;
            this.cbbModel.FillColor = System.Drawing.Color.White;
            this.cbbModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbbModel.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cbbModel.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cbbModel.Location = new System.Drawing.Point(48, 41);
            this.cbbModel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbbModel.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbbModel.Name = "cbbModel";
            this.cbbModel.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbbModel.RectColor = System.Drawing.Color.Silver;
            this.cbbModel.Size = new System.Drawing.Size(201, 29);
            this.cbbModel.SymbolSize = 24;
            this.cbbModel.TabIndex = 0;
            this.cbbModel.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbbModel.Watermark = "";
            this.cbbModel.SelectedIndexChanged += new System.EventHandler(this.cbbModel_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Coral;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lbPrintType);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(304, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(559, 65);
            this.panel2.TabIndex = 1;
            // 
            // lbPrintType
            // 
            this.lbPrintType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbPrintType.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrintType.ForeColor = System.Drawing.Color.White;
            this.lbPrintType.Location = new System.Drawing.Point(0, 0);
            this.lbPrintType.Name = "lbPrintType";
            this.lbPrintType.Size = new System.Drawing.Size(557, 63);
            this.lbPrintType.TabIndex = 1;
            this.lbPrintType.Text = "PRINT LABEL";
            this.lbPrintType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnException
            // 
            this.btnException.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnException.FillColor = System.Drawing.Color.DarkBlue;
            this.btnException.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnException.ForeColor = System.Drawing.Color.Red;
            this.btnException.Location = new System.Drawing.Point(6, 6);
            this.btnException.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnException.Name = "btnException";
            this.btnException.Radius = 15;
            this.btnException.RectColor = System.Drawing.Color.Transparent;
            this.btnException.Size = new System.Drawing.Size(116, 39);
            this.btnException.Symbol = 61561;
            this.btnException.TabIndex = 0;
            this.btnException.Text = "Exception";
            this.btnException.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnException.Click += new System.EventHandler(this.btnException_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panelSystem);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(304, 70);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(559, 378);
            this.panel3.TabIndex = 2;
            // 
            // panelSystem
            // 
            this.panelSystem.Controls.Add(this.txtPrinter);
            this.panelSystem.Controls.Add(this.label4);
            this.panelSystem.Controls.Add(this.label5);
            this.panelSystem.Controls.Add(this.uiTextBox2);
            this.panelSystem.Controls.Add(this.label6);
            this.panelSystem.Controls.Add(this.txtEndBodyNo);
            this.panelSystem.Controls.Add(this.label7);
            this.panelSystem.Controls.Add(this.txtPrintNumbers);
            this.panelSystem.Controls.Add(this.lbCharNumber);
            this.panelSystem.Controls.Add(this.txtNumberLastPrint);
            this.panelSystem.Controls.Add(this.label9);
            this.panelSystem.Controls.Add(this.label8);
            this.panelSystem.Controls.Add(this.txtStartBodyNo);
            this.panelSystem.Controls.Add(this.txtPart);
            this.panelSystem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSystem.Location = new System.Drawing.Point(0, 93);
            this.panelSystem.Name = "panelSystem";
            this.panelSystem.Size = new System.Drawing.Size(559, 285);
            this.panelSystem.TabIndex = 2;
            // 
            // txtPrinter
            // 
            this.txtPrinter.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrinter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPrinter.Location = new System.Drawing.Point(130, 16);
            this.txtPrinter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPrinter.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtPrinter.Name = "txtPrinter";
            this.txtPrinter.Padding = new System.Windows.Forms.Padding(5);
            this.txtPrinter.ReadOnly = true;
            this.txtPrinter.RectColor = System.Drawing.Color.Silver;
            this.txtPrinter.RectSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)(((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.txtPrinter.ShowText = false;
            this.txtPrinter.Size = new System.Drawing.Size(273, 29);
            this.txtPrinter.TabIndex = 0;
            this.txtPrinter.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtPrinter.Watermark = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Printer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Part Number";
            // 
            // uiTextBox2
            // 
            this.uiTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiTextBox2.Location = new System.Drawing.Point(130, 55);
            this.uiTextBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox2.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTextBox2.Name = "uiTextBox2";
            this.uiTextBox2.Padding = new System.Windows.Forms.Padding(5);
            this.uiTextBox2.RectColor = System.Drawing.Color.Silver;
            this.uiTextBox2.RectSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)(((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.uiTextBox2.ShowText = false;
            this.uiTextBox2.Size = new System.Drawing.Size(273, 29);
            this.uiTextBox2.TabIndex = 0;
            this.uiTextBox2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTextBox2.Watermark = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Checker";
            // 
            // txtEndBodyNo
            // 
            this.txtEndBodyNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEndBodyNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtEndBodyNo.Location = new System.Drawing.Point(130, 208);
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
            this.txtEndBodyNo.TabIndex = 0;
            this.txtEndBodyNo.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtEndBodyNo.Watermark = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Start Body No";
            // 
            // txtPrintNumbers
            // 
            this.txtPrintNumbers.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrintNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPrintNumbers.Location = new System.Drawing.Point(426, 169);
            this.txtPrintNumbers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPrintNumbers.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtPrintNumbers.Name = "txtPrintNumbers";
            this.txtPrintNumbers.Padding = new System.Windows.Forms.Padding(5);
            this.txtPrintNumbers.RectColor = System.Drawing.Color.Silver;
            this.txtPrintNumbers.RectSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)(((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.txtPrintNumbers.ShowText = false;
            this.txtPrintNumbers.Size = new System.Drawing.Size(115, 29);
            this.txtPrintNumbers.TabIndex = 0;
            this.txtPrintNumbers.Text = "0";
            this.txtPrintNumbers.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtPrintNumbers.Type = Sunny.UI.UITextBox.UIEditType.Integer;
            this.txtPrintNumbers.Watermark = "Số lượng in";
            this.txtPrintNumbers.Click += new System.EventHandler(this.txtPrintNumbers_Click);
            this.txtPrintNumbers.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPrintNumbers_KeyDown);
            // 
            // lbCharNumber
            // 
            this.lbCharNumber.AutoSize = true;
            this.lbCharNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCharNumber.ForeColor = System.Drawing.Color.Red;
            this.lbCharNumber.Location = new System.Drawing.Point(19, 138);
            this.lbCharNumber.Name = "lbCharNumber";
            this.lbCharNumber.Size = new System.Drawing.Size(98, 16);
            this.lbCharNumber.TabIndex = 1;
            this.lbCharNumber.Text = "Char number:";
            // 
            // txtNumberLastPrint
            // 
            this.txtNumberLastPrint.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNumberLastPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNumberLastPrint.Location = new System.Drawing.Point(288, 169);
            this.txtNumberLastPrint.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNumberLastPrint.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtNumberLastPrint.Name = "txtNumberLastPrint";
            this.txtNumberLastPrint.Padding = new System.Windows.Forms.Padding(5);
            this.txtNumberLastPrint.ReadOnly = true;
            this.txtNumberLastPrint.RectColor = System.Drawing.Color.Silver;
            this.txtNumberLastPrint.RectSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)(((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.txtNumberLastPrint.ShowText = false;
            this.txtNumberLastPrint.Size = new System.Drawing.Size(115, 29);
            this.txtNumberLastPrint.TabIndex = 0;
            this.txtNumberLastPrint.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtNumberLastPrint.Watermark = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(423, 148);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 16);
            this.label9.TabIndex = 1;
            this.label9.Text = "Serialzation";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 217);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "End Body No";
            // 
            // txtStartBodyNo
            // 
            this.txtStartBodyNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStartBodyNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtStartBodyNo.Location = new System.Drawing.Point(130, 169);
            this.txtStartBodyNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtStartBodyNo.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtStartBodyNo.Name = "txtStartBodyNo";
            this.txtStartBodyNo.Padding = new System.Windows.Forms.Padding(5);
            this.txtStartBodyNo.ReadOnly = true;
            this.txtStartBodyNo.RectColor = System.Drawing.Color.Silver;
            this.txtStartBodyNo.RectSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)(((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.txtStartBodyNo.ShowText = false;
            this.txtStartBodyNo.Size = new System.Drawing.Size(150, 29);
            this.txtStartBodyNo.TabIndex = 0;
            this.txtStartBodyNo.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtStartBodyNo.Watermark = "";
            // 
            // txtPart
            // 
            this.txtPart.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPart.Location = new System.Drawing.Point(130, 92);
            this.txtPart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPart.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtPart.Name = "txtPart";
            this.txtPart.Padding = new System.Windows.Forms.Padding(5);
            this.txtPart.RectColor = System.Drawing.Color.Silver;
            this.txtPart.RectSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)(((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.txtPart.ShowText = false;
            this.txtPart.Size = new System.Drawing.Size(273, 29);
            this.txtPart.TabIndex = 0;
            this.txtPart.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtPart.Watermark = "";
            // 
            // lbAlarm
            // 
            this.lbAlarm.AutoSize = true;
            this.lbAlarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAlarm.ForeColor = System.Drawing.Color.Red;
            this.lbAlarm.Location = new System.Drawing.Point(33, 61);
            this.lbAlarm.Name = "lbAlarm";
            this.lbAlarm.Size = new System.Drawing.Size(0, 16);
            this.lbAlarm.TabIndex = 1;
            // 
            // txtPathFile
            // 
            this.txtPathFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPathFile.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPathFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPathFile.Location = new System.Drawing.Point(130, 12);
            this.txtPathFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPathFile.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtPathFile.Name = "txtPathFile";
            this.txtPathFile.Padding = new System.Windows.Forms.Padding(5);
            this.txtPathFile.ReadOnly = true;
            this.txtPathFile.RectColor = System.Drawing.Color.Silver;
            this.txtPathFile.RectSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)(((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.txtPathFile.ShowText = false;
            this.txtPathFile.Size = new System.Drawing.Size(425, 27);
            this.txtPathFile.TabIndex = 0;
            this.txtPathFile.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtPathFile.Watermark = "";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnException);
            this.panel4.Controls.Add(this.txtPathFile);
            this.panel4.Controls.Add(this.lbAlarm);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(559, 93);
            this.panel4.TabIndex = 3;
            // 
            // FormPrinter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 453);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimizeBox = false;
            this.Name = "FormPrinter";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDes)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panelSystem.ResumeLayout(false);
            this.panelSystem.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Sunny.UI.UIComboBox cbbModel;
        private System.Windows.Forms.Label label1;
        private Sunny.UI.UIComboBox cbbCell;
        private System.Windows.Forms.DataGridView dgvDes;
        private System.Windows.Forms.Label label2;
        private Sunny.UI.UIMarkLabel uiMarkLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private Sunny.UI.UISymbolButton btnException;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbPrintType;
        private Sunny.UI.UITextBox uiTextBox2;
        private Sunny.UI.UITextBox txtPrinter;
        private Sunny.UI.UITextBox txtPart;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Sunny.UI.UITextBox txtEndBodyNo;
        private Sunny.UI.UITextBox txtPrintNumbers;
        private Sunny.UI.UITextBox txtNumberLastPrint;
        private Sunny.UI.UITextBox txtStartBodyNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbCharNumber;
        private Sunny.UI.UITextBox txtPathFile;
        private System.Windows.Forms.Panel panelSystem;
        private System.Windows.Forms.Label lbAlarm;
        private System.Windows.Forms.Panel panel4;
    }
}

