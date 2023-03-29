using CazhOn.Domain.Models;
using System.Collections.Generic;

namespace CazhOn.Core.Repository
{
    public interface IBonusRewardsRepository: IRepository<TblBonusrewards>
    {
        public IList<TblBonusrewards> GetBonusRewardsList();
        int InsertBonusRewards(TblBonusrewards tblBonusRewards);

        int UpdateBonusRewards(TblBonusrewards tblBonusRewards);

        TblBonusrewards GetBonusRewards(string Id);

       
    }
}
