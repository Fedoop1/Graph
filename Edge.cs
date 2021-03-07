using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    class Edge
    {
        public Vertex edgeTo { get; set; }
        public Vertex edgeFrom { get; set; }

        public int weight { get; private set; } = 1;

        public Edge(Vertex from, Vertex to, int weight)
        {
            edgeFrom = from;
            edgeTo = to;
            this.weight = weight;
        }
    }
}
