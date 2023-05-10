namespace Car_Renting
{
    partial class fStatusRent
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.gvStatusRent = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvStatusRent)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gvStatusRent);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(943, 460);
            this.panel2.TabIndex = 20;
            // 
            // gvStatusRent
            // 
            this.gvStatusRent.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.gvStatusRent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvStatusRent.Dock = System.Windows.Forms.DockStyle.Top;
            this.gvStatusRent.Location = new System.Drawing.Point(0, 0);
            this.gvStatusRent.Name = "gvStatusRent";
            this.gvStatusRent.RowHeadersWidth = 51;
            this.gvStatusRent.Size = new System.Drawing.Size(943, 460);
            this.gvStatusRent.TabIndex = 4;
            // 
            // fStatusRent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(78)))));
            this.ClientSize = new System.Drawing.Size(943, 460);
            this.Controls.Add(this.panel2);
            this.Name = "fStatusRent";
            this.Text = "fStatusRent";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvStatusRent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView gvStatusRent;
    }
}