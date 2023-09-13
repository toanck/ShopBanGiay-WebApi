using AppData.IRepositories;
using AppData.Repositories;
using BanGiayTheThao.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AppC5API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GioHangController : ControllerBase
    {
        private readonly IAllRepositories<GioHang> irepos;

        GiayDBcontext context =
            new GiayDBcontext();

        public GioHangController()
        {
            irepos = new AllRepositories<GioHang>(context, context.GioHangs);
        }

        // GET: api/<GioHangController>
        [HttpGet("get-all-GioHang")]
        public IEnumerable<GioHang> GetAllGioHang()
        {
            return irepos.GetAll();
        }

        // GET api/<GioHangController>/5
        [HttpPost("create-GioHang")]
        public bool CreateGioHang(Guid idNguoiIDung, string mota)
        {
            GioHang GioHang = new GioHang();
            GioHang.IdGioHang = Guid.NewGuid();
            GioHang.IdNguoiDung = idNguoiIDung;
            GioHang.MoTa = mota;
            return irepos.CreateItem(GioHang);
        }

        // PUT api/<GioHangController>/5
        [HttpPost("update-GioHang{id}")]
        public bool UpdateGioHang(Guid id, Guid idNguoiDung, string mota)
        {
            GioHang GioHang = new GioHang()
            {
                IdGioHang = id,
                IdNguoiDung = idNguoiDung,
                MoTa = mota,
            };
            return irepos.UpdateItem(GioHang);
        }

        // DELETE api/<GioHangController>/5
        [HttpDelete("delete-GioHang{id}")]
        public bool DeleteGioHang(Guid id)
        {
            GioHang GioHang = new GioHang()
            {
                IdGioHang = id,
            };
            return irepos.DeleteItem(GioHang);
        }

    }
}