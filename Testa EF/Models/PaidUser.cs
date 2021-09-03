using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testa_EF.Models
{
    public class PaidUser : User
    {
        public int Balance { get; set; }
    }
}
