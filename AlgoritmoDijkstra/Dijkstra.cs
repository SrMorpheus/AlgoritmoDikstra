using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmoDijkstra
{
    public class Dijkstra
    {




        private static void GetRoute ( int[] prev , int i , List<int> route )
        {

            if( i >= 0)
            {
                 GetRoute(prev, prev[i], route);

                route.Add(i);

            }


        }


        public static void FindDijkstra( Graph graph , int source , int n)
        {

            Queue<Node> minHeap = new();


           
            minHeap.Enqueue(new Node(source, 0));

            //bug
                
            List<int> dis = new List<int>();

            for (int i = 0; i < n; i++)
            {


                dis.Add (int.MaxValue);

            }



            dis.Insert(source, 0);


            bool[] done = new bool[n];
            done[source] = true;

            int[] prev = new int[n];
            prev[source] = -1;



            while(minHeap.Count != 0)
            {


                Node node = minHeap.Dequeue();
                int u = node.Vertice;

                foreach( var edge in graph.Adjacencias[u])
                {

                    int v = edge.Dest;
                    int peso = edge.Peso;

                    if (!done[v] && (dis[u] + peso) < dis[v])
                    {
                        dis.Insert(v, dis[u] + peso);
                        prev[v] = u;
                        minHeap.Enqueue(new Node(v, dis[v]));

                    }



                }

                done[u] = true;


            }


            List<int> route = new ();

            for (int i = 0;  i < n; i ++)
            {

                if (i != source && dis[i] != int.MaxValue)
                {
                    GetRoute(prev, i, route);

                    Console.WriteLine("Path ({0} —> {1}): Minimum cost = {2}, Route = {3}\n",
                                    source, i, dis[i], route);
                    route.Clear();


                }




            }



        }







    }
}
