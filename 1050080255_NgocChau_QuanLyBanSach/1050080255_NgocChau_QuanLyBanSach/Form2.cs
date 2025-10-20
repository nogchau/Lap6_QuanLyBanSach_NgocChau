using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyBanSach_BuiHaiDuong_1150080012
{
    public partial class Form2 : Form
    {
        string strCon = @"Data Source=LAPTOP-1OLPGQ5K\SUGAR;
Initial Catalog=QuanLyBanSach;
Integrated Security=True;";

        SqlConnection sqlCon = null;

        public Form2()
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

        // Hiển thị danh sách sau khi thêm
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

        private void Form2_Load(object sender, EventArgs e)
        {
            HienThiDanhSachXB();
            txtMaXB.Focus();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaXB.Text.Trim() == "" || txtTenXB.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            MoKetNoi();
            SqlCommand cmd = new SqlCommand("ThemDuLieu", sqlCon);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@maXB", SqlDbType.Char).Value = txtMaXB.Text.Trim();
            cmd.Parameters.Add("@tenXB", SqlDbType.NVarChar).Value = txtTenXB.Text.Trim();
            cmd.Parameters.Add("@diaChi", SqlDbType.NVarChar).Value = txtDiaChi.Text.Trim();

            int kq = cmd.ExecuteNonQuery();
            if (kq > 0)
            {
                MessageBox.Show("✅ Thêm dữ liệu thành công!");
                HienThiDanhSachXB();
                txtMaXB.Clear();
                txtTenXB.Clear();
                txtDiaChi.Clear();
                txtMaXB.Focus();
            }
            else
            {
                MessageBox.Show("❌ Thêm thất bại!");
            }

            DongKetNoi();
        }
    }
}
