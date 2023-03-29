using CazhOn.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CazhOn.Core.Repository
{
    public interface IBannerRepo : IRepository<Tblbanner>
    {
        IList<Tblbanner> GetBannerList(string Id);     
    }
 
}
