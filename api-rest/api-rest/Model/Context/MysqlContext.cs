// Importa o namespace do Entity Framework Core, necessário para usar o DbContext e funcionalidades relacionadas.
using Microsoft.EntityFrameworkCore;

namespace api_rest.Model.Context
{
    // Esta classe representa o "contexto" do banco de dados para o Entity Framework.
    // Ela herda de DbContext, a classe base usada para acessar e configurar o banco de dados.
    public class MysqlContext : DbContext
    {
        // Construtor padrão sem parâmetros.
        // É necessário em alguns casos, por exemplo, quando o framework precisa instanciar o contexto sem parâmetros.
        public MysqlContext()
        {
        }

        // Construtor que recebe opções de configuração para o contexto, como a string de conexão.
        // Essas opções normalmente são passadas pelo sistema de injeção de dependência.
        public MysqlContext(DbContextOptions<MysqlContext>options) : base(options) { }

        // Essa propriedade representa uma "tabela" no banco de dados.
        // O Entity Framework vai mapear a entidade Person para a tabela correspondente no MySQL.
        public DbSet<Person> Person { get; set; }
    }
}