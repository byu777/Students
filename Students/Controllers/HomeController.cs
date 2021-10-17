using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Students.Models;

namespace Students.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(Models.Students.getStudents());
        }
    }
}
