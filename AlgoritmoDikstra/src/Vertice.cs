using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmoDikstra.src
{
    public class Vertice : IComparable<Vertice>
    {
        public string Descricao { get; set; }

        public int Distancia { get; set; }

        public bool Visitado { get; set; } = false;

        public Vertice Pai { get; set; }

        public List<Aresta> Arestas { get; set; } = new List<Aresta>();

        public List<Vertice> Vizinhos { get;set; } = new List<Vertice>();



        public void Visitar()
        {

            Visitado = true;

        }


        public bool VerificarVisita()
        {

            return Visitado;

        }


        public void SetVizinhos( List<Vertice> vizinhos)
        {

            Vizinhos = vizinhos;

        }

        public void SetArestas(List<Aresta> arestas )
        {

            Arestas = arestas;
        }

     
        public int CompareTo(Vertice? other)
        {

            if (Distancia < other.Distancia) return -1;
            else if (Distancia == other.Distancia) return 0;

            return 1;


        }


        public override bool Equals(object? obj)
        {
            if ( obj is Vertice)
            {

                Vertice vRef = (Vertice)obj;

                if (Descricao.Equals(vRef.Descricao)) return true;


            }


            return false;


        }


        public override string ToString()
        {

            string s = " ";

            s += Descricao;

            return s; 


        }


    }
}
