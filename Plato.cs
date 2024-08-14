using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_03
{
    public class Plato
    {
        public List<Plato> listaPlatos = new List<Plato>();
        public string Nombre { get; set; }
        public double Precio { get; set; }

        public Plato(string nombre, double precio)
        {
            Nombre = nombre;
            Precio = precio;
        }
        public string MostrarPlato()
        {
            return $"{Nombre}--------------Q{Precio}";
        }
    }
}
