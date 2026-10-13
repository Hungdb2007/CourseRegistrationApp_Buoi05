using System.Globalization;
using System.Text;

namespace CourseRegistrationApp;

public partial class Form1 : Form
{
    private readonly CultureInfo _viVN = CultureInfo.GetCultureInfo("vi-VN");

    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object? sender, EventArgs e)
    {
        NapDanhSachKhoaHoc();

        dtpNgaySinh.MaxDate = DateTime.Today;
        numSoThang.Minimum = 1;
        numSoThang.Maximum = 12;
        numSoThang.Value = 1;
        radOnline.Checked = true;

        CapNhatHocPhi();
        txtHoTen.Focus();
    }

    private void NapDanhSachKhoaHoc()
    {
        // Học phí được giữ trong danh sách để dễ thay đổi khi cần.
        var cacKhoaHoc = new List<KhoaHoc>
        {
            new("C# WinForms cơ bản", 800_000m),
            new("SQL Server cơ bản", 700_000m),
            new("Web Frontend cơ bản", 750_000m),
            new("Lập trình Python cơ bản", 650_000m)
        };

        cboKhoaHoc.DataSource = cacKhoaHoc;
        cboKhoaHoc.DisplayMember = nameof(KhoaHoc.TenKhoaHoc);
        if (cboKhoaHoc.Items.Count > 0)
            cboKhoaHoc.SelectedIndex = 0;
    }

    private void cboKhoaHoc_SelectedIndexChanged(object? sender, EventArgs e)
    {
        CapNhatHocPhi();
    }

    private void numSoThang_ValueChanged(object? sender, EventArgs e)
    {
        CapNhatHocPhi();
    }

    private void CapNhatHocPhi()
    {
        if (cboKhoaHoc.SelectedItem is not KhoaHoc khoaHoc)
        {
            lblDonGia.Text = "Học phí/tháng: --";
            lblTongTien.Text = "0 VNĐ";
            return;
        }

        decimal donGia = khoaHoc.HocPhiThang;
        decimal tongTien = donGia * numSoThang.Value;

        lblDonGia.Text = $"Học phí/tháng: {DinhDangTien(donGia)} VNĐ";
        lblTongTien.Text = $"{DinhDangTien(tongTien)} VNĐ";
    }

    private void btnDangKy_Click(object? sender, EventArgs e)
    {
        if (!KiemTraThongTin())
            return;

        KhoaHoc khoaHoc = (KhoaHoc)cboKhoaHoc.SelectedItem!;
        string hinhThuc = radOnline.Checked ? "Online" : "Trực tiếp (Offline)";
        decimal tongTien = khoaHoc.HocPhiThang * numSoThang.Value;

        string phieu = TaoPhieuDangKy(
            txtHoTen.Text.Trim(),
            txtSoDienThoai.Text.Trim(),
            dtpNgaySinh.Value,
            khoaHoc,
            hinhThuc,
            (int)numSoThang.Value,
            tongTien,
            chkNhanEmail.Checked);

        MessageBox.Show(phieu, "Phiếu đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private bool KiemTraThongTin()
    {
        if (string.IsNullOrWhiteSpace(txtHoTen.Text))
        {
            BaoLoi("Bạn chưa nhập họ tên học viên.", txtHoTen);
            return false;
        }

        if (string.IsNullOrWhiteSpace(txtSoDienThoai.Text))
        {
            BaoLoi("Bạn chưa nhập số điện thoại.", txtSoDienThoai);
            return false;
        }

        if (cboKhoaHoc.SelectedItem is not KhoaHoc)
        {
            BaoLoi("Bạn hãy chọn một khóa học.", cboKhoaHoc);
            return false;
        }

        return true;
    }

    private static void BaoLoi(string noiDung, Control controlCanNhap)
    {
        MessageBox.Show(noiDung, "Chưa đủ thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        controlCanNhap.Focus();
    }

    private string TaoPhieuDangKy(
        string hoTen,
        string soDienThoai,
        DateTime ngaySinh,
        KhoaHoc khoaHoc,
        string hinhThuc,
        int soThang,
        decimal tongTien,
        bool nhanEmail)
    {
        var sb = new StringBuilder();
        sb.AppendLine("THÔNG TIN ĐĂNG KÝ KHÓA HỌC");
        sb.AppendLine(new string('─', 34));
        sb.AppendLine($"Họ tên học viên : {hoTen}");
        sb.AppendLine($"Số điện thoại   : {soDienThoai}");
        sb.AppendLine($"Ngày sinh       : {ngaySinh:dd/MM/yyyy}");
        sb.AppendLine($"Khóa học        : {khoaHoc.TenKhoaHoc}");
        sb.AppendLine($"Hình thức       : {hinhThuc}");
        sb.AppendLine($"Thời gian       : {soThang} tháng");
        sb.AppendLine($"Học phí/tháng   : {DinhDangTien(khoaHoc.HocPhiThang)} VNĐ");
        sb.AppendLine($"TỔNG HỌC PHÍ    : {DinhDangTien(tongTien)} VNĐ");
        sb.Append($"Nhận email      : {(nhanEmail ? "Có" : "Không")}");
        return sb.ToString();
    }

    private string DinhDangTien(decimal soTien)
    {
        return soTien.ToString("N0", _viVN);
    }

    private void btnLamMoi_Click(object? sender, EventArgs e)
    {
        txtHoTen.Clear();
        txtSoDienThoai.Clear();
        dtpNgaySinh.Value = DateTime.Today;
        chkNhanEmail.Checked = false;

        if (cboKhoaHoc.Items.Count > 0)
            cboKhoaHoc.SelectedIndex = 0;

        radOnline.Checked = true;
        numSoThang.Value = 1;
        CapNhatHocPhi();
        txtHoTen.Focus();
    }

    private void btnThoat_Click(object? sender, EventArgs e)
    {
        DialogResult luaChon = MessageBox.Show(
            "Bạn có muốn kết thúc phiên đăng ký hiện tại không?",
            "Xác nhận đóng chương trình",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button2);

        if (luaChon == DialogResult.Yes)
            Close();
    }
}
