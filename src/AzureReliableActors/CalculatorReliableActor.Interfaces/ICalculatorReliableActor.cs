using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.ServiceFabric.Actors;

namespace CalculatorReliableActor.Interfaces
{
    public interface ICalculatorReliableActor : IActor
    {
        Task<double> Add(double x, double y);
        Task<double> Subtract(double x, double y);
        Task<double> Multiply(double x, double y);
        Task<double> Divide(double x, double y);
    }
}
