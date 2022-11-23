using Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public static class ArchivosSecuenciales
    {
        private static string archivo = "Esferas.txt";
            public static void GuardarEnArchivo(List<Esfera> lista)
            {
                using (var escritor = new StreamWriter(archivo))
                {
                    foreach (var e in lista)
                    {
                        string linea = ConstruirLinea(e);
                        escritor.WriteLine(linea);
                    }
                }

            }

            private static string ConstruirLinea(Esfera esfera)
            {
                return $"{esfera.radio}|{(int)esfera.Color}|{(int)esfera.Trazo}";
            }

            public static List<Esfera> LeerArchivo()
            {
                List<Esfera> lista = new List<Esfera>();
                if (File.Exists(archivo))
                {
                    using (var lector = new StreamReader(archivo))
                    {
                        while (!lector.EndOfStream)
                        {
                            string linea = lector.ReadLine();
                            Esfera esfera = ConstruirEsfera(linea);
                            lista.Add(esfera);
                        }
                    }

                }
                return lista;
            }

            private static Esfera ConstruirEsfera(string linea)
            {
                var campos = linea.Split('|');
                Esfera esfera = new Esfera()
                {
                radio = double.Parse(campos[0]),
                Color = (Color)int.Parse(campos[1]),
                Trazo = (Trazo)int.Parse(campos[2])
                };

                return esfera;
            }
        }
}
