namespace PrintLabel
{
    partial class FormSelectPrintType
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
            this.btnBody = new Sunny.UI.UISymbolButton();
            this.btnRating = new Sunny.UI.UISymbolButton();
            this.btnOuterBox = new Sunny.UI.UISymbolButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Coral;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHỌN KIỂU IN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBody
            // 
            this.btnBody.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBody.FillColor = System.Drawing.Color.Brown;
            this.btnBody.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnBody.Location = new System.Drawing.Point(53, 67);
            this.btnBody.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnBody.Name = "btnBody";
            this.btnBody.RectColor = System.Drawing.Color.Transparent;
            this.btnBody.Size = new System.Drawing.Size(149, 35);
            this.btnBody.Symbol = 61482;
            this.btnBody.TabIndex = 1;
            this.btnBody.Text = "Body";
            this.btnBody.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnBody.Click += new System.EventHandler(this.btnBody_Click);
            // 
            // btnRating
            // 
            this.btnRating.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRating.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(10)))), ((int)(((byte)(255)))));
            this.btnRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnRating.Location = new System.Drawing.Point(53, 125);
            this.btnRating.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnRating.Name = "btnRating";
            this.btnRating.RectColor = System.Drawing.Color.Transparent;
            this.btnRating.Size = new System.Drawing.Size(149, 35);
            this.btnRating.Symbol = 61482;
            this.btnRating.TabIndex = 1;
            this.btnRating.Text = "Rating";
            this.btnRating.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            // 
            // btnOuterBox
            // 
            this.btnOuterBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOuterBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(10)))), ((int)(((byte)(255)))));
            this.btnOuterBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnOuterBox.Location = new System.Drawing.Point(53, 186);
            this.btnOuterBox.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnOuterBox.Name = "btnOuterBox";
            this.btnOuterBox.RectColor = System.Drawing.Color.Transparent;
            this.btnOuterBox.Size = new System.Drawing.Size(149, 35);
            this.btnOuterBox.Symbol = 61481;
            this.btnOuterBox.TabIndex = 1;
            this.btnOuterBox.Text = "Outer Box";
            this.btnOuterBox.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            // 
            // FormSelectPrintType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 249);
            this.Controls.Add(this.btnOuterBox);
            this.Controls.Add(this.btnRating);
            this.Controls.Add(this.btnBody);
            this.Controls.Add(this.label1);
            this.Name = "FormSelectPrintType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSelectPrintType";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Sunny.UI.UISymbolButton btnBody;
        private Sunny.UI.UISymbolButton btnRating;
        private Sunny.UI.UISymbolButton btnOuterBox;
    }
}