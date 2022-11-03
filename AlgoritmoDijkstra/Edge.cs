using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmoDijkstra
{
    public class Edge
    {

        public int Source { get; set; }

        public int Dest { get; set; }


        public int Peso { get; set; }



        public Edge(int source, int dest , int peso )
        {

            Source = source;

            Dest = dest;

            Peso = peso;


        }



    }
}
