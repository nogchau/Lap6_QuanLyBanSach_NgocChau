using System.Windows.Forms;

namespace QuanLyBanSach_BuiHaiDuong_1150080012
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaXB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenXB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.lsvDanhSach = new System.Windows.Forms.ListView();
            this.colMaXB = new System.Windows.Forms.ColumnHeader();
            this.colTenXB = new System.Windows.Forms.ColumnHeader();
            this.colDiaChi = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(650, 40);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "THÊM NHÀ XUẤT BẢN MỚI";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1 - Mã XB
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.Text = "Mã XB:";
            // 
            // txtMaXB
            // 
            this.txtMaXB.Location = new System.Drawing.Point(120, 57);
            this.txtMaXB.Size = new System.Drawing.Size(160, 27);
            // 
            // label2 - Tên XB
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.Text = "Tên XB:";
            // 
            // txtTenXB
            // 
            this.txtTenXB.Location = new System.Drawing.Point(120, 92);
            this.txtTenXB.Size = new System.Drawing.Size(250, 27);
            // 
            // label3 - Địa chỉ
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.Text = "Địa chỉ:";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(120, 127);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Size = new System.Drawing.Size(400, 50);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(120, 190);
            this.btnThem.Size = new System.Drawing.Size(120, 35);
            this.btnThem.Text = "Thêm mới";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lsvDanhSach
            // 
            this.lsvDanhSach.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaXB, this.colTenXB, this.colDiaChi});
            this.lsvDanhSach.FullRowSelect = true;
            this.lsvDanhSach.GridLines = true;
            this.lsvDanhSach.Location = new System.Drawing.Point(20, 240);
            this.lsvDanhSach.Size = new System.Drawing.Size(610, 200);
            this.lsvDanhSach.View = System.Windows.Forms.View.Details;
            // 
            // colMaXB
            // 
            this.colMaXB.Text = "Mã XB";
            this.colMaXB.Width = 100;
            // 
            // colTenXB
            // 
            this.colTenXB.Text = "Tên Nhà Xuất Bản";
            this.colTenXB.Width = 200;
            // 
            // colDiaChi
            // 
            this.colDiaChi.Text = "Địa chỉ";
            this.colDiaChi.Width = 280;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.ClientSize = new System.Drawing.Size(650, 470);
            this.Controls.Add(this.lsvDanhSach);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTenXB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaXB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form2";
            this.Text = "THÊM NHÀ XUẤT BẢN";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label label1;
        private TextBox txtMaXB;
        private Label label2;
        private TextBox txtTenXB;
        private Label label3;
        private TextBox txtDiaChi;
        private Button btnThem;
        private ListView lsvDanhSach;
        private ColumnHeader colMaXB;
        private ColumnHeader colTenXB;
        private ColumnHeader colDiaChi;
    }
}
