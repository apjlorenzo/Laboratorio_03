using Laboratorio_03;

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
                            break;

                        case "b":
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