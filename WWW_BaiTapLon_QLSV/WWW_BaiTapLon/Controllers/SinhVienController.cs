using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WWW_BaiTapLon.Models;
using Services_BaiTapLon;
using EntityFrameWork_BaiTapLon.Entities_BaiTapLon;
using EntityFrameWork_BaiTapLon.DataAcces;


namespace WWW_BaiTapLon.Controllers
{
    public class SinhVienController : Controller
    {
        // GET: SinhVien
        public ActionResult SinhVien()
        {
            SinhVienService sv = new SinhVienService();
            var list = sv.getById(1);
            return View(sv.getById(3));
        }

        public ActionResult DangKyHocPhan()
        {
            List<MonHoc> list = new List<MonHoc>();
            MonHocService mh = new MonHocService();
            KetQuaHocTapService ketQuaHocTap = new KetQuaHocTapService();
            LopHocPhanService lopHocPhanService = new LopHocPhanService();
            QLSVDatabaseContext db = new QLSVDatabaseContext();
            List<KetQuaHocTap> a = db.KetQuaHocTaps.Where(x => x.SinhVienId == 2).ToList();
            if (a.Count == 0)
            {
                return PartialView(mh.GetAll());
            }
            foreach (var item in a)
            {
                foreach (var y in mh.GetAll())
                {
                    if (y.MonhocId != lopHocPhanService.getById(item.LopHocPhanId).MonHocId)
                    {
                        var DataMonHoc = new MonHoc();
                        DataMonHoc = y;
                        list.Add(DataMonHoc);
                    }
                }
            }
            return PartialView(list);
        }
        public ActionResult KetQuaHocTap()
        {
            LopHocPhanService hocPhanService = new LopHocPhanService();
            KetQuaHocTapService kqs = new KetQuaHocTapService();
            List<KQHT> l = new List<KQHT>();
            foreach (var item in kqs.GetAll())
            {

                KQHT kq = new KQHT();
                kq.kqhtid = item.kqhtID;
                kq.lophpid = item.LopHocPhanId;
                kq.svid = item.SinhVienId;
                kq.tk = item.ThuongKy;
                kq.gk = item.GiuaKy;
                kq.ck = item.CuoiKy;

                kq.tenlhp = hocPhanService.getById(item.LopHocPhanId).tenLopHocPhan;
                l.Add(kq);
            }
            return PartialView(l);
        }

        public JsonResult getDangKyHocPhan(int id)
        {
            LopHocPhanService lopHocPhan = new LopHocPhanService();
            KetQuaHocTapService kqhtsev = new KetQuaHocTapService();
            List<LopHocPhan> lopHocPhans = lopHocPhan.GetLopHocPhansByID(id).ToList();
            List<LopHocPhan_soluong> lsl = new List<LopHocPhan_soluong>();
            foreach (var item in lopHocPhans)
            {
                LopHocPhan_soluong x = new LopHocPhan_soluong();
                x.malophp = item.LopHocPhanId;
                x.sisotoida = item.soLuongSV;
                x.tenlophp = item.tenLopHocPhan;
                if (item.TrangThai.Equals("1"))
                {
                    x.trangthai = "Chờ sinh viên đăng kí";
                }
                else
                {
                    if (item.TrangThai.Equals("2"))
                    {
                        x.trangthai = "Chấp nhận mở lớp";
                    }
                    else
                        x.trangthai = "Chờ hủy lớp";
                }

                x.sisohientai = kqhtsev.getSLSVDK(item.LopHocPhanId);
                lsl.Add(x);
            }
            var res = Json(lsl, JsonRequestBehavior.AllowGet);
            return res;
        }
        public ActionResult getDangKy(int idlhp, int idsv)
        {
            KetQuaHocTapService kqhtsv = new KetQuaHocTapService();
            KetQuaHocTap kq = new KetQuaHocTap();
            kq.LopHocPhanId = idlhp;
            kq.SinhVienId = 1;
            kq = kqhtsv.Add(kq);
            if (kq == null)
                return View();
            var result = Json(kq, JsonRequestBehavior.AllowGet);
            return result;
        }
    }
}