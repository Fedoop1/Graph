using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    class Vertex
    {
        public int number { get; private set; }

        public Vertex(int number)
        {
            this.number = number;
        }

        public override string ToString()
        {
            return $"{number}";
        }
    }
}
