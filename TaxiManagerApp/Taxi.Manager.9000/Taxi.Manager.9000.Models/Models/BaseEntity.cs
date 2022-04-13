﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi.Manager._9000.Models.Models
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public BaseEntity() { }
        public BaseEntity(int id)
        {
            Id = id;
        }
    }

}
