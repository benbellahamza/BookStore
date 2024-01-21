using Microsoft.AspNetCore.Mvc;

namespace BookShoppingCartMvcUI.Controllers
{
    public class PrivacyController : Controller
    {
        public IActionResult Index()
        {
            // Supposons que vous avez les détails du livre, tels que l'image et les informations, dans votre base de données ou ailleurs.
            ViewBag.BookImage = "/images/your_book_image.jpg";
            ViewBag.BookDetails = "Description du livre, auteur, etc.";

            return View();
        }
    }
}
