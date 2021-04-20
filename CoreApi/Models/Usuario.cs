using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreApi.Models
{
    public class UsuarioDTO
    {
        //[Key]
        //public int Id { get; set; }

        //[Column(TypeName = "varchar(50)")]
        //public string UserName { get; set; }

        //[Column(TypeName = "varchar(100)")]
        //public string Password { get; set; }

        //[Column(TypeName = "varchar(50)")]
        //public string Email { get; set; }

        public int ID { get; set; }
        public string Nome { get; set; }
        public string NomeCompleto { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
        public bool Verificado { get; set; }
        public bool Travado { get; set; }
        public string Chave { get; set; }
    }

   
}
