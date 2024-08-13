using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_03
{
    public class Cliente
    {
        //Variables globales
        public string nombre=null;
        public string correo=null;
        public string direccion=null;
        public List<Cliente> listaClientes = new List<Cliente>();
        public Cliente cliente;


        //Atributos 
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Direccion { get; set; }
        //Método constructor
        public Cliente(string nombre, string correo, string direccion)
        {
            Nombre = nombre;
            Correo = correo;
            Direccion = direccion;
        }
        //Métodos
        public virtual void RegistrarClientes()
        {
            Console.Write("Ingrese el nombre del cliente: ");
            nombre = Console.ReadLine();
            Console.Write("Ingrese el correo del cliente: ");
            correo = Console.ReadLine();
            Console.Write("Ingrese la dirección del cliente: ");
            direccion = Console.ReadLine();
        }
        public virtual void MostrarInformacion()
        {
            Console.Clear();
            foreach (Cliente cliente in listaClientes)
            {
                Console.WriteLine("Nombre del cliente: " + cliente.Nombre);
                Console.WriteLine("Correo del cliente: " + cliente.Correo);
                Console.WriteLine("Dirección del cliente: " + cliente.Direccion);
            }
            Console.ReadKey();
        }
    }
}
