using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmoDikstra.src
{
    public class Dijkstra
    {

        List<Vertice> menorCaminho = new List<Vertice>();

        Vertice verticeCaminho = new Vertice();

        Vertice atual = new Vertice();

        Vertice vizinho = new Vertice();

        List<Vertice> naoVisitados = new List<Vertice>();


        public List<Vertice> EncontarMenorCaminhoDijkstra (Grafo grafo, Vertice vertice1, Vertice vertice2)

        {
            menorCaminho.Add(vertice1);
          



            for (int i  = 0; i < grafo.Grafos.Count; i++)
            {


                if (grafo.Grafos[i].Descricao.Equals(vertice1.Descricao))
                {

                    grafo.Grafos[i].Distancia = 0; 


                }else
                {

                    grafo.Grafos[i].Distancia = 9999;



                }


                naoVisitados.Add(grafo.Grafos[i]);

            }


            naoVisitados.Sort();

            while (naoVisitados.Count != 0)
            {

               atual = naoVisitados[0];

               Console.WriteLine("Pegou esse vertice: " + atual);

               for (int i = 0; i < atual.Arestas.Count; i ++)
                {

                    vizinho = atual.Arestas[i].Destino;

                    Console.WriteLine("Olhando o vizinho de " + atual + ": " + vizinho);

                    if(!vizinho.VerificarVisita())
                    {

                        if(vizinho.Distancia > (atual.Distancia + atual.Arestas[i].Peso))
                        {

                            vizinho.Distancia = atual.Distancia + atual.Arestas[i].Peso;

                            vizinho.Pai = atual;


                            if (vizinho == vertice2)
                            {

                                menorCaminho.Clear();

                                verticeCaminho = vizinho.Pai;

                                menorCaminho.Add(vizinho);


                                while(verticeCaminho.Pai != null)
                                {

                                    menorCaminho.Add(verticeCaminho.Pai);

                                    verticeCaminho = verticeCaminho.Pai;



                                }


                                menorCaminho.Sort();



                            }



                        }   



                    }
                    




                }

                atual.Visitar();

                naoVisitados.Remove(atual);


                naoVisitados.Sort();
                Console.WriteLine("Não foram visitados ainda: " );

                foreach( var naoVisitado in naoVisitados)
                {

                    Console.WriteLine(naoVisitado);


                }


            }

            return menorCaminho;

        }




    }
}
