using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domains
{
    public class Log:BaseEntity
    {
        public Log()
        {
            LogTime = DateTime.Now;
        }
        public DateTime LogTime { get; set; }
        public string ActionName { get; set; }

    }
}
