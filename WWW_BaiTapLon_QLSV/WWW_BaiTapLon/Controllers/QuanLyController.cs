using EntityFrameWork_BaiTapLon.Entities_BaiTapLon;
using Services_BaiTapLon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static ComMon_BaiTapLon.EnumsHelper;

namespace WWW_BaiTapLon.Controllers
{
    public class QuanLyController : Controller
    {
        public ActionResult LopHocPhan()
        {
            MonHocService mh = new MonHocService();
            var list = mh.GetAll();
            return View(list);
        }
        public ActionResult SinhVien()
        {
            SinhVienService sinhVienService = new SinhVienService();
            return View(sinhVienService.GetAll());
        }
        public ActionResult Them()
        {
            List<LopHocPhanService> lopHocPhanServices = new List<LopHocPhanService>();
            return View();
        }
        public JsonResult AddLHP(int idMon)
        {
            LopHocPhanService lopHocPhanService = new LopHocPhanService();
            LopHocPhan lopHocPhan = new LopHocPhan();
            lopHocPhan.MonHocId= 1;
            lopHocPhan.GiangVienid = 3;
            lopHocPhan.tenLopHocPhan = "WWW";
            lopHocPhan.soLuongSV = 12;
            lopHocPhan.TrangThai = TrangThaiLHP.Chap_Nhan_Mo_Lop;
            lopHocPhan.Mota = "";
            lopHocPhan.NgayBD = Convert.ToDateTime("10/11/1998");
            lopHocPhan.NgayKT = Convert.ToDateTime("10/1/2000");
            lopHocPhan.NgayKTDK= Convert.ToDateTime("6/1/2000");
            lopHocPhan.Hockyid = 1;
            lopHocPhan = lopHocPhanService.Add(lopHocPhan);
            var res = Json(lopHocPhanService, JsonRequestBehavior.AllowGet);
            return res;
        }
        public ActionResult CapNhat()
        {
            return View();
        }

        
    }

}