using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11urok2uprajnenie2zadacha
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> result = new List<int>();
            int maxCount = 1;
            int count = 1;
            int element = numList[0] ; 
            for (int i = 0; i < numList.Count-1; i++)
            {
                if (numList[i] == numList[i+1])
                {
                    count++;
                   
                }
                else
                {
                    if (maxCount<count)
                    {
                        maxCount = count;
                        element = numList[i];
                    }
                    count = 1;
                }
            
                }
                for (int i = 1; i <= maxCount; i++)
                {

            Console.Write( element + " " );
            }
        }
    }
}
