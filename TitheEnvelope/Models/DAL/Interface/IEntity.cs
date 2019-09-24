using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TitheEnvelopeApi.Models.DAL.Interface
{
    interface IEntity
    {
        Guid Id { get; set; }
    }
}
