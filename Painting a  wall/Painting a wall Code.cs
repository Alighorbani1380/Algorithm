using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewYearHomeWork
{
     class Program                           //Ali Ghorbani Bargani 99405065
     {
          static void Main(string[] args)
          {

               int Counter = 0;
               int Length = Convert.ToInt32(Console.ReadLine());
               int[] Blocks = new int[Length];
               GetBlockNumber(Blocks);
               Counter = ProblemSolver(Counter, Length, Blocks);
               Console.WriteLine(Counter);

          }

          private static int ProblemSolver(int Counter, int Length, int[] Blocks)
          {
               for (int i = 0; i < Length; i++) //Peymayesh Araye   //i => Soton
               {
                    for (; Blocks[i] > 0;)
                    {
                         int j = 0;     //j => Tool Satr
                         for (int k = i; k < Length; k++) //Bedast Avardan Tool Satr Ghabl Rang
                         {
                              if (Blocks[k] == 0)
                              {
                                   break;
                              }
                              j++;
                         }
                         if (Blocks[i] >= j) 
                         {
                              Blocks[i] = 0; // Rang Be Soorat Amoodi
                              Counter++;
                         }
                         else
                         {
                              for (int k = i; k < i + j; k++) //Rang Be Soorat Ofoghi
                              {
                                   Blocks[k]--; 
                              }
                              Counter++;
                         }
                    }

               }

               return Counter;
          }

          private static void GetBlockNumber(int[] Blocks)
          {
               string blocksnumber = Console.ReadLine();
               string[] blocksstring = blocksnumber.Split(' ').ToArray();
               for (int i = 0; i < Blocks.Length; i++)
               {
                    Blocks[i] = Convert.ToInt32(blocksstring[i]);
               } 
          }
     }
}
