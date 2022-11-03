using AlgoritmoDijkstra;

List<Edge> edges = new List<Edge> {
               new Edge(0, 1, 10), new Edge(0, 4, 3), new Edge(1, 2, 2),
               new Edge(1, 4, 4), new Edge(2, 3, 9), new Edge(3, 2, 7),
               new Edge(4, 1, 1), new Edge(4, 2, 8), new Edge(4, 3, 2)
       };

// número total de nós no gráfico (rotulado de 0 a 4)
int n = 5;

// constrói o gráfico
Graph graph = new Graph(edges, n);

// executa o algoritmo de Dijkstra de cada nó
for (int source = 0; source < n; source++)
{
    Dijkstra.FindDijkstra(graph, source, n);
}