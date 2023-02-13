using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiTcc.Models;
using ApiTcc.Models.Enuns;
using Microsoft.EntityFrameworkCore;

namespace ApiTcc.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public DbSet<Professor> Professores {get; set;}

        public DbSet<Item> Itens {get; set;}

        public DbSet<Almoxarife> Almoxarifes {get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //Área para futuros Inserts no banco
        }
    }
}