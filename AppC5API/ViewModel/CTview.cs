using BanGiayTheThao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppC5Data.ViewModel
{
	internal class CTview
	{
		public IEnumerable<SanPham> sanPhams { get; set;}
		public IEnumerable<NSX> Nsxes { get; set; } 
		public IEnumerable<ChatLieu> ChatLieus { get; set; }
		public IEnumerable<Mau> mau;
		public IEnumerable<PhanLoaiSP> PhanLoaiSps { get; set; }
        public IEnumerable<Size> Sizes { get; set; }
        public IEnumerable<Anh> Anhs { get; set; }
		public string tenSp { get; set; }
		public Guid IdSanPham { get; set; }
		public string? MaSanPham { get; set; }
		public string? TenSanPham { get; set; }

		public double? GiaBan { get; set; }
		public double? GiaNhap { get; set; }
		public double? ChieuCaoDeGiay { get; set; }
		public string? MoTa { get; set; }
		public string? AnhDaidien { get; set; }
		public int? TrangThaiSp { get; set; }

	}
}
