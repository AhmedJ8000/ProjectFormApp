using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HSMSBusinessObjects;
using ProjectWebApp.ViewModel;

namespace ProjectWebApp
{
    public class CategoriesController : Controller
    {
        private readonly HSMSContext _context;

        public CategoriesController()
        {
            _context = new HSMSContext();
        }

        public IActionResult Index(string SearchString)
        {
            IEnumerable<Category> categoryList;

            categoryList = _context.Categories.Include(x => x.Manager);

            if (!String.IsNullOrEmpty(SearchString))
            {
                categoryList = categoryList.Where(x => x.CategoryName.Contains(SearchString));
            }

            var categoryVM = new NewCategoryViewModel
            {
                Categories = categoryList
            };

            return View(categoryVM);
        }

        // Create Method
        public IActionResult Create()
        {
            var viewModel = new NewCategoryViewModel
            {
                category = new Category(),
                Categories = _context.Categories,
                Users = _context.Users
            };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(NewCategoryViewModel newCat)
        {

            if (ModelState.IsValid)
            {
                _context.Categories.Add(newCat.category);
                _context.SaveChanges();
                TempData["CreateSuccess"] = "Category Added Successfully";
                return RedirectToAction("Index");
            }
            else
            {
                var viewModel = new NewCategoryViewModel
                {
                    category = newCat.category,
                    Categories = _context.Categories,
                    Users = _context.Users.Where(x => x.Role == "Manager")
                };
                return View(viewModel);
            }
        }

        // Edit Method
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
                return NotFound();

            var catgoryFromDB = _context.Categories.Find(id);

            if (catgoryFromDB == null)
                NotFound();

            var viewModel = new NewCategoryViewModel
            {
                category = catgoryFromDB,
                Categories = _context.Categories,
                Users = _context.Users.Where(x => x.Role == "Manager")
            };

            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(NewCategoryViewModel editCat)
        {
            if (ModelState.IsValid)
            {
                _context.Categories.Update(editCat.category);
                _context.SaveChanges();
                TempData["CreateSuccess"] = "Category Updated Successfully";
                return RedirectToAction("Index");
            }
            else
            {
                var viewModel = new NewCategoryViewModel
                {
                    category = editCat.category,
                    Categories = _context.Categories,
                    Users = _context.Users.Where(x => x.Role == "Manager")
                };
                return View(viewModel);
            }
        }

        // Delete Methods

        // GET: Categories/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Categories == null)
            {
                return NotFound();
            }

            var category = await _context.Categories
                .Include(c => c.Manager)
                .FirstOrDefaultAsync(m => m.CategoryId == id);
            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        // POST: Categories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Categories == null)
            {
                return Problem("Entity set 'HSMSContext.Categories'  is null.");
            }
            var category = await _context.Categories.FindAsync(id);
            if (category != null)
            {
                _context.Categories.Remove(category);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CategoryExists(int id)
        {
          return _context.Categories.Any(e => e.CategoryId == id);
        }
    }
}
