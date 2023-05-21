using InAndOut.Models;
using Microsoft.EntityFrameworkCore;

namespace InAndOut.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Item> Items { get; set; }
		public DbSet<Expense> Expenses { get; set; }
	}
}

//desde la consola de paquetes:
//add-migration nombre    -> crea automaticamente una migracion con los cambios en la carpeta de modelos. 
// update-database     -> modifica la db con las migraciones actuales. 
