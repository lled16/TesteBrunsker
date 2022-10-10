
using Microsoft.EntityFrameworkCore;

using locamais.Models;

namespace locamais
{
    public class DataContext : DbContext
    {
        public virtual DbSet<cadImovel> imoveis { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
       optionsBuilder.UseSqlServer("server=DESKTOP-278IVMV;database=LOCAMAIS_IMOVEIS;trusted_connection=true;user=DESKTOP-278IVMV\\55319");
        }

    }


}
