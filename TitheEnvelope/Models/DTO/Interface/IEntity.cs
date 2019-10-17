using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TitheEnvelopeApi.Models.DTO.Interface
{
    public interface IEntity
    { 
         long Id { get; set; }
         DateTime? DateUpdated { get; set; }
         DateTime DateInserted { get; set; } 
         bool IsDeleted { get; set; }
    }
}
