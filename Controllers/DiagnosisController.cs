using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectCalidadSoft.Data;
using ProjectCalidadSoft.Models;

namespace ProjectCalidadSoft.Controllers
{
    public class DiagnosisController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DiagnosisController(ApplicationDbContext context){

            _context = context;

        }

        // GET: Diagnosis
        public async Task<IActionResult> Index()
        { 

                        var query = (from diag in _context.Set<DiagnosticoMedico>()
                            join paciente in _context.Set<Paciente>()
                                on diag.IdPaciente equals paciente
                            join cie  in _context.Set<Cie10>()
                                on diag.CodigoCie10 equals cie
                                    where(paciente.Id == 2) 

                                    select new { 
                                                descripcion = cie.Descripcion,
                                                fecha = diag.Fecha,
                                                codigoCie = cie.Codigo,
                                                cie = cie.Descripcion

                                    }).ToList();
         
            return View( query);
        }

        // GET: Diagnosis/Details/5
        public ActionResult Details(int id)
        {
            var query = (from diag in _context.Set<DiagnosticoMedico>()
                         join paciente in _context.Set<Paciente>()
                             on diag.IdPaciente equals paciente
                         join cie in _context.Set<Cie10>()
                             on diag.CodigoCie10 equals cie
                         where (paciente.Id == id)

                         select new
                         {
                             descripcion = cie.Descripcion,
                             fecha = diag.Fecha,
                             codigoCie = cie.Codigo,
                             cie = cie.Descripcion

                         }).ToList();


            return View(query);
        }

        // GET: Diagnosis/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Diagnosis/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Diagnosis/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Diagnosis/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Diagnosis/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Diagnosis/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}