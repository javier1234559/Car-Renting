namespace Car_Renting
{
    partial class fBillDashBoard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.chartColumn = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartDoughnut = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.btnQuarterLy = new System.Windows.Forms.Label();
            this.btnByYear = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnByMonth = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnByDay = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnStatisticByRating = new System.Windows.Forms.Button();
            this.btnStatíticByBestsellers = new System.Windows.Forms.Button();
            this.btnStatisticDamage = new System.Windows.Forms.Button();
            this.btnSearch = new FontAwesome.Sharp.IconButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.gvBill = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartColumn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDoughnut)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.btnByYear.SuspendLayout();
            this.btnByMonth.SuspendLayout();
            this.btnByDay.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvBill)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 414F));
            this.tableLayoutPanel2.Controls.Add(this.chartColumn, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.chartDoughnut, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(10, 93);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 251F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1109, 252);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // chartColumn
            // 
            this.chartColumn.BorderlineColor = System.Drawing.Color.DarkOrange;
            chartArea1.AxisX.IsMarginVisible = false;
            chartArea1.AxisX.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisX.LineWidth = 0;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisY.LineColor = System.Drawing.Color.Linen;
            chartArea1.AxisY.LineWidth = 0;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.MediumPurple;
            chartArea1.Name = "ChartArea1";
            this.chartColumn.ChartAreas.Add(chartArea1);
            this.chartColumn.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartColumn.Legends.Add(legend1);
            this.chartColumn.Location = new System.Drawing.Point(1, 1);
            this.chartColumn.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.chartColumn.Name = "chartColumn";
            this.chartColumn.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(137)))), ((int)(((byte)(255)))));
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.MarkerSize = 10;
            series1.Name = "ColumnSeries";
            series1.YValuesPerPoint = 2;
            this.chartColumn.Series.Add(series1);
            this.chartColumn.Size = new System.Drawing.Size(682, 240);
            this.chartColumn.TabIndex = 0;
            this.chartColumn.Text = "chart1";
            // 
            // chartDoughnut
            // 
            chartArea2.Name = "ChartArea1";
            this.chartDoughnut.ChartAreas.Add(chartArea2);
            this.chartDoughnut.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.TopRight;
            legend2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            legend2.DockedToChartArea = "ChartArea1";
            legend2.IsDockedInsideChartArea = false;
            legend2.ItemColumnSpacing = 5;
            legend2.LegendItemOrder = System.Windows.Forms.DataVisualization.Charting.LegendItemOrder.SameAsSeriesOrder;
            legend2.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Column;
            legend2.MaximumAutoSize = 1F;
            legend2.Name = "Legend1";
            legend2.TableStyle = System.Windows.Forms.DataVisualization.Charting.LegendTableStyle.Tall;
            legend2.TitleAlignment = System.Drawing.StringAlignment.Near;
            this.chartDoughnut.Legends.Add(legend2);
            this.chartDoughnut.Location = new System.Drawing.Point(694, 1);
            this.chartDoughnut.Margin = new System.Windows.Forms.Padding(0);
            this.chartDoughnut.Name = "chartDoughnut";
            this.chartDoughnut.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chartDoughnut.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(137)))), ((int)(((byte)(255))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(127))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(153)))), ((int)(((byte)(254))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(220)))), ((int)(((byte)(205))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(137)))), ((int)(((byte)(10))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(169)))), ((int)(((byte)(9))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(233)))), ((int)(((byte)(8))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(163)))), ((int)(((byte)(5)))))};
            series2.BorderColor = System.Drawing.Color.White;
            series2.BorderWidth = 5;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.EmptyPointStyle.IsVisibleInLegend = false;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "DoughnutSeries";
            series2.SmartLabelStyle.Enabled = false;
            this.chartDoughnut.Series.Add(series2);
            this.chartDoughnut.Size = new System.Drawing.Size(414, 250);
            this.chartDoughnut.TabIndex = 1;
            this.chartDoughnut.Text = "chart2";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.panel6, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnByYear, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnByMonth, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnByDay, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1109, 83);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel6.Controls.Add(this.label16);
            this.panel6.Controls.Add(this.btnQuarterLy);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(831, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(268, 73);
            this.panel6.TabIndex = 3;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(2, 47);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(67, 15);
            this.label16.TabIndex = 0;
            this.label16.Text = "Completed";
            // 
            // btnQuarterLy
            // 
            this.btnQuarterLy.AutoSize = true;
            this.btnQuarterLy.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuarterLy.ForeColor = System.Drawing.Color.White;
            this.btnQuarterLy.Location = new System.Drawing.Point(3, 8);
            this.btnQuarterLy.Name = "btnQuarterLy";
            this.btnQuarterLy.Size = new System.Drawing.Size(89, 22);
            this.btnQuarterLy.TabIndex = 0;
            this.btnQuarterLy.Text = "Quarterly ";
            this.btnQuarterLy.Click += new System.EventHandler(this.btnQuarterLy_Click);
            // 
            // btnByYear
            // 
            this.btnByYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(127)))));
            this.btnByYear.Controls.Add(this.label12);
            this.btnByYear.Controls.Add(this.label13);
            this.btnByYear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnByYear.Location = new System.Drawing.Point(554, 0);
            this.btnByYear.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.btnByYear.Name = "btnByYear";
            this.btnByYear.Size = new System.Drawing.Size(267, 73);
            this.btnByYear.TabIndex = 2;
            this.btnByYear.Click += new System.EventHandler(this.btnByYear_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(2, 47);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 15);
            this.label12.TabIndex = 0;
            this.label12.Text = "Completed";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(3, 8);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 22);
            this.label13.TabIndex = 0;
            this.label13.Text = "Year";
            // 
            // btnByMonth
            // 
            this.btnByMonth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnByMonth.Controls.Add(this.label8);
            this.btnByMonth.Controls.Add(this.label9);
            this.btnByMonth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnByMonth.Location = new System.Drawing.Point(277, 0);
            this.btnByMonth.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.btnByMonth.Name = "btnByMonth";
            this.btnByMonth.Size = new System.Drawing.Size(267, 73);
            this.btnByMonth.TabIndex = 1;
            this.btnByMonth.Click += new System.EventHandler(this.btnByMonth_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(2, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "Completed";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(3, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 22);
            this.label9.TabIndex = 0;
            this.label9.Text = "Month";
            // 
            // btnByDay
            // 
            this.btnByDay.BackColor = System.Drawing.Color.DarkGray;
            this.btnByDay.Controls.Add(this.label5);
            this.btnByDay.Controls.Add(this.label2);
            this.btnByDay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnByDay.Location = new System.Drawing.Point(0, 0);
            this.btnByDay.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.btnByDay.Name = "btnByDay";
            this.btnByDay.Size = new System.Drawing.Size(267, 73);
            this.btnByDay.TabIndex = 0;
            this.btnByDay.Click += new System.EventHandler(this.btnByDay_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(2, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Completed";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Day";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Controls.Add(this.tableLayoutPanel2);
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(1129, 660);
            this.panel2.TabIndex = 3;
            // 
            // panel8
            // 
            this.panel8.AutoScroll = true;
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.Controls.Add(this.panel9);
            this.panel8.Controls.Add(this.gvBill);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(10, 345);
            this.panel8.Margin = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1109, 305);
            this.panel8.TabIndex = 3;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.btnStatisticByRating);
            this.panel9.Controls.Add(this.btnStatíticByBestsellers);
            this.panel9.Controls.Add(this.btnStatisticDamage);
            this.panel9.Controls.Add(this.btnSearch);
            this.panel9.Controls.Add(this.txtSearch);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1109, 65);
            this.panel9.TabIndex = 7;
            // 
            // btnStatisticByRating
            // 
            this.btnStatisticByRating.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(127)))));
            this.btnStatisticByRating.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnStatisticByRating.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatisticByRating.ForeColor = System.Drawing.Color.White;
            this.btnStatisticByRating.Location = new System.Drawing.Point(830, 10);
            this.btnStatisticByRating.Name = "btnStatisticByRating";
            this.btnStatisticByRating.Size = new System.Drawing.Size(151, 41);
            this.btnStatisticByRating.TabIndex = 26;
            this.btnStatisticByRating.Text = "Statistic By Rating";
            this.btnStatisticByRating.UseVisualStyleBackColor = false;
            this.btnStatisticByRating.Click += new System.EventHandler(this.btnStatisticByRating_Click);
            // 
            // btnStatíticByBestsellers
            // 
            this.btnStatíticByBestsellers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnStatíticByBestsellers.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnStatíticByBestsellers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatíticByBestsellers.ForeColor = System.Drawing.Color.White;
            this.btnStatíticByBestsellers.Location = new System.Drawing.Point(621, 10);
            this.btnStatíticByBestsellers.Name = "btnStatíticByBestsellers";
            this.btnStatíticByBestsellers.Size = new System.Drawing.Size(151, 41);
            this.btnStatíticByBestsellers.TabIndex = 26;
            this.btnStatíticByBestsellers.Text = "Statistic By Bestsellers";
            this.btnStatíticByBestsellers.UseVisualStyleBackColor = false;
            this.btnStatíticByBestsellers.Click += new System.EventHandler(this.btnStatíticByBestsellers_Click);
            // 
            // btnStatisticDamage
            // 
            this.btnStatisticDamage.BackColor = System.Drawing.Color.DarkGray;
            this.btnStatisticDamage.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnStatisticDamage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatisticDamage.ForeColor = System.Drawing.Color.White;
            this.btnStatisticDamage.Location = new System.Drawing.Point(406, 10);
            this.btnStatisticDamage.Name = "btnStatisticDamage";
            this.btnStatisticDamage.Size = new System.Drawing.Size(151, 41);
            this.btnStatisticDamage.TabIndex = 26;
            this.btnStatisticDamage.Text = "Statistic By Damage";
            this.btnStatisticDamage.UseVisualStyleBackColor = false;
            this.btnStatisticDamage.Click += new System.EventHandler(this.btnStatisticDamage_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnSearch.IconColor = System.Drawing.Color.Gainsboro;
            this.btnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearch.IconSize = 20;
            this.btnSearch.Location = new System.Drawing.Point(157, 23);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(20, 20);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(6, 20);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(121, 23);
            this.txtSearch.TabIndex = 1;
            // 
            // gvBill
            // 
            this.gvBill.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvBill.BackgroundColor = System.Drawing.Color.White;
            this.gvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvBill.Location = new System.Drawing.Point(0, 67);
            this.gvBill.Name = "gvBill";
            this.gvBill.Size = new System.Drawing.Size(1106, 232);
            this.gvBill.TabIndex = 0;
            // 
            // fBillDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 660);
            this.Controls.Add(this.panel2);
            this.Name = "fBillDashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fBillDashBoard";
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartColumn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDoughnut)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.btnByYear.ResumeLayout(false);
            this.btnByYear.PerformLayout();
            this.btnByMonth.ResumeLayout(false);
            this.btnByMonth.PerformLayout();
            this.btnByDay.ResumeLayout(false);
            this.btnByDay.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvBill)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartColumn;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDoughnut;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label btnQuarterLy;
        private System.Windows.Forms.Panel btnByYear;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel btnByMonth;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel btnByDay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel9;
        private FontAwesome.Sharp.IconButton btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.DataGridView gvBill;
        private System.Windows.Forms.Button btnStatisticByRating;
        private System.Windows.Forms.Button btnStatíticByBestsellers;
        private System.Windows.Forms.Button btnStatisticDamage;
    }
}