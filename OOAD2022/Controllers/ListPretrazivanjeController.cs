using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OOAD2022.Data;
using OOAD2022.Models;

namespace OOAD2022.Controllers
{
    public class ListPretrazivanjeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ListPretrazivanjeController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ListPretrazivanje
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Smjestaj.Include(s => s.Slike);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: ListPretrazivanje/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var smjestaj = await _context.Smjestaj
                .Include(s => s.Slike)
                .FirstOrDefaultAsync(m => m.SmjestajId == id);
            if (smjestaj == null)
            {
                return NotFound();
            }

            return View(smjestaj);
        }

        // GET: ListPretrazivanje/Create
        public IActionResult Create()
        {
            ViewData["SlikaId"] = new SelectList(_context.Slike, "Id", "Id");
            return View();
        }

        // POST: ListPretrazivanje/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SmjestajId,NazivSmjestaja,AdresaSmjestaja,Kontakt,VrstaSmjestaja,SlikaId")] Smjestaj smjestaj)
        {
            if (ModelState.IsValid)
            {
                _context.Add(smjestaj);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["SlikaId"] = new SelectList(_context.Slike, "Id", "Id", smjestaj.SlikaId);
            return View(smjestaj);
        }

        // GET: ListPretrazivanje/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var smjestaj = await _context.Smjestaj.FindAsync(id);
            if (smjestaj == null)
            {
                return NotFound();
            }
            ViewData["SlikaId"] = new SelectList(_context.Slike, "Id", "Id", smjestaj.SlikaId);
            return View(smjestaj);
        }

        // POST: ListPretrazivanje/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SmjestajId,NazivSmjestaja,AdresaSmjestaja,Kontakt,VrstaSmjestaja,SlikaId")] Smjestaj smjestaj)
        {
            if (id != smjestaj.SmjestajId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(smjestaj);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SmjestajExists(smjestaj.SmjestajId))
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
            ViewData["SlikaId"] = new SelectList(_context.Slike, "Id", "Id", smjestaj.SlikaId);
            return View(smjestaj);
        }

        // GET: ListPretrazivanje/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var smjestaj = await _context.Smjestaj
                .Include(s => s.Slike)
                .FirstOrDefaultAsync(m => m.SmjestajId == id);
            if (smjestaj == null)
            {
                return NotFound();
            }

            return View(smjestaj);
        }

        // POST: ListPretrazivanje/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var smjestaj = await _context.Smjestaj.FindAsync(id);
            _context.Smjestaj.Remove(smjestaj);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SmjestajExists(int id)
        {
            return _context.Smjestaj.Any(e => e.SmjestajId == id);
        }
    }
}
