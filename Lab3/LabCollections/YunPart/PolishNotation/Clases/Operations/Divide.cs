﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.LabCollections.YunPart.PolishNotation.Clases.Operations
{
    internal class Divide : Operation
    {
        public override string Name => "/";
        public override int Priority => 2;
        public override bool IsFunction => false;
        public override int ArgsCount => 2;
        public override Number Execute(params Number[] numbers)
        {
            double firstNum = numbers[0].Numbering;
            double secondNum = numbers[1].Numbering;
            // double maxNum = Math.Max(firstNum, secondNum);
            // double minNum = Math.Min(firstNum, secondNum);
            // return new Number(maxNum / minNum);
            return new Number(firstNum / secondNum);



        }
    }
}
