using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ReceptorSensoresAPI.Persistence
{
    [Table("ReceptorSinal")]
    public class SignalData
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Time_stamp { get; set; }
        public string Tag { get; set; }
        public string Valor { get; set; }

    }
}
