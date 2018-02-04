using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace masiviuprajneniq
{
    class uprajnenie1
    {

        static string[] ReplaceMy(string command, string[] arr)
        {
            string[] result = arr;
            string[] commandParam = command.Split(' ').ToArray();
            string commandName = commandParam[0];
            int index = int.Parse(commandParam[1]);
            string word = commandParam[2];
            result[index] = word;
            return result;

        }
        static void Main(string[] args)
        {

            string[] numsList = Console.ReadLine().Split(' ').ToArray();

            int n = int.Parse(Console.ReadLine()); //br comandi
            for (int i = 0; i < n; i++)
            {
                string command = Console.ReadLine();
                switch (command)
                {
                    case "Reverse":
                        {
                            Array.Reverse(numsList);
                            break;
                        }

                    case "Distinct":
                        {
                            
                            string[] newlist=numsList.Distinct().ToArray();
                            Console.WriteLine(string.Join(" - ", newlist));
                            break;

                        }

                    default:
                        {
                            numsList = ReplaceMy(command, numsList);
                            break;
                        }

                        
                }
            }
            //Console.WriteLine(string.Join(" - ", numsList));
        }

    }
}

