using api_rest.Model;

// Importa o namespace onde está a classe base para as entidades (BaseEntity)
using api_rest.Model.Context.Base;

namespace api_rest.Repository
{
    // Define uma interface genérica chamada IRepository que só pode ser usada com tipos que herdam de BaseEntity
    public interface IRepository<T> where T : BaseEntity
    {
        // Cria uma nova entidade do tipo T e a retorna (por exemplo, salvar no banco)
        T Create(T T);

        // Atualiza uma entidade existente do tipo T e a retorna (após atualização no banco)
        T Update(T T);

        // Remove uma entidade com base no ID
        void Delete(long id);

        // Retorna uma entidade do tipo T com base no ID (ou null se não encontrar)
        T FindById(long id);

        // Retorna todas as entidades do tipo T em uma lista
        List<T> FindAll();

        // Verifica se existe uma entidade com o ID fornecido (retorna true/false)
        bool Exists(long id);
    }
}
