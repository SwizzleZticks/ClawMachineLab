﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClawMachineLab
{
    public class Reward
    {
        string? _name;
        decimal _value;

        public string? Name 
        { 
            get { return _name; } 
            set { _name = value; }
        }
        public decimal Value 
        { 
            get { return _value; }
            set { _value = value; } 
        }

        public Reward(string name, decimal value)
        {
            _name = name;
            _value = value;
        }
    }
}
