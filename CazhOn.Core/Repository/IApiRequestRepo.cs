using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CazhOn.Domain.Models;
namespace CazhOn.Core.Repository
{
    public interface IApiRequestRepo
    {
        public long Insert(Tblapirequestresponselogs tblapirequestresponselogs);
        public Tblapirequestresponselogs GetTblapirequestresponselogs(long id);
        public  int Update(Tblapirequestresponselogs tblapirequestresponselogs);
    }
}
