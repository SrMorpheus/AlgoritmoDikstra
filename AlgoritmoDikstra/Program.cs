using AlgoritmoDikstra.src;
using AlgoritmoDikstra2.src;
using System.Security.Cryptography.X509Certificates;


Grafo teste = new Grafo();

teste.SetVertices(LerArquivo.LerGrafo(".\\testeAlgoritmo.txt"));
Vertice i1 = new Vertice();
Vertice i2 = new Vertice();
i1 = teste.EncontrarVertice("v1");
i2 = teste.EncontrarVertice("v4");

List<Vertice> resultado = new List<Vertice>();
Dijkstra algoritmo = new Dijkstra();
resultado = algoritmo.EncontarMenorCaminhoDijkstra(teste, i1, i2);

Console.WriteLine("Esse é o menor caminho feito pelo algoritmo: ");

foreach( var resultadoTeste in resultado)
{
    Console.Write(" " + resultadoTeste);






}
