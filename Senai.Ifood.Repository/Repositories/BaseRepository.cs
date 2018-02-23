using System.Collections.Generic;
using Senai.Ifood.Domain.Contracts;

namespace Senai.Ifood.Repository.Repositories
{
    public class BaseRepository<T>: IBaseRepository<T> where T: class
    {
        public int Atualizar(T dados)
        {
            throw new System.NotImplementedException();
        }

        public T BuscarPorId(int id)
        {
            throw new System.NotImplementedException();
        }

        public int Deletar(T dados)
        {
            throw new System.NotImplementedException();
        }

        public int Inserir(T dados)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<T> Listar()
        {
            throw new System.NotImplementedException();
        }
    }
}