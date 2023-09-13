namespace BanGiayTheThao.Models
{
    public class ChucVu
    {
        public Guid IdChucVu { get; set; }
        public string? TenCV { get; set; }
        public int? TrangThai { get; set; }

        public virtual List<NguoiDung> NguoiDung { get; set; }

    }
}
