using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmoDijkstra
{
    public class Graph
    {

        public List<List<Edge>> Adjacencias { get; set; }


        public Graph (List<Edge> edges , int n)
        {

            Adjacencias = new List<List<Edge>>();


            for (int i = 0 ; i < n; i++)
            {

                Adjacencias.Add(new List<Edge>());


            }


           foreach( var edge in edges)
            {

                Adjacencias[edge.Source].Add(edge);



            }



        }

       



    }
}
