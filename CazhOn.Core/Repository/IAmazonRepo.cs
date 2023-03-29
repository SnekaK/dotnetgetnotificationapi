using CazhOn.Dtos.DTO;
using System.Collections.Generic;
using System.Data;

namespace CazhOn.Core.Repository
{
    public interface IAmazonRepo
    {
        public List<AmazonDTO> getamazontracking();
        public int UpdateAmazonTracking(DataTable dt);
    }
}
