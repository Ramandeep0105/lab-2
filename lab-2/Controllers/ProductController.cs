using System
    ;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab2.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product

        public ActionResult Index()
        {
            return View();
        }
        public string details(string id)
        {

            string message = HttpUtility.HtmlEncode("you selected product:" + id);
            return message;
        }
    }

}
