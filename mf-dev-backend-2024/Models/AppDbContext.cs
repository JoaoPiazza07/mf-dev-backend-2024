using Microsoft.EntityFrameworkCore;

namespace mf_dev_backend_2024.Models
{ // Classe resposável por fazer essa configuração do Entity Framework, para gerar a tabela/processo, 
  // como se fosse um utilitário resposável, por pegar todas as minhas classes e gerar as tabelas dos bancos de dados
    public class AppDbContext : DbContext //Herança
    {
        public AppDbContext (DbContextOptions<AppDbContext> options): base(options) { }

        public DbSet<Veiculo> Veiculos { get; set; }

    }
}