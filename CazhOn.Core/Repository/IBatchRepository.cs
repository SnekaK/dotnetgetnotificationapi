using CazhOn.Domain.CustomModels;
using CazhOn.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CazhOn.Core.Repository
{
    public interface IBatchRepository : IRepository<Tblemailnotificationbatch>
    {
        CallStatus CheckIfBatchRunningForGivenBatchName(string batchName, string batchStatus);        
    }
}
