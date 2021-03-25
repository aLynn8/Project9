using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Project3.Models;

namespace Project3.Controllers
{
    public class ApplicationResponsesController : Controller
    {
        private readonly MovieListDbContext _context;

        public ApplicationResponsesController(MovieListDbContext context)
        {
            _context = context;
        }

        // GET: ApplicationResponses
        public async Task<IActionResult> Index()
        {
            return View(await _context.ApplicationResponses.ToListAsync());
        }

        // GET: ApplicationResponses/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var applicationResponse = await _context.ApplicationResponses
                .FirstOrDefaultAsync(m => m.ApplicationResponseID == id);
            if (applicationResponse == null)
            {
                return NotFound();
            }

            return View(applicationResponse);
        }

        // GET: ApplicationResponses/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ApplicationResponses/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ApplicationResponseID,Category,Title,Year,Director,Rating,Edited,Lent_To,Notes")] ApplicationResponse applicationResponse)
        {
            if (ModelState.IsValid)
            {
                _context.Add(applicationResponse);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(applicationResponse);
        }

        // GET: ApplicationResponses/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var applicationResponse = await _context.ApplicationResponses.FindAsync(id);
            if (applicationResponse == null)
            {
                return NotFound();
            }
            return View(applicationResponse);
        }

        // POST: ApplicationResponses/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ApplicationResponseID,Category,Title,Year,Director,Rating,Edited,Lent_To,Notes")] ApplicationResponse applicationResponse)
        {
            if (id != applicationResponse.ApplicationResponseID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(applicationResponse);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ApplicationResponseExists(applicationResponse.ApplicationResponseID))
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
            return View(applicationResponse);
        }

        // GET: ApplicationResponses/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var applicationResponse = await _context.ApplicationResponses
                .FirstOrDefaultAsync(m => m.ApplicationResponseID == id);
            if (applicationResponse == null)
            {
                return NotFound();
            }

            return View(applicationResponse);
        }

        // POST: ApplicationResponses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var applicationResponse = await _context.ApplicationResponses.FindAsync(id);
            _context.ApplicationResponses.Remove(applicationResponse);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ApplicationResponseExists(int id)
        {
            return _context.ApplicationResponses.Any(e => e.ApplicationResponseID == id);
        }
    }
}
