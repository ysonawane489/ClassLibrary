﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesSpace
{
   public static class Class2
    {
        
        
            public static bool StartsWithUpper(this string str)
            {
                if (string.IsNullOrWhiteSpace(str))
                    return false;

                char ch = str[0];
                return char.IsUpper(ch);
            }
        }
    }


