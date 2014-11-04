using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace Radix_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();
            var testArray = new int[1000];
            for(int i = 999; i >= 0; i--){
                testArray[i] = rand.Next(10000);
            }

            Sorter sort = new Sorter();
            var timeIt = new Stopwatch();
            timeIt.Start();
            sort.Radix(testArray);
            timeIt.Stop();

            int count = 0;
            foreach(int i in testArray){
                if(count % 10 == 0){
                    Console.WriteLine();
                    count = 0;
                }
                Console.Write(i + ", ");
                count ++;
            }
            Console.WriteLine(timeIt.Elapsed);
        }
    }
}
