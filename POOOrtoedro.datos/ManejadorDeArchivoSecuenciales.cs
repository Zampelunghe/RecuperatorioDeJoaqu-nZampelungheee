using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POOOrtaedro.entidades;

namespace POOOrtoedro.datos
{
    public class ManejadorDeArchivoSecuenciales
    {
        private static string Archivo = "ortoedro.txt";
        public static void GuardarArchivoSecuenciales(List<Ortoedro> listaOrtoedro)
        {
            using (var escribir = new StreamWriter(Archivo))
            {
                foreach (var ortoedro in listaOrtoedro)
                {
                       string linea = Construirlinea(ortoedro);
                    escribir.WriteLine(linea);
                }
                
            }
        }

        private static string Construirlinea(Ortoedro ortoedro)
        {
            return $"{ortoedro.AristaA}|{ortoedro.AristaB}|{ortoedro.AristaC}|{(int)ortoedro.Relleno} ";
        }
        public static List<Ortoedro> LeerDelArchivo()
        {
            List<Ortoedro> lista = new List<Ortoedro>();
            if (File.Exists(Archivo))
            {
                using (var lector = new StreamReader(Archivo))
                {
                    while (!lector.EndOfStream)
                    {
                        string linea = lector.ReadLine();
                        Ortoedro ortoedro = CrearOrtoedro(linea);
                        lista.Add(ortoedro);
                    }
                }
            }

            return lista;
        }
        private static Ortoedro CrearOrtoedro(string linea)
        {
            var campos = linea.Split('|');
            Ortoedro ortoedro = new Ortoedro()
            {
                AristaA = int.Parse(campos[0]),
                AristaB = int.Parse(campos[1]),
                AristaC = int.Parse(campos[2]),
                Relleno = (ColorRelleno)int.Parse(campos[3]),
                
            };
            return ortoedro;
        }
    }
}
