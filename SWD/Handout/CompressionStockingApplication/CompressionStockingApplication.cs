using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CompressionStocking;

namespace CompressionStockingApplication
{

    public class StubCompressionCtrl : ICompressionCtrl
    {
        private readonly ITimer _timer;
        private readonly IPump _pump;

        public StubCompressionCtrl(ITimer timer, IPump pump)
        {
            _timer = timer;
            _pump = pump;

        }

        public void Compress()
        {
            Console.WriteLine("StubCompressionCtrl::Compress() called");
            _pump.Pump();
            _timer.CompressTimer();
            _pump.StopPump();
        }

        public void Decompress()
        {
            Console.WriteLine("StubCompressionCtrl::Decompress() called");
            _pump.PumpBackwards();
            _timer.DecompressTimer();
            _pump.StopPump();
        }
    }



    class CompressionStockingApplication
    {
        static void Main(string[] args)
        {
            var compressionStocking = new StockingCtrl(new StubCompressionCtrl(new Timer5and2(), new TimedPump()));
            ConsoleKeyInfo consoleKeyInfo;
            
            Console.WriteLine("Compression Stocking Control User Interface");
            Console.WriteLine("A:   Compress");
            Console.WriteLine("Z:   Decompress");
            Console.WriteLine("ESC: Terminate application");

            do
            {
                consoleKeyInfo = Console.ReadKey(true); // true = do not echo character
                if (consoleKeyInfo.Key == ConsoleKey.A)  compressionStocking.StartBtnPushed();
                if (consoleKeyInfo.Key == ConsoleKey.Z)  compressionStocking.StopBtnPushed();

            } while (consoleKeyInfo.Key != ConsoleKey.Escape);
        }
    }
}
