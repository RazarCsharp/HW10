using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppForHW
{
    internal class Logger : ILogger
    {
        public void Blue() { Console.ForegroundColor = ConsoleColor.Blue; }

        public void Red() { Console.ForegroundColor = ConsoleColor.Red; }
    }
}
