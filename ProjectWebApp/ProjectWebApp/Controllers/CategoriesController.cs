using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HSMSBusinessObjects;
using ProjectWebApp.ViewModel;
using Microsoft.AspNetCore.Authorization;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace ProjectWebApp.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly HSMSContext _context;

        public CategoriesController()
        {
            _context = new HSMSContext();
        }

        // GET: Categories
        public async Task<IActionResult> Index(string SearchString)
        {
            IEnumerable<Category> categoryList;

            categoryList = _context.Categories.Include(x => x.Manager);

            if (!string.IsNullOrEmpty(SearchString))
            {
                categoryList = categoryList.Where(x => x.CategoryName.Contains(SearchString));
            }

            var categoryVM = new NewCategoryViewModel
            {
                Categories = categoryList,
                Users = _context.AppUsers
            };

            return View(categoryVM);
        }

        // GET: Categories/Details/5
        [Authorize(Roles ="Admin")]
        public async Task<IActionResult> Details(int? id)
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

        // GET: Categories/Create
        [Authorize(Roles = "Admin")]
        public IActionResult Create()
        {
            var viewModel = new NewCategoryViewModel
            {
                category = new Category(),
                Categories = _context.Categories,
                Users = _context.AppUsers
            };

            return View(viewModel);
        }

        // POST: Categories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Create(NewCategoryViewModel newCat)
        {
            if(newCat == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _context.ChangeTracker.DetectChanges();
                _context.Categories.Add(newCat.category);

                var entry = _context.ChangeTracker.Entries().FirstOrDefault();

                Log log = new Log
                {
                    Table = entry.Entity.GetType().Name,
                    Status = entry.State.ToString(),
                    LDate = DateTime.Now,
                    UserId = _context.AppUsers.Where(x => x.UserName == User.Identity.Name).FirstOrDefault().Id,
                    User = _context.AppUsers.Where(x => x.Id == _context.AppUsers.Where(x => x.UserName == User.Identity.Name).FirstOrDefault().Id).FirstOrDefault(),
                    OriginalValues = entry.CurrentValues.GetType().Name,
                    CurrentValues = entry.CurrentValues.GetType().Name,
                    Time = DateTime.Now.TimeOfDay
                };
                _context.Logs.Add(log);

                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                var viewModel = new NewCategoryViewModel
                {
                    category = newCat.category,
                    Categories = _context.Categories,
                    Users = _context.AppUsers
                };
                return View(viewModel);
            }
        }

        // GET: Categories/Edit/5
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Categories == null)
            {
                return NotFound();
            }

            var category = await _context.Categories.FindAsync(id);
            if (category == null)
            {
                return NotFound();
            }
            ViewData["ManagerId"] = new SelectList(_context.AppUsers, "Id", "Id", category.ManagerId);
            return View(category);
        }

        // POST: Categories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit(int id, [Bind("CategoryId,CategoryName,Description,ManagerId")] Category category)
        {
            if (id != category.CategoryId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.ChangeTracker.DetectChanges();
                    _context.Update(category);
                    LogsController.AddLog(_context, User.Identity.Name);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CategoryExists(category.CategoryId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["ManagerId"] = new SelectList(_context.AppUsers, "Id", "Id", category.ManagerId);
            return View(category);
        }

        // GET: Categories/Delete/5
        [Authorize(Roles = "Admin")]
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
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Categories == null)
            {
                return Problem("Entity set 'HSMSContext.Categories'  is null.");
            }
            var category = await _context.Categories.FindAsync(id);
            _context.ChangeTracker.DetectChanges();
            if (category != null)
            {
                _context.Categories.Remove(category);
            }

            LogsController.AddLog(_context, User.Identity.Name);

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CategoryExists(int id)
        {
            return _context.Categories.Any(e => e.CategoryId == id);
        }
    }
}
