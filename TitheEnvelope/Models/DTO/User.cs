using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using TitheEnvelopeApi.Models.DTO.Interface;

namespace TitheEnvelopeApi.Models.DTO
{
    [Table("User", Schema = "dbo")]
    public class User: BaseObject
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "UserId")]
        public long UserId { get; set; }

        [Required]
        [Display(Name ="Username")]
        [Column(TypeName ="varchar(100)")]
        public string Username { get; set; }


        [Required]
        [Display(Name = "LastName")]
        [Column(TypeName = "varchar(100)")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "FirstName")]
        [Column(TypeName = "varchar(100)")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Email")]
        [Column(TypeName = "varchar(100)")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Password")]
        [Column(TypeName = "binary(64)")]
        public string Password { get; set; }


        public ICollection<UserRole> UserRoles { get; set; }

    }
}
