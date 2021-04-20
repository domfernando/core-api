using Core.Domain;
using Core.Domain.Acesso;
using Microsoft.EntityFrameworkCore;
using System;

namespace Core.Data
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Perfil> Perfis { get; set; }
        public DbSet<UsuarioPerfil> UsuarioPerfis { get; set; }
    }
}
