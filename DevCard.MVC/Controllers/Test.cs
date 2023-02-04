using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Net.Mime;

namespace DevCard.MVC.Controllers
{
    public class Test : Controller
    {
        //public IActionResult Index()
        //{
        //	return PartialView("Footer");
        //}

        //public PartialViewResult Index()
        //{
        //	return PartialView("Footer");
        //}

        //public ContentResult Index()
        //{
        //    //return Content("<h1>Hello Asp.Net Core MVC Students<h1>");
        //    return Content("<h1 style=\"color:red\">Hello Asp.Net Core MVC Students</h1>", "text/html");
        //}

        //public EmptyResult Index()
        //{
        //    //return new EmptyResult();
        //    return null;
        //}

        //public FileResult Index()
        //{
        //    //return File("~/Test.txt", "text/plain");
        //    var fileByte = System.IO.File.ReadAllBytes("wwwroot/Test.txt");
        //    const string fileName = "testFIle.txt";
        //    return File(fileByte, MediaTypeNames.Text.Plain, fileName);
        //}

        //public JsonResult Index()
        //{
        //    return Json(new 
        //    {
        //        Id = 12,
        //        Name="Hossein", 
        //        Job="Programmer", 
        //        Site="Atriya.com"
        //    });
        //}

        //public JavascriptResult Index()
        //{
        //    return new JavascriptResult("alert('Salam Salam, Hamegi Salam!!!')");
        //}
        //public RedirectResult Index()
        //{
        //    return Redirect("http://www.atriya.com");
        //}

        //public RedirectToActionResult Index()
        //{
        //    return RedirectToAction("Contact","Home");
        //}

        //public IActionResult Index()
        //{
        //    //return new OkResult();
        //    //return new NotFoundResult();
        //    //return new BadRequestResult();
        //    //return new NoContentResult();
        //    return new UnauthorizedResult();
        //    //return new StatusCodeResult(510);
        //}
    }

    //public class JavascriptResult : ContentResult
    //{
    //    public JavascriptResult(string data)
    //    {
    //        Content = data;
    //        ContentType = "application/javascript";
    //    }
    //}
}
