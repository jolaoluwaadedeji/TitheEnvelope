using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TitheEnvelopeApi.Models.DTO.Interface
{
   public interface IUnitOfWork
    {
        IGenericRepository<TitherDetail> TitherDetailRepository { get;}
        IGenericRepository<TithePaymentDetail> TithePaymentRepository { get;}
        void Save();

    }
}
