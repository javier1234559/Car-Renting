namespace Car_Renting
{
    partial class fRenting
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnSearch = new FontAwesome.Sharp.IconButton();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnNavRent = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnFilter = new FontAwesome.Sharp.IconButton();
            this.btnSearchf = new FontAwesome.Sharp.IconButton();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.btSua = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.gvRentList = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbNameCar = new System.Windows.Forms.Label();
            this.lbCategory = new System.Windows.Forms.Label();
            this.lbBrand = new System.Windows.Forms.Label();
            this.lbNumbePlate = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnNavCarReturn = new System.Windows.Forms.Button();
            this.ImageCar = new System.Windows.Forms.PictureBox();
            this.btnCancelRent = new System.Windows.Forms.Button();
            this.lbTimeRemain = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.btnDetailContact = new System.Windows.Forms.Button();
            this.lbael = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvRentList)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageCar)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(11, 39);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(89, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.btnFilter);
            this.panel1.Controls.Add(this.btnSearchf);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.btSua);
            this.panel1.Controls.Add(this.btThem);
            this.panel1.Controls.Add(this.txtTim);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(623, 70);
            this.panel1.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btnSearch);
            this.panel4.Controls.Add(this.btnRefresh);
            this.panel4.Controls.Add(this.btnNavRent);
            this.panel4.Controls.Add(this.txtSearch);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(621, 70);
            this.panel4.TabIndex = 6;
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSearch.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnSearch.IconColor = System.Drawing.Color.Gainsboro;
            this.btnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearch.IconSize = 20;
            this.btnSearch.Location = new System.Drawing.Point(153, 22);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(20, 20);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(78)))));
            this.btnRefresh.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnRefresh.Location = new System.Drawing.Point(429, 19);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(69, 35);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnNavRent
            // 
            this.btnNavRent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(78)))));
            this.btnNavRent.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnNavRent.Location = new System.Drawing.Point(515, 19);
            this.btnNavRent.Name = "btnNavRent";
            this.btnNavRent.Size = new System.Drawing.Size(69, 35);
            this.btnNavRent.TabIndex = 3;
            this.btnNavRent.Text = "Add Rent";
            this.btnNavRent.UseVisualStyleBackColor = false;
            this.btnNavRent.Click += new System.EventHandler(this.btnNavRent_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(10, 22);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(121, 20);
            this.txtSearch.TabIndex = 1;
            // 
            // btnFilter
            // 
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnFilter.IconChar = FontAwesome.Sharp.IconChar.Filter;
            this.btnFilter.IconColor = System.Drawing.Color.Gainsboro;
            this.btnFilter.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFilter.IconSize = 20;
            this.btnFilter.Location = new System.Drawing.Point(225, 39);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(20, 20);
            this.btnFilter.TabIndex = 5;
            this.btnFilter.UseVisualStyleBackColor = true;
            // 
            // btnSearchf
            // 
            this.btnSearchf.BackColor = System.Drawing.Color.White;
            this.btnSearchf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchf.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSearchf.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnSearchf.IconColor = System.Drawing.Color.Gainsboro;
            this.btnSearchf.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearchf.IconSize = 20;
            this.btnSearchf.Location = new System.Drawing.Point(52, 10);
            this.btnSearchf.Name = "btnSearchf";
            this.btnSearchf.Size = new System.Drawing.Size(640, 105);
            this.btnSearchf.TabIndex = 5;
            this.btnSearchf.UseVisualStyleBackColor = false;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(116, 39);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(89, 21);
            this.comboBox2.TabIndex = 4;
            // 
            // btSua
            // 
            this.btSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(78)))));
            this.btSua.ForeColor = System.Drawing.Color.Gainsboro;
            this.btSua.Location = new System.Drawing.Point(532, 14);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(71, 35);
            this.btSua.TabIndex = 3;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = false;
            // 
            // btThem
            // 
            this.btThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(78)))));
            this.btThem.ForeColor = System.Drawing.Color.Gainsboro;
            this.btThem.Location = new System.Drawing.Point(430, 14);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(69, 35);
            this.btThem.TabIndex = 3;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = false;
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(11, 10);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(121, 20);
            this.txtTim.TabIndex = 1;
            // 
            // gvRentList
            // 
            this.gvRentList.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(125)))), ((int)(((byte)(1)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvRentList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gvRentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvRentList.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gvRentList.Location = new System.Drawing.Point(-3, 67);
            this.gvRentList.Name = "gvRentList";
            this.gvRentList.RowHeadersWidth = 51;
            this.gvRentList.Size = new System.Drawing.Size(623, 460);
            this.gvRentList.TabIndex = 4;
            this.gvRentList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvRentList_CellClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.gvRentList);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(623, 460);
            this.panel2.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lbNameCar);
            this.panel3.Controls.Add(this.lbCategory);
            this.panel3.Controls.Add(this.lbBrand);
            this.panel3.Controls.Add(this.lbNumbePlate);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.btnNavCarReturn);
            this.panel3.Controls.Add(this.ImageCar);
            this.panel3.Controls.Add(this.btnCancelRent);
            this.panel3.Controls.Add(this.lbTimeRemain);
            this.panel3.Controls.Add(this.lbStatus);
            this.panel3.Controls.Add(this.btnDetailContact);
            this.panel3.Controls.Add(this.lbael);
            this.panel3.Controls.Add(this.label20);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(629, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(314, 460);
            this.panel3.TabIndex = 13;
            // 
            // lbNameCar
            // 
            this.lbNameCar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbNameCar.AutoSize = true;
            this.lbNameCar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(78)))));
            this.lbNameCar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbNameCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameCar.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbNameCar.Location = new System.Drawing.Point(26, 307);
            this.lbNameCar.Name = "lbNameCar";
            this.lbNameCar.Size = new System.Drawing.Size(54, 20);
            this.lbNameCar.TabIndex = 69;
            this.lbNameCar.Text = "Camry";
            // 
            // lbCategory
            // 
            this.lbCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCategory.AutoSize = true;
            this.lbCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(78)))));
            this.lbCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategory.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbCategory.Location = new System.Drawing.Point(26, 374);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(48, 20);
            this.lbCategory.TabIndex = 70;
            this.lbCategory.Text = "Truck";
            // 
            // lbBrand
            // 
            this.lbBrand.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbBrand.AutoSize = true;
            this.lbBrand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(78)))));
            this.lbBrand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBrand.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbBrand.Location = new System.Drawing.Point(172, 307);
            this.lbBrand.Name = "lbBrand";
            this.lbBrand.Size = new System.Drawing.Size(44, 20);
            this.lbBrand.TabIndex = 71;
            this.lbBrand.Text = "John";
            // 
            // lbNumbePlate
            // 
            this.lbNumbePlate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbNumbePlate.AutoSize = true;
            this.lbNumbePlate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(78)))));
            this.lbNumbePlate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbNumbePlate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumbePlate.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbNumbePlate.Location = new System.Drawing.Point(172, 374);
            this.lbNumbePlate.Name = "lbNumbePlate";
            this.lbNumbePlate.Size = new System.Drawing.Size(86, 20);
            this.lbNumbePlate.TabIndex = 72;
            this.lbNumbePlate.Text = "GD70-E00";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(165, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 65;
            this.label4.Text = "Client Name";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(17, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 66;
            this.label3.Text = "Name Car";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(165, 348);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 67;
            this.label6.Text = "Number Plate";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Gainsboro;
            this.label7.Location = new System.Drawing.Point(14, 348);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 68;
            this.label7.Text = "Category";
            // 
            // btnNavCarReturn
            // 
            this.btnNavCarReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(78)))));
            this.btnNavCarReturn.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnNavCarReturn.Location = new System.Drawing.Point(172, 412);
            this.btnNavCarReturn.Name = "btnNavCarReturn";
            this.btnNavCarReturn.Size = new System.Drawing.Size(124, 35);
            this.btnNavCarReturn.TabIndex = 63;
            this.btnNavCarReturn.Text = "Come To Car Return";
            this.btnNavCarReturn.UseVisualStyleBackColor = false;
            this.btnNavCarReturn.Click += new System.EventHandler(this.btnNavCarReturn_Click);
            // 
            // ImageCar
            // 
            this.ImageCar.Location = new System.Drawing.Point(54, 181);
            this.ImageCar.Margin = new System.Windows.Forms.Padding(2);
            this.ImageCar.Name = "ImageCar";
            this.ImageCar.Size = new System.Drawing.Size(183, 82);
            this.ImageCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImageCar.TabIndex = 62;
            this.ImageCar.TabStop = false;
            // 
            // btnCancelRent
            // 
            this.btnCancelRent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(78)))));
            this.btnCancelRent.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCancelRent.Location = new System.Drawing.Point(20, 412);
            this.btnCancelRent.Name = "btnCancelRent";
            this.btnCancelRent.Size = new System.Drawing.Size(71, 35);
            this.btnCancelRent.TabIndex = 51;
            this.btnCancelRent.Text = "Cancel";
            this.btnCancelRent.UseVisualStyleBackColor = false;
            this.btnCancelRent.Click += new System.EventHandler(this.btnCancelRent_Click);
            // 
            // lbTimeRemain
            // 
            this.lbTimeRemain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTimeRemain.AutoSize = true;
            this.lbTimeRemain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(78)))));
            this.lbTimeRemain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbTimeRemain.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimeRemain.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbTimeRemain.Location = new System.Drawing.Point(167, 79);
            this.lbTimeRemain.Name = "lbTimeRemain";
            this.lbTimeRemain.Size = new System.Drawing.Size(96, 25);
            this.lbTimeRemain.TabIndex = 50;
            this.lbTimeRemain.Text = "00:00:00";
            // 
            // lbStatus
            // 
            this.lbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbStatus.AutoSize = true;
            this.lbStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(78)))));
            this.lbStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatus.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbStatus.Location = new System.Drawing.Point(162, 26);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(67, 20);
            this.lbStatus.TabIndex = 50;
            this.lbStatus.Text = "Pedding";
            // 
            // btnDetailContact
            // 
            this.btnDetailContact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(78)))));
            this.btnDetailContact.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDetailContact.Location = new System.Drawing.Point(166, 131);
            this.btnDetailContact.Name = "btnDetailContact";
            this.btnDetailContact.Size = new System.Drawing.Size(71, 35);
            this.btnDetailContact.TabIndex = 49;
            this.btnDetailContact.Text = "More";
            this.btnDetailContact.UseVisualStyleBackColor = false;
            this.btnDetailContact.Click += new System.EventHandler(this.btnDetailContact_Click);
            // 
            // lbael
            // 
            this.lbael.AutoSize = true;
            this.lbael.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbael.Location = new System.Drawing.Point(17, 142);
            this.lbael.Name = "lbael";
            this.lbael.Size = new System.Drawing.Size(74, 13);
            this.lbael.TabIndex = 43;
            this.lbael.Text = "Detail Contact";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label20.Location = new System.Drawing.Point(17, 26);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(37, 13);
            this.label20.TabIndex = 39;
            this.label20.Text = "Status";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label17.Location = new System.Drawing.Point(17, 84);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(74, 13);
            this.label17.TabIndex = 40;
            this.label17.Text = "Time Remains";
            // 
            // fRenting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(78)))));
            this.ClientSize = new System.Drawing.Size(943, 460);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.ForeColor = System.Drawing.Color.Orange;
            this.Name = "fRenting";
            this.Text = "fRenting2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvRentList)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageCar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnSearchf;
        private System.Windows.Forms.ComboBox comboBox1;
        private FontAwesome.Sharp.IconButton btnSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnNavRent;
        private System.Windows.Forms.TextBox txtSearch;
        private FontAwesome.Sharp.IconButton btnFilter;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.DataGridView gvRentList;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnDetailContact;
        private System.Windows.Forms.Label lbael;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnCancelRent;
        private System.Windows.Forms.Label lbTimeRemain;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Button btnNavCarReturn;
        private System.Windows.Forms.PictureBox ImageCar;
        private System.Windows.Forms.Label lbNameCar;
        private System.Windows.Forms.Label lbCategory;
        private System.Windows.Forms.Label lbBrand;
        private System.Windows.Forms.Label lbNumbePlate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnRefresh;
    }
}