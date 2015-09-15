using CalculatorReliableActor.Interfaces;
using Microsoft.ServiceFabric.Actors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceFabricReliableActor.Client
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var proxy = ActorProxy.Create<ICalculatorReliableActor>(ActorId.NewId(), "fabric:/ServiceFabricReliableActor");

            Console.WriteLine("From Actor {0}: {1}", proxy.GetActorId(), proxy.Add(1, 1).Result);
            Console.WriteLine("From Actor {0}: {1}", proxy.GetActorId(), proxy.Subtract(0, 1).Result);
            Console.WriteLine("From Actor {0}: {1}", proxy.GetActorId(), proxy.Multiply(0.5f, 3f).Result);
            Console.WriteLine("From Actor {0}: {1}", proxy.GetActorId(), proxy.Divide(11f, 2f).Result);
            Console.WriteLine("Press any key to exit.");
            Console.ReadLine();
        }
    }
}
