using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisOrThatCLI
{
    public class Program
    {
        static void Main(string[] args)
        {
            DatabaseFile dbFile = new DatabaseFile(args[0]);

            bool isRunning = true;
            while(isRunning)
            {
                Console.Write("> ");
                int input = Console.Read();

                if (input == (int)'q')
                {
                    isRunning = false;
                }
            }

        }
    }
}
