﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator
{
    class Human:Sentient
    {
        public Human() { }
        public Human(int str, int sta, string nam, int intel) :base (str,sta,nam, intel){

        }
        public override string PrintRace()
        {
            return base.PrintRace() ;
        }
    }
}
