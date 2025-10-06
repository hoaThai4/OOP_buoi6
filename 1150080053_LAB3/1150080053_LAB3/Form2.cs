using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _1150080053_LAB3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            
            picLogo.Image = Properties.Resources.pho;     
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.BackColor = Color.Transparent;

            SetupTables();
            SetupGrid();
            WireMenuButtons();

            dgvDS.KeyDown += dgvDS_KeyDown; 
        }

        private void SetupTables()
        {
            cmbBan.Items.Clear();
            cmbBan.Items.AddRange(new object[]
            {
                "Bàn 1","Bàn 2","Bàn 3","Bàn 4","Bàn 5","Bàn 6","Bàn 7","Bàn 8"
            });
            if (cmbBan.Items.Count > 0) cmbBan.SelectedIndex = 0;
        }

        private void SetupGrid()
        {
            dgvDS.Columns.Clear();
            dgvDS.AutoGenerateColumns = false;
            dgvDS.AllowUserToAddRows = false;
            dgvDS.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDS.MultiSelect = false;
            dgvDS.RowHeadersVisible = false;

            var colMon = new DataGridViewTextBoxColumn
            {
                Name = "Mon",
                HeaderText = "Món",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                ReadOnly = true
            };
            var colSL = new DataGridViewTextBoxColumn
            {
                Name = "SoLuong",
                HeaderText = "Số lượng",
                Width = 100,
                ReadOnly = true
            };

            dgvDS.Columns.Add(colMon);
            dgvDS.Columns.Add(colSL);
        }

        private void WireMenuButtons()
        {
            AttachButtonsRecursive(grpMenu);
        }

        private void AttachButtonsRecursive(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c is Button b && b != btnOrder && b != btnXoa)
                {
                    if (b.Tag == null || string.IsNullOrWhiteSpace(b.Tag.ToString()))
                        b.Tag = b.Text.Trim();
                    b.Click += MenuButton_Click;
                }
                else if (c.HasChildren)
                {
                    AttachButtonsRecursive(c);
                }
            }
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            if (sender is Button b)
            {
                string tenMon = (b.Tag ?? b.Text).ToString().Trim();
                AddOrIncrease(tenMon);
            }
        }

        private void AddOrIncrease(string tenMon)
        {
            foreach (DataGridViewRow row in dgvDS.Rows)
            {
                if (string.Equals(row.Cells["Mon"].Value?.ToString(), tenMon,
                                  StringComparison.CurrentCultureIgnoreCase))
                {
                    int sl = int.TryParse(row.Cells["SoLuong"].Value?.ToString(), out var x) ? x : 0;
                    row.Cells["SoLuong"].Value = sl + 1;
                    return;
                }
            }
            dgvDS.Rows.Add(tenMon, 1);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDS.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa.", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            dgvDS.Rows.RemoveAt(dgvDS.SelectedRows[0].Index);
        }

        private void dgvDS_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete) btnXoa.PerformClick();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (cmbBan.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn bàn trước khi Order.", "Thiếu thông tin",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dgvDS.Rows.Count == 0)
            {
                MessageBox.Show("Chưa có món nào trong danh sách.", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string dir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "orders");
            Directory.CreateDirectory(dir);

            string banSafe = cmbBan.SelectedItem.ToString().Replace(' ', '_');
            string fileName = $"{DateTime.Now:yyyyMMdd_HHmmss}_ban_{banSafe}.txt";
            string path = Path.Combine(dir, fileName);

            using (var sw = new StreamWriter(path, false, Encoding.UTF8))
            {
                sw.WriteLine("QUÁN ĂN NHANH HƯNG THỊNH");
                sw.WriteLine($"Bàn: {cmbBan.SelectedItem}");
                sw.WriteLine($"Thời gian: {DateTime.Now:dd/MM/yyyy HH:mm:ss}");
                sw.WriteLine(new string('-', 40));

                foreach (DataGridViewRow row in dgvDS.Rows)
                {
                    string mon = row.Cells["Mon"].Value?.ToString() ?? "";
                    string sl = row.Cells["SoLuong"].Value?.ToString() ?? "0";
                    sw.WriteLine($"{mon,-25} x {sl,2}");
                }

                sw.WriteLine(new string('-', 40));
                sw.WriteLine("Ghi chú: File sinh tự động từ PDA (WinForms).");
            }

            MessageBox.Show($"Đã ghi đơn hàng:\n{path}", "Thành công",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

            dgvDS.Rows.Clear();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
