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
    public class MissingCashbackService : IMissingCashbackService
    {
        private ICashbackRepo CashbackRepo;
        private IMapper _mapper;
        public MissingCashbackService(ICashbackRepo cashbackRepo,IMapper mapper)
        {
            this.CashbackRepo = cashbackRepo;
            this._mapper = mapper;
        }
        public CashbackDTO GetCashback(string Id)
        {
            try
            {
                var cashbacklist = !string.IsNullOrEmpty(Id) ? CashbackRepo.GetCashbackList(Id) :
                    CashbackRepo.GetCashbackList();
                 var map_data = _mapper.Map<IList<Tblmissingcashback>, IList<CashbackDTO>>(cashbacklist)[0];
                return map_data;
            }
            catch
            {
                throw;
            }
        }
    

        public IList<CashbackDTO> GetCashbackList(string Id)
        {
            try
            {
                var cashbacklist = !string.IsNullOrEmpty(Id) ? CashbackRepo.GetCashbackList(Id) :
                 CashbackRepo.GetCashbackList();
               
                var map_data = _mapper.Map<IList<Tblmissingcashback>, IList<CashbackDTO>>(cashbacklist);
                return map_data;
            }
            catch
            {
                throw;
            }
        }

        public int InsertCashback(CashbackDTO tblcashback)
        {
            throw new NotImplementedException();
        }

        public IList<CashbackDTO> Search(DateTime startdateTime,DateTime enddateTime, string PaymentStatus)
        {
            try
            {
                var cashbacklist = CashbackRepo.Search(startdateTime,enddateTime,PaymentStatus);

                var map_data = _mapper.Map<IList<Tblmissingcashback>, IList<CashbackDTO>>(cashbacklist);
                return map_data;
            }
            catch
            {
                throw;
            }
        }

        public int UpdateCashback(CashbackDTO cashbackDTO)
        {
            try
            {

                var data = _mapper.Map<CashbackDTO, Tblmissingcashback>(cashbackDTO);
                data.CashbackGuid = cashbackDTO.CashbackGuid;
                data.CashbackStatusId = cashbackDTO.ClaimStatus;
                return CashbackRepo.UpdateCashback(data);
            }
            catch
            {

                throw;
            }
        }
    }
}
