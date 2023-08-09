using ILibrary_BuyBooksOnline.Data;
using ILibrary_BuyBooksOnline.Models;
using Microsoft.AspNetCore.Mvc;

namespace ILibrary_BuyBooksOnline.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            List<Category> objCategoryList = _db.Categories.ToList(); //Will retrieve the category data
           
            return View(objCategoryList);
        }
    }
}
