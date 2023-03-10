using DotnetCoreForms.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http;

namespace DotnetCoreForms.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            // TODO: gán bất kì giá trị mặc dịnh nào & gủi lại cho view
            var model = new ProductEditModel(); 
            return View(model);
        }
        
        [HttpPost]
        public IActionResult Create(ProductEditModel editModel)
        {
            string message = string.Empty;
            if (ModelState.IsValid)
            {
                message = "Product: " + editModel.Name + ". Rate = " + editModel.Rate + ". Rating = " + editModel.Rating;
            }
            else
            {
                message = "Failed to create the product. Please try again";
            }
            return Content(message);
        }
    }
}
