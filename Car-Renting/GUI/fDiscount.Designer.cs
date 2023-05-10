namespace Car_Renting
{
    partial class fDiscount
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.LBDiscountCode = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddDiscount = new System.Windows.Forms.Button();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtDiscountPercent = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCreatedBy = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gvDiscount = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDiscount)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.LBDiscountCode);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.btnAddDiscount);
            this.panel3.Controls.Add(this.dtpEndDate);
            this.panel3.Controls.Add(this.dtpStartDate);
            this.panel3.Controls.Add(this.txtQuantity);
            this.panel3.Controls.Add(this.txtDiscountPercent);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.txtCreatedBy);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(629, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(314, 460);
            this.panel3.TabIndex = 17;
            // 
            // LBDiscountCode
            // 
            this.LBDiscountCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LBDiscountCode.AutoSize = true;
            this.LBDiscountCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBDiscountCode.ForeColor = System.Drawing.Color.Gainsboro;
            this.LBDiscountCode.Location = new System.Drawing.Point(53, 402);
            this.LBDiscountCode.Name = "LBDiscountCode";
            this.LBDiscountCode.Size = new System.Drawing.Size(64, 25);
            this.LBDiscountCode.TabIndex = 65;
            this.LBDiscountCode.Text = "FFFF";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(57, 359);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 66;
            this.label3.Text = "Code";
            // 
            // btnAddDiscount
            // 
            this.btnAddDiscount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(78)))));
            this.btnAddDiscount.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAddDiscount.Location = new System.Drawing.Point(179, 402);
            this.btnAddDiscount.Name = "btnAddDiscount";
            this.btnAddDiscount.Size = new System.Drawing.Size(88, 35);
            this.btnAddDiscount.TabIndex = 30;
            this.btnAddDiscount.Text = "Add Discount";
            this.btnAddDiscount.UseVisualStyleBackColor = false;
            this.btnAddDiscount.Click += new System.EventHandler(this.btnAddDiscount_Click);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(147, 192);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(120, 20);
            this.dtpEndDate.TabIndex = 29;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(147, 134);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(120, 20);
            this.dtpStartDate.TabIndex = 29;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(147, 246);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(120, 20);
            this.txtQuantity.TabIndex = 24;
            // 
            // txtDiscountPercent
            // 
            this.txtDiscountPercent.Location = new System.Drawing.Point(147, 307);
            this.txtDiscountPercent.Name = "txtDiscountPercent";
            this.txtDiscountPercent.Size = new System.Drawing.Size(120, 20);
            this.txtDiscountPercent.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Gainsboro;
            this.label8.Location = new System.Drawing.Point(57, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "DateEnd";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Gainsboro;
            this.label9.Location = new System.Drawing.Point(57, 310);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Value ( Decimal )  ";
            // 
            // txtCreatedBy
            // 
            this.txtCreatedBy.Location = new System.Drawing.Point(147, 79);
            this.txtCreatedBy.Name = "txtCreatedBy";
            this.txtCreatedBy.Size = new System.Drawing.Size(120, 20);
            this.txtCreatedBy.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Gainsboro;
            this.label7.Location = new System.Drawing.Point(55, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "DateStart";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(57, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Quantity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(55, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Created By";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(122, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Discount Information";
            // 
            // gvDiscount
            // 
            this.gvDiscount.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.gvDiscount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDiscount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvDiscount.Location = new System.Drawing.Point(0, 0);
            this.gvDiscount.Name = "gvDiscount";
            this.gvDiscount.RowHeadersWidth = 51;
            this.gvDiscount.Size = new System.Drawing.Size(623, 460);
            this.gvDiscount.TabIndex = 4;
            this.gvDiscount.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvDiscount_CellClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gvDiscount);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(623, 460);
            this.panel2.TabIndex = 18;
            // 
            // fDiscount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(78)))));
            this.ClientSize = new System.Drawing.Size(943, 460);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "fDiscount";
            this.Text = "fDiscount";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDiscount)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtDiscountPercent;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCreatedBy;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Button btnAddDiscount;
        private System.Windows.Forms.Label LBDiscountCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView gvDiscount;
        private System.Windows.Forms.Panel panel2;
    }
}