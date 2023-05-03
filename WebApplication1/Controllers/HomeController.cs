using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController:Controller
    {
        public FileResult Index()
        {
            ViewResult viewResult= new ViewResult();

            viewResult.ViewName = "test";
            return viewResult;  
        }

        //public ViewResult Index()
        //{
        //    ViewResult viewResult = new ViewResult();

        //    viewResult.ViewName = "test";
        //    return viewResult;
        //}



        //public ContentResult Index()
        //{
        //   ContentResult result = new ContentResult();
        //   result.Content="PWRAEDerpawwa";
        //    result.ContentType="test";
        //    result.StatusCode = 500;
        //    return result;
        //}



        //public JsonResult index()
        //{
        //    JsonResult jsonResult = new JsonResult("Salam");
        //    jsonResult.StatusCode = 400;


        //    return jsonResult;
        //}
    }
}
