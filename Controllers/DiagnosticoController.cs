using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using ProjectCalidadSoft.Data;
using ProjectCalidadSoft.Models;

namespace ProjectCalidadSoft.Controllers
{
    public class DiagnosticoController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DiagnosticoController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Diagnostico
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.DiagnosticoMedico.Include(d => d.Cie10).Include(d => d.Paciente);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Diagnostico/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var diagnosticoMedico = await _context.DiagnosticoMedico
                .Include(d => d.Cie10)
                .Include(d => d.Paciente)
                .FirstOrDefaultAsync(m => m.IdCie10 == id);
            if (diagnosticoMedico == null)
            {
                return NotFound();
            }

            return View(diagnosticoMedico);
        }

        // GET: Diagnostico/Create
        public IActionResult Create(int? id)
        {
            ViewData["IdCie10"] = new SelectList(_context.Cie10, "Codigo", "Codigo");
            //ViewData["IdPaciente"] = new SelectList(_context.Paciente, "Id", "Id");
            ViewData["IdPaciente"] = id;
            
            DiagnosticoMedico diag =  new DiagnosticoMedico();
            return View("PopupDiagnostico",diag);
        }

        // POST: Diagnostico/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdPaciente,IdCie10,Fecha")] DiagnosticoMedico diagnosticoMedico)
        {
            if (ModelState.IsValid)
            {
                _context.Add(diagnosticoMedico);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdCie10"] = new SelectList(_context.Cie10, "Codigo", "Codigo", diagnosticoMedico.IdCie10);
            ViewData["IdPaciente"] = new SelectList(_context.Paciente, "Id", "Id", diagnosticoMedico.IdPaciente);
            return View(diagnosticoMedico);
        }

        // GET: Diagnostico/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var diagnosticoMedico = await _context.DiagnosticoMedico.FindAsync(id);
            if (diagnosticoMedico == null)
            {
                return NotFound();
            }
            ViewData["IdCie10"] = new SelectList(_context.Cie10, "Codigo", "Codigo", diagnosticoMedico.IdCie10);
            ViewData["IdPaciente"] = new SelectList(_context.Paciente, "Id", "Id", diagnosticoMedico.IdPaciente);
            return View(diagnosticoMedico);
        }

        // POST: Diagnostico/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("IdPaciente,IdCie10,Fecha")] DiagnosticoMedico diagnosticoMedico)
        {
            if (id != diagnosticoMedico.IdCie10)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(diagnosticoMedico);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DiagnosticoMedicoExists(diagnosticoMedico.IdCie10))
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
            ViewData["IdCie10"] = new SelectList(_context.Cie10, "Codigo", "Codigo", diagnosticoMedico.IdCie10);
            ViewData["IdPaciente"] = new SelectList(_context.Paciente, "Id", "Id", diagnosticoMedico.IdPaciente);
            return View(diagnosticoMedico);
        }

        // GET: Diagnostico/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var diagnosticoMedico = await _context.DiagnosticoMedico
                .Include(d => d.Cie10)
                .Include(d => d.Paciente)
                .FirstOrDefaultAsync(m => m.IdCie10 == id);
            if (diagnosticoMedico == null)
            {
                return NotFound();
            }

            return View(diagnosticoMedico);
        }

        // POST: Diagnostico/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var diagnosticoMedico = await _context.DiagnosticoMedico.FindAsync(id);
            _context.DiagnosticoMedico.Remove(diagnosticoMedico);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DiagnosticoMedicoExists(string id)
        {
            return _context.DiagnosticoMedico.Any(e => e.IdCie10 == id);
        }
    }
}
