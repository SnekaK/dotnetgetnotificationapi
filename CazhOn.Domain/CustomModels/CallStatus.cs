using System;
using System.Collections.Generic;
using System.Text;

namespace CazhOn.Domain.CustomModels
{
    public class CallStatus
    {
        public long CallStatusId { get; set; }

        public int ElapsedTimeInMinutes { get; set; }

        public bool Status { get; set; }
    }
}
