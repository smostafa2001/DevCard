using DevCard.MVC.Data;
using DevCard.MVC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DevCard.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly List<Service> services = new List<Service>
        {
            new Service(1,"نقره ای"),
            new Service(2,"طلایی"),
            new Service(3,"پلاتین"),
            new Service(4,"الماس"),
        };
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ProjectDetails(long id)
        {
            Project project = ProjectStore.GetProjectBy(id);
            return View(project??new Project(long.MinValue, "", "","",""));
        }

        [HttpGet]
        public IActionResult Contact()
        {
            var model = new Contact
            {
                Services = new SelectList(services, "Id", "Name")
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult Contact(Contact model)
        {
            model.Services = new SelectList(services, "Id", "Name");
            if (!ModelState.IsValid)
            {
                ViewBag.Error = "اطلاعات وارد شده صحیح نیست، لطفا دوباره تلاش کنید";
                return View(model);
            }
            ModelState.Clear();
            model = new Contact
            {
                Services = new SelectList(services, "Id", "Name")
            };
            ViewBag.Success = "پیغام شما با موفقیت ارسال شد. با تشکر";
            return View(model);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
