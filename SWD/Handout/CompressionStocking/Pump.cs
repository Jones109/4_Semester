using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompressionStocking
{
    public interface IPump
    {
        void Pump();
        void PumpBackwards();
        void StopPump();
    }


    public class TimedPump : IPump
    {
        public void Pump()
        {
            Console.WriteLine("Pump is starting");
        }

        public void PumpBackwards()
        {
            Console.WriteLine("Pump is starting backwards");
        }

        public void StopPump()
        {
            Console.WriteLine("Pump is stopping");
        }
    }
}
