﻿
using EjemploMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace EjemploMVC.Data
{
    public class ContextoBD: DbContext
    {
        public ContextoBD(DbContextOptions<ContextoBD> optiones ): base( optiones )
        {

        }

        public DbSet<Profesor> profesors { get; set; }
    }
}
