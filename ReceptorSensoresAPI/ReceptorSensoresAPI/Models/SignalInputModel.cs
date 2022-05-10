using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReceptorSensoresAPI.Models
{
    public struct SignalInputModel
    {
        public string Time_stamp { get; set; }
        public string Tag { get; set; }
        public string Valor { get; set; }
    }
}
