
using EjemploMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace EjemploMVC.Data
{
    public class ContextoBD: DbContext
    {
        public ContextoBD(DbContextOptions<ContextoBD> options ): base( options )
        {

        }

        public DbSet<Profesor> profesors { get; set; }
    }
}
