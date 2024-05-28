using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HSMSBusinessObjects;

namespace ProjectWebApp.Controllers
{
    public class NotificationsController : Controller
    {
        private readonly HSMSContext _context;

        public NotificationsController()
        {
            _context = new HSMSContext();
        }

        // GET: Notifications
        public async Task<IActionResult> Index()
        {
            var hSMSContext = _context.Notifications.Include(n => n.User).OrderByDescending(x => x.NDate);
            return View(await hSMSContext.ToListAsync());
        }

        // GET: Notifications/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Notifications == null)
            {
                return NotFound();
            }

            var notification = await _context.Notifications
                .Include(n => n.User)
                .FirstOrDefaultAsync(m => m.NotificationId == id);
            if (notification == null)
            {
                return NotFound();
            }

            if (User.IsInRole("Manager") || User.IsInRole("User") && notification.Status == "Unread")
            {
                notification.Status = "Read";
                _context.Update(notification);
                await _context.SaveChangesAsync();
            }

            return View(notification);
        }

        // GET: Notifications/Create
        public IActionResult Create()
        {
            ViewData["UserId"] = new SelectList(_context.AppUsers, "Id", "Id");
            return View();
        }

        // POST: Notifications/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("NotificationId,Message,Type,Status,UserId,NDate")] Notification notification)
        {
            if (ModelState.IsValid)
            {
                _context.ChangeTracker.DetectChanges();
                _context.Add(notification);

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
            ViewData["UserId"] = new SelectList(_context.AppUsers, "Id", "Id", notification.UserId);
            return View(notification);
        }

        // GET: Notifications/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Notifications == null)
            {
                return NotFound();
            }

            var notification = await _context.Notifications.FindAsync(id);
            if (notification == null)
            {
                return NotFound();
            }
            ViewData["UserId"] = new SelectList(_context.AppUsers, "Id", "Id", notification.UserId);
            return View(notification);
        }

        // POST: Notifications/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("NotificationId,Message,Type,Status,UserId,NDate")] Notification notification)
        {
            if (id != notification.NotificationId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.ChangeTracker.DetectChanges();
                    _context.Update(notification);
                    LogsController.AddLog(_context, User.Identity.Name);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NotificationExists(notification.NotificationId))
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
            ViewData["UserId"] = new SelectList(_context.AppUsers, "Id", "Id", notification.UserId);
            return View(notification);
        }

        // GET: Notifications/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Notifications == null)
            {
                return NotFound();
            }

            var notification = await _context.Notifications
                .Include(n => n.User)
                .FirstOrDefaultAsync(m => m.NotificationId == id);
            if (notification == null)
            {
                return NotFound();
            }

            return View(notification);
        }

        // POST: Notifications/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Notifications == null)
            {
                return Problem("Entity set 'HSMSContext.Notifications'  is null.");
            }
            var notification = await _context.Notifications.FindAsync(id);
            if (notification != null)
            {
                _context.ChangeTracker.DetectChanges();
                _context.Notifications.Remove(notification);
                LogsController.AddLog(_context, User.Identity.Name);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NotificationExists(int id)
        {
            return _context.Notifications.Any(e => e.NotificationId == id);
        }
    }
}
