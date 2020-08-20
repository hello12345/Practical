using Practical.Models;
using Practical.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Practical.Helper.EnumsCollection;

namespace Practical.Implementation
{
    public class CalculationMethod: ICalculationServices
    {
        public Calculation calculation(Calculation calculation)
        {

            if (calculation.CalculationType == MethodType.Method1)
            {
                calculation.result = calculation.value1 * calculation.value2;
            }
            else if(calculation.CalculationType == MethodType.Method2)
            {
                calculation.result= (calculation.value1 + calculation.value2) - (calculation.value1 * calculation.value2);
            }
            return calculation;
        }
    }
}
