using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HSMSBusinessObjects;
using Microsoft.AspNetCore.Authorization;
using ProjectWebApp.ViewModel;

namespace ProjectWebApp.Controllers
{
    public class ServiceRequestsController : Controller
    {
        private readonly HSMSContext _context;

        public ServiceRequestsController()
        {
            _context = new HSMSContext();
        }

        // GET: ServiceRequests
        public async Task<IActionResult> Index(string SearchString)
        {
            IEnumerable<ServiceRequest> serviceRequestList;

            serviceRequestList = _context.ServiceRequests.Include(s => s.Comment).Include(s => s.IdNavigation).Include(s => s.Technician);

            if (!string.IsNullOrEmpty(SearchString))
            {
                serviceRequestList = serviceRequestList.Where(x => x.Description.Contains(SearchString));
            }

            var serviceRequestVM = new NewServiceRequestViewModel
            {
                ServiceRequests = serviceRequestList
            };

            return View(serviceRequestVM);
        }

        // GET: ServiceRequests/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.ServiceRequests == null)
            {
                return NotFound();
            }

            var serviceRequest = await _context.ServiceRequests
                .Include(s => s.Comment)
                .Include(s => s.IdNavigation)
                .Include(s => s.Technician)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (serviceRequest == null)
            {
                return NotFound();
            }

            return View(serviceRequest);
        }

        // GET: ServiceRequests/Create
        public IActionResult Create()
        {
            ViewData["CommentId"] = new SelectList(_context.Comments, "CommentId", "UserId");
            ViewData["Id"] = new SelectList(_context.Services, "ServiceId", "ServiceName");
            ViewData["TechnicianId"] = new SelectList(_context.AppUsers, "Id", "Id");
            return View();
        }

        // POST: ServiceRequests/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Description,DateNeeded,Price,CommentId,TechnicianId,IsPending")] ServiceRequest serviceRequest)
        {
            if (ModelState.IsValid)
            {
                _context.ChangeTracker.DetectChanges();
                _context.Add(serviceRequest);

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
            ViewData["CommentId"] = new SelectList(_context.Comments, "CommentId", "UserId", serviceRequest.CommentId);
            ViewData["Id"] = new SelectList(_context.Services, "ServiceId", "ServiceName", serviceRequest.Id);
            ViewData["TechnicianId"] = new SelectList(_context.AppUsers, "Id", "Id", serviceRequest.TechnicianId);
            return View(serviceRequest);
        }

        // GET: ServiceRequests/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.ServiceRequests == null)
            {
                return NotFound();
            }

            var serviceRequest = await _context.ServiceRequests.FindAsync(id);
            if (serviceRequest == null)
            {
                return NotFound();
            }
            ViewData["CommentId"] = new SelectList(_context.Comments, "CommentId", "UserId", serviceRequest.CommentId);
            ViewData["Id"] = new SelectList(_context.Services, "ServiceId", "ServiceName", serviceRequest.Id);
            ViewData["TechnicianId"] = new SelectList(_context.AppUsers, "Id", "Id", serviceRequest.TechnicianId);
            return View(serviceRequest);
        }

        // POST: ServiceRequests/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Description,DateNeeded,Price,CommentId,TechnicianId,IsPending")] ServiceRequest serviceRequest)
        {
            if (id != serviceRequest.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.ChangeTracker.DetectChanges();
                    _context.Update(serviceRequest);
                    LogsController.AddLog(_context, User.Identity.Name);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ServiceRequestExists(serviceRequest.Id))
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
            ViewData["CommentId"] = new SelectList(_context.Comments, "CommentId", "UserId", serviceRequest.CommentId);
            ViewData["Id"] = new SelectList(_context.Services, "ServiceId", "ServiceName", serviceRequest.Id);
            ViewData["TechnicianId"] = new SelectList(_context.AppUsers, "Id", "Id", serviceRequest.TechnicianId);
            return View(serviceRequest);
        }

        // GET: ServiceRequests/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.ServiceRequests == null)
            {
                return NotFound();
            }

            var serviceRequest = await _context.ServiceRequests
                .Include(s => s.Comment)
                .Include(s => s.IdNavigation)
                .Include(s => s.Technician)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (serviceRequest == null)
            {
                return NotFound();
            }

            return View(serviceRequest);
        }

        // POST: ServiceRequests/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.ServiceRequests == null)
            {
                return Problem("Entity set 'HSMSContext.ServiceRequests'  is null.");
            }
            var serviceRequest = await _context.ServiceRequests.FindAsync(id);
            if (serviceRequest != null)
            {
                _context.ChangeTracker.DetectChanges();
                _context.ServiceRequests.Remove(serviceRequest);
                LogsController.AddLog(_context, User.Identity.Name);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ServiceRequestExists(int id)
        {
            return _context.ServiceRequests.Any(e => e.Id == id);
        }
    }
}
