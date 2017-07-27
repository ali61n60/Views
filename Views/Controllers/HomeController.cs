using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Views.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return  View(new string[] { "<i>Apple</i>", "Orange", "Pear" });
        }

        public ViewResult List() => View();
    }
}
