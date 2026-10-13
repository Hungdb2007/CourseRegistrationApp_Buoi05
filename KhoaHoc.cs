namespace CourseRegistrationApp;

// Lưu tên khóa học và học phí cho một tháng học.
public class KhoaHoc
{
    public string TenKhoaHoc { get; }
    public decimal HocPhiThang { get; }

    public KhoaHoc(string tenKhoaHoc, decimal hocPhiThang)
    {
        TenKhoaHoc = tenKhoaHoc;
        HocPhiThang = hocPhiThang;
    }
}
