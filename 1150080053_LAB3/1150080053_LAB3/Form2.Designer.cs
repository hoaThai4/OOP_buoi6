using System;

namespace _1150080053_LAB3
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblBrand;

        private System.Windows.Forms.GroupBox grpMenu;
        private System.Windows.Forms.TableLayoutPanel tlpMenu;

        private System.Windows.Forms.Button btnComChienTrung;
        private System.Windows.Forms.Button btnBanhMyOpla;
        private System.Windows.Forms.Button btnCoca;
        private System.Windows.Forms.Button btnLipton;
        private System.Windows.Forms.Button btnOcRangMuoi;
        private System.Windows.Forms.Button btnKhoaiTayChien;
        private System.Windows.Forms.Button btn7up;
        private System.Windows.Forms.Button btnCam;
        private System.Windows.Forms.Button btnMyXaoHaiSan;
        private System.Windows.Forms.Button btnCaVienChien;
        private System.Windows.Forms.Button btnPepsi;
        private System.Windows.Forms.Button btnCafe;
        private System.Windows.Forms.Button btnBurgerBoNuong;
        private System.Windows.Forms.Button btnDuiGaRan;
        private System.Windows.Forms.Button btnBunBoHue;

        private System.Windows.Forms.TableLayoutPanel tlpActions;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label lblBan;
        private System.Windows.Forms.ComboBox cmbBan;
        private System.Windows.Forms.Button btnOrder;

        private System.Windows.Forms.DataGridView dgvDS;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblBrand = new System.Windows.Forms.Label();
            this.grpMenu = new System.Windows.Forms.GroupBox();
            this.tlpMenu = new System.Windows.Forms.TableLayoutPanel();
            this.btnComChienTrung = new System.Windows.Forms.Button();
            this.btnBanhMyOpla = new System.Windows.Forms.Button();
            this.btnCoca = new System.Windows.Forms.Button();
            this.btnLipton = new System.Windows.Forms.Button();
            this.btnOcRangMuoi = new System.Windows.Forms.Button();
            this.btnKhoaiTayChien = new System.Windows.Forms.Button();
            this.btn7up = new System.Windows.Forms.Button();
            this.btnCam = new System.Windows.Forms.Button();
            this.btnMyXaoHaiSan = new System.Windows.Forms.Button();
            this.btnCaVienChien = new System.Windows.Forms.Button();
            this.btnPepsi = new System.Windows.Forms.Button();
            this.btnCafe = new System.Windows.Forms.Button();
            this.btnBurgerBoNuong = new System.Windows.Forms.Button();
            this.btnDuiGaRan = new System.Windows.Forms.Button();
            this.btnBunBoHue = new System.Windows.Forms.Button();
            this.tlpActions = new System.Windows.Forms.TableLayoutPanel();
            this.btnXoa = new System.Windows.Forms.Button();
            this.lblBan = new System.Windows.Forms.Label();
            this.cmbBan = new System.Windows.Forms.ComboBox();
            this.btnOrder = new System.Windows.Forms.Button();
            this.dgvDS = new System.Windows.Forms.DataGridView();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.grpMenu.SuspendLayout();
            this.tlpMenu.SuspendLayout();
            this.tlpActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDS)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.picLogo);
            this.pnlHeader.Controls.Add(this.lblBrand);
            this.pnlHeader.Location = new System.Drawing.Point(14, 9);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(910, 51);
            this.pnlHeader.TabIndex = 0;
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.Location = new System.Drawing.Point(7, 4);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(46, 43);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // lblBrand
            // 
            this.lblBrand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.lblBrand.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblBrand.ForeColor = System.Drawing.Color.White;
            this.lblBrand.Location = new System.Drawing.Point(66, 4);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(837, 43);
            this.lblBrand.TabIndex = 1;
            this.lblBrand.Text = "Quán ăn nhanh Hưng Thịnh";
            this.lblBrand.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grpMenu
            // 
            this.grpMenu.Controls.Add(this.tlpMenu);
            this.grpMenu.Location = new System.Drawing.Point(14, 66);
            this.grpMenu.Name = "grpMenu";
            this.grpMenu.Size = new System.Drawing.Size(910, 203);
            this.grpMenu.TabIndex = 1;
            this.grpMenu.TabStop = false;
            this.grpMenu.Text = "Danh sách món ăn:";
            // 
            // tlpMenu
            // 
            this.tlpMenu.ColumnCount = 4;
            this.tlpMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpMenu.Controls.Add(this.btnComChienTrung, 0, 0);
            this.tlpMenu.Controls.Add(this.btnBanhMyOpla, 1, 0);
            this.tlpMenu.Controls.Add(this.btnCoca, 2, 0);
            this.tlpMenu.Controls.Add(this.btnLipton, 3, 0);
            this.tlpMenu.Controls.Add(this.btnOcRangMuoi, 0, 1);
            this.tlpMenu.Controls.Add(this.btnKhoaiTayChien, 1, 1);
            this.tlpMenu.Controls.Add(this.btn7up, 2, 1);
            this.tlpMenu.Controls.Add(this.btnCam, 3, 1);
            this.tlpMenu.Controls.Add(this.btnMyXaoHaiSan, 0, 2);
            this.tlpMenu.Controls.Add(this.btnCaVienChien, 1, 2);
            this.tlpMenu.Controls.Add(this.btnPepsi, 2, 2);
            this.tlpMenu.Controls.Add(this.btnCafe, 3, 2);
            this.tlpMenu.Controls.Add(this.btnBurgerBoNuong, 0, 3);
            this.tlpMenu.Controls.Add(this.btnDuiGaRan, 1, 3);
            this.tlpMenu.Controls.Add(this.btnBunBoHue, 2, 3);
            this.tlpMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMenu.Location = new System.Drawing.Point(3, 18);
            this.tlpMenu.Name = "tlpMenu";
            this.tlpMenu.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.tlpMenu.RowCount = 4;
            this.tlpMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpMenu.Size = new System.Drawing.Size(904, 182);
            this.tlpMenu.TabIndex = 0;
            // 
            // btnComChienTrung
            // 
            this.btnComChienTrung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnComChienTrung.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnComChienTrung.Location = new System.Drawing.Point(14, 12);
            this.btnComChienTrung.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnComChienTrung.Name = "btnComChienTrung";
            this.btnComChienTrung.Size = new System.Drawing.Size(208, 30);
            this.btnComChienTrung.TabIndex = 0;
            this.btnComChienTrung.Tag = "Cơm chiên trứng";
            this.btnComChienTrung.Text = "Cơm chiên trứng";
            // 
            // btnBanhMyOpla
            // 
            this.btnBanhMyOpla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBanhMyOpla.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBanhMyOpla.Location = new System.Drawing.Point(236, 12);
            this.btnBanhMyOpla.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnBanhMyOpla.Name = "btnBanhMyOpla";
            this.btnBanhMyOpla.Size = new System.Drawing.Size(208, 30);
            this.btnBanhMyOpla.TabIndex = 1;
            this.btnBanhMyOpla.Tag = "Bánh mì ốp la";
            this.btnBanhMyOpla.Text = "Bánh mì ốp la";
            // 
            // btnCoca
            // 
            this.btnCoca.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCoca.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCoca.Location = new System.Drawing.Point(458, 12);
            this.btnCoca.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnCoca.Name = "btnCoca";
            this.btnCoca.Size = new System.Drawing.Size(208, 30);
            this.btnCoca.TabIndex = 2;
            this.btnCoca.Tag = "Coca";
            this.btnCoca.Text = "Coca";
            // 
            // btnLipton
            // 
            this.btnLipton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLipton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLipton.Location = new System.Drawing.Point(680, 12);
            this.btnLipton.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnLipton.Name = "btnLipton";
            this.btnLipton.Size = new System.Drawing.Size(210, 30);
            this.btnLipton.TabIndex = 3;
            this.btnLipton.Tag = "Lipton";
            this.btnLipton.Text = "Lipton";
            // 
            // btnOcRangMuoi
            // 
            this.btnOcRangMuoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOcRangMuoi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnOcRangMuoi.Location = new System.Drawing.Point(14, 54);
            this.btnOcRangMuoi.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnOcRangMuoi.Name = "btnOcRangMuoi";
            this.btnOcRangMuoi.Size = new System.Drawing.Size(208, 30);
            this.btnOcRangMuoi.TabIndex = 4;
            this.btnOcRangMuoi.Tag = "Ốc rang muối";
            this.btnOcRangMuoi.Text = "Ốc rang muối";
            // 
            // btnKhoaiTayChien
            // 
            this.btnKhoaiTayChien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnKhoaiTayChien.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnKhoaiTayChien.Location = new System.Drawing.Point(236, 54);
            this.btnKhoaiTayChien.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnKhoaiTayChien.Name = "btnKhoaiTayChien";
            this.btnKhoaiTayChien.Size = new System.Drawing.Size(208, 30);
            this.btnKhoaiTayChien.TabIndex = 5;
            this.btnKhoaiTayChien.Tag = "Khoai tây chiên";
            this.btnKhoaiTayChien.Text = "Khoai tây chiên";
            // 
            // btn7up
            // 
            this.btn7up.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn7up.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn7up.Location = new System.Drawing.Point(458, 54);
            this.btn7up.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btn7up.Name = "btn7up";
            this.btn7up.Size = new System.Drawing.Size(208, 30);
            this.btn7up.TabIndex = 6;
            this.btn7up.Tag = "7 up";
            this.btn7up.Text = "7 up";
            // 
            // btnCam
            // 
            this.btnCam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCam.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCam.Location = new System.Drawing.Point(680, 54);
            this.btnCam.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnCam.Name = "btnCam";
            this.btnCam.Size = new System.Drawing.Size(210, 30);
            this.btnCam.TabIndex = 7;
            this.btnCam.Tag = "Cam";
            this.btnCam.Text = "Cam";
            // 
            // btnMyXaoHaiSan
            // 
            this.btnMyXaoHaiSan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMyXaoHaiSan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMyXaoHaiSan.Location = new System.Drawing.Point(14, 96);
            this.btnMyXaoHaiSan.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnMyXaoHaiSan.Name = "btnMyXaoHaiSan";
            this.btnMyXaoHaiSan.Size = new System.Drawing.Size(208, 30);
            this.btnMyXaoHaiSan.TabIndex = 8;
            this.btnMyXaoHaiSan.Tag = "Mỳ xào hải sản";
            this.btnMyXaoHaiSan.Text = "Mỳ xào hải sản";
            // 
            // btnCaVienChien
            // 
            this.btnCaVienChien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCaVienChien.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCaVienChien.Location = new System.Drawing.Point(236, 96);
            this.btnCaVienChien.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnCaVienChien.Name = "btnCaVienChien";
            this.btnCaVienChien.Size = new System.Drawing.Size(208, 30);
            this.btnCaVienChien.TabIndex = 9;
            this.btnCaVienChien.Tag = "Cá viên chiên";
            this.btnCaVienChien.Text = "Cá viên chiên";
            // 
            // btnPepsi
            // 
            this.btnPepsi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPepsi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPepsi.Location = new System.Drawing.Point(458, 96);
            this.btnPepsi.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnPepsi.Name = "btnPepsi";
            this.btnPepsi.Size = new System.Drawing.Size(208, 30);
            this.btnPepsi.TabIndex = 10;
            this.btnPepsi.Tag = "Pepsi";
            this.btnPepsi.Text = "Pepsi";
            // 
            // btnCafe
            // 
            this.btnCafe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCafe.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCafe.Location = new System.Drawing.Point(680, 96);
            this.btnCafe.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnCafe.Name = "btnCafe";
            this.btnCafe.Size = new System.Drawing.Size(210, 30);
            this.btnCafe.TabIndex = 11;
            this.btnCafe.Tag = "Cafe";
            this.btnCafe.Text = "Cafe";
            // 
            // btnBurgerBoNuong
            // 
            this.btnBurgerBoNuong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBurgerBoNuong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBurgerBoNuong.Location = new System.Drawing.Point(14, 138);
            this.btnBurgerBoNuong.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnBurgerBoNuong.Name = "btnBurgerBoNuong";
            this.btnBurgerBoNuong.Size = new System.Drawing.Size(208, 32);
            this.btnBurgerBoNuong.TabIndex = 12;
            this.btnBurgerBoNuong.Tag = "Burger bò nướng";
            this.btnBurgerBoNuong.Text = "Burger bò nướng";
            // 
            // btnDuiGaRan
            // 
            this.btnDuiGaRan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDuiGaRan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDuiGaRan.Location = new System.Drawing.Point(236, 138);
            this.btnDuiGaRan.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnDuiGaRan.Name = "btnDuiGaRan";
            this.btnDuiGaRan.Size = new System.Drawing.Size(208, 32);
            this.btnDuiGaRan.TabIndex = 13;
            this.btnDuiGaRan.Tag = "Đùi gà rán";
            this.btnDuiGaRan.Text = "Đùi gà rán";
            // 
            // btnBunBoHue
            // 
            this.btnBunBoHue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBunBoHue.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBunBoHue.Location = new System.Drawing.Point(458, 138);
            this.btnBunBoHue.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnBunBoHue.Name = "btnBunBoHue";
            this.btnBunBoHue.Size = new System.Drawing.Size(208, 32);
            this.btnBunBoHue.TabIndex = 14;
            this.btnBunBoHue.Tag = "Bún bò Huế";
            this.btnBunBoHue.Text = "Bún bò Huế";
            // 
            // tlpActions
            // 
            this.tlpActions.ColumnCount = 5;
            this.tlpActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 114F));
            this.tlpActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 91F));
            this.tlpActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 206F));
            this.tlpActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 114F));
            this.tlpActions.Controls.Add(this.btnXoa, 0, 0);
            this.tlpActions.Controls.Add(this.lblBan, 1, 0);
            this.tlpActions.Controls.Add(this.cmbBan, 2, 0);
            this.tlpActions.Controls.Add(this.btnOrder, 4, 0);
            this.tlpActions.Location = new System.Drawing.Point(14, 275);
            this.tlpActions.Name = "tlpActions";
            this.tlpActions.RowCount = 1;
            this.tlpActions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tlpActions.Size = new System.Drawing.Size(910, 43);
            this.tlpActions.TabIndex = 2;
            // 
            // btnXoa
            // 
            this.btnXoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnXoa.Location = new System.Drawing.Point(3, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(108, 37);
            this.btnXoa.TabIndex = 0;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // lblBan
            // 
            this.lblBan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBan.Location = new System.Drawing.Point(117, 0);
            this.lblBan.Name = "lblBan";
            this.lblBan.Size = new System.Drawing.Size(85, 43);
            this.lblBan.TabIndex = 1;
            this.lblBan.Text = "Chọn bàn:";
            this.lblBan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbBan
            // 
            this.cmbBan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbBan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBan.Location = new System.Drawing.Point(208, 3);
            this.cmbBan.Name = "cmbBan";
            this.cmbBan.Size = new System.Drawing.Size(200, 24);
            this.cmbBan.TabIndex = 2;
            // 
            // btnOrder
            // 
            this.btnOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOrder.Location = new System.Drawing.Point(799, 3);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(108, 37);
            this.btnOrder.TabIndex = 4;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // dgvDS
            // 
            this.dgvDS.AllowUserToAddRows = false;
            this.dgvDS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDS.ColumnHeadersHeight = 29;
            this.dgvDS.Location = new System.Drawing.Point(14, 324);
            this.dgvDS.Name = "dgvDS";
            this.dgvDS.RowHeadersVisible = false;
            this.dgvDS.RowHeadersWidth = 51;
            this.dgvDS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDS.Size = new System.Drawing.Size(910, 260);
            this.dgvDS.TabIndex = 3;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 597);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.grpMenu);
            this.Controls.Add(this.tlpActions);
            this.Controls.Add(this.dgvDS);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quán ăn nhanh Hưng Thịnh";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.grpMenu.ResumeLayout(false);
            this.tlpMenu.ResumeLayout(false);
            this.tlpActions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDS)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
