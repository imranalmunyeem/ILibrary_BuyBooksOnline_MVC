using ILibrary_BuyBooksOnline.Data;
using ILibrary_BuyBooksOnline.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace ILibrary_BuyBooksOnline.Controllers
{
    public class ILibraryBooksController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ILibraryBooksController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            List<ILibraryBooks> objILibraryBooksList = _db.ILibraryBook.ToList(); // Will retrieve the ILibraryBooks data

            return View(objILibraryBooksList);
        }

        //-------------------------------------------Create Controller------------------------------------------------//
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ILibraryBooks obj)
        {

            if (ModelState.IsValid)
            {
                _db.ILibraryBook.Add(obj);
                _db.SaveChanges();
                TempData["success"] = "Book was added successfully";
                return RedirectToAction("Index");
            }

            return View();
        }

        //-------------------------------------------Edit Controller------------------------------------------------//
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            ILibraryBooks? iLibraryBooksFromDb = _db.ILibraryBook.Find(id);

            if (iLibraryBooksFromDb == null)
            {
                return NotFound();
            }
            return View(iLibraryBooksFromDb);
        }

        [HttpPost]
        public IActionResult Edit(ILibraryBooks obj)
        {
            if (ModelState.IsValid)
            {
                _db.ILibraryBook.Update(obj);
                _db.SaveChanges();
                TempData["success"] = "Book was updated successfully";
                return RedirectToAction("Index");
            }
            return View();
        }

        //-------------------------------------------Delete Controller------------------------------------------------//
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            ILibraryBooks? iLibraryBooksFromDb = _db.ILibraryBook.Find(id);

            if (iLibraryBooksFromDb == null)
            {
                return NotFound();
            }
            return View(iLibraryBooksFromDb);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePOST(int? id)
        {
            ILibraryBooks? obj = _db.ILibraryBook.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            _db.ILibraryBook.Remove(obj);
            _db.SaveChanges();
            TempData["success"] = "Book was deleted successfully";
            return RedirectToAction("Index");
        }
    }
}
