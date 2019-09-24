using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TitheEnvelopeApi.Models.DAL.Interface;

namespace TitheEnvelopeApi.Models.DAL.Abstract
{
    public class GenericRepository<T> : IGenericRepository<T> where T: class
    {
    }
}
