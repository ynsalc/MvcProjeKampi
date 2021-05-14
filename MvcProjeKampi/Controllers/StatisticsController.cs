using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;

namespace MvcProjeKampi.Controllers
{
    public class StatisticsController : Controller
    {
        StatisticManager statistic = new StatisticManager();

        [HttpGet]
        public ActionResult Index()
        {
            var categoryCount = statistic.getCount();
            ViewBag.count = categoryCount.ToString();

            var h = statistic.findTitle();
            ViewBag.titleCount = h.ToString();

            var writer = statistic.charWriter();
            ViewBag.writerCharCount = writer.ToString();

            var categoryMax = statistic.categoryName();
            ViewBag.categoryMaxValue = categoryMax;

            var fark = statistic.trueFalse();
            ViewBag.fark = fark.ToString();

            return View();
        }
    }
}