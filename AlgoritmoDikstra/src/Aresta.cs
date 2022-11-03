using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmoDikstra.src
{
    public  class Aresta
    {

        public  int Peso { set; get; }

        public  Vertice Origem { set; get; }

        public  Vertice Destino { set; get; }



        public Aresta( Vertice vertice1 , Vertice vertice2)
        {

            Peso = 1;
            Origem = vertice1;
            Destino = vertice2;
          

        }
        


    }
}
