using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CRMApp.Data;
using CRMApp.Models;
using Microsoft.AspNetCore.Authorization;

namespace CRMApp.Controllers
{
    public class ManagersController : Controller
    {
        private readonly CrmDbContext _context;

        public ManagersController(CrmDbContext context)
        {
            _context = context;
        }

        // GET: Managers
        public async Task<IActionResult> Index()
        {
            return View(await _context.Managers.ToListAsync());
        }

        // GET: Managers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var managerEntity = await _context.Managers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (managerEntity == null)
            {
                return NotFound();
            }

            return View(managerEntity);
        }

        // GET: Managers/Create

        public IActionResult Create()
        {
            return View();
        }

        // POST: Managers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Create([Bind("Id,Name,Mobile,Email")] ManagerEntity managerEntity)
        {
            if (ModelState.IsValid)
            {
                _context.Add(managerEntity);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(managerEntity);
        }

        // GET: Managers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var managerEntity = await _context.Managers.FindAsync(id);
            if (managerEntity == null)
            {
                return NotFound();
            }
            return View(managerEntity);
        }

        // POST: Managers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Mobile,Email")] ManagerEntity managerEntity)
        {
            if (id != managerEntity.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(managerEntity);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ManagerEntityExists(managerEntity.Id))
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
            return View(managerEntity);
        }

        // GET: Managers/Delete/5
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var managerEntity = await _context.Managers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (managerEntity == null)
            {
                return NotFound();
            }

            return View(managerEntity);
        }

        // POST: Managers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var managerEntity = await _context.Managers.FindAsync(id);
            if (managerEntity != null)
            {
                _context.Managers.Remove(managerEntity);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ManagerEntityExists(int id)
        {
            return _context.Managers.Any(e => e.Id == id);
        }
    }
}
