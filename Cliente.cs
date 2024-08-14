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
        public int telefono=0;
        public string nombreReserva = null;
        public List<Cliente> listaClientes = new List<Cliente>();
        public Cliente cliente;


        //Atributos 
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public int Telefono { get; set; }
        //Método constructor
        public Cliente(string nombre, string correo, int telefono)
        {
            Nombre = nombre;
            Correo = correo;
            Telefono = telefono;
        }
        //Métodos
        public virtual void RegistrarClientes()
        {
            Console.Write("Ingrese el nombre del cliente: ");
            nombre = Console.ReadLine();
            Console.Write("Ingrese el correo del cliente: ");
            correo = Console.ReadLine();
            Console.Write("Ingrese el número de telefono del cliente: ");
            telefono = int.Parse(Console.ReadLine());
        }
        public virtual void MostrarInformacion()
        {
            foreach (Cliente cliente in listaClientes)
            {
                Console.WriteLine("\nNombre del cliente: " + cliente.Nombre);
                Console.WriteLine("Correo del cliente: " + cliente.Correo);
                Console.WriteLine("Telefono del cliente: " + cliente.Telefono);
            }
        }
    }
}
