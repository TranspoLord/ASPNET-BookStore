using BookStore.Models;
using BookStore.DataAccess.Data;
using Microsoft.AspNetCore.Mvc;
using BookStore.DataAccess.Repository.IRepository;

namespace BookStore.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryRepository _catRepo;
        public CategoryController(ICategoryRepository db)
        {
            _catRepo = db;
        }
        public IActionResult Index()
        {
            List<Category> categories = _catRepo.GetAll().ToList();
            return View(categories);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category obj)
        {
            if(obj.Name == obj.DisplayOrder.ToString())
            {
                ModelState.AddModelError("name", "The provided name cannot be the same as the display order");
            }
            if (obj.Name.ToLower() == "test")
            {
                ModelState.AddModelError("", "Test is an invalid value");
            }
            if (ModelState.IsValid)
            {
                _catRepo.Add(obj);
                _catRepo.Save();
                TempData["success"] = "The category has been added successfully";
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Category? catFromDB = _catRepo.Get(u => u.Id == id);
            // Category? catFromDB2 = _db.Categories.FirstOrDefault(u => u.Id == id);
            // Category? catFromDB3 = _db.Categories.Where(u => u.Id == id).FirstOrDefault();
            if (catFromDB == null)
            {
                return NotFound();
            }
            return View(catFromDB);
        }

        [HttpPost]
        public IActionResult Edit(Category obj)
        {
            if (ModelState.IsValid)
            {
                _catRepo.Update(obj);
                _catRepo.Save();
                TempData["success"] = "The category has been updated successfully";
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Category? catFromDB = _catRepo.Get(u => u.Id == id);
            if (catFromDB == null)
            {
                return NotFound();
            }
            return View(catFromDB);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePOST(int? id)
        {
            Category? obj = _catRepo.Get(u => u.Id == id);
            if (obj == null)
            {
                return NotFound();
            }
            _catRepo.Remove(obj);
            _catRepo.Save();
            TempData["success"] = "The category has been deleted successfully";
            return RedirectToAction("Index");

        }
    }
}
