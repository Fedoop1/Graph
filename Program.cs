using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph graph = new Graph();

            var vertex1 = new Vertex(1);
            var vertex2 = new Vertex(2);
            var vertex3 = new Vertex(3);
            var vertex4 = new Vertex(4);
            var vertex5 = new Vertex(5);
            var vertex6 = new Vertex(6);
            var vertex7 = new Vertex(7);

            graph.VertexAdd(vertex1);
            graph.VertexAdd(vertex2);
            graph.VertexAdd(vertex3);
            graph.VertexAdd(vertex4);
            graph.VertexAdd(vertex5);
            graph.VertexAdd(vertex6);
            graph.VertexAdd(vertex7);

            graph.EdgeAdd(vertex1, vertex2, 1);
            graph.EdgeAdd(vertex1, vertex3, 1);
            graph.EdgeAdd(vertex3, vertex4, 1);
            graph.EdgeAdd(vertex2, vertex5, 1);
            graph.EdgeAdd(vertex2, vertex6, 1);
            graph.EdgeAdd(vertex6, vertex5, 1);
            graph.EdgeAdd(vertex5, vertex6, 1);

            GetMatrix(graph);

            Console.WriteLine();

            GetVertex(graph, vertex1);
            GetVertex(graph, vertex2);
            GetVertex(graph, vertex3);
            GetVertex(graph, vertex4);
            GetVertex(graph, vertex5);
            GetVertex(graph, vertex6);
            GetVertex(graph, vertex7);

            Console.WriteLine("\n");

            Wave(graph, vertex1, vertex2);
            Wave(graph, vertex7, vertex1);

            Console.ReadLine();
        }
        private static void GetMatrix(Graph graph)
        {
            Console.Write("  ");
            for (int index = 0; index < graph.vertexesCount; index++)
            {
                Console.Write($"| {index + 1}x|"); 
            }

            int[,] matrix = graph.GetMatrix();

            for (int indexFrom = 0; indexFrom < graph.vertexesCount; indexFrom++)
            {
                Console.Write($"\n{indexFrom + 1}y");

                for (int indexTo = 0; indexTo < graph.vertexesCount; indexTo++)
                {
                    Console.Write("| " + matrix[indexFrom,indexTo] + " |");
                }
            }
        }

        private static void GetVertex(Graph graph, Vertex vertex)
        {
            Console.Write($"\nNeighbours {vertex.number}: ");

            foreach (var item in graph.GetVertexes(vertex))
            {
                Console.Write(item.number + ", " );
            }
        }

        private static void Wave(Graph graph, Vertex from, Vertex to)
        {
            if(graph.Wave(from, to))
            {
                Console.WriteLine($"There is a way from {from} to the {to}.");
                return;
            }

            Console.WriteLine($"There is no way from {from} to the {to}.");
        }
    }
}
