﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lab3.LabCollections.YunPart.PolishNotation.Clases
{
    public class Variable : Token
    {
        public char variable { get; }

        public Variable(char x)
        {
            variable = x;
        }
    }
}
