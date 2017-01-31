using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace graph2
{
    public class Graph
    {
        List<Vertex> vertices = new List<Vertex>();
       public int[,] vedges;

        public List<Vertex> Vertices
        {
            get
            {
                return vertices;
            }

            set
            {
                vertices = value;
            }
        }

        public int[,] Vedges
        {
            get
            {
                return vedges;
            }

            set
            {
                vedges = value;
            }
        }
    }
}