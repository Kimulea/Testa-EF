using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testa_EF.Models
{
    public class Hobby : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<AditionalInfo> AditionalInfos { get; set; }
    }
}
