using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Laboratorio_03
{
    public class Reserva
    {
        public List<Reserva> listaReservas = new List<Reserva>();
        int id = 2020;
        public int Id { get; set; }
        public string Fecha { get; set; }
        public string Hora { get; set; }
        public List<Plato> Platos { get; set; }

        public Reserva(int id, string fecha, string hora, List<Plato> platos)
        {
            Id = id;
            Fecha = fecha;
            Hora = hora;
            Platos = platos;
        }
        public void RegistrarReserva()
        {
            Console.Clear();
            Console.Write("Ingrese el numero de reservas que quiere registrar: ");
            int cantidad = int.Parse(Console.ReadLine());
            for (int i = 0; i < cantidad; i++)
            {
                id += 1;
                Console.Clear();
                Console.WriteLine($"\nReserva No.{i+1}" );
                Console.Write("Ingrese la fecha de la reserva: ");
                string fecha = Console.ReadLine();
                Console.Write("Ingrese la hora de la reserva: ");
                string hora = Console.ReadLine();
                List<Plato> platos = new List<Plato>();
                bool continuar = true;
                while (continuar)
                {
                    Console.Clear();
                    Console.WriteLine("______________MENU DE PLATOS______________");
                    Console.WriteLine("1.Churrasco________________________Q100.00");
                    Console.WriteLine("2.Ceviche__________________________Q50.00");
                    Console.WriteLine("3.Filete de prescado_______________Q60.00");
                    Console.WriteLine("4.Ensalada_________________________Q45.00");
                    Console.WriteLine("5.Pasta____________________________Q90.00");
                    Console.WriteLine("6.Confirmar platos");
                    Console.Write("Ingrese una opción: ");
                    int opcion2 = int.Parse(Console.ReadLine());
                    switch (opcion2)
                    {
                        case 1:
                            platos.Add(new Plato("CHURRASCO", 100));
                            Console.Clear();
                            Console.WriteLine("Plato registrado correctamente");
                            Console.ReadKey();
                            break;
                        case 2:
                            platos.Add(new Plato("CEVICHE", 50));
                            Console.Clear();
                            Console.WriteLine("Plato registrado correctamente");
                            Console.ReadKey();
                            break;
                        case 3:
                            platos.Add(new Plato("FILETE DE PESCADO", 60));
                            Console.Clear();
                            Console.WriteLine("Plato registrado correctamente");
                            Console.ReadKey();
                            break;
                        case 4:
                            platos.Add(new Plato("ENSALDA", 45));
                            Console.Clear();
                            Console.WriteLine("Plato registrado correctamente");
                            Console.ReadKey();
                            break;
                        case 5:
                            platos.Add(new Plato("PASTA", 90));
                            Console.Clear();
                            Console.WriteLine("Plato registrado correctamente");
                            Console.ReadKey();
                            break;
                        case 6:
                            listaReservas.Add(new Reserva(id, fecha, hora, platos));
                            continuar = false;
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("No es una opción válida.");
                            break;
                    }
                }
            }
        }
        public double CalcularTotal(List<Plato> platos)
        {
            double total = 0;
            foreach (Plato plato in platos)
            {
                total += plato.Precio;
            }
            return total;
        }
        public void MostrarInformacion()
        {
            Console.WriteLine("Información de la reserva:");
            foreach (Reserva reserva in listaReservas)
            {
                Console.WriteLine("\nID de la reserva: "+reserva.Id);
                Console.WriteLine("Fecha de la reserva: "+reserva.Fecha);
                Console.WriteLine("Hora de la reserva: "+reserva.Hora);
                Console.WriteLine("Platos registrados de la reserva:");
                foreach (Plato plato in reserva.Platos)
                {
                    Console.WriteLine($"- {plato.MostrarPlato()}");
                }
                Console.WriteLine("El total de la reserva es: Q"+CalcularTotal(reserva.Platos));
            }
        }
        public void BuscarReserva()
        {
            Console.Clear();
            Console.Write("Ingrese el ID de la reserva que quiere buscar: ");
            int id = int.Parse(Console.ReadLine());
            Reserva encontrar = listaReservas.Find(p => p.Id == id);
            if (encontrar != null)
            {
                Console.WriteLine("\nInformación de la reserva: ");
                Console.WriteLine("ID:" + encontrar.Id);
                Console.WriteLine("Fecha:" + encontrar.Fecha);
                Console.WriteLine("Hora:" + encontrar.Hora);
                Console.WriteLine("Platos registrados de la reserva:");
                foreach (Reserva reserva in listaReservas)
                {
                    foreach(Plato plato in reserva.Platos)
                    {
                        Console.WriteLine($"- {plato.MostrarPlato()}");
                    }
                    Console.WriteLine("El total de la reserva es: Q" + CalcularTotal(reserva.Platos));
                }

            }
            else
            {
                Console.WriteLine("No existe ningún cliente con ese nombre");
            }
            Console.WriteLine("\nPresione cualquier tecla para continuar: ");
        }
    }
}
