using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POOOrtaedro.entidades;

namespace POOOrtoedro.datos
{

    public class RepositorioDeOrtoedro
    {
        private bool HayCambios=false;


        private List<Ortoedro> listaOrtoedro;

        public RepositorioDeOrtoedro()
        {
            listaOrtoedro = new List<Ortoedro>();
            listaOrtoedro = ManejadorDeArchivoSecuenciales.LeerDelArchivo();
        }

        public void Agregar(Ortoedro ortoedro)
        { 
            HayCambios = true;
            listaOrtoedro.Add(ortoedro);
           
            

        }

        public int GetCantidad()
        {
            return listaOrtoedro.Count;
        }
        public List<Ortoedro> GetLista()
        {
            return listaOrtoedro;
        }

        public bool Borrar(Ortoedro ortoedro)
        {
            if (listaOrtoedro.Contains(ortoedro))
            {
                HayCambios = true;
                listaOrtoedro.Remove(ortoedro);
                
                return true;
            }

            return false;

        }

        public void Editar()
        {
            HayCambios = true;
        }

        public void Guardar()
        {
            if (HayCambios)
            {
                ManejadorDeArchivoSecuenciales.GuardarArchivoSecuenciales(listaOrtoedro);
            }
        }

        public List<Ortoedro> OrdenarLista(Orden ordenar)
        {
            return ordenar == Orden.Acendente ? listaOrtoedro.OrderBy(l => l.GetVolumen()).ToList():listaOrtoedro.OrderByDescending(l => l.GetVolumen()).ToList();
        }

        

        
    }
}
