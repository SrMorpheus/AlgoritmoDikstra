using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmoDikstra.src
{
    public class Grafo
    {

        public List<Vertice> Grafos { get; set; } = new();

       

        public void SetVertices( List<Vertice> vertices)
        {

            Grafos = vertices;


        }


        public List<Vertice> GetVertices ()
        {


            return Grafos;
        }


        public void AdicionarVertice(Vertice novaVertice)
        {

            Grafos.Add(novaVertice);   

        }

           

        public Vertice EncontrarVertice (string nome)
        {


            for (int i = 0; i < Grafos.Count; i++)
            {
                if (nome.Equals(Grafos[i].Descricao))
                {

                    return Grafos[i];

                }


            }

            return null;



        }




    }
}
