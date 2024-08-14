using Laboratorio_03;

List<Cliente> listaClientes = new List<Cliente>();
ClienteRegular clienteRegular = new ClienteRegular(null,null,0);
ClienteVip clienteVip = new ClienteVip(null,null,0,0);
List<Reserva> listaReservas = new List<Reserva>();
Reserva reserva = new Reserva(0,null,null,null);
Menu menu= new Menu();
bool condicionMenuPrincipal = true;
do
{
    menu.MenuPrincipal();
    try
    {
        int opcion = int.Parse(Console.ReadLine());
        switch (opcion)
        {
            case 1:
                bool condicionMenucliente = true;
                do
                {
                    menu.MenuClientes();
                    string opcion2 = Console.ReadLine();
                    switch (opcion2)
                    {
                        case "a":
                            clienteRegular.RegistrarClientes();
                            menu.MensajeRegistroClientes();
                            break;

                        case "b":
                            clienteVip.RegistrarClientes();
                            menu.MensajeRegistroClientes();
                            break;

                        case "c":
                            condicionMenucliente = false;
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("No es una opción válida.");
                            Console.WriteLine("\nPresione cualquier tecla para continuar: ");
                            Console.ReadKey();
                            break;
                    }
                }
                while (condicionMenucliente);
                break;
            case 2:
                break;
            case 3:
                menu.MenuMostrarInfo();
                int opcion3 = int.Parse(Console.ReadLine());
                switch(opcion3)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Clientes regulares:");
                        clienteRegular.MostrarInformacion();
                        Console.WriteLine("\nClientes VIP:");
                        clienteVip.MostrarInformacionVip();
                        Console.ReadKey();
                        break;
                }
                Console.ReadKey();
                break;
            case 4:
                condicionMenuPrincipal = false;
                break;
            default:
                Console.Clear();
                Console.WriteLine("No es una opción válida");
                Console.WriteLine("\nPresione cualquier tecla para continuar: ");
                Console.ReadKey();
                break;
        }
    }
    catch(FormatException ex)
    {
        Console.Clear();
        Console.WriteLine("Error de formato: Ingrese un parametro válido.");
        Console.WriteLine("Más información: "+ex.Message);
        Console.WriteLine("\nPresione cualquier tecla para continuar: ");
        Console.ReadKey();
    }
    catch(OverflowException ex)
    {
        Console.Clear();
        Console.WriteLine("Error: Se ha superado el limite de caracteres permitidos.");
        Console.WriteLine("Más información: "+ex.Message);
        Console.WriteLine("\nPresione cualquier tecla para continuar: ");
        Console.ReadKey();
    }
    catch(Exception ex)
    {
        Console.Clear();
        Console.WriteLine(ex.Message);
        Console.WriteLine("\nPresione cualquier tecla para continuar: ");
        Console.ReadKey();
    }
}
while (condicionMenuPrincipal);