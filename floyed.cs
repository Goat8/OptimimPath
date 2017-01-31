using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace graph2
{
    public class floyed
    {

        private int NumVertex;
        private int INF;
        string[,] mystr = new string[39, 39];
        // Solves the all-pairs shortest path problem using Floyd Warshall algorithm
        /* A utility function to print solution */
        public floyed()
        {
            NumVertex = 39;
            INF = 99999;
        }

        public void printSolution(int[,] dist)
        {
          //  Console.WriteLine("Following matrix shows the shortest distances between every pair of vertices ");
            for (int i = 0; i < NumVertex; i++)
            {
                for (int j = 0; j < NumVertex; j++)
                {
                    if (dist[i, j] == INF) {
                        //   Console.Write("INF");
                    }
                    else {
                        // Console.Write(dist[i, j]);
                    }
                }
               // Console.WriteLine();
            }
        }

        void printPathUtil(int[,] path, int i, int j)
        {
            if (path[i, j] == i)
                return;

            //   mystr[i, j] = mystr[i, j] + "/" + path[i, j].ToString();
            printPathUtil(path, i, path[i, j]);
            //   Console.Write(path[i, j] + " :)");
            if (j>0) {
                mystr[i, j] = mystr[i, j - 1] + path[i, j].ToString() + ","; }
        }

        /* A utility function to print solution */
      public  void printPath(int[,] path)
        {



          //  Console.WriteLine("Following matrix shows the shortest path between every pair of vertices ");

            for (int i = 0; i < NumVertex; i++)
            {
                for (int j = 0; j < NumVertex; j++)
                {
                    if (path[i, j] == -1)
                    {
                      //  Console.Write("INF");
                        mystr[i, j] = "INF";
                    }
                    else {
                       // Console.Write("(" + i);
                        mystr[i, j] = i.ToString() + ",";
                        printPathUtil(path, i, j);
                     //   Console.Write(j + ")");
                        //  mystr[j, j] = mystr[j, j]+j.ToString()+"&";
                    }
                }
             //   Console.WriteLine();

            }
        }

        public string[,] floydWarshell(int[,] graph)
        {
            /* dist[][] will be the output matrix that will finally have the shortest 
            distances between every pair of vertices

            path[][] will be the output matrix that will finally have the shortest 
            path between every pair of vertices
            */
            int[,] dist = new int[NumVertex, NumVertex];
            int[,] path = new int[NumVertex, NumVertex];
            int i, j, k;

            /* Initialize the solution matrix same as input graph matrix. Or 
            we can say the initial values of shortest distances are based
            on shortest paths considering no intermediate vertex. 

            Initialize the path matrix as i if path exists from i to j in 
            input graph matrix considering no intermediate vertex. 
            */
            for (i = 0; i < NumVertex; i++)
            {
                for (j = 0; j < NumVertex; j++)
                {
                    dist[i, j] = graph[i, j];

                    if (dist[i, j] != INF && i != j)
                    {
                        path[i, j] = i;
                    }
                    else {
                        path[i, j] = -1;
                    }
                }
            }
            /* Add all vertices one by one to the set of intermediate vertices.
            ---> Before start of a iteration, we have shortest distances between all
            pairs of vertices such that the shortest distances consider only the
            vertices in set {0, 1, 2, .. k-1} as intermediate vertices.
            ----> After the end of a iteration, vertex no. k is added to the set of
            intermediate vertices and the set becomes {0, 1, 2, .. k} */
            for (k = 0; k < NumVertex; k++)
            {
                // Pick all vertices as source one by one
                for (i = 0; i < NumVertex; i++)
                {
                    // Pick all vertices as destination for the
                    // above picked source
                    for (j = 0; j < NumVertex; j++)
                    {
                        // If vertex k is on the shortest path from i to j,
                        // then update the value of dist[i][j], path[i][j]
                        if (dist[i, k] != INF && dist[k, j] != INF &&
                                dist[i, k] + dist[k, j] < dist[i, j])
                        {
                            dist[i, j] = dist[i, k] + dist[k, j];
                            path[i, j] = path[k, j];
                        }
                    }
                    // if diagonal elements become negative, 
                    // graph contains negative weight cycle
                    if (dist[i, i] < 0)
                    {

                       // Console.WriteLine("Graph contains negative weight cycle\n");
                        //return 0;
                    }
                }
            }


            // Print the shortest distance matrix
            printSolution(dist);

            // Print the shortest path matrix
            printPath(path);
            return mystr;
        }
        public void mainresult()
        {

            int[,] graph = { {0, 5, INF, 10},
                        {INF, 0, 3, INF},
                        {INF, INF, 0, 1},
                        {INF, INF, INF, 0}
                    };

            // Print the solution
            floydWarshell(graph);
          
         //   Console.WriteLine("MY MATRIXXXXXXX");

          //  Console.WriteLine(mystr[1, 3]);
            //            Print2DArray(mystr);

        }

    }
}