using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroEmpresa.Models
{
    public class Contexto : DbContext
    {
        // Referencia para criação da base de dados.
        public Contexto (DbContextOptions<Contexto> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Empresa> Empresas { get; set; }
    }
}
