using Practical.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practical.Helper
{
    public static class CommonHelper
    {
        public static string logmessage(Calculation calculation)
        {
            return string.Format("\n Date: {0} \n Type Of calculation:{1} \n " +
                "Input 1 : {2} \n Input 2 : {3} \n Result : {4} \n", 
                DateTime.UtcNow, calculation.CalculationType, calculation.value1,
                calculation.value2, calculation.result);
        }
    }
}
