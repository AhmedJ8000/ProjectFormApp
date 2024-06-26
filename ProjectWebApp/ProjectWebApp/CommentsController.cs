﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HSMSBusinessObjects;
using ProjectWebApp.Controllers;

namespace ProjectWebApp
{
    public class CommentsController : Controller
    {
        private readonly HSMSContext _context;

        public CommentsController()
        {
            _context = new HSMSContext();
        }

        // GET: Comments
        public async Task<IActionResult> Index()
        {
            var hSMSContext = _context.Comments.Include(c => c.User);
            return View(await hSMSContext.ToListAsync());
        }

        // GET: Comments/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Comments == null)
            {
                return NotFound();
            }

            var comment = await _context.Comments
                .Include(c => c.User)
                .FirstOrDefaultAsync(m => m.CommentId == id);
            if (comment == null)
            {
                return NotFound();
            }

            return View(comment);
        }

        // GET: Comments/Create
        public IActionResult Create()
        {
            ViewData["UserId"] = new SelectList(_context.AppUsers, "Id", "Id");
            return View();
        }

        // POST: Comments/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CommentId,Notes,Date,Time,UserId")] Comment comment)
        {
            if (ModelState.IsValid)
            {
                _context.ChangeTracker.DetectChanges();
                _context.Add(comment);

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
            ViewData["UserId"] = new SelectList(_context.AppUsers, "Id", "Id", comment.UserId);
            return View(comment);
        }

        // GET: Comments/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Comments == null)
            {
                return NotFound();
            }

            var comment = await _context.Comments.FindAsync(id);
            if (comment == null)
            {
                return NotFound();
            }
            ViewData["UserId"] = new SelectList(_context.AppUsers, "Id", "Id", comment.UserId);
            return View(comment);
        }

        // POST: Comments/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CommentId,Notes,Date,Time,UserId")] Comment comment)
        {
            if (id != comment.CommentId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.ChangeTracker.DetectChanges();
                    _context.Update(comment);
                    LogsController.AddLog(_context, User.Identity.Name);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CommentExists(comment.CommentId))
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
            ViewData["UserId"] = new SelectList(_context.AppUsers, "Id", "Id", comment.UserId);
            return View(comment);
        }

        // GET: Comments/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Comments == null)
            {
                return NotFound();
            }

            var comment = await _context.Comments
                .Include(c => c.User)
                .FirstOrDefaultAsync(m => m.CommentId == id);
            if (comment == null)
            {
                return NotFound();
            }

            return View(comment);
        }

        // POST: Comments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Comments == null)
            {
                return Problem("Entity set 'HSMSContext.Comments'  is null.");
            }
            var comment = await _context.Comments.FindAsync(id);
            if (comment != null)
            {
                _context.ChangeTracker.DetectChanges();
                _context.Comments.Remove(comment);
                LogsController.AddLog(_context, User.Identity.Name);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CommentExists(int id)
        {
          return _context.Comments.Any(e => e.CommentId == id);
        }
    }
}
