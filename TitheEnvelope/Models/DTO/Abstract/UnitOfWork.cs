using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TitheEnvelope.DAL.Models;
using TitheEnvelopeApi.Models.DTO.Interface;

namespace TitheEnvelopeApi.Models.DTO.Abstract
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly TitheContext _titheContext;
        private IGenericRepository<TithePaymentDetail> _tithePaymentDetailRepository;
        private IGenericRepository<TitherDetail> _titherDetailRepository;

        public  UnitOfWork(TitheContext titheContext){
            _titheContext = titheContext;
        }
        public IGenericRepository<TithePaymentDetail> TithePaymentRepository
        {
            get
            {
                return _tithePaymentDetailRepository = _tithePaymentDetailRepository ?? new GenericRepository<TithePaymentDetail>(_titheContext);
            }
        }

        public IGenericRepository<TitherDetail>  TitherDetailRepository
        {
            get
            {
                return _titherDetailRepository = _titherDetailRepository ?? new GenericRepository<TitherDetail>(_titheContext);
            }
        }

        public void Save()
        {
            _titheContext.SaveChanges();
        }

    }
}
