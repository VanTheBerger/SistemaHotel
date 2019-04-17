using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebSistemaHotel.Models;
using WebSistemaHotel.Repositories;
using WebSistemaHotel.ViewModel;

namespace WebSistemaHotel.Controllers
{
    public class CadastrosController : Controller
    {
        private readonly CadastroRepository db;

        public CadastrosController(CadastroRepository _db)
        {
            db = _db;
         
        }

        public IActionResult Index()
        {
            return View();
        }

        //GET
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CadastroViewModel cadastro)
        {
            if (ModelState.IsValid)
            {
                var model = new CadastroModel()
                {
                    Id = cadastro.Id,
                    Nome = cadastro.Nome,
                    Email = cadastro.Email,
                    Sexo = cadastro.Sexo,
                    Estado = cadastro.Estado,
                    Cidade = cadastro.Cidade,
                    Telefone = cadastro.Telefone,
                    Senha = cadastro.Senha
                };

                await db.AddCadastro(model);

                return RedirectToAction("Index");
            }
            return View(cadastro);

        }

        public IActionResult Cadastrados()
        {
            return View();

        }
    }
}