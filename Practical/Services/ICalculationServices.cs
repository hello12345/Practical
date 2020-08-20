using Practical.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practical.Services
{
    public interface ICalculationServices
    {
        public Calculation calculation(Calculation calculation);
    }
}
