using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimeGraphServer.Models
{
    public class TimeLog
    {
        public int Id { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }

        public string User { get; set; }

        public int ProjectId { get; set; }
        public Project Project { get; set; }
    }
}
