﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.Class01.Exercise3.Models
{
    public class User
    {
        int SelectedRole { get; set; }

        public User(int role)
        {
            SelectedRole = role;
        }
    }

    
}
