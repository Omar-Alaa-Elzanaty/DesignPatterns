﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Furniture
{
	internal class ModernBed:BedFactory
	{
        public ModernBed()
        {
            BedName = "Modern Bed";
        }
    }
}