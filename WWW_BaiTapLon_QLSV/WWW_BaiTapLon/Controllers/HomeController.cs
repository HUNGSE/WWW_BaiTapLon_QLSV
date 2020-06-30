using EntityFrameWork_BaiTapLon.Entities_BaiTapLon;
using Services_BaiTapLon;
using System;
using System.Collections.Generic;
using System.Web.Mvc;
using WWW_BaiTapLon.Models;
using static ComMon_BaiTapLon.EnumsHelper;

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

            EntityFrameWork_BaiTapLon.Entities_BaiTapLon.DiemDanh aa = new EntityFrameWork_BaiTapLon.Entities_BaiTapLon.DiemDanh(); aa.kqhtID = 1; aa.tragthai = (TrangThaiDD)1; aa.ngayDD = DateTime.Parse("03-01-2020");
            a.Add(aa);
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