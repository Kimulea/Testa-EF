using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testa_EF.Models
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public AditionalInfo AditionalInfo { get; set; }
        public ICollection<Group> Groups { get; set; }
        public ICollection<Availability> Availabilities { get; set; }
    }
}
