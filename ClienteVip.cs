﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_03
{
    internal class ClienteVip : Cliente
    {
        public double Descuento { get; set; }
        public ClienteVip(string nombre, string correo, int telefono, double descuento) : base(nombre, correo, telefono)
        {
            Descuento = descuento;
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
                Console.Write("Ingrese el descuento del cliente: %");
                double descuento = double.Parse(Console.ReadLine());
                listaClientes.Add(new ClienteVip(nombre, correo, telefono, descuento));
            }
        }
        public void MostrarInformacionVip()
        {
            foreach (ClienteVip cliente in listaClientes)
            {
                Console.WriteLine("\nNombre del cliente: " + cliente.Nombre);
                Console.WriteLine("Correo del cliente: " + cliente.Correo);
                Console.WriteLine("Telefono del cliente: " + cliente.Telefono);
                Console.WriteLine($"Descuento: {cliente.Descuento}%");
            }
        }
        public virtual void BuscarCliente()
        {
            Console.Clear();
            Console.Write("Ingrese el nombre del cliente que quiere buscar: ");
            string nombre = Console.ReadLine().ToUpper();
            ClienteVip encontrar = listaClientes.OfType<ClienteVip>().FirstOrDefault(p => p.Nombre == nombre);
            if (encontrar != null)
            {
                Console.WriteLine("Información del cliente VIP: ");
                Console.WriteLine("Nombre: " + encontrar.Nombre);
                Console.WriteLine("Correo: " + encontrar.Correo);
                Console.WriteLine("Telefono: " + encontrar.Telefono);
                Console.WriteLine($"Descuento: {encontrar.Descuento}%");
            }
            else
            {
                Console.WriteLine("No existe ningún cliente VIP con ese nombre.");
            }
        }
    }
}
