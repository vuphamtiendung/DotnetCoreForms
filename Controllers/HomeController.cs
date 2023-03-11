using DotnetCoreForms_004.Models;
using Microsoft.AspNetCore.Mvc;

namespace DotnetCoreForms_004.Controllers
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
            var model = new ProductEditModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult Create(ProductEditModel editModel)
        {
            var message = string.Empty;
            if (ModelState.IsValid)
            {
                // TODO: Check product name exist
                if (editModel.Name == "test")
                {
                    ModelState.AddModelError(" ", "This product name was existed");
                    return View(editModel);
                }
                message = "Product name: " + editModel.Name + ". Rate: " + editModel.Rate + ". Rating: " + editModel.Rating + " Create Successfully";
            }
            else
            {
                return View(editModel);
            }
            return Content(message);
        }
    }
}
