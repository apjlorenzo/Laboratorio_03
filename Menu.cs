using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_03
{
    public  class Menu
    {
        public void MenuPrincipal()
        {
            Console.Clear();
            Console.WriteLine("_____MENU_____");
            Console.WriteLine("1.Registrar cliente");
            Console.WriteLine("2.Registrar reserva");
            Console.WriteLine("3.Mostrar información");
            Console.WriteLine("4.Salir");
            Console.Write("Ingrese una opción: ");
        }
        public void MenuClientes()
        {
            Console.Clear();
            Console.WriteLine("----REGISTRAR CLIENTES----");
            Console.WriteLine("a.Cliente Regular");
            Console.WriteLine("b.Cliente VIP");
            Console.WriteLine("c.Regresar");
            Console.Write("Ingrese una opción: ");
        }
    }
}
