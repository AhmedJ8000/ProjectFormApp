﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HSMSBusinessObjects;
using ProjectWebApp.ViewModel;

namespace ProjectWebApp.Controllers
{
    public class ServicesController : Controller
    {
        private readonly HSMSContext _context;

        public ServicesController()
        {
            _context = new HSMSContext();
        }

        // GET: Services
        public async Task<IActionResult> Index(string SearchString, string SearchCategory)
        {
            IEnumerable<Service> serviceList;

            serviceList = _context.Services.Include(s => s.Category);

            if (!string.IsNullOrEmpty(SearchString))
            {
                serviceList = serviceList.Where(x => x.ServiceName.Contains(SearchString));
            }

            if (!string.IsNullOrEmpty(SearchCategory))
            {
                serviceList = serviceList.Where(x => x.CategoryId == Convert.ToInt32(SearchCategory));
            }

            var serviceVM = new NewServiceViewModel
            {
                Services = serviceList,
                Categories = _context.Categories,
            };

            return View(serviceVM);
        }

        // GET: Services/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Services == null)
            {
                return NotFound();
            }

            var service = await _context.Services
                .Include(s => s.Category)
                .FirstOrDefaultAsync(m => m.ServiceId == id);
            if (service == null)
            {
                return NotFound();
            }

            return View(service);
        }

        // GET: Services/Create
        public IActionResult Create()
        {
            ViewData["CategoryId"] = new SelectList(_context.Categories, "CategoryId", "CategoryName");
            return View();
        }

        // POST: Services/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ServiceId,ServiceName,Description,Price,CategoryId")] Service service)
        {
            if (ModelState.IsValid)
            {
                _context.ChangeTracker.DetectChanges();
                _context.Add(service);
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
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryId"] = new SelectList(_context.Categories, "CategoryId", "CategoryName", service.CategoryId);
            return View(service);
        }

        // GET: Services/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Services == null)
            {
                return NotFound();
            }

            var service = await _context.Services.FindAsync(id);
            if (service == null)
            {
                return NotFound();
            }
            ViewData["CategoryId"] = new SelectList(_context.Categories, "CategoryId", "CategoryName", service.CategoryId);
            return View(service);
        }

        // POST: Services/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ServiceId,ServiceName,Description,Price,CategoryId")] Service service)
        {
            if (id != service.ServiceId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.ChangeTracker.DetectChanges();
                    _context.Update(service);
                    LogsController.AddLog(_context, User.Identity.Name);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ServiceExists(service.ServiceId))
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
            ViewData["CategoryId"] = new SelectList(_context.Categories, "CategoryId", "CategoryName", service.CategoryId);
            return View(service);
        }

        // GET: Services/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Services == null)
            {
                return NotFound();
            }

            var service = await _context.Services
                .Include(s => s.Category)
                .FirstOrDefaultAsync(m => m.ServiceId == id);
            if (service == null)
            {
                return NotFound();
            }

            return View(service);
        }

        // POST: Services/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Services == null)
            {
                return Problem("Entity set 'HSMSContext.Services'  is null.");
            }
            var service = await _context.Services.FindAsync(id);
            if (service != null)
            {
                _context.ChangeTracker.DetectChanges();
                _context.Services.Remove(service);
                LogsController.AddLog(_context, User.Identity.Name);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ServiceExists(int id)
        {
            return _context.Services.Any(e => e.ServiceId == id);
        }
    }
}
