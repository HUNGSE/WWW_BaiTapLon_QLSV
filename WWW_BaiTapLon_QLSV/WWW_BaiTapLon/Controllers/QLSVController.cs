
using Services_BaiTapLon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WWW_BaiTapLon.Models;

namespace WWW_BaiTapLon.Controllers
{
    public class QLSVController : Controller
    {
        // GET: QLSV
        public ActionResult Index()
        {
            GiangVienService a = new GiangVienService();
                Session["dsgv"] = a.GetAll();
            return View(a.GetAll());
        }
    }
}