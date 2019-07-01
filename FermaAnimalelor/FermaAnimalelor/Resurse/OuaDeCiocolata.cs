﻿using FermaAnimalelor.Infrastructura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FermaAnimalelor.Resurse
{
    class OuaDeCiocolata : IResursa
    {
        public int Cantitate => 5;

        public string UnitateDeMasura => "buc";
    }
}
