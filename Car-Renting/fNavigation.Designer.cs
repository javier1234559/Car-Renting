namespace Car_Renting
{
    partial class fNavigation
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_RentsNav = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_SettingNav = new System.Windows.Forms.Button();
            this.btn_UsersNav = new System.Windows.Forms.Button();
            this.tbn_BillsNav = new System.Windows.Forms.Button();
            this.btn_ClientsNav = new System.Windows.Forms.Button();
            this.btn_CarsNav = new System.Windows.Forms.Button();
            this.plMainScreen = new System.Windows.Forms.Panel();
            this.rentsScreen1 = new Car_Renting.UserControls.RentsScreen();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.plMainScreen.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_RentsNav);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(155, 479);
            this.panel1.TabIndex = 0;
            // 
            // btn_RentsNav
            // 
            this.btn_RentsNav.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_RentsNav.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RentsNav.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_RentsNav.Location = new System.Drawing.Point(0, 112);
            this.btn_RentsNav.Name = "btn_RentsNav";
            this.btn_RentsNav.Size = new System.Drawing.Size(155, 39);
            this.btn_RentsNav.TabIndex = 0;
            this.btn_RentsNav.Text = "Rents";
            this.btn_RentsNav.UseVisualStyleBackColor = true;
            this.btn_RentsNav.Click += new System.EventHandler(this.btn_RentsNav_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(155, 112);
            this.panel3.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btn_SettingNav, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btn_UsersNav, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tbn_BillsNav, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_ClientsNav, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn_CarsNav, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 151);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.9992F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.9992F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.9992F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.9992F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0032F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(155, 209);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btn_SettingNav
            // 
            this.btn_SettingNav.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_SettingNav.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SettingNav.Location = new System.Drawing.Point(4, 168);
            this.btn_SettingNav.Name = "btn_SettingNav";
            this.btn_SettingNav.Size = new System.Drawing.Size(147, 37);
            this.btn_SettingNav.TabIndex = 5;
            this.btn_SettingNav.Text = "Setting";
            this.btn_SettingNav.UseVisualStyleBackColor = true;
            this.btn_SettingNav.Click += new System.EventHandler(this.btn_SettingNav_Click);
            // 
            // btn_UsersNav
            // 
            this.btn_UsersNav.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_UsersNav.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UsersNav.Location = new System.Drawing.Point(4, 127);
            this.btn_UsersNav.Name = "btn_UsersNav";
            this.btn_UsersNav.Size = new System.Drawing.Size(147, 34);
            this.btn_UsersNav.TabIndex = 4;
            this.btn_UsersNav.Text = "Users";
            this.btn_UsersNav.UseVisualStyleBackColor = true;
            this.btn_UsersNav.Click += new System.EventHandler(this.btn_UsersNav_Click);
            // 
            // tbn_BillsNav
            // 
            this.tbn_BillsNav.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbn_BillsNav.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbn_BillsNav.Location = new System.Drawing.Point(4, 45);
            this.tbn_BillsNav.Name = "tbn_BillsNav";
            this.tbn_BillsNav.Size = new System.Drawing.Size(147, 34);
            this.tbn_BillsNav.TabIndex = 2;
            this.tbn_BillsNav.Text = "Bills";
            this.tbn_BillsNav.UseVisualStyleBackColor = true;
            this.tbn_BillsNav.Click += new System.EventHandler(this.tbn_BillsNav_Click);
            // 
            // btn_ClientsNav
            // 
            this.btn_ClientsNav.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_ClientsNav.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ClientsNav.Location = new System.Drawing.Point(4, 86);
            this.btn_ClientsNav.Name = "btn_ClientsNav";
            this.btn_ClientsNav.Size = new System.Drawing.Size(147, 34);
            this.btn_ClientsNav.TabIndex = 3;
            this.btn_ClientsNav.Text = "Clients";
            this.btn_ClientsNav.UseVisualStyleBackColor = true;
            this.btn_ClientsNav.Click += new System.EventHandler(this.btn_ClientsNav_Click);
            // 
            // btn_CarsNav
            // 
            this.btn_CarsNav.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_CarsNav.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CarsNav.Location = new System.Drawing.Point(4, 4);
            this.btn_CarsNav.Name = "btn_CarsNav";
            this.btn_CarsNav.Size = new System.Drawing.Size(147, 34);
            this.btn_CarsNav.TabIndex = 1;
            this.btn_CarsNav.Text = "Cars";
            this.btn_CarsNav.UseVisualStyleBackColor = true;
            this.btn_CarsNav.Click += new System.EventHandler(this.btn_CarsNav_Click);
            // 
            // plMainScreen
            // 
            this.plMainScreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plMainScreen.Controls.Add(this.rentsScreen1);
            this.plMainScreen.Location = new System.Drawing.Point(155, 67);
            this.plMainScreen.Name = "plMainScreen";
            this.plMainScreen.Size = new System.Drawing.Size(951, 412);
            this.plMainScreen.TabIndex = 1;
            // 
            // rentsScreen1
            // 
            this.rentsScreen1.Location = new System.Drawing.Point(-1, 62);
            this.rentsScreen1.Name = "rentsScreen1";
            this.rentsScreen1.Size = new System.Drawing.Size(0, 0);
            this.rentsScreen1.TabIndex = 0;
            // 
            // fNavigation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 479);
            this.Controls.Add(this.plMainScreen);
            this.Controls.Add(this.panel1);
            this.Name = "fNavigation";
            this.Text = "Car Renting ";
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.plMainScreen.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_RentsNav;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_SettingNav;
        private System.Windows.Forms.Button btn_UsersNav;
        private System.Windows.Forms.Button tbn_BillsNav;
        private System.Windows.Forms.Button btn_ClientsNav;
        private System.Windows.Forms.Button btn_CarsNav;
        private System.Windows.Forms.Panel plMainScreen;
        private UserControls.RentsScreen rentsScreen1;
    }
}