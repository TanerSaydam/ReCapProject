﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class FindeksService : IEntity
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int FindeksScore { get; set; }
    }
}
