
using System.Data.Entity;

namespace CRUD_Cadastro_de_Veiculo___Desafio_Fullstack.Models
{
    public class VeiculoDbContext : DbContext
    {
        public DbSet<Veiculo> Veiculos { get; set; }
    }
}
