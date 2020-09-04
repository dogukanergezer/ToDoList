using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskList.Domain
{
    public class UserEntity
    {
        [Key]
        public int UserId { get; set; }
        [Required]
        [Column(TypeName = "Varchar(20)")]
        public string Username { get; set; }
        [Required]
        [Column(TypeName = "Varchar(10)")]
        public string Password { get; set; }
    }
}
