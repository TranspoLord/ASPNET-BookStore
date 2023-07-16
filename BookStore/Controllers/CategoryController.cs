using BookStore.Data;
using BookStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    public class CategoryController : Controller
    {
        private readonly AppDatabaseContext _db;
        public CategoryController(AppDatabaseContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Category> categories = _db.Categories.ToList();
            return View(categories);
        }
    }
}
