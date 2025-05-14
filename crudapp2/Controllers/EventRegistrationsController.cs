using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CrudApp1.Models;

namespace CrudApp1.Controllers
{
    public class EventRegistrationsController : Controller
    {
        private readonly AppDbContext _context;

        public EventRegistrationsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: EventRegistrations
        public async Task<IActionResult> Index()
        {
            return View(await _context.EventRegistrations.ToListAsync());
        }

        // GET: EventRegistrations/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var eventRegistration = await _context.EventRegistrations
                .FirstOrDefaultAsync(m => m.Id == id);
            if (eventRegistration == null)
            {
                return NotFound();
            }

            return View(eventRegistration);
        }

        // GET: EventRegistrations/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: EventRegistrations/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FullName,Email,Role")] EventRegistration eventRegistration)
        {
            if (ModelState.IsValid)
            {
                _context.Add(eventRegistration);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(eventRegistration);
        }

        // GET: EventRegistrations/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var eventRegistration = await _context.EventRegistrations.FindAsync(id);
            if (eventRegistration == null)
            {
                return NotFound();
            }
            return View(eventRegistration);
        }

        // POST: EventRegistrations/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FullName,Email,Role")] EventRegistration eventRegistration)
        {
            if (id != eventRegistration.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(eventRegistration);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EventRegistrationExists(eventRegistration.Id))
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
            return View(eventRegistration);
        }

        // GET: EventRegistrations/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var eventRegistration = await _context.EventRegistrations
                .FirstOrDefaultAsync(m => m.Id == id);
            if (eventRegistration == null)
            {
                return NotFound();
            }

            return View(eventRegistration);
        }

        // POST: EventRegistrations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var eventRegistration = await _context.EventRegistrations.FindAsync(id);
            if (eventRegistration != null)
            {
                _context.EventRegistrations.Remove(eventRegistration);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EventRegistrationExists(int id)
        {
            return _context.EventRegistrations.Any(e => e.Id == id);
        }
    }
}
