using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SachOnlineLab01.Models;

namespace SachOnlineLab01.Controllers
{
    public class HomeController : Controller
    {
        private SachOnlineEntities db = new SachOnlineEntities();
        public ActionResult Index()
        {
            var sACHes = db.SACHes.OrderByDescending(s => s.NgayCapNhat).Take(6);
            return View(sACHes.ToList());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult ChuDePartial()
        {
            var listChuDe = db.CHUDEs.ToList();
            return PartialView(listChuDe);
        }

        public ActionResult NhaXuatBanPartial()
        {
            var listNXB = db.NHAXUATBANs.ToList();
            return PartialView(listNXB);
        }
        public ActionResult SachBanNhieuPartial()
        {
            return PartialView();
        }
    }
}