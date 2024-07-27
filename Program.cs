using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TamrinMaze
{
     class Program                    //Ali Ghorbani bargani 99405065
     {
          static void Main(string[] args)
          {
               int WidthAndLength, PenaltyTime, Target, Start, Start2, NumOfVertexes;
               char[] Maze;
               int[,] Graph; ;
               GetDataFromConsole(out WidthAndLength, out PenaltyTime, out Maze, out Target, out Start, out Start2, out NumOfVertexes, out Graph);
               MakeGraphsWithMatris(WidthAndLength, PenaltyTime, ref Target, ref Start, ref Start2, Maze, Graph);
               int Man = Dijkstra.GetMinimumPathCost(Graph, Start, NumOfVertexes, Target);
               //int BatMan = Dijkstra.GetMinimumPathCost(Graph2, Start2, NumOfVertexes, Target);
               int BatMan = BFS.GetMinimumPathCost(Graph, Start2,Target,NumOfVertexes);
               Console.WriteLine(Man);
               Console.WriteLine(BatMan);
          }

          private static void MakeGraphsWithMatris(int WidthAndLength, int PenaltyTime, ref int Target, ref int Start, ref int Start2, char[] Maze, int[,] Graph)
          {
               for (int i = 0; i < Maze.Length; i++)
               {
                    int rast = i + 1;
                    int chap = i - 1;
                    int bala = i - WidthAndLength;
                    int paiin = i + WidthAndLength;
                    SamtRast(WidthAndLength, PenaltyTime, ref Target, ref Start, ref Start2, Maze, Graph, i, rast);
                    Bala(WidthAndLength, PenaltyTime, ref Target, ref Start, ref Start2, Maze, Graph, i, bala);
                    SamtChap(WidthAndLength, PenaltyTime, ref Target, ref Start, ref Start2, Maze, Graph, i, chap);
                    Pain(WidthAndLength, PenaltyTime, ref Target, ref Start, ref Start2, Maze, Graph, i, paiin);
               }
          }

          private static void Pain(int WidthAndLength, int PenaltyTime, ref int Target, ref int Start, ref int Start2, char[] Maze, int[,] Graph, int i, int paiin)
          {
               if (paiin >= 0 && !((i + 1) > ((WidthAndLength * WidthAndLength) - WidthAndLength)))
               {
                    if (Maze[paiin] == 'O' || Maze[paiin] == 'A' || Maze[paiin] == 'S' || Maze[paiin] == 'T')
                    {
                         Graph[i, paiin] = 1;
                         if (Maze[paiin] == 'T')
                         {
                              Target = paiin;
                         }
                         if (Maze[paiin] == 'A')
                         {
                              Start2 = paiin;
                         }
                         if (Maze[paiin] == 'S')
                         {
                              Start = paiin;
                         }

                    }
                    else if (Maze[paiin] == 'X')
                    {
                         Graph[i, paiin] = PenaltyTime + 1;
                    }

               }
          }

          private static void SamtChap(int WidthAndLength, int PenaltyTime, ref int Target, ref int Start, ref int Start2, char[] Maze, int[,] Graph,  int i, int chap)
          {
               if (chap >= 0 && (i + 1) % WidthAndLength != 1)
               {
                    if (Maze[chap] == 'O' || Maze[chap] == 'A' || Maze[chap] == 'S' || Maze[chap] == 'T')
                    {
                         Graph[i, chap] = 1;
                         
                         if (Maze[chap] == 'T')
                         {
                              Target = chap;
                         }
                         if (Maze[chap] == 'A')
                         {
                              Start2 = chap;
                         }
                         if (Maze[chap] == 'S')
                         {
                              Start = chap;
                         }
                    }
                    else if (Maze[chap] == 'X')
                    {
                         Graph[i, chap] = PenaltyTime + 1;
                         
                    }

               }
          }

          private static void Bala(int WidthAndLength, int PenaltyTime, ref int Target, ref int Start, ref int Start2, char[] Maze, int[,] Graph, int i, int bala)
          {
               if (bala >= 0 && !((i + 1) < WidthAndLength))
               {
                    if (Maze[bala] == 'O' || Maze[bala] == 'A' || Maze[bala] == 'S' || Maze[bala] == 'T')
                    {
                         Graph[i, bala] = 1;
                         
                         if (Maze[bala] == 'T')
                         {
                              Target = bala;
                         }
                         if (Maze[bala] == 'A')
                         {
                              Start2 = bala;
                         }
                         if (Maze[bala] == 'S')
                         {
                              Start = bala;
                         }
                    }
                    else if (Maze[bala] == 'X')
                    {
                         Graph[i, bala] = PenaltyTime + 1;
                         
                    }

               }
          }

          private static void SamtRast(int WidthAndLength, int PenaltyTime, ref int Target, ref int Start, ref int Start2, char[] Maze, int[,] Graph, int i, int rast)
          {
               if (rast >= 0 && (i + 1) % WidthAndLength != 0)
               {
                    if (Maze[rast] == 'O' || Maze[rast] == 'A' || Maze[rast] == 'S' || Maze[rast] == 'T')
                    {
                         Graph[i, rast] = 1;
                         
                         if (Maze[rast] == 'T')
                         {
                              Target = rast;
                         }
                         if (Maze[rast] == 'A')
                         {
                              Start2 = rast;
                         }
                         if (Maze[rast] == 'S')
                         {
                              Start = rast;
                         }
                    }
                    else if (Maze[rast] == 'X')
                    {
                         Graph[i, rast] = PenaltyTime + 1;
                        
                    }

               }
          }

          private static void GetDataFromConsole(out int WidthAndLength, out int PenaltyTime, out char[] Maze, out int Target, out int Start, out int Start2, out int NumOfVertexes, out int[,] Graph)
          {
               string inputednumber = Console.ReadLine();
               WidthAndLength = Convert.ToInt32(inputednumber.Split(' ')[0]);
               PenaltyTime = Convert.ToInt32(inputednumber.Split(' ')[1]);
               Maze = new char[WidthAndLength * WidthAndLength];
               Target = 0;
               Start = 0;
               Start2 = 0;
               NumOfVertexes = WidthAndLength * WidthAndLength;
               for (int i = 0; i < WidthAndLength; i++)
               {
                    string input = Console.ReadLine();
                    for (int j = 0; j < WidthAndLength; j++)
                    {
                         Maze[(i * WidthAndLength) + j] = input[j];
                    }
               }
               Graph = new int[NumOfVertexes, NumOfVertexes];
              
               for (int i = 0; i < WidthAndLength; i++)
               {
                    for (int j = 0; j < WidthAndLength; j++)
                    {
                         Graph[i, j] = 0;
                         
                    }
               }
          }
     }
     public class Dijkstra
     {
          
          
          public static int GetMinimumPathCost(int[,] Graph, int Start,int Vertex,int target)
          {

               int[] Distances = new int[Vertex];
               bool[] SetedVertexes = new bool[Vertex];
               INIT(Start, Vertex, Distances, SetedVertexes);
               for (int i = 0; i < Vertex - 1; i++)
               {
                    int MinVertex = Relax(Distances, SetedVertexes, Vertex);
                    SetedVertexes[MinVertex] = true;
                    for (int j = 0; j < Vertex; j++)
                    {
                         if (!SetedVertexes[j] && Distances[MinVertex] != 1000000 && Distances[MinVertex] + Graph[MinVertex, j] < Distances[j] && Graph[MinVertex, j] != 0)
                         {
                              Distances[j] = Distances[MinVertex] + Graph[MinVertex, j];
                         }
                    }

               }
               return Distances[target];

          }

          private static void INIT(int Start, int Vertex, int[] Distances, bool[] SetedVertexes)
          {
               for (int i = 0; i < Vertex; i++)
               {
                    Distances[i] = 1000000;
                    SetedVertexes[i] = false;
               }
               Distances[Start] = 0;
          }

          private static int Relax(int[] distances, bool[] setedVertexes , int Vertex)
          {
               int Min = int.MaxValue, MinVertex = 0;
               for (int i = 0; i < Vertex; i++)
               {
                    if (setedVertexes[i] == false && distances[i] <= Min)
                    {
                         Min = distances[i];
                         MinVertex = i;
                    }
               }
               return MinVertex;
          }

     }
     public class BFS
     {
          
          public BFS()
          {

          }

          public static int GetMinimumPathCost(int[,] Graph,int start,int target,int numofvertexes)
          {
               Queue<int> Que = new Queue<int>();
               Queue<int> Que2 = new Queue<int>();

               int Cost = 0;
               bool end = false;
               Que.Enqueue(start);
               while (!end)
               {
                    while (Que.Count > 0)
                    {
                         Que2.Enqueue(Que.Dequeue());
                    }
                    while (Que2.Count>0)
                    {
                         int Root = Que2.Dequeue();
                         for (int i = 0; i < numofvertexes; i++)
                         {
                              if (Graph[Root, i] > 0)
                              {
                                   if (i == target)
                                   {
                                        end = true;
                                        break;
                                   }
                                   Que.Enqueue(i);
                              }
                         }
                    }
                    Cost++;
                    

               }
               return Cost;

          }

     }
}
