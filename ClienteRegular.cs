using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_03
{
    public class ClienteRegular : Cliente
    {
        public ClienteRegular(string nombre, string correo, string direccion) : base(nombre, correo, direccion)
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
                listaClientes.Add(new ClienteRegular(nombre,correo,direccion));
            }

        }

    }
}
