using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

namespace MvcMovie.Controllers
{
    public class DenunciasController : Controller
    {
        private readonly Contexto _context;

        public DenunciasController(Contexto context)
        {
            _context = context;
        }

        // GET: Denuncias
        public async Task<IActionResult> Index()
        {
            var contexto = _context.Denuncia;
            return View(await contexto.ToListAsync());
        }

        // GET: Denuncias/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var denuncia = await _context.Denuncia
                .FirstOrDefaultAsync(m => m.DenunciaId == id);
            if (denuncia == null)
            {
                return NotFound();
            }

            return View(denuncia);
        }


        // GET: Denuncias/Create
        public IActionResult Create()
        {
            ViewData["UsuarioId"] = new SelectList(_context.Usuarios, "Id", "Id");
            return View();
        }

        // POST: Denuncias/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DenunciaId,UsuarioId,Descricao,Localizacao,DataHora,Autorizado")] Denuncia denuncia)
        {
            if (ModelState.IsValid)
            {
                _context.Add(denuncia);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["UsuarioId"] = new SelectList(_context.Usuarios, "Id", "Id", denuncia.UsuarioId);
            return View(denuncia);
        }

        // GET: Denuncias/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var denuncia = await _context.Denuncia.FindAsync(id);
            if (denuncia == null)
            {
                return NotFound();
            }
            ViewData["UsuarioId"] = new SelectList(_context.Usuarios, "Id", "Id", denuncia.UsuarioId);
            return View(denuncia);
        }

        // POST: Denuncias/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DenunciaId,UsuarioId,Descricao,Localizacao,DataHora,Autorizado")] Denuncia denuncia)
        {
            if (id != denuncia.DenunciaId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(denuncia);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DenunciaExists(denuncia.DenunciaId))
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
            ViewData["UsuarioId"] = new SelectList(_context.Usuarios, "Id", "Id", denuncia.UsuarioId);
            return View(denuncia);
        }

        // GET: Denuncias/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var denuncia = await _context.Denuncia
                .FirstOrDefaultAsync(m => m.DenunciaId == id);
            if (denuncia == null)
            {
                return NotFound();
            }

            return View(denuncia);
        }

        // POST: Denuncias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var denuncia = await _context.Denuncia.FindAsync(id);
            if (denuncia != null)
            {
                _context.Denuncia.Remove(denuncia);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DenunciaExists(int id)
        {
            return _context.Denuncia.Any(e => e.DenunciaId == id);
        }
    }
}
