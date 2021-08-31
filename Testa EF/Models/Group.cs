using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testa_EF.Models
{
    public class Group : BaseEntity
    {
        public string Name { get; set; }
        public int Level { get; set; }

        public ICollection<User> Users { get; set; }
    }
}
