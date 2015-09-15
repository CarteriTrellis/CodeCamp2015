using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Akka;
using Akka.Actor;

namespace CalculatorAkkaDotNetActor
{

    public class CalculateMessage
    {
        public enum Op
        {
            Add,
            Subtract,
            Multiply,
            Divide
        }

        public CalculateMessage(Op operation, double x, double y)
        {
            Operation = operation;
            X = x;
            Y = y;
        }

        public Op Operation { get; private set; }
        public double X { get; private set; }
        public double Y { get; private set; }
    }

    public class CalculatorActor : UntypedActor
    {
        protected override void OnReceive(object message)
        {
            if (message as CalculateMessage == null)
            {
                throw new ArgumentException();
            }

            CalculateMessage msg = (CalculateMessage) message;

            Console.Write("From Actor {0}: ", this.Self.Path);

            switch(msg.Operation)
            {
                case CalculateMessage.Op.Add:
                    Console.WriteLine(msg.X + msg.Y);
                    break;
                case CalculateMessage.Op.Subtract:
                    Console.WriteLine(msg.X - msg.Y);
                    break;
                case CalculateMessage.Op.Multiply:
                    Console.WriteLine(msg.X * msg.Y);
                    break;
                case CalculateMessage.Op.Divide:
                    Console.WriteLine(msg.X / msg.Y);
                    break;
                default:
                    throw new ArgumentException();
            }
        }
    }
}
