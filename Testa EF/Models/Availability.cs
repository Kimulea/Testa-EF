using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testa_EF.Models
{
    public class Availability : BaseEntity
    {
        public int Hour { get; set; }
        public int Minute { get; set; }
        public int DayOfWeek { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}
