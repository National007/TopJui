using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TopJUI_Demo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Iframe()
        {
            return View();
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }
        public ActionResult TableDemo()
        {
            return View();
        }

        public ActionResult List() {
            var list = new List<User>
            {
                new User() {Name="詹宝华",Sex="男",Age=23 },
                new User() {Name="测试",Sex="未知",Age=99 },
                new User() {Name="演示",Sex="女" },
            };
            return Json(new {rows= list,total=list.Count },JsonRequestBehavior.AllowGet);

        }


    }

    public class User
    {
        public User() {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public int Age { get; set; }
    }
}