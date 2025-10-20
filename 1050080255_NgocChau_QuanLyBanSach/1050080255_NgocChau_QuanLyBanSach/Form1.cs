using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace _1050080255_NgocChau_QuanLyBanSach
{
    public partial class Form1 : Form
    {
        // 🔹 Chuỗi kết nối SQL Server
        string strCon = @"Data Source=CHAUDANGG\SQLEXPRESS;Initial Catalog=QuanLyBanSach;Integrated Security=True";
        SqlConnection sqlCon = null;

        public Form1()
        {
            InitializeComponent();
        }

        // 🔹 Mở kết nối
        private void MoKetNoi()
        {
            if (sqlCon == null)
                sqlCon = new SqlConnection(strCon);
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
        }

        // 🔹 Đóng kết nối
        private void DongKetNoi()
        {
            if (sqlCon != null && sqlCon.State == ConnectionState.Open)
                sqlCon.Close();
        }

        // 🔹 Hiển thị danh sách Nhà xuất bản
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

        // 🔹 Hiển thị chi tiết khi chọn dòng
        private void HienThiChiTietXBTheoMa(string maXB)
        {
            MoKetNoi();
            SqlCommand cmd = new SqlCommand("hienThiChiTietXB", sqlCon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@maXB", SqlDbType.Char).Value = maXB;

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                txtMaXB.Text = reader.GetString(0);
                txtTenXB.Text = reader.GetString(1);
                txtDiaChi.Text = reader.GetString(2);
            }
            reader.Close();
            DongKetNoi();
        }

        // 🔹 Khi Form Load
        private void Form1_Load(object sender, EventArgs e)
        {
            HienThiDanhSachXB();
        }

        // 🔹 Khi chọn dòng trong ListView
        private void lsvDanhSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvDanhSach.SelectedItems.Count == 0) return;
            string ma = lsvDanhSach.SelectedItems[0].SubItems[0].Text;
            HienThiChiTietXBTheoMa(ma);
        }
    }
}
