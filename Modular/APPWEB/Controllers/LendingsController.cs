using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using API.Data;
using Bussiness_Logic.Models;

namespace APPWEB.Controllers
{
    public class LendingsController : Controller
    {
        private readonly AppDBContext _context;

        public LendingsController(AppDBContext context)
        {
            _context = context;
        }

        // GET: Lendings
        public async Task<IActionResult> Index()
        {
            var appDBContext = _context.Lendings.Include(l => l.Equipments).Include(l => l.Ubication);
            return View(await appDBContext.ToListAsync());
        }

        // GET: Lendings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lending = await _context.Lendings
                .Include(l => l.Equipments)
                .Include(l => l.Ubication)
                .FirstOrDefaultAsync(m => m.Id_Lending == id);
            if (lending == null)
            {
                return NotFound();
            }

            return View(lending);
        }

        // GET: Lendings/Create
        public IActionResult Create()
        {
            ViewData["EquipmentId"] = new SelectList(_context.Equipments, "Id_Equipment", "Equipement_Internal_Code");
            ViewData["UbicationId"] = new SelectList(_context.Ubications, "Id_Ubication", "UbicationName");
            return View();
        }

        // POST: Lendings/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id_Lending,DateLending,CodeEquipment,DescriptionMantenaince,UserId,EquipmentId,UbicationId")] Lending lending)
        {
            if (ModelState.IsValid)
            {
                _context.Add(lending);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["EquipmentId"] = new SelectList(_context.Equipments, "Id_Equipment", "Equipement_Internal_Code", lending.EquipmentId);
            ViewData["UbicationId"] = new SelectList(_context.Ubications, "Id_Ubication", "UbicationName", lending.UbicationId);
            return View(lending);
        }

        // GET: Lendings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lending = await _context.Lendings.FindAsync(id);
            if (lending == null)
            {
                return NotFound();
            }
            ViewData["EquipmentId"] = new SelectList(_context.Equipments, "Id_Equipment", "Equipement_Internal_Code", lending.EquipmentId);
            ViewData["UbicationId"] = new SelectList(_context.Ubications, "Id_Ubication", "UbicationName", lending.UbicationId);
            return View(lending);
        }

        // POST: Lendings/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id_Lending,DateLending,CodeEquipment,DescriptionMantenaince,UserId,EquipmentId,UbicationId")] Lending lending)
        {
            if (id != lending.Id_Lending)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(lending);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LendingExists(lending.Id_Lending))
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
            ViewData["EquipmentId"] = new SelectList(_context.Equipments, "Id_Equipment", "Equipement_Internal_Code", lending.EquipmentId);
            ViewData["UbicationId"] = new SelectList(_context.Ubications, "Id_Ubication", "UbicationName", lending.UbicationId);
            return View(lending);
        }

        // GET: Lendings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lending = await _context.Lendings
                .Include(l => l.Equipments)
                .Include(l => l.Ubication)
                .FirstOrDefaultAsync(m => m.Id_Lending == id);
            if (lending == null)
            {
                return NotFound();
            }

            return View(lending);
        }

        // POST: Lendings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var lending = await _context.Lendings.FindAsync(id);
            _context.Lendings.Remove(lending);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LendingExists(int id)
        {
            return _context.Lendings.Any(e => e.Id_Lending == id);
        }
    }
}
