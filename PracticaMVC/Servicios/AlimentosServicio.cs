using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public class AlimentosServicio
    {
        
        private static List<Alimento> Lista = new List<Alimento>();


        public List<Alimento> ObtenerTodos()
        {
            return Lista;
        }
     
        public void Crear(Alimento alimento)
        {
            int maxId = 0;
            if (Lista.Count > 0)
            {
                maxId = Lista.Max(o => o.Id);
            }

            alimento.Id = maxId + 1;

            Lista.Add(alimento);
        }
        public void Editar(Alimento alimento)
        {
            Alimento alimentoActual = ObtenerPorId(alimento.Id);
            alimentoActual.Nombre = alimento.Nombre;
            alimentoActual.Peso = alimento.Peso;
        }

        public void Borrar(int id)
        {
            Lista.RemoveAll(o => o.Id == id);
        }

        public Alimento ObtenerPorId(int id)
        {
            return Lista.Find(o => o.Id == id);
        }
    }
    
}
