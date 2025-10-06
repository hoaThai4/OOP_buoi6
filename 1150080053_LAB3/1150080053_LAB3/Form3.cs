using Npgsql;
using System;
using System.Configuration;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1150080053_LAB3
{
    public partial class Form3 : Form
    {
        private NpgsqlConnection pgCon = null;
        private string strCon = "Host=localhost;Port=5432;Database=SinhVien;Username=postgres;Password=12345678";

        public Form3()
        {
            InitializeComponent();
        }

        private void btnMoKetNoi_Click(object sender, EventArgs e)
        {
            try
            {
                if (pgCon == null)
                    pgCon = new NpgsqlConnection(strCon);

                if (pgCon.State == ConnectionState.Closed)
                {
                    pgCon.Open();
                    MessageBox.Show("✅ Kết nối PostgreSQL thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Lỗi mở kết nối: " + ex.Message);
            }
        }

        private void btnDongKetNoi_Click(object sender, EventArgs e)
        {
            try
            {
                if (pgCon != null && pgCon.State == ConnectionState.Open)
                {
                    pgCon.Close();
                    MessageBox.Show("🔒 Đã đóng kết nối!");
                }
                else
                {
                    MessageBox.Show("⚠️ Chưa mở kết nối!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Lỗi đóng kết nối: " + ex.Message);
            }
        }

        private void thuchanh1lab4_Load(object sender, EventArgs e)
        {

        }
    }
}
