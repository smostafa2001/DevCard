using DevCard.MVC.Data;
using Microsoft.AspNetCore.Mvc;

namespace DevCard.MVC.ViewComponents
{
    public class ProjectsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(string name)
        {
            var projects = ProjectStore.GetProjects();
            return View("_Projects", projects);
        }
    }
}
