using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Repositorio
    {
        public List<Esfera> listaEsferas;
        public Repositorio()
        {
            listaEsferas = new List<Esfera>();
            listaEsferas = ArchivosSecuenciales.LeerArchivo();
        }
        public void Agregar(Esfera esfera)
        {
            
            listaEsferas.Add(esfera);
        }

        public void Borrar(Esfera esfera)
        {
            
            listaEsferas.Remove(esfera);
        }

        
        public int GetCantidad()
        {
            return listaEsferas.Count;
        }

        public void Guardar()
        {
            ArchivosSecuenciales.GuardarEnArchivo(listaEsferas);
        }

        public List<Esfera> GetLista()
        {
            return listaEsferas;
        }

    }

}
