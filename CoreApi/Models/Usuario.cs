using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreApi.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        
        [Column(TypeName ="varchar(50)")]
        public string UserName { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string Password { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string Email { get; set; }
    }
}
