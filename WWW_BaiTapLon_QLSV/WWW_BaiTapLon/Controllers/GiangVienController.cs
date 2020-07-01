using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EntityFrameWork_BaiTapLon;
using Services_BaiTapLon;
using EntityFrameWork_BaiTapLon.Entities_BaiTapLon;
using EntityFrameWork_BaiTapLon.DataAcces;
using WWW_BaiTapLon;

namespace WWW_BaiTapLon.Controllers
{
    public class GiangVienController : Controller
    {
        public ActionResult GiangVien()
        {
            GiangVienService giangVienService = new GiangVienService();
            return View(giangVienService.getById(2));
        }
        public ActionResult getDanhsachMonHoc()
        {
            MonHocService mh = new MonHocService();
            var list = mh.GetAll();
            return View(list);
        }
        public ActionResult DanhSachMonHoc()
        {
            List<MonHoc> list = new List<MonHoc>();
            MonHocService mh = new MonHocService();
            foreach (var item in mh.GetAll())
            {
                var DataMonHoc = new MonHoc();
                DataMonHoc = item;
                list.Add(DataMonHoc);
            }
            return PartialView(list);
        }

        public JsonResult getDanhSachLopHocPhan()
        {
            LopHocPhanService sc = new LopHocPhanService();
            List<LopHocPhan> lst = new List<LopHocPhan>();
            lst = sc.GetLopHocPhanByGV(2);
            return Json(lst, JsonRequestBehavior.AllowGet);
        }
        public JsonResult GetDanhSachSinhVien(int id)
        {
            SinhVienService sc = new SinhVienService();
            List<SinhVien> lst = new List<SinhVien>();
            lst = sc.GetSVByMaLopHP(id);
            return Json(lst, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Upload()
        {
            return View();
        }
        public JsonResult NhapDiem()
        {
            IEnumerable<KetQuaHocTap> lst = new List<KetQuaHocTap>();
            KetQuaHocTapService sc = new KetQuaHocTapService();
            lst = sc.GetAll();
            return Json(lst, JsonRequestBehavior.AllowGet);
        }
    }
}