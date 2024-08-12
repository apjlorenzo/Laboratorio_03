using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_03
{
    public class Cliente
    {
        public List<Cliente> listaClientes = new List<Cliente>();
        //Atributos 
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Direccion { get; set; }
        //Método
        public Cliente(string nombre, string correo, string direccion)
        {
            Nombre = nombre;
            Correo = correo;
            Direccion = direccion;
        }
    }
}
