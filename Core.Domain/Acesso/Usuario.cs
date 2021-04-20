using System;
using System.Collections.Generic;

namespace Core.Domain.Acesso
{
    public class Usuario: EntidadeBase
    {
        public string Nome { get; set; }
        public string NomeCompleto { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
        public bool Verificado { get; set; }
        public bool Travado { get; set; }
        public string Chave { get; set; }
        public List<UsuarioPerfil> UsuarioPerfis { get; set; }
    }

    public class Perfil: EntidadeBase
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public List<UsuarioPerfil> UsuarioPerfis { get; set; }
    }

    public class UsuarioPerfil : EntidadeBase
    {
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
        public int PerfilId { get; set; }
        public Perfil Perfil { get; set; }
    }
}
