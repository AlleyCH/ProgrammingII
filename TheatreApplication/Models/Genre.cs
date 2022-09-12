﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheatreApplication.Models
{
    [Flags]
   public enum Genre
    {
        Undrated = 0,
        Action = 1,
        Romance = 2,
        Documentary = 4, 
        Mystery = 8,
        Musical = 16,
        Horror = 32, 
        Comedy = 64,
        Fantasy = 128, 
        Animation = 256,
        Adventure = 512
    }
}
