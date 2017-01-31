using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace graph2
{
    public class Edge
    {
       private Vertex node1;
       private Vertex node2;
        private int weight;

        public Vertex Node1
        {
            get
            {
                return node1;
            }

            set
            {
                node1 = value;
            }
        }

        public Vertex Node2
        {
            get
            {
                return node2;
            }

            set
            {
                node2 = value;
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
    }
}