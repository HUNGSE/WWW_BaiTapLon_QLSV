using EntityFrameWork_BaiTapLon.Entities_BaiTapLon;
using Services_BaiTapLon;
using System.Collections.Generic;
using System.Web.Mvc;
using WWW_BaiTapLon.Models;

namespace WWW_BaiTapLon.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            //var diem = new KetQuaHocTap();
            //diem.LoaiDiem = (int)LoaiDiemEnum.CuoiKy;
            //var gt = new SinhVien();
            //gt.Gioitinh = (GioitinhEnum.Khac).ToString();
            //return View();
            DiemDanhService a = new DiemDanhService();
            SinhVienService b = new SinhVienService();
            LopHocPhanService c = new LopHocPhanService();
            List<EntityFrameWork_BaiTapLon.Entities_BaiTapLon.DiemDanh> lst = new List<EntityFrameWork_BaiTapLon.Entities_BaiTapLon.DiemDanh>();
            foreach (var item in a.GetbyIDSV(1,1))
            {
                EntityFrameWork_BaiTapLon.Entities_BaiTapLon.DiemDanh m = new EntityFrameWork_BaiTapLon.Entities_BaiTapLon.DiemDanh();
                m = item;
                lst.Add(m);
            }
            ViewBag.ten = b.getById(1).tenSinhVien;
            ViewBag.mon = c.getById(1).tenLopHocPhan;
            return View(lst);
        }
    }
}