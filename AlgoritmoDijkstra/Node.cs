using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmoDijkstra
{
    public class Node : IComparable<Node>
    {

        public int Vertice { get; set; }

        public int Peso { get; set; }


        public Node (int vertice , int peso )
        {

            Vertice = vertice; 

            Peso = peso;

        }

        public int CompareTo(Node? other)
        {
            
            if (other == null) return 1;

            return Peso.CompareTo(other.Peso);


        }
    }
}
