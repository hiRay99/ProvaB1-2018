using Microsoft.EntityFrameworkCore;
using SGA.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGA.Infrastructure.Data
{
    public class AlunoContext : DbContext
    {
        public AlunoContext(DbContextOptions<AlunoContext> options) : base(options)
        {

        }
        public DbSet<Participante> Participantes { get; set; }

        public DbSet<Endereco> Enderecos { get; set; }

        public DbSet<Trabalho> Trabalhos { get; set; }

        public DbSet<Categoria>  Categorias { get; set; }

        public DbSet<Avaliacao> Avaliacoes { get; set; }
    }
}
