using api_filmes_senai.Domains;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace api_filmes_senai.Context
{
    public class Filmes_Context : DbContext
    {
       
        public Filmes_Context()
        {
        }

        public Filmes_Context(DbContextOptions<Filmes_Context> options)
            : base(options)
        {
        }

        public DbSet<Genero> Generos { get; set; }
        public DbSet<Filme> Filmes { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server = DESKTOP-S3CGL03\\SQLEXPRESS; Database = filmes; User id = sa; Pwd = Senai@134; trustServerCertificate = true;");
            }
        }
    }
}