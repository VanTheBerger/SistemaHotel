using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SistemaHotel.Data;
using SistemaHotel.Entidades;
using SistemaHotel.Models;

namespace SistemaHotel.Controllers
{
 
    public class ClienteController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ClienteController(ApplicationDbContext context)
        {
            _context = context;
        }

        //Get Cliente/Details
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cadastro = await _context.Cadastro
                .SingleOrDefaultAsync(m => m.Id == id);
            if (cadastro == null)
            {
                return NotFound();
            }

            return View(cadastro);

        }

  //Post Cliente/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CadastroViewModel cadastro)
        {
            if (ModelState.IsValid)
            {
                var cadastroEntity = new Cadastro(cadastro.Nome,cadastro.Email,cadastro.Sexo,cadastro.Estado,cadastro.Cidade,cadastro.Telefone,cadastro.Senha);
                _context.Cadastro.Add(cadastroEntity);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Cadastro));
            }
            return RedirectToPage("Index");
        }

        //Get Cliente/Edit
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var cadastro = await _context.Cadastro.SingleOrDefaultAsync(m => m.Id == id);
            if (cadastro == null)
            {
                return NotFound();
            }
            return View(cadastro);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, CadastroViewModel cadastro)
        {
            if (id != cadastro.Id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cadastro);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CadastroExists(cadastro.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Cadastro));
            }
            return View(cadastro);
        }




        public async Task<IActionResult> Delete(int id)
        {
            var cadastro = await _context.Cadastro.FindAsync(id);

            if (cadastro != null)
            {
                _context.Cadastro.Remove(cadastro);
                await _context.SaveChangesAsync();
            }    

            return View();
        }


        private bool CadastroExists(int id)
        {
            return _context.Cadastro.Any(e => e.Id == id);
        }


    }
}

