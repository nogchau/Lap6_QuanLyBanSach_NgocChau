using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyBanSach_BuiHaiDuong_1150080012
{
    public partial class Form4 : Form
    {
        string strCon = @"Data Source=LAPTOP-1OLPGQ5K\SUGAR;
Initial Catalog=QuanLyBanSach;
Integrated Security=True;";

        SqlConnection sqlCon = null;

        public Form4()
        {
            InitializeComponent();
        }

        private void MoKetNoi()
        {
            if (sqlCon == null)
                sqlCon = new SqlConnection(strCon);
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
        }

        private void DongKetNoi()
        {
            if (sqlCon != null && sqlCon.State == ConnectionState.Open)
                sqlCon.Close();
        }

        private void HienThiDanhSachXB()
        {
            MoKetNoi();
            SqlCommand cmd = new SqlCommand("hienThiXB", sqlCon);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataReader reader = cmd.ExecuteReader();
            lsvDanhSach.Items.Clear();
            while (reader.Read())
            {
                string ma = reader.GetString(0);
                string ten = reader.GetString(1);
                string diaChi = reader.GetString(2);

                ListViewItem item = new ListViewItem(ma);
                item.SubItems.Add(ten);
                item.SubItems.Add(diaChi);
                lsvDanhSach.Items.Add(item);
            }
            reader.Close();
            DongKetNoi();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            HienThiDanhSachXB();
        }

        private void lsvDanhSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvDanhSach.SelectedItems.Count == 0) return;
            var item = lsvDanhSach.SelectedItems[0];
            txtMaXB.Text = item.SubItems[0].Text;
            txtTenXB.Text = item.SubItems[1].Text;
            txtDiaChi.Text = item.SubItems[2].Text;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaXB.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn nhà xuất bản cần xóa!");
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            MoKetNoi();
            SqlCommand cmd = new SqlCommand("XoaDuLieu", sqlCon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@maXB", SqlDbType.Char).Value = txtMaXB.Text.Trim();

            int kq = cmd.ExecuteNonQuery();
            if (kq > 0)
            {
                MessageBox.Show("✅ Xóa thành công!");
                HienThiDanhSachXB();
                txtMaXB.Clear();
                txtTenXB.Clear();
                txtDiaChi.Clear();
            }
            else
            {
                MessageBox.Show("❌ Xóa thất bại!");
            }
            DongKetNoi();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaXB.Clear();
            txtTenXB.Clear();
            txtDiaChi.Clear();
            HienThiDanhSachXB();
        }
    }
}
