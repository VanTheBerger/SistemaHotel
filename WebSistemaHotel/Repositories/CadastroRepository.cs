using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSistemaHotel.Context;
using WebSistemaHotel.Models;
using WebSistemaHotel.Parse;
using WebSistemaHotel.ViewModel;

namespace WebSistemaHotel.Repositories
{
    public class CadastroRepository
    {
        private CadastroContext db;
        public CadastroRepository(CadastroContext _db )
        {
            db = _db;
            db.Cadastro.Load();   
        }

        public System.ComponentModel.BindingList<CadastroModel> GetAllCadastros()
        {
            return db.Cadastro.Local.ToBindingList();
        }

        public async Task<bool>  AddCadastro(CadastroModel cadastro)
        {
            db.Cadastro.Add(cadastro);
           return await db.SaveChangesAsync() >0;
        }

        public CadastroModel GetCadastro(int id)
        {
            return db.Cadastro.Where(b => b.Id.Equals(id)).First();
        }

        public void UpdateCadastro(CadastroViewModel cadastroViewModel)
        {
            CadastroModel cadastro = GetCadastro(cadastroViewModel.Id);

            CadastroModelTOCadastroViewModelParse.Parse(cadastroViewModel); 


            db.Entry<CadastroModel>(cadastro).State = EntityState.Modified;

            db.SaveChanges();

            //var cadastroParse = new CadastroModelTOCadastroViewModelParse();
            //cadastroParse.Parse()

        }
        public void DeleteCadastro(int id)
        {
            db.Cadastro.Remove(GetCadastro(id));
            db.SaveChanges();

        }
    
    }

}
