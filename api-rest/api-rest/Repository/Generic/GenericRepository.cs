using api_rest.Model;
using api_rest.Model.Context;
using api_rest.Model.Context.Base;
using Microsoft.EntityFrameworkCore;
using System;

namespace api_rest.Repository.Generic
{
    // Define uma classe genérica chamada GenericRepository, que implementa a interface IRepository<T>
    // O tipo T precisa herdar de BaseEntity (ou seja, possuir pelo menos um Id, por exemplo)
    public class GenericRepository<T> : IRepository<T> where T : BaseEntity
    {

        private MysqlContext _context;
        private DbSet<T> dataset;

        public GenericRepository(MysqlContext context)
        {
            _context = context;
            dataset = _context.Set<T>();
        }

        // Retorna uma lista de todas as entidades do tipo T (não implementado ainda)
        public List<T> FindAll()
        {
            return dataset.ToList();
        }

        // Retorna uma entidade pelo ID (ainda não implementado)
        public T FindById(long id)
        {
            return dataset.SingleOrDefault(p => p.Id.Equals(id));
        }

        // Implementa o método Create da interface, mas ainda não tem lógica definida (lança exceção)
        public T Create(T item)
        {
            try
            {
                dataset.Add(item);
                _context.SaveChanges();
                return item;
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Atualiza uma entidade existente (não implementado ainda)
        public T Update(T item)
        {
            var result = dataset.SingleOrDefault(p => p.Id.Equals(item.Id));
            if (result != null)
            {
                try
                {
                    _context.Entry(result).CurrentValues.SetValues(item);
                    _context.SaveChanges();
                    return item;
                }
                catch (Exception)
                {
                    throw;
                }
            }
            else 
            {
                return null;
            }
        }


        // Implementa o método Delete, mas ainda sem lógica (lança exceção)
        public void Delete(long id)
        {
            var result = dataset.SingleOrDefault(p => p.Id.Equals(id));
            if (result != null)
            {
                try
                {
                    dataset.Remove(result);
                    _context.SaveChanges();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        // Verifica se existe um registro com o ID fornecido (ainda não implementado)
        public bool Exists(long id)
        {
            return dataset.Any(p => p.Id.Equals(id));
        }
    }
}
