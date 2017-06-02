using log4net.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LogAnalyserTest.Controllers
{
    public class HomeController : Controller
    {
        private static log4net.ILog log;

        static HomeController()
        {
            log = log4net.LogManager.GetLogger("default_logger");
            //log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);            
            XmlConfigurator.Configure();
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            try
            {
                string s = null;
                s.ToString();

                ViewBag.Message = "Your application description page.";
            }
            catch(Exception ex)
            {
                log.Error(ex);
            }

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            log.Error("Custom error");
            log.Info("Custom info");
            log.Warn("custom warning");

            return View();
        }
    }
}