using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_03
{
    public class ClienteRegular : Cliente
    {
        public ClienteRegular(string nombre, string correo, int telefono) : base(nombre, correo, telefono)
        { 
        }
        public override void RegistrarClientes()
        {
            Console.Clear();
            Console.Write("Ingrese la cantidad de clientes a registrar: ");
            int cantidad = int.Parse(Console.ReadLine());
            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine($"\nCliente No.{i + 1}: ");
                base.RegistrarClientes();
                listaClientes.Add(new ClienteRegular(nombre,correo,telefono));
            }

        }
        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
        }
        public virtual void BuscarCliente()
        {
            Console.Clear();
            Console.Write("Ingrese el nombre del cliente que quiere buscar: ");
            string nombre = Console.ReadLine().ToUpper();
            Cliente encontrar = listaClientes.Find(p => p.Nombre == nombre);
            if (encontrar != null)
            {
                Console.WriteLine("Información del cliente: ");
                Console.WriteLine("Nombre:" + encontrar.Nombre);
                Console.WriteLine("Correo:" + encontrar.Correo);
                Console.WriteLine("Telefono:" + encontrar.Telefono);
            }
            else
            {
                Console.WriteLine("No existe ningún cliente con ese nombre");
            }
        }
    }
}
