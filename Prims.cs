using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace graph2
{
  public class totaledgs
    {
        private string src;
        private string dst;
        private int weight;

        public string Src
        {
            get
            {
                return src;
            }

            set
            {
                src = value;
            }
        }

        public string Dst
        {
            get
            {
                return dst;
            }

            set
            {
                dst = value;
            }
        }

        public int Weight
        {
            get
            {
                return weight;
            }

            set
            {
                weight = value;
            }
        }
    };
    public class Prims
    {
        private int V = 39;

        // A utility function to find the vertex with minimum key
        // value, from the set of vertices not yet included in MST
        int minKey(int[] key, Boolean[] mstSet)
        {
            // Initialize min value
            int min = 9999;
            int min_index = -1;

            for (int v = 0; v < V; v++)
                if (mstSet[v] == false && key[v] < min)
                {
                    min = key[v];
                    min_index = v;
                }

            return min_index;
        }

        // A utility function to print the constructed MST stored in
        // parent[]
    public  List<totaledgs> printMST(int[] parent, int n, int[,] graph)
        {
            List<totaledgs> mlist = new List<totaledgs>();
            Console.WriteLine("Edge   Weight");
            for (int i = 1; i < V; i++)
            {
                totaledgs obj = new totaledgs();
                obj.Src = parent[i].ToString();
                obj.Dst = i.ToString();
                obj.Weight = graph[i, parent[i]];
             //   Console.WriteLine(parent[i] + " - " + i + "    " +
                              //     graph[i, parent[i]]);
                mlist.Add(obj);

            }
        
            return mlist;
        }

        // Function to construct and print MST for a graph represented
        //  using adjacency matrix representation
  public  List<totaledgs> primMST(int[,] graph)
        {
            // Array to store constructed MST
            int[] parent = new int[V];

            // Key values used to pick minimum weight edge in cut
            int[] key = new int[V];

            // To represent set of vertices not yet included in MST
            Boolean[] mstSet = new Boolean[V];

            // Initialize all keys as INFINITE
            for (int i = 0; i < V; i++)
            {
                key[i] = 9999;
                mstSet[i] = false;
            }

            // Always include first 1st vertex in MST.
            key[0] = 0;     // Make key 0 so that this vertex is
                            // picked as first vertex
            parent[0] = -1; // First node is always root of MST

            // The MST will have V vertices
            for (int count = 0; count < V - 1; count++)
            {
                // Pick thd minimum key vertex from the set of vertices
                // not yet included in MST
                int u = minKey(key, mstSet);

                // Add the picked vertex to the MST Set
                mstSet[u] = true;

                // Update key value and parent index of the adjacent
                // vertices of the picked vertex. Consider only those
                // vertices which are not yet included in MST
                for (int v = 0; v < V; v++)

                    // graph[u][v] is non zero only for adjacent vertices of m
                    // mstSet[v] is false for vertices not yet included in MST
                    // Update the key only if graph[u][v] is smaller than key[v]
                    if (graph[u, v] != 0 && mstSet[v] == false &&
                        graph[u, v] < key[v])
                    {
                        parent[v] = u;
                        key[v] = graph[u, v];
                    }
            }

            // print the constructed MST
          List<totaledgs> newlst =   printMST(parent, V, graph);
            return newlst;
        }
      

    }
}