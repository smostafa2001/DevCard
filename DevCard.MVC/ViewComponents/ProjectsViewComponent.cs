using DevCard.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DevCard.MVC.ViewComponents
{
    public class ProjectsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(string name)
        {
            var projects = new List<Project>
            {
                new Project(1, "تاکسی", "درخواست آنلاین تاکسی برای سفرهای درون شهری", "project-1.jpg", "Atriya"),
                new Project(2, "زودفود", "درخواست آنلاین غذا برای سراسر کشور", "project-2.jpg", "ZoodFood"),
                new Project(3, "مدارس", "سیستم مدیریت یکپارچه مدارس", "project-3.jpg", "MONOP"),
                new Project(4, "فضاپیما", "برنامه مدیریت فضاپیما های ناسا", "project-4.jpg", "NASA")
            };
            return View("_Projects", projects);
        }
    }
}
