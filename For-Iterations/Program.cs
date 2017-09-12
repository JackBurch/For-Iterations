using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_Iterations
{
    class Program
    {
        static void Main(string[] args)
        {
            //increase "i" by 1 10 times. 
            // when i = 7, it prints found 7
            for (int i = 0; i <10; i++)
            {
                Console.WriteLine(i.ToString());
                // 
                if(i == 7)
                {
                    Console.WriteLine("Found seven!");
                    break;
                }

            }
            // myValue increases 12 times
            
            for (int myValue = 0; myValue < 12; myValue++)
            {
                Console.WriteLine(myValue);   
            }
            
            Console.ReadLine();
        }
    }
}
