using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace graph2
{
    public class Vertex
    {
        private string name;
        public Vertex() {
            this.name = "";
        }
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }
    }
}