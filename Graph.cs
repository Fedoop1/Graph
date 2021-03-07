using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    class Graph
    {
        private List<Vertex> Vertexes = new List<Vertex>();
        private List<Edge> Edges = new List<Edge>();

        public int vertexesCount => Vertexes.Count;
        public int edgesCount => Edges.Count;

        public void VertexAdd(Vertex vertex)
        {
            if(!Vertexes.Contains(vertex))
            {
                Vertexes.Add(vertex);
            }
        }

        public void EdgeAdd(Vertex from, Vertex to, int weight)
        {
            var newEdge = new Edge(from, to, weight);
            Edges.Add(newEdge);
        }

        public int[,] GetMatrix()
        {
            int[,] result = new int[vertexesCount, vertexesCount];

            foreach (var item in Edges)
            {
                int row = item.edgeFrom.number - 1;
                int col = item.edgeTo.number - 1;
                result[row, col] = item.weight;
            }

            return result;
        }

        public List<Vertex> GetVertexes(Vertex vertex)
        {
            var result = new List<Vertex>();

            foreach (var item in Edges)
            {
                if(item.edgeFrom.number == vertex.number)
                {
                    result.Add(item.edgeTo);
                }
            }

            return result;
        }

        public bool Wave(Vertex from, Vertex to)
        {
            var result = new List<Vertex> { from };

            for (int index = 0; index < result.Count; index++)
            {
                var currentVertex = result[index];
                foreach (var item in GetVertexes(currentVertex))
                {
                    if(!result.Contains(item))
                    {
                        result.Add(item);
                    }
                }
            }

            return result.Contains(to);
        }
    }
}
