﻿using FermaAnimalelor.Infrastructura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FermaAnimalelor.Resurse
{
    class Oua : IResursa
    {
        public int Cantitate => 2;

        public string UnitateDeMasura => "bucati";
    }
}
