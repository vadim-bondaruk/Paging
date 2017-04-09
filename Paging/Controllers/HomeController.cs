using Paging.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Paging.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index(int id=1)
        {
            var pageInfo = new PageInfo { PageNumber = id, PageSize = 10, TotalItems = 103 };
            return View(pageInfo);
        }
    }
}