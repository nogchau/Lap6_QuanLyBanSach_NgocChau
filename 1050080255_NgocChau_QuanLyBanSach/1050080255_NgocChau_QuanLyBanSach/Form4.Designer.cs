using System.Windows.Forms;

namespace QuanLyBanSach_BuiHaiDuong_1150080012
{
    partial class Form4
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lsvDanhSach = new System.Windows.Forms.ListView();
            this.colMaXB = new System.Windows.Forms.ColumnHeader();
            this.colTenXB = new System.Windows.Forms.ColumnHeader();
            this.colDiaChi = new System.Windows.Forms.ColumnHeader();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaXB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenXB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(650, 40);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "XÓA NHÀ XUẤT BẢN";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lsvDanhSach
            // 
            this.lsvDanhSach.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaXB, this.colTenXB, this.colDiaChi});
            this.lsvDanhSach.FullRowSelect = true;
            this.lsvDanhSach.GridLines = true;
            this.lsvDanhSach.Location = new System.Drawing.Point(20, 60);
            this.lsvDanhSach.Size = new System.Drawing.Size(610, 220);
            this.lsvDanhSach.View = System.Windows.Forms.View.Details;
            this.lsvDanhSach.SelectedIndexChanged += new System.EventHandler(this.lsvDanhSach_SelectedIndexChanged);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 300);
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.Text = "Mã XB:";
            // 
            // txtMaXB
            // 
            this.txtMaXB.Location = new System.Drawing.Point(120, 297);
            this.txtMaXB.ReadOnly = true;
            this.txtMaXB.Size = new System.Drawing.Size(150, 27);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 335);
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.Text = "Tên XB:";
            // 
            // txtTenXB
            // 
            this.txtTenXB.Location = new System.Drawing.Point(120, 332);
            this.txtTenXB.ReadOnly = true;
            this.txtTenXB.Size = new System.Drawing.Size(250, 27);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 370);
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.Text = "Địa chỉ:";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(120, 367);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.ReadOnly = true;
            this.txtDiaChi.Size = new System.Drawing.Size(400, 50);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Firebrick;
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(120, 430);
            this.btnXoa.Size = new System.Drawing.Size(100, 35);
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.LightGray;
            this.btnLamMoi.Location = new System.Drawing.Point(240, 430);
            this.btnLamMoi.Size = new System.Drawing.Size(100, 35);
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.ClientSize = new System.Drawing.Size(650, 490);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTenXB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaXB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lsvDanhSach);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form4";
            this.Text = "XÓA NHÀ XUẤT BẢN";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private ListView lsvDanhSach;
        private ColumnHeader colMaXB;
        private ColumnHeader colTenXB;
        private ColumnHeader colDiaChi;
        private Label label1;
        private TextBox txtMaXB;
        private Label label2;
        private TextBox txtTenXB;
        private Label label3;
        private TextBox txtDiaChi;
        private Button btnXoa;
        private Button btnLamMoi;
    }
}
