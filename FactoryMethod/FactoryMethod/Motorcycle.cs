﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class Motorcycle: Vehicle
    {
        public override int MaxSpeed()
        {
            return 180;
        }
    }
}
