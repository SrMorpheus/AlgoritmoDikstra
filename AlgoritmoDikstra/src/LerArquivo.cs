using AlgoritmoDikstra.src;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmoDikstra2.src
{
   public class LerArquivo
    {


        public static List<Vertice> LerGrafo ( string path)
        {

            Grafo g = new Grafo ();
            Vertice v;
            string []vertices;
            string linha;
            List<string[]> s1 = new List<string[]> ();
            
          //  try
            //{
                StreamReader sr = new StreamReader(path);

                Dictionary<string, Vertice> mapa= new Dictionary<string, Vertice>();

                while((linha = sr.ReadLine()) != null )
                {
                    if (linha.Contains(","))
                    {

                        s1.Add(linha.Split("/"));
                        vertices = s1[0][0].Split(",");

                       mapa.TryGetValue(vertices[0], out  v);

                        if (v == null)
                        {

                            v = new Vertice();

                        }

                        List<Vertice> vizinhoAtual = new List<Vertice>();
                        List<Aresta> arestasAtual = new List<Aresta>();

                        v.Descricao = vertices[0];
                        mapa.TryAdd(vertices[0], v);

                        if (linha.Contains("/"))
                        {

                            string[] pesoArestas = s1[0][1].Split(",");

                            for (int i = 1; i < vertices.Length; i++)
                            {

                                Vertice vit;
                                mapa.TryGetValue(vertices[i], out vit);
                              //vit = mapa[vertices[i]];

                                if (vit == null) vit = new Vertice();

                                vit.Descricao = vertices[i];
                                vizinhoAtual.Add(vit);
                                mapa.TryAdd(vertices[i], vit);

                                Aresta ait = new Aresta(v, vit);
                                ait.Peso = int.Parse(pesoArestas[i - 1]);
                                arestasAtual.Add(ait);
                            }

                            v.SetVizinhos(vizinhoAtual);
                            v.SetArestas(arestasAtual);

                        }


                    }

                    else
                    {

                        v = mapa[linha];

                        if(v == null)
                        {
                            v = new Vertice();
                            v.Descricao = linha;
                            mapa.TryAdd(linha, v);

                        }                    
                    }

                    g.AdicionarVertice(v);

                    s1.Clear();



                }



            // }
            //catch (Exception)
            //{
                //Console.WriteLine("Erro nessa parte aqui");
            //}





            return g.GetVertices();



        }




    }
}
