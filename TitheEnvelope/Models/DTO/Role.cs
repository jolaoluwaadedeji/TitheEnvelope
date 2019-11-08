using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TitheEnvelopeApi.Models.DTO
{
    [Table("Role", Schema = "dbo")]
    public class Role: BaseObject
    {
       
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "RoleId")]
        public long RoleId { get; set; }

        [Display(Name = "RoleName")]
        [Required]
        [Column(TypeName = "varchar(100)")]
        public string Name { get; set; }

        public ICollection<UserRole> UserRoles { get; set; }
    }
}
