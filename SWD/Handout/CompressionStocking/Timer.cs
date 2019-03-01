using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompressionStocking
{
    public interface ITimer
    {
        void CompressTimer();
        void DecompressTimer();
    }

    public class Timer5and2: ITimer 
    {

        public void CompressTimer()
        {

            Console.WriteLine("Waiting for 5 seconds");
        }

        public void DecompressTimer()
        {
            Console.WriteLine("Waiting for 2 seconds");
        }
    }
}
