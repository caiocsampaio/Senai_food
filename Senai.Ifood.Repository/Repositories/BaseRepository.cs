using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Senai.Ifood.Domain.Contracts;
using Senai.Ifood.Repository.Context;

namespace Senai.Ifood.Repository.Repositories
{
    public class BaseRepository<T>: IBaseRepository<T> where T: class
    {
        private readonly IFoodContext _context;

        public BaseRepository(IFoodContext context)
        {
            _context = context;
        }

        public int Atualizar(T dados)
        {
            try{
                _context.Set<T>().Update(dados);

                return _context.SaveChanges();
            }
            catch(Exception ex){
                throw new Exception(ex.Message);
            }
        }

        public T BuscarPorId(int id)
        {
            try
            {
                var keyProperty = _context.Model.FindEntityType(typeof(T)).FindPrimaryKey().Properties[0];
	
                return _context.Set<T>().FirstOrDefault(e => EF.Property<int>(e, keyProperty.Name) == id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int Deletar(T dados)
        {
            try{
                _context.Set<T>().Remove(dados);

                return _context.SaveChanges();
            }
            catch(Exception ex){
                throw new Exception(ex.Message);
            }
        }

        public int Inserir(T dados)
        {
            try{
                _context.Set<T>().Add(dados);

                return _context.SaveChanges();
            }
            catch(Exception ex){
                throw new Exception(ex.Message);
            }
            throw new System.NotImplementedException();
        }

        public IEnumerable<T> Listar()
        {
            try{
                var lista_dados = _context.Set<T>().ToList();

                return lista_dados; 
            }
            catch(Exception ex){
                throw new Exception(ex.Message);
            }
        }
    }
}