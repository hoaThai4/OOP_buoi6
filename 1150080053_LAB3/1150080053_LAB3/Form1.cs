using System;
using System.Linq;
using System.Windows.Forms;

namespace _1150080053_LAB3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lvSV.Columns.Clear();
            lvSV.Columns.Add("Họ tên", 180);
            lvSV.Columns.Add("Ngày sinh", 120);
            lvSV.Columns.Add("Lớp", 120);
            lvSV.Columns.Add("Địa chỉ", 220);

            lvSV.View = View.Details;
            lvSV.FullRowSelect = true;
            lvSV.GridLines = true;
            ActiveControl = txtHoTen;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return; 

            var item = new ListViewItem(txtHoTen.Text.Trim());                
            item.SubItems.Add(dtpNgaySinh.Value.ToString("dd/MM/yyyy"));     
            item.SubItems.Add(txtLop.Text.Trim());                             
            item.SubItems.Add(txtDiaChi.Text.Trim());                          

            lvSV.Items.Add(item);
            ClearInputs();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lvSV.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một dòng để sửa.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!ValidateInputs()) return;

            var sel = lvSV.SelectedItems[0];
            sel.Text = txtHoTen.Text.Trim();
            sel.SubItems[1].Text = dtpNgaySinh.Value.ToString("dd/MM/yyyy");
            sel.SubItems[2].Text = txtLop.Text.Trim();
            sel.SubItems[3].Text = txtDiaChi.Text.Trim();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lvSV.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var ans = MessageBox.Show("Bạn có chắc muốn xóa dòng đã chọn?",
                                      "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ans == DialogResult.Yes)
            {
                lvSV.Items.Remove(lvSV.SelectedItems[0]);
                ClearInputs();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            var ans = MessageBox.Show("Bạn có chắc muốn thoát?", "Xác nhận",
                                      MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ans == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void lvSV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvSV.SelectedItems.Count == 0) return;
            var sel = lvSV.SelectedItems[0];

            txtHoTen.Text = sel.SubItems[0].Text;

            if (DateTime.TryParse(sel.SubItems[1].Text, out var d))
                dtpNgaySinh.Value = d;
            else
                dtpNgaySinh.Value = DateTime.Today;

            txtLop.Text = sel.SubItems[2].Text;
            txtDiaChi.Text = sel.SubItems[3].Text;
        }

   
        private bool ValidateInputs()
        {
            var hoTen = txtHoTen.Text.Trim();
            if (string.IsNullOrWhiteSpace(hoTen))
            {
                MessageBox.Show("Họ tên không được rỗng.", "Lỗi nhập liệu",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTen.Focus();
                return false;
            }
            return true;
        }

        private void ClearInputs()
        {
            txtHoTen.Clear();
            txtLop.Clear();
            txtDiaChi.Clear();
            dtpNgaySinh.Value = DateTime.Today;
            txtHoTen.Focus();
            lvSV.SelectedItems.Clear();
        }
    }
}