using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using CalculatorReliableActor.Interfaces;
using Microsoft.ServiceFabric;
using Microsoft.ServiceFabric.Actors;

namespace CalculatorReliableActor
{
    public class CalculatorReliableActor : Actor, ICalculatorReliableActor
    {
        public async Task<double> Add(double x, double y)
        {
            ActorEventSource.Current.ActorMessage(this, "Adding");

            return await Task.FromResult(x + y);
        }
        public async Task<double> Subtract(double x, double y)
        {
            ActorEventSource.Current.ActorMessage(this, "Subtracting");

            return await Task.FromResult(x - y);
        }
        public async Task<double> Multiply(double x, double y)
        {
            ActorEventSource.Current.ActorMessage(this, "Multiplying");

            return await Task.FromResult(x * y);
        }
        public async Task<double> Divide(double x, double y)
        {
            ActorEventSource.Current.ActorMessage(this, "Dividing");

            return await Task.FromResult(x / y);
        }
    }
}
