using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using insuren.Data;
using insuren.Models;

namespace insuren
{
    public class AcountsController : Controller
    {
        private readonly insurenContext _context;

        public AcountsController(insurenContext context)
        {
            _context = context;
        }

        // GET: Acounts
        public async Task<IActionResult> Index()
        {
            return View(await _context.Acount.ToListAsync());
        }

        // GET: Acounts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var acount = await _context.Acount
                .FirstOrDefaultAsync(m => m.Id == id);
            if (acount == null)
            {
                return NotFound();
            }

            return View(acount);
        }

        // GET: Acounts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Acounts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Email,Name,Password,Role")] Acount acount)
        {
            if (ModelState.IsValid)
            {
                _context.Add(acount);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(acount);
        }

        // GET: Acounts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var acount = await _context.Acount.FindAsync(id);
            if (acount == null)
            {
                return NotFound();
            }
            return View(acount);
        }

        // POST: Acounts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Email,Name,Password,Role")] Acount acount)
        {
            if (id != acount.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(acount);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AcountExists(acount.Id))
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
            return View(acount);
        }

        // GET: Acounts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var acount = await _context.Acount
                .FirstOrDefaultAsync(m => m.Id == id);
            if (acount == null)
            {
                return NotFound();
            }

            return View(acount);
        }

        // POST: Acounts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var acount = await _context.Acount.FindAsync(id);
            if (acount != null)
            {
                _context.Acount.Remove(acount);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AcountExists(int id)
        {
            return _context.Acount.Any(e => e.Id == id);
        }
    }
}
