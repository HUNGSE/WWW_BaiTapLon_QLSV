using EntityFrameWork_BaiTapLon.Entities_BaiTapLon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static ComMon_BaiTapLon.EnumsHelper;

namespace WWW_BaiTapLon.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var diem = new KetQuaHocTap();
           // diem.LoaiDiem = (int)LoaiDiemEnum.CuoiKy;
            var gt = new SinhVien();
            gt.Gioitinh = (GioitinhEnum.Khac);
            return View();
        }
    }
}