 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio3
{
    public class Direccion
    {
        public int Id { get; set; }
        public string Calle { get; set; }
        public int Altura { get; set; } 
    }

    public class DireccionNegocio 
    {
        public List<Direccion> listar()
        { 
            List<Direccion> lista = new List<Direccion>();

            lista.Add(new Direccion());
            lista.Add(new Direccion());

            lista[0].Id = 1;
            lista[0].Calle = "Enciso";
            lista[0].Altura = 2250;

            lista[1].Id = 2;
            lista[1].Calle = "bustamante";
            lista[1].Altura = 1773; 

            return lista;
        }
    
    }

}
