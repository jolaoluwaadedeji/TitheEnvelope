using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TitheEnvelopeApi.Models.DTO
{
    [Table("UserRole", Schema = "dbo")]

    public class UserRole
    {
        public Role Role { get; set; }
        public User User { get; set; }
        public long RoleId { get; set; }
        public long UserId { get; set; }
    }
}
