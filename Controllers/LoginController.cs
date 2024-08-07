﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CrimeWatch.Models;

public class UsuariosController : Controller
{
    private readonly Contexto _context;

    public UsuariosController(Contexto context)
    {
        _context = context;
    }

    // GET: Usuarios/Login
    public IActionResult Login()
    {
        return View();
    }

    // POST: Usuarios/Login
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Login([Bind("Login,Senha")] Usuario usuario)
    {
        if (ModelState.IsValid)
        {
            var user = await _context.Usuarios
                .FirstOrDefaultAsync(u => u.email == usuario.email && u.senha == usuario.senha && u.Role == usuario.Role);
            if (user != null)
            {
                if (usuario.Role == "Admin")
                {
                    Console.WriteLine("Funciona");
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    return RedirectToAction(nameof(Index));
                }
            }
            else
            {
                // Autenticação falhou
                ModelState.AddModelError(string.Empty, "Login ou senha inválidos.");
            }
        }
        return View(usuario);
    }

    // Outros métodos existentes...
}
