namespace Car_Renting.UserControls
{
    partial class CarsScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarsScreen));
            this.panel2 = new System.Windows.Forms.Panel();
            this.gvCars = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btSua = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.btTim = new System.Windows.Forms.Button();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ImageCar = new System.Windows.Forms.PictureBox();
            this.btnRentFromCars = new System.Windows.Forms.Button();
            this.txtPricePerDay = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.txtNameCar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvCars)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageCar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(78)))));
            this.panel2.Controls.Add(this.gvCars);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(944, 394);
            this.panel2.TabIndex = 8;
            // 
            // gvCars
            // 
            this.gvCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvCars.Location = new System.Drawing.Point(6, 75);
            this.gvCars.Name = "gvCars";
            this.gvCars.RowHeadersWidth = 51;
            this.gvCars.Size = new System.Drawing.Size(619, 316);
            this.gvCars.TabIndex = 4;
            this.gvCars.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvCars_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.btSua);
            this.panel1.Controls.Add(this.btThem);
            this.panel1.Controls.Add(this.btTim);
            this.panel1.Controls.Add(this.txtTim);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(6, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(619, 66);
            this.panel1.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(89, 37);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(102, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(532, 14);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(71, 35);
            this.btSua.TabIndex = 3;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(430, 14);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(69, 35);
            this.btThem.TabIndex = 3;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            // 
            // btTim
            // 
            this.btTim.Location = new System.Drawing.Point(209, 11);
            this.btTim.Name = "btTim";
            this.btTim.Size = new System.Drawing.Size(60, 20);
            this.btTim.TabIndex = 3;
            this.btTim.Text = "Tìm";
            this.btTim.UseVisualStyleBackColor = true;
            this.btTim.Click += new System.EventHandler(this.btTim_Click);
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(70, 11);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(121, 20);
            this.txtTim.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tim Kiem";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Loại";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(78)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.ImageCar);
            this.panel3.Controls.Add(this.btnRentFromCars);
            this.panel3.Controls.Add(this.txtPricePerDay);
            this.panel3.Controls.Add(this.txtDescription);
            this.panel3.Controls.Add(this.txtCategory);
            this.panel3.Controls.Add(this.txtNameCar);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtBrand);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(634, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(616, 388);
            this.panel3.TabIndex = 9;
            // 
            // ImageCar
            // 
            this.ImageCar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ImageCar.BackgroundImage")));
            this.ImageCar.Location = new System.Drawing.Point(47, 11);
            this.ImageCar.Margin = new System.Windows.Forms.Padding(2);
            this.ImageCar.Name = "ImageCar";
            this.ImageCar.Size = new System.Drawing.Size(221, 129);
            this.ImageCar.TabIndex = 7;
            this.ImageCar.TabStop = false;
            // 
            // btnRentFromCars
            // 
            this.btnRentFromCars.Location = new System.Drawing.Point(212, 342);
            this.btnRentFromCars.Name = "btnRentFromCars";
            this.btnRentFromCars.Size = new System.Drawing.Size(80, 22);
            this.btnRentFromCars.TabIndex = 6;
            this.btnRentFromCars.Text = "Thuê";
            this.btnRentFromCars.UseVisualStyleBackColor = true;
            this.btnRentFromCars.Click += new System.EventHandler(this.btnRentFromCars_Click);
            // 
            // txtPricePerDay
            // 
            this.txtPricePerDay.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtPricePerDay.Location = new System.Drawing.Point(162, 238);
            this.txtPricePerDay.Name = "txtPricePerDay";
            this.txtPricePerDay.Size = new System.Drawing.Size(130, 20);
            this.txtPricePerDay.TabIndex = 5;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(14, 285);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(278, 51);
            this.txtDescription.TabIndex = 5;
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(14, 240);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(130, 20);
            this.txtCategory.TabIndex = 5;
            // 
            // txtNameCar
            // 
            this.txtNameCar.Location = new System.Drawing.Point(11, 177);
            this.txtNameCar.Name = "txtNameCar";
            this.txtNameCar.Size = new System.Drawing.Size(130, 20);
            this.txtNameCar.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(159, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Brand";
            // 
            // txtBrand
            // 
            this.txtBrand.Location = new System.Drawing.Point(162, 177);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(130, 20);
            this.txtBrand.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên Xe";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(162, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Giá / Ngày";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Miêu tả";
            // 
            // CarsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "CarsScreen";
            this.Size = new System.Drawing.Size(950, 400);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvCars)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageCar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gvCars;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btTim;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtPricePerDay;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.TextBox txtNameCar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRentFromCars;
        private System.Windows.Forms.PictureBox ImageCar;
    }
}
