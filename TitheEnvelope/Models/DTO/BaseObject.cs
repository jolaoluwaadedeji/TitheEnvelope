using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using TitheEnvelopeApi.Models.DTO.Interface;

namespace TitheEnvelopeApi.Models.DTO
{
    public class BaseObject
    {
        
        [Column(TypeName = "datetime")]
        public DateTime ? DateUpdated { get; set; } 

        [Required]
        [Column(TypeName = "datetime")]
        public DateTime DateInserted { get; set; } = DateTime.Now;

        [Required]
        [Column(TypeName = "bit")]
        public bool IsDeleted { get; set; } 
    }
}
