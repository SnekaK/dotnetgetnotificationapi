using System;
using System.Collections.Generic;
using System.Text;
using CazhOn.Domain.Models;
using CazhOn.Core.Services;
using CazhOn.Dtos.DTO;
using CazhOn.Core.Repository;
using AutoMapper;
using System.Text.RegularExpressions;

namespace CazhOn.Services.Admins
{
    public class BonusRewardsService : IBonusRewardsService
    {
        private IBonusRewardsRepository bonusRewardsRepository;
        private IGroupCodeRepo groupCodeRepo;
      
        private IMapper _mapper;
        public BonusRewardsService(IBonusRewardsRepository bonusRewardsRepository, IMapper mapper,
            IGroupCodeRepo groupCodeRepo)
        {
            this.bonusRewardsRepository = bonusRewardsRepository;
            this._mapper = mapper;
            this.groupCodeRepo = groupCodeRepo;
        }
        public IList<BonusRewardsDTO> GetBonusRewardsFilter(string keyword)
        {
            throw new NotImplementedException();
        }

        public IList<BonusRewardsDTO> GetBonusRewardsList()
        {
            try
            {
                var BonusRewardsList = bonusRewardsRepository.GetBonusRewardsList();
                var map_data = _mapper.Map<IList<TblBonusrewards>, IList<BonusRewardsDTO>>(BonusRewardsList);
                return map_data;
            }
            catch
            {
                throw;
            }
        }

        public BonusRewardsDTO GetBonusRewardsList(string Id)
        {
            try
            {
                var BonusRewardsList = bonusRewardsRepository.GetBonusRewards(Id);
                var map_data = _mapper.Map<TblBonusrewards,BonusRewardsDTO>(BonusRewardsList);
                return map_data;
            }
            catch
            {
                throw;
            }
        }

        public IList<GroupCodeList> GetGroupCodeList(string type)
        {
            try
            {
                var GroupCode = groupCodeRepo.GetBR(type);
                var map_data = _mapper.Map<IList<Tbllkuplist>, IList<GroupCodeList>>(GroupCode);
                return map_data;
            }
            catch
            {
                throw;
            }
        }

        public int InsertBonusRewardsList(BonusRewardsDTO bonusRewards)
        {
            try
            {
                var data = _mapper.Map<BonusRewardsDTO, TblBonusrewards>(bonusRewards);
                data.BonusRewardsGuid = Guid.NewGuid().ToString();
                return bonusRewardsRepository.InsertBonusRewards(data);
            }
            catch
            {
                throw;
            }
        }

        public int UpdateBonusRewardsList(BonusRewardsDTO bonusRewards)
        {
            try
            {
                var data = _mapper.Map<BonusRewardsDTO, TblBonusrewards>(bonusRewards);
             
                data.UpdatedDate = DateTime.Now;
                data.UpdatedDateUTC = DateTime.UtcNow;
                
                return bonusRewardsRepository.Update(data);
            }
            catch
            {
                throw;
            }
        }
    }
}
