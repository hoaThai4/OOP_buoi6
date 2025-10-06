using System;

namespace _1150080053_LAB3
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtLop;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblLop;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblDiaChi;

        private System.Windows.Forms.TableLayoutPanel tlpActions;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;

        private System.Windows.Forms.GroupBox grpList;
        private System.Windows.Forms.ListView lvSV;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtLop = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblLop = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();

            this.tlpActions = new System.Windows.Forms.TableLayoutPanel();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();

            this.grpList = new System.Windows.Forms.GroupBox();
            this.lvSV = new System.Windows.Forms.ListView();

            this.grpInfo.SuspendLayout();
            this.tlpActions.SuspendLayout();
            this.grpList.SuspendLayout();
            this.SuspendLayout();
            // 
            // Form1 (form)
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Text = "Danh sách sinh viên";
            this.Name = "Form1";
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(220, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(328, 32);
            this.lblTitle.Text = "DANH MỤC SINH VIÊN";
            // 
            // grpInfo
            // 
            this.grpInfo.Controls.Add(this.txtHoTen);
            this.grpInfo.Controls.Add(this.txtLop);
            this.grpInfo.Controls.Add(this.txtDiaChi);
            this.grpInfo.Controls.Add(this.dtpNgaySinh);
            this.grpInfo.Controls.Add(this.lblHoTen);
            this.grpInfo.Controls.Add(this.lblLop);
            this.grpInfo.Controls.Add(this.lblNgaySinh);
            this.grpInfo.Controls.Add(this.lblDiaChi);
            this.grpInfo.Location = new System.Drawing.Point(12, 50);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(760, 120);
            this.grpInfo.TabStop = true;
            this.grpInfo.Text = "Thông tin sinh viên";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(90, 25);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(250, 23);
            // 
            // txtLop
            // 
            this.txtLop.Location = new System.Drawing.Point(470, 25);
            this.txtLop.Name = "txtLop";
            this.txtLop.Size = new System.Drawing.Size(250, 23);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(470, 70);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(250, 23);
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(90, 70);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(250, 23);
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(20, 28);
            this.lblHoTen.Text = "Họ tên:";
            // 
            // lblLop
            // 
            this.lblLop.AutoSize = true;
            this.lblLop.Location = new System.Drawing.Point(420, 28);
            this.lblLop.Text = "Lớp:";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(20, 74);
            this.lblNgaySinh.Text = "Ngày sinh:";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(420, 74);
            this.lblDiaChi.Text = "Địa chỉ:";
            // 
            // tlpActions (panel chứa nút)
            // 
            this.tlpActions.ColumnCount = 4;
            this.tlpActions.RowCount = 1;
            this.tlpActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpActions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpActions.Location = new System.Drawing.Point(12, 175);
            this.tlpActions.Name = "tlpActions";
            this.tlpActions.Size = new System.Drawing.Size(760, 40);
            this.tlpActions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                        | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // btnThem
            // 
            this.btnThem.Text = "Thêm";
            this.btnThem.Size = new System.Drawing.Size(100, 30);
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Text = "Sửa";
            this.btnSua.Size = new System.Drawing.Size(100, 30);
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Size = new System.Drawing.Size(100, 30);
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Size = new System.Drawing.Size(100, 30);
            this.btnThoat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // add buttons vào tlp
            // 
            this.tlpActions.Controls.Add(this.btnThem, 0, 0);
            this.tlpActions.Controls.Add(this.btnSua, 1, 0);
            this.tlpActions.Controls.Add(this.btnXoa, 2, 0);
            this.tlpActions.Controls.Add(this.btnThoat, 3, 0);
            // 
            // grpList
            // 
            this.grpList.Controls.Add(this.lvSV);
            this.grpList.Location = new System.Drawing.Point(12, 220);
            this.grpList.Name = "grpList";
            this.grpList.Size = new System.Drawing.Size(760, 230);
            this.grpList.TabStop = true;
            this.grpList.Text = "Thông tin chung sinh viên";
            // 
            // lvSV
            // 
            this.lvSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvSV.HideSelection = false;
            this.lvSV.Location = new System.Drawing.Point(3, 19);
            this.lvSV.Name = "lvSV";
            this.lvSV.Size = new System.Drawing.Size(754, 208);
            this.lvSV.UseCompatibleStateImageBehavior = false;
            this.lvSV.SelectedIndexChanged += new System.EventHandler(this.lvSV_SelectedIndexChanged);
            // 
            // Thêm controls lên Form
            // 
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grpInfo);
            this.Controls.Add(this.tlpActions);
            this.Controls.Add(this.grpList);

            // Phím tắt tiện
            this.AcceptButton = this.btnThem;
            this.CancelButton = this.btnThoat;

            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            this.tlpActions.ResumeLayout(false);
            this.grpList.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
