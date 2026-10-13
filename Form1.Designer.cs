namespace CourseRegistrationApp;

partial class Form1
{
    private System.ComponentModel.IContainer? components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && components is not null)
            components.Dispose();
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        pnlTieuDe = new Panel();
        lblTieuDe = new Label();
        lblMoTa = new Label();
        grpThongTinHocVien = new GroupBox();
        lblHoTen = new Label();
        txtHoTen = new TextBox();
        lblSoDienThoai = new Label();
        txtSoDienThoai = new TextBox();
        lblNgaySinh = new Label();
        dtpNgaySinh = new DateTimePicker();
        chkNhanEmail = new CheckBox();
        grpThongTinKhoaHoc = new GroupBox();
        lblKhoaHoc = new Label();
        cboKhoaHoc = new ComboBox();
        lblHinhThucHoc = new Label();
        radOnline = new RadioButton();
        radOffline = new RadioButton();
        lblSoThang = new Label();
        numSoThang = new NumericUpDown();
        lblDonGia = new Label();
        lblTongTienTieuDe = new Label();
        lblTongTien = new Label();
        btnDangKy = new Button();
        btnLamMoi = new Button();
        btnThoat = new Button();
        lblGhiChu = new Label();
        pnlTieuDe.SuspendLayout();
        grpThongTinHocVien.SuspendLayout();
        grpThongTinKhoaHoc.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)numSoThang).BeginInit();
        SuspendLayout();
        // 
        // pnlTieuDe
        // 
        pnlTieuDe.BackColor = Color.FromArgb(35, 65, 86);
        pnlTieuDe.Controls.Add(lblTieuDe);
        pnlTieuDe.Controls.Add(lblMoTa);
        pnlTieuDe.Location = new Point(0, 0);
        pnlTieuDe.Name = "pnlTieuDe";
        pnlTieuDe.Size = new Size(920, 88);
        pnlTieuDe.TabIndex = 0;
        // 
        // lblTieuDe
        // 
        lblTieuDe.AutoSize = true;
        lblTieuDe.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
        lblTieuDe.ForeColor = Color.White;
        lblTieuDe.Location = new Point(26, 12);
        lblTieuDe.Name = "lblTieuDe";
        lblTieuDe.Size = new Size(352, 41);
        lblTieuDe.TabIndex = 0;
        lblTieuDe.Text = "ĐĂNG KÝ KHÓA HỌC";
        // 
        // lblMoTa
        // 
        lblMoTa.AutoSize = true;
        lblMoTa.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
        lblMoTa.ForeColor = Color.FromArgb(222, 235, 242);
        lblMoTa.Location = new Point(30, 54);
        lblMoTa.Name = "lblMoTa";
        lblMoTa.Size = new Size(338, 21);
        lblMoTa.TabIndex = 1;
        lblMoTa.Text = "Điền thông tin bên dưới để tạo phiếu đăng ký.";
        // 
        // grpThongTinHocVien
        // 
        grpThongTinHocVien.BackColor = Color.White;
        grpThongTinHocVien.Controls.Add(lblHoTen);
        grpThongTinHocVien.Controls.Add(txtHoTen);
        grpThongTinHocVien.Controls.Add(lblSoDienThoai);
        grpThongTinHocVien.Controls.Add(txtSoDienThoai);
        grpThongTinHocVien.Controls.Add(lblNgaySinh);
        grpThongTinHocVien.Controls.Add(dtpNgaySinh);
        grpThongTinHocVien.Controls.Add(chkNhanEmail);
        grpThongTinHocVien.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
        grpThongTinHocVien.Location = new Point(24, 104);
        grpThongTinHocVien.Name = "grpThongTinHocVien";
        grpThongTinHocVien.Size = new Size(872, 174);
        grpThongTinHocVien.TabIndex = 1;
        grpThongTinHocVien.TabStop = false;
        grpThongTinHocVien.Text = "  01  |  THÔNG TIN HỌC VIÊN  ";
        // 
        // lblHoTen
        // 
        lblHoTen.AutoSize = true;
        lblHoTen.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
        lblHoTen.Location = new Point(23, 39);
        lblHoTen.Name = "lblHoTen";
        lblHoTen.Size = new Size(76, 21);
        lblHoTen.TabIndex = 0;
        lblHoTen.Text = "Họ và tên";
        // 
        // txtHoTen
        // 
        txtHoTen.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
        txtHoTen.Location = new Point(158, 35);
        txtHoTen.Name = "txtHoTen";
        txtHoTen.PlaceholderText = "Nhập họ tên học viên";
        txtHoTen.Size = new Size(682, 30);
        txtHoTen.TabIndex = 1;
        // 
        // lblSoDienThoai
        // 
        lblSoDienThoai.AutoSize = true;
        lblSoDienThoai.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
        lblSoDienThoai.Location = new Point(23, 83);
        lblSoDienThoai.Name = "lblSoDienThoai";
        lblSoDienThoai.Size = new Size(96, 21);
        lblSoDienThoai.TabIndex = 2;
        lblSoDienThoai.Text = "Số điện thoại";
        // 
        // txtSoDienThoai
        // 
        txtSoDienThoai.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
        txtSoDienThoai.Location = new Point(158, 79);
        txtSoDienThoai.Name = "txtSoDienThoai";
        txtSoDienThoai.PlaceholderText = "Ví dụ: 09xxxxxxxx";
        txtSoDienThoai.Size = new Size(280, 30);
        txtSoDienThoai.TabIndex = 2;
        // 
        // lblNgaySinh
        // 
        lblNgaySinh.AutoSize = true;
        lblNgaySinh.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
        lblNgaySinh.Location = new Point(473, 83);
        lblNgaySinh.Name = "lblNgaySinh";
        lblNgaySinh.Size = new Size(72, 21);
        lblNgaySinh.TabIndex = 3;
        lblNgaySinh.Text = "Ngày sinh";
        // 
        // dtpNgaySinh
        // 
        dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
        dtpNgaySinh.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
        dtpNgaySinh.Format = DateTimePickerFormat.Custom;
        dtpNgaySinh.Location = new Point(572, 79);
        dtpNgaySinh.Name = "dtpNgaySinh";
        dtpNgaySinh.Size = new Size(268, 30);
        dtpNgaySinh.TabIndex = 3;
        // 
        // chkNhanEmail
        // 
        chkNhanEmail.AutoSize = true;
        chkNhanEmail.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
        chkNhanEmail.Location = new Point(158, 122);
        chkNhanEmail.Name = "chkNhanEmail";
        chkNhanEmail.Size = new Size(184, 25);
        chkNhanEmail.TabIndex = 4;
        chkNhanEmail.Text = "Nhận email thông báo";
        chkNhanEmail.UseVisualStyleBackColor = false;
        // 
        // grpThongTinKhoaHoc
        // 
        grpThongTinKhoaHoc.BackColor = Color.White;
        grpThongTinKhoaHoc.Controls.Add(lblKhoaHoc);
        grpThongTinKhoaHoc.Controls.Add(cboKhoaHoc);
        grpThongTinKhoaHoc.Controls.Add(lblHinhThucHoc);
        grpThongTinKhoaHoc.Controls.Add(radOnline);
        grpThongTinKhoaHoc.Controls.Add(radOffline);
        grpThongTinKhoaHoc.Controls.Add(lblSoThang);
        grpThongTinKhoaHoc.Controls.Add(numSoThang);
        grpThongTinKhoaHoc.Controls.Add(lblDonGia);
        grpThongTinKhoaHoc.Controls.Add(lblTongTienTieuDe);
        grpThongTinKhoaHoc.Controls.Add(lblTongTien);
        grpThongTinKhoaHoc.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
        grpThongTinKhoaHoc.Location = new Point(24, 292);
        grpThongTinKhoaHoc.Name = "grpThongTinKhoaHoc";
        grpThongTinKhoaHoc.Size = new Size(872, 248);
        grpThongTinKhoaHoc.TabIndex = 2;
        grpThongTinKhoaHoc.TabStop = false;
        grpThongTinKhoaHoc.Text = "  02  |  THÔNG TIN KHÓA HỌC  ";
        // 
        // lblKhoaHoc
        // 
        lblKhoaHoc.AutoSize = true;
        lblKhoaHoc.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
        lblKhoaHoc.Location = new Point(23, 41);
        lblKhoaHoc.Name = "lblKhoaHoc";
        lblKhoaHoc.Size = new Size(73, 21);
        lblKhoaHoc.TabIndex = 0;
        lblKhoaHoc.Text = "Khóa học";
        // 
        // cboKhoaHoc
        // 
        cboKhoaHoc.DropDownStyle = ComboBoxStyle.DropDownList;
        cboKhoaHoc.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
        cboKhoaHoc.FormattingEnabled = true;
        cboKhoaHoc.Location = new Point(158, 37);
        cboKhoaHoc.Name = "cboKhoaHoc";
        cboKhoaHoc.Size = new Size(682, 31);
        cboKhoaHoc.TabIndex = 5;
        cboKhoaHoc.SelectedIndexChanged += cboKhoaHoc_SelectedIndexChanged;
        // 
        // lblHinhThucHoc
        // 
        lblHinhThucHoc.AutoSize = true;
        lblHinhThucHoc.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
        lblHinhThucHoc.Location = new Point(23, 91);
        lblHinhThucHoc.Name = "lblHinhThucHoc";
        lblHinhThucHoc.Size = new Size(99, 21);
        lblHinhThucHoc.TabIndex = 2;
        lblHinhThucHoc.Text = "Hình thức học";
        // 
        // radOnline
        // 
        radOnline.AutoSize = true;
        radOnline.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
        radOnline.Location = new Point(158, 89);
        radOnline.Name = "radOnline";
        radOnline.Size = new Size(75, 25);
        radOnline.TabIndex = 6;
        radOnline.TabStop = true;
        radOnline.Text = "Online";
        radOnline.UseVisualStyleBackColor = false;
        // 
        // radOffline
        // 
        radOffline.AutoSize = true;
        radOffline.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
        radOffline.Location = new Point(267, 89);
        radOffline.Name = "radOffline";
        radOffline.Size = new Size(153, 25);
        radOffline.TabIndex = 7;
        radOffline.Text = "Trực tiếp (Offline)";
        radOffline.UseVisualStyleBackColor = false;
        // 
        // lblSoThang
        // 
        lblSoThang.AutoSize = true;
        lblSoThang.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
        lblSoThang.Location = new Point(23, 141);
        lblSoThang.Name = "lblSoThang";
        lblSoThang.Size = new Size(129, 21);
        lblSoThang.TabIndex = 4;
        lblSoThang.Text = "Số tháng đăng ký";
        // 
        // numSoThang
        // 
        numSoThang.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
        numSoThang.Location = new Point(158, 137);
        numSoThang.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
        numSoThang.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        numSoThang.Name = "numSoThang";
        numSoThang.Size = new Size(100, 30);
        numSoThang.TabIndex = 8;
        numSoThang.Value = new decimal(new int[] { 1, 0, 0, 0 });
        numSoThang.ValueChanged += numSoThang_ValueChanged;
        // 
        // lblDonGia
        // 
        lblDonGia.AutoSize = true;
        lblDonGia.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
        lblDonGia.ForeColor = Color.FromArgb(75, 87, 96);
        lblDonGia.Location = new Point(398, 142);
        lblDonGia.Name = "lblDonGia";
        lblDonGia.Size = new Size(179, 21);
        lblDonGia.TabIndex = 9;
        lblDonGia.Text = "Học phí/tháng: 800.000 VNĐ";
        // 
        // lblTongTienTieuDe
        // 
        lblTongTienTieuDe.AutoSize = true;
        lblTongTienTieuDe.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
        lblTongTienTieuDe.ForeColor = Color.FromArgb(35, 65, 86);
        lblTongTienTieuDe.Location = new Point(23, 194);
        lblTongTienTieuDe.Name = "lblTongTienTieuDe";
        lblTongTienTieuDe.Size = new Size(123, 23);
        lblTongTienTieuDe.TabIndex = 10;
        lblTongTienTieuDe.Text = "TỔNG HỌC PHÍ";
        // 
        // lblTongTien
        // 
        lblTongTien.AutoSize = true;
        lblTongTien.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
        lblTongTien.ForeColor = Color.FromArgb(0, 112, 106);
        lblTongTien.Location = new Point(158, 187);
        lblTongTien.Name = "lblTongTien";
        lblTongTien.Size = new Size(141, 35);
        lblTongTien.TabIndex = 11;
        lblTongTien.Text = "800.000 VNĐ";
        // 
        // btnDangKy
        // 
        btnDangKy.BackColor = Color.FromArgb(0, 112, 106);
        btnDangKy.FlatAppearance.BorderSize = 0;
        btnDangKy.FlatStyle = FlatStyle.Flat;
        btnDangKy.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
        btnDangKy.ForeColor = Color.White;
        btnDangKy.Location = new Point(279, 557);
        btnDangKy.Name = "btnDangKy";
        btnDangKy.Size = new Size(150, 43);
        btnDangKy.TabIndex = 9;
        btnDangKy.Text = "Đăng ký";
        btnDangKy.UseVisualStyleBackColor = false;
        btnDangKy.Click += btnDangKy_Click;
        // 
        // btnLamMoi
        // 
        btnLamMoi.BackColor = Color.FromArgb(226, 235, 240);
        btnLamMoi.FlatAppearance.BorderSize = 0;
        btnLamMoi.FlatStyle = FlatStyle.Flat;
        btnLamMoi.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
        btnLamMoi.ForeColor = Color.FromArgb(35, 65, 86);
        btnLamMoi.Location = new Point(443, 557);
        btnLamMoi.Name = "btnLamMoi";
        btnLamMoi.Size = new Size(150, 43);
        btnLamMoi.TabIndex = 10;
        btnLamMoi.Text = "Làm mới";
        btnLamMoi.UseVisualStyleBackColor = false;
        btnLamMoi.Click += btnLamMoi_Click;
        // 
        // btnThoat
        // 
        btnThoat.BackColor = Color.FromArgb(255, 255, 255);
        btnThoat.FlatAppearance.BorderColor = Color.FromArgb(177, 190, 199);
        btnThoat.FlatStyle = FlatStyle.Flat;
        btnThoat.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
        btnThoat.ForeColor = Color.FromArgb(65, 76, 84);
        btnThoat.Location = new Point(607, 557);
        btnThoat.Name = "btnThoat";
        btnThoat.Size = new Size(150, 43);
        btnThoat.TabIndex = 11;
        btnThoat.Text = "Thoát";
        btnThoat.UseVisualStyleBackColor = false;
        btnThoat.Click += btnThoat_Click;
        // 
        // lblGhiChu
        // 
        lblGhiChu.AutoSize = true;
        lblGhiChu.ForeColor = Color.FromArgb(100, 113, 122);
        lblGhiChu.Location = new Point(26, 615);
        lblGhiChu.Name = "lblGhiChu";
        lblGhiChu.Size = new Size(422, 20);
        lblGhiChu.TabIndex = 12;
        lblGhiChu.Text = "* Học phí được tính tự động theo khóa học và thời gian đăng ký.";
        // 
        // Form1
        // 
        AcceptButton = btnDangKy;
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(241, 245, 248);
        ClientSize = new Size(920, 650);
        Controls.Add(lblGhiChu);
        Controls.Add(btnThoat);
        Controls.Add(btnLamMoi);
        Controls.Add(btnDangKy);
        Controls.Add(grpThongTinKhoaHoc);
        Controls.Add(grpThongTinHocVien);
        Controls.Add(pnlTieuDe);
        Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Đăng ký khóa học";
        Load += Form1_Load;
        pnlTieuDe.ResumeLayout(false);
        pnlTieuDe.PerformLayout();
        grpThongTinHocVien.ResumeLayout(false);
        grpThongTinHocVien.PerformLayout();
        grpThongTinKhoaHoc.ResumeLayout(false);
        grpThongTinKhoaHoc.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)numSoThang).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Panel pnlTieuDe;
    private Label lblTieuDe;
    private Label lblMoTa;
    private GroupBox grpThongTinHocVien;
    private Label lblHoTen;
    private TextBox txtHoTen;
    private Label lblSoDienThoai;
    private TextBox txtSoDienThoai;
    private Label lblNgaySinh;
    private DateTimePicker dtpNgaySinh;
    private CheckBox chkNhanEmail;
    private GroupBox grpThongTinKhoaHoc;
    private Label lblKhoaHoc;
    private ComboBox cboKhoaHoc;
    private Label lblHinhThucHoc;
    private RadioButton radOnline;
    private RadioButton radOffline;
    private Label lblSoThang;
    private NumericUpDown numSoThang;
    private Label lblDonGia;
    private Label lblTongTienTieuDe;
    private Label lblTongTien;
    private Button btnDangKy;
    private Button btnLamMoi;
    private Button btnThoat;
    private Label lblGhiChu;
}
