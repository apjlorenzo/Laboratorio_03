
using Laboratorio_03;

Menu menu= new Menu();
bool condicionMenuPrincipal = true;
do
{
    menu.MenuPrincipal();
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
                        condicionMenucliente= false;
                        break;
                }
            }
            while (condicionMenucliente);
            break;
        case 2:
            break;
        case 3:
            break;
        default:
            Console.Clear();
            Console.WriteLine("No es una opción válida");
            Console.WriteLine("\nPresione cualquier tecla para continuar: ");
            Console.ReadKey();
            break;
    }
}
while (condicionMenuPrincipal);