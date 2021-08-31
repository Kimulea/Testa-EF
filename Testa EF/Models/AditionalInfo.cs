﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testa_EF.Models
{
    public class AditionalInfo : BaseEntity
    {
        public string Description { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public ICollection<Hobby> Hobbies { get; set; }
    }
}