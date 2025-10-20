using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyBanSach_BuiHaiDuong_1150080012
{
    public partial class Form3 : Form
    {
        string strCon = @"Data Source=LAPTOP-1OLPGQ5K\SUGAR;
Initial Catalog=QuanLyBanSach;
Integrated Security=True;";

        SqlConnection sqlCon = null;

        public Form3()
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

        private void Form3_Load(object sender, EventArgs e)
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaXB.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn một nhà xuất bản để sửa!");
                return;
            }

            MoKetNoi();
            SqlCommand cmd = new SqlCommand("SuaDuLieu", sqlCon);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@maXB", SqlDbType.Char).Value = txtMaXB.Text.Trim();
            cmd.Parameters.Add("@tenXB", SqlDbType.NVarChar).Value = txtTenXB.Text.Trim();
            cmd.Parameters.Add("@diaChi", SqlDbType.NVarChar).Value = txtDiaChi.Text.Trim();

            int kq = cmd.ExecuteNonQuery();
            if (kq > 0)
            {
                MessageBox.Show("✅ Cập nhật thành công!");
                HienThiDanhSachXB();
            }
            else
            {
                MessageBox.Show("❌ Cập nhật thất bại!");
            }
            DongKetNoi();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaXB.Clear();
            txtTenXB.Clear();
            txtDiaChi.Clear();
            txtMaXB.Focus();
        }
    }
}
