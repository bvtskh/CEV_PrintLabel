namespace PrintLabel
{
    partial class FormMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.lbUser = new Sunny.UI.UISymbolLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.uiSymbolLabel4 = new Sunny.UI.UISymbolLabel();
            this.uiMarkLabel2 = new Sunny.UI.UIMarkLabel();
            this.btnDatabase = new Sunny.UI.UISymbolButton();
            this.btnConfig = new Sunny.UI.UISymbolButton();
            this.panel9 = new System.Windows.Forms.Panel();
            this.uiSymbolLabel3 = new Sunny.UI.UISymbolLabel();
            this.uiMarkLabel1 = new Sunny.UI.UIMarkLabel();
            this.btnPrintBody = new Sunny.UI.UISymbolButton();
            this.btnPrintOuterBox = new Sunny.UI.UISymbolButton();
            this.btnPrintRating = new Sunny.UI.UISymbolButton();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbException = new Sunny.UI.UIRadioButton();
            this.cbNormal = new Sunny.UI.UIRadioButton();
            this.uiSymbolLabel2 = new Sunny.UI.UISymbolLabel();
            this.uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panelChart = new System.Windows.Forms.Panel();
            this.process1 = new Sunny.UI.UIProgressIndicator();
            this.graphColumns = new LiveCharts.WinForms.CartesianChart();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panelCirle = new System.Windows.Forms.Panel();
            this.process2 = new Sunny.UI.UIProgressIndicator();
            this.graphCircle = new ZedGraph.ZedGraphControl();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnAccount = new Sunny.UI.UISymbolButton();
            this.uiPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panelChart.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panelCirle.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiPanel1
            // 
            this.uiPanel1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.uiPanel1.Controls.Add(this.lbUser);
            this.uiPanel1.Controls.Add(this.label1);
            this.uiPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel1.FillColor = System.Drawing.Color.DarkTurquoise;
            this.uiPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiPanel1.Location = new System.Drawing.Point(5, 5);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.RectColor = System.Drawing.Color.Transparent;
            this.uiPanel1.Size = new System.Drawing.Size(1167, 53);
            this.uiPanel1.TabIndex = 0;
            this.uiPanel1.Text = null;
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbUser
            // 
            this.lbUser.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbUser.ForeColor = System.Drawing.Color.White;
            this.lbUser.Location = new System.Drawing.Point(951, 0);
            this.lbUser.MinimumSize = new System.Drawing.Size(1, 1);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(216, 53);
            this.lbUser.Symbol = 62142;
            this.lbUser.SymbolColor = System.Drawing.Color.White;
            this.lbUser.SymbolSize = 29;
            this.lbUser.TabIndex = 1;
            this.lbUser.Text = "user";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1167, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "PRINT LABEL CANON";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.splitter2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(5, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1167, 646);
            this.panel1.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.dgvReport);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 44);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(776, 238);
            this.panel6.TabIndex = 1;
            // 
            // dgvReport
            // 
            this.dgvReport.AllowUserToAddRows = false;
            this.dgvReport.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.dgvReport.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvReport.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvReport.ColumnHeadersHeight = 35;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReport.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvReport.EnableHeadersVisualStyles = false;
            this.dgvReport.Location = new System.Drawing.Point(5, 6);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.RowHeadersVisible = false;
            this.dgvReport.Size = new System.Drawing.Size(766, 229);
            this.dgvReport.TabIndex = 0;
            // 
            // splitter2
            // 
            this.splitter2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter2.Location = new System.Drawing.Point(0, 282);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(776, 3);
            this.splitter2.TabIndex = 3;
            this.splitter2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel10);
            this.panel2.Controls.Add(this.panel9);
            this.panel2.Controls.Add(this.splitter3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(776, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(389, 241);
            this.panel2.TabIndex = 2;
            // 
            // panel10
            // 
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel10.Controls.Add(this.uiSymbolLabel4);
            this.panel10.Controls.Add(this.uiMarkLabel2);
            this.panel10.Controls.Add(this.btnAccount);
            this.panel10.Controls.Add(this.btnDatabase);
            this.panel10.Controls.Add(this.btnConfig);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(206, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(181, 238);
            this.panel10.TabIndex = 4;
            // 
            // uiSymbolLabel4
            // 
            this.uiSymbolLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiSymbolLabel4.Location = new System.Drawing.Point(22, 8);
            this.uiSymbolLabel4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel4.Name = "uiSymbolLabel4";
            this.uiSymbolLabel4.Size = new System.Drawing.Size(130, 29);
            this.uiSymbolLabel4.Symbol = 61459;
            this.uiSymbolLabel4.SymbolColor = System.Drawing.Color.Black;
            this.uiSymbolLabel4.SymbolOffset = new System.Drawing.Point(0, 1);
            this.uiSymbolLabel4.SymbolSize = 32;
            this.uiSymbolLabel4.TabIndex = 0;
            this.uiSymbolLabel4.Text = "System";
            // 
            // uiMarkLabel2
            // 
            this.uiMarkLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiMarkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiMarkLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiMarkLabel2.Location = new System.Drawing.Point(-1, 35);
            this.uiMarkLabel2.MarkPos = Sunny.UI.UIMarkLabel.UIMarkPos.Bottom;
            this.uiMarkLabel2.Name = "uiMarkLabel2";
            this.uiMarkLabel2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.uiMarkLabel2.Size = new System.Drawing.Size(180, 12);
            this.uiMarkLabel2.TabIndex = 2;
            // 
            // btnDatabase
            // 
            this.btnDatabase.BackColor = System.Drawing.Color.Transparent;
            this.btnDatabase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDatabase.FillColor = System.Drawing.Color.Chocolate;
            this.btnDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnDatabase.Location = new System.Drawing.Point(22, 106);
            this.btnDatabase.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnDatabase.Name = "btnDatabase";
            this.btnDatabase.RectColor = System.Drawing.Color.Transparent;
            this.btnDatabase.Size = new System.Drawing.Size(138, 35);
            this.btnDatabase.Symbol = 361888;
            this.btnDatabase.TabIndex = 1;
            this.btnDatabase.Text = "Database";
            this.btnDatabase.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnDatabase.Click += new System.EventHandler(this.btnDatabase_Click);
            // 
            // btnConfig
            // 
            this.btnConfig.BackColor = System.Drawing.Color.Transparent;
            this.btnConfig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfig.FillColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnConfig.Location = new System.Drawing.Point(22, 60);
            this.btnConfig.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.RectColor = System.Drawing.Color.Transparent;
            this.btnConfig.Size = new System.Drawing.Size(138, 35);
            this.btnConfig.Symbol = 57397;
            this.btnConfig.TabIndex = 1;
            this.btnConfig.Text = "Config File";
            this.btnConfig.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // panel9
            // 
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.uiSymbolLabel3);
            this.panel9.Controls.Add(this.uiMarkLabel1);
            this.panel9.Controls.Add(this.btnPrintBody);
            this.panel9.Controls.Add(this.btnPrintOuterBox);
            this.panel9.Controls.Add(this.btnPrintRating);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(206, 238);
            this.panel9.TabIndex = 3;
            // 
            // uiSymbolLabel3
            // 
            this.uiSymbolLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiSymbolLabel3.Location = new System.Drawing.Point(22, 7);
            this.uiSymbolLabel3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel3.Name = "uiSymbolLabel3";
            this.uiSymbolLabel3.Size = new System.Drawing.Size(130, 29);
            this.uiSymbolLabel3.Symbol = 57603;
            this.uiSymbolLabel3.SymbolColor = System.Drawing.Color.Black;
            this.uiSymbolLabel3.SymbolOffset = new System.Drawing.Point(0, 5);
            this.uiSymbolLabel3.SymbolSize = 32;
            this.uiSymbolLabel3.TabIndex = 0;
            this.uiSymbolLabel3.Text = "Print Option";
            // 
            // uiMarkLabel1
            // 
            this.uiMarkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiMarkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiMarkLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiMarkLabel1.Location = new System.Drawing.Point(-2, 35);
            this.uiMarkLabel1.MarkPos = Sunny.UI.UIMarkLabel.UIMarkPos.Bottom;
            this.uiMarkLabel1.Name = "uiMarkLabel1";
            this.uiMarkLabel1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.uiMarkLabel1.Size = new System.Drawing.Size(206, 12);
            this.uiMarkLabel1.TabIndex = 2;
            // 
            // btnPrintBody
            // 
            this.btnPrintBody.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrintBody.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(110)))), ((int)(((byte)(55)))));
            this.btnPrintBody.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnPrintBody.Location = new System.Drawing.Point(39, 60);
            this.btnPrintBody.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnPrintBody.Name = "btnPrintBody";
            this.btnPrintBody.RectColor = System.Drawing.Color.Transparent;
            this.btnPrintBody.Size = new System.Drawing.Size(130, 35);
            this.btnPrintBody.Symbol = 61481;
            this.btnPrintBody.SymbolOffset = new System.Drawing.Point(-10, 0);
            this.btnPrintBody.TabIndex = 1;
            this.btnPrintBody.Text = "Body";
            this.btnPrintBody.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnPrintBody.Click += new System.EventHandler(this.btnPrintBody_Click);
            // 
            // btnPrintOuterBox
            // 
            this.btnPrintOuterBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrintOuterBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(80)))), ((int)(((byte)(255)))));
            this.btnPrintOuterBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnPrintOuterBox.Location = new System.Drawing.Point(39, 153);
            this.btnPrintOuterBox.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnPrintOuterBox.Name = "btnPrintOuterBox";
            this.btnPrintOuterBox.RectColor = System.Drawing.Color.Transparent;
            this.btnPrintOuterBox.Size = new System.Drawing.Size(130, 35);
            this.btnPrintOuterBox.Symbol = 61481;
            this.btnPrintOuterBox.SymbolOffset = new System.Drawing.Point(5, 0);
            this.btnPrintOuterBox.TabIndex = 1;
            this.btnPrintOuterBox.Text = "Outer box";
            this.btnPrintOuterBox.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnPrintOuterBox.Click += new System.EventHandler(this.btnPrintOuterBox_Click);
            // 
            // btnPrintRating
            // 
            this.btnPrintRating.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrintRating.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(160)))), ((int)(((byte)(25)))));
            this.btnPrintRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnPrintRating.Location = new System.Drawing.Point(39, 106);
            this.btnPrintRating.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnPrintRating.Name = "btnPrintRating";
            this.btnPrintRating.RectColor = System.Drawing.Color.Transparent;
            this.btnPrintRating.Size = new System.Drawing.Size(130, 35);
            this.btnPrintRating.Symbol = 61481;
            this.btnPrintRating.SymbolOffset = new System.Drawing.Point(-5, 0);
            this.btnPrintRating.TabIndex = 1;
            this.btnPrintRating.Text = "Rating";
            this.btnPrintRating.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnPrintRating.Click += new System.EventHandler(this.btnPrintRating_Click);
            // 
            // splitter3
            // 
            this.splitter3.BackColor = System.Drawing.Color.Black;
            this.splitter3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter3.Location = new System.Drawing.Point(0, 238);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(387, 1);
            this.splitter3.TabIndex = 5;
            this.splitter3.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.cbException);
            this.panel3.Controls.Add(this.cbNormal);
            this.panel3.Controls.Add(this.uiSymbolLabel2);
            this.panel3.Controls.Add(this.uiSymbolLabel1);
            this.panel3.Controls.Add(this.dtpTo);
            this.panel3.Controls.Add(this.dtpFrom);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1165, 44);
            this.panel3.TabIndex = 1;
            // 
            // cbException
            // 
            this.cbException.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbException.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbException.Location = new System.Drawing.Point(231, 13);
            this.cbException.MinimumSize = new System.Drawing.Size(1, 1);
            this.cbException.Name = "cbException";
            this.cbException.RadioButtonColor = System.Drawing.Color.Red;
            this.cbException.Size = new System.Drawing.Size(98, 22);
            this.cbException.TabIndex = 4;
            this.cbException.Text = "Exception";
            this.cbException.ValueChanged += new Sunny.UI.UIRadioButton.OnValueChanged(this.cbNormal_ValueChanged);
            // 
            // cbNormal
            // 
            this.cbNormal.Checked = true;
            this.cbNormal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbNormal.Location = new System.Drawing.Point(143, 13);
            this.cbNormal.MinimumSize = new System.Drawing.Size(1, 1);
            this.cbNormal.Name = "cbNormal";
            this.cbNormal.RadioButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.cbNormal.Size = new System.Drawing.Size(78, 22);
            this.cbNormal.TabIndex = 4;
            this.cbNormal.Text = "Normal";
            this.cbNormal.ValueChanged += new Sunny.UI.UIRadioButton.OnValueChanged(this.cbNormal_ValueChanged);
            // 
            // uiSymbolLabel2
            // 
            this.uiSymbolLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiSymbolLabel2.Location = new System.Drawing.Point(465, 12);
            this.uiSymbolLabel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel2.Name = "uiSymbolLabel2";
            this.uiSymbolLabel2.Size = new System.Drawing.Size(40, 23);
            this.uiSymbolLabel2.Symbol = 61609;
            this.uiSymbolLabel2.SymbolColor = System.Drawing.Color.Blue;
            this.uiSymbolLabel2.TabIndex = 3;
            // 
            // uiSymbolLabel1
            // 
            this.uiSymbolLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiSymbolLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiSymbolLabel1.Location = new System.Drawing.Point(0, 0);
            this.uiSymbolLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel1.Name = "uiSymbolLabel1";
            this.uiSymbolLabel1.Size = new System.Drawing.Size(132, 44);
            this.uiSymbolLabel1.Symbol = 61568;
            this.uiSymbolLabel1.SymbolColor = System.Drawing.Color.Red;
            this.uiSymbolLabel1.SymbolSize = 32;
            this.uiSymbolLabel1.TabIndex = 0;
            this.uiSymbolLabel1.Text = "Daily report";
            // 
            // dtpTo
            // 
            this.dtpTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(511, 12);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(119, 24);
            this.dtpTo.TabIndex = 2;
            this.dtpTo.ValueChanged += new System.EventHandler(this.dtpFrom_ValueChanged);
            // 
            // dtpFrom
            // 
            this.dtpFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(340, 12);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(119, 24);
            this.dtpFrom.TabIndex = 2;
            this.dtpFrom.ValueChanged += new System.EventHandler(this.dtpFrom_ValueChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 285);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1165, 359);
            this.panel4.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.panel5);
            this.panel7.Controls.Add(this.splitter1);
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1165, 359);
            this.panel7.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panelChart);
            this.panel5.Controls.Add(this.graphColumns);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(775, 359);
            this.panel5.TabIndex = 3;
            // 
            // panelChart
            // 
            this.panelChart.BackColor = System.Drawing.Color.White;
            this.panelChart.Controls.Add(this.process1);
            this.panelChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChart.Location = new System.Drawing.Point(0, 0);
            this.panelChart.Name = "panelChart";
            this.panelChart.Size = new System.Drawing.Size(775, 359);
            this.panelChart.TabIndex = 1;
            // 
            // process1
            // 
            this.process1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.process1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.process1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.process1.Location = new System.Drawing.Point(263, 82);
            this.process1.MinimumSize = new System.Drawing.Size(1, 1);
            this.process1.Name = "process1";
            this.process1.Size = new System.Drawing.Size(235, 169);
            this.process1.TabIndex = 5;
            // 
            // graphColumns
            // 
            this.graphColumns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.graphColumns.Location = new System.Drawing.Point(0, 0);
            this.graphColumns.Name = "graphColumns";
            this.graphColumns.Size = new System.Drawing.Size(775, 359);
            this.graphColumns.TabIndex = 0;
            this.graphColumns.Text = "cartesianChart1";
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter1.Location = new System.Drawing.Point(775, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 359);
            this.splitter1.TabIndex = 5;
            this.splitter1.TabStop = false;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.panelCirle);
            this.panel8.Controls.Add(this.graphCircle);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel8.Location = new System.Drawing.Point(778, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(387, 359);
            this.panel8.TabIndex = 4;
            // 
            // panelCirle
            // 
            this.panelCirle.BackColor = System.Drawing.Color.White;
            this.panelCirle.Controls.Add(this.process2);
            this.panelCirle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCirle.Location = new System.Drawing.Point(0, 0);
            this.panelCirle.Name = "panelCirle";
            this.panelCirle.Size = new System.Drawing.Size(387, 359);
            this.panelCirle.TabIndex = 3;
            // 
            // process2
            // 
            this.process2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.process2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.process2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.process2.Location = new System.Drawing.Point(123, 82);
            this.process2.MinimumSize = new System.Drawing.Size(1, 1);
            this.process2.Name = "process2";
            this.process2.Size = new System.Drawing.Size(179, 169);
            this.process2.TabIndex = 6;
            // 
            // graphCircle
            // 
            this.graphCircle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.graphCircle.Location = new System.Drawing.Point(0, 0);
            this.graphCircle.Name = "graphCircle";
            this.graphCircle.ScrollGrace = 0D;
            this.graphCircle.ScrollMaxX = 0D;
            this.graphCircle.ScrollMaxY = 0D;
            this.graphCircle.ScrollMaxY2 = 0D;
            this.graphCircle.ScrollMinX = 0D;
            this.graphCircle.ScrollMinY = 0D;
            this.graphCircle.ScrollMinY2 = 0D;
            this.graphCircle.Size = new System.Drawing.Size(387, 359);
            this.graphCircle.TabIndex = 2;
            this.graphCircle.UseExtendedPrintDialog = true;
            // 
            // btnAccount
            // 
            this.btnAccount.BackColor = System.Drawing.Color.Transparent;
            this.btnAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccount.FillColor = System.Drawing.Color.Crimson;
            this.btnAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAccount.Location = new System.Drawing.Point(22, 153);
            this.btnAccount.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.RectColor = System.Drawing.Color.Transparent;
            this.btnAccount.Size = new System.Drawing.Size(138, 35);
            this.btnAccount.Symbol = 559603;
            this.btnAccount.TabIndex = 1;
            this.btnAccount.Text = "Account";
            this.btnAccount.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 709);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.uiPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.uiPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panelChart.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panelCirle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIPanel uiPanel1;
        private System.Windows.Forms.Panel panel1;
        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
        private System.Windows.Forms.Panel panel2;
        private Sunny.UI.UISymbolLabel uiSymbolLabel2;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private Sunny.UI.UISymbolLabel uiSymbolLabel3;
        private Sunny.UI.UISymbolButton btnPrintOuterBox;
        private Sunny.UI.UISymbolButton btnPrintRating;
        private Sunny.UI.UISymbolButton btnPrintBody;
        private Sunny.UI.UIMarkLabel uiMarkLabel1;
        private Sunny.UI.UISymbolButton btnConfig;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private Sunny.UI.UISymbolLabel lbUser;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel7;
        private ZedGraph.ZedGraphControl graphCircle;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panelChart;
        private Sunny.UI.UIProgressIndicator process1;
        private System.Windows.Forms.Panel panelCirle;
        private Sunny.UI.UIProgressIndicator process2;
        private System.Windows.Forms.Panel panel10;
        private Sunny.UI.UISymbolLabel uiSymbolLabel4;
        private Sunny.UI.UIMarkLabel uiMarkLabel2;
        private System.Windows.Forms.Panel panel9;
        private Sunny.UI.UISymbolButton btnDatabase;
        private Sunny.UI.UIRadioButton cbException;
        private Sunny.UI.UIRadioButton cbNormal;
        private LiveCharts.WinForms.CartesianChart graphColumns;
        private System.Windows.Forms.Splitter splitter3;
        private Sunny.UI.UISymbolButton btnAccount;
    }
}