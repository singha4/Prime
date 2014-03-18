using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Prime
    {
        static void Main(string[] args)
        {
            
            for (int i = 3; i <= 150; i += 2)
            {

            if (i % 2 != 0 && i % 3 != 0 && i % 5 != 0 && i % 7 != 0 && i % 11 != 0)
            {
                
                Console.WriteLine(i);
                
            }

        }
            }
    }
}
