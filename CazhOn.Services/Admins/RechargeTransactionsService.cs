using AutoMapper;
using CazhOn.Core.Repository;
using CazhOn.Core.Services;
using CazhOn.Domain.Models;
using CazhOn.Dtos.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace CazhOn.Services.Admins
{
    public class RechargeTransactionsService : IRechargeTransactionsService
    {
        private IRechargeTransactionsRepo RechargeTransactionsRepo;
        private IMapper _mapper;
        public RechargeTransactionsService(IRechargeTransactionsRepo rechargeTransactionsRepo, IMapper mapper)
        {
            this.RechargeTransactionsRepo = rechargeTransactionsRepo;
            this._mapper = mapper;
        }
        public RechargeTransactionDTO GetRechargeTransactions(string Id)
        {
            try
            {
                var rechargetransactions = RechargeTransactionsRepo.GetRechargeTransactions(Id);
                var map_data = _mapper.Map<TblRechargeTransaction, RechargeTransactionDTO>(rechargetransactions);
                return map_data;
            }
            catch
            {
                throw;
            }
        }
        public IList<RechargeTransactionDTO> Search(RechargetransactionsDTO rechargetransactionsDTO)
        {
            try
            {
                var rechargetransactions = RechargeTransactionsRepo.Search(rechargetransactionsDTO);
                var map_data = _mapper.Map<IList<TblRechargeTransaction>, IList<RechargeTransactionDTO>>(rechargetransactions);
                return map_data;

            }
            catch
            {
                throw;
            }
        }
        public IList<RechargeTransactionDTO> GetRechargeTransactionsList(string id)
        {
            try
            {
                var rechargetransactions = RechargeTransactionsRepo.GetRechargeTransactionsList();
                var map_data = _mapper.Map<IList<TblRechargeTransaction>, IList<RechargeTransactionDTO>>(rechargetransactions);
                return map_data;
            }
            catch
            {
                throw;
            }
        }
      

    }
}
