using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Akka;
using Akka.Actor;

namespace CalculatorAkkaDotNetActor
{
    class Program
    {
        public static ActorSystem MyActorSystem;

        static void Main(string[] args)
        {
            MyActorSystem = ActorSystem.Create("MySystem");

            var calculator = MyActorSystem.ActorOf<CalculatorActor>();

            var addMessage = new CalculateMessage(CalculateMessage.Op.Add, 1,1);
            var subMessage = new CalculateMessage(CalculateMessage.Op.Subtract, 0, 1);
            var divMessage = new CalculateMessage(CalculateMessage.Op.Divide, 11f, 2f);
            var mltMessage = new CalculateMessage(CalculateMessage.Op.Multiply, 0.5f, 3f);

            calculator.Tell(addMessage);
            calculator.Tell(subMessage);
            calculator.Tell(divMessage);
            calculator.Tell(mltMessage);

            Console.WriteLine("Press any key to exit.");
            Console.ReadLine();
        }
    }
}
