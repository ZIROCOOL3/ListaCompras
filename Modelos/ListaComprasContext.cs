using Microsoft.EntityFrameworkCore;

namespace ListaCompras.Modelos
{
    public class ListaComprasContext : DbContext
    {
        public DbSet<ListaCompras> ListaCompras { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=listacompras.mssql.somee.com;Initial Catalog=listacompras;User ID=zirocool_SQLLogin_1;Password=ahjbrax8bk;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
    }
}
