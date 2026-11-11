int opcion = 0;
string nombreCliente = "";
string nombreExpediente = "";
int opcionServicio = 0;
string nombreServicio = "";
decimal precioServicio = 0;

do
{
    Console.WriteLine("*===============================*");
    Console.WriteLine("          INVESTICORE");
    Console.WriteLine("    GESTOR DE INVESTIGACIONES");
    Console.WriteLine("*===============================*");
    Console.WriteLine();
    Console.WriteLine("1. Registrar nuevo expediente");
    Console.WriteLine("2. Consultar estadisticas de la agencia");
    Console.WriteLine("3. Salir");
    Console.WriteLine();
    Console.WriteLine("=================================");
    Console.WriteLine("Selecciona una opcion: ");

    opcion = int.Parse(Console.ReadLine());
    
        if (opcion == 1)
        {
            Console.WriteLine("InvestiCore . NUEVO EXPEDIENTE");
            Console.WriteLine("-------------------------------------");
            Console.Write("Introduce el nombre del cliente: ");
            nombreCliente = Console.ReadLine();
            Console.Write("Introduce el nombre del expediente: ");
            nombreExpediente = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Datos registrados correctamente");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine($"Cliente: {nombreCliente}");
            Console.WriteLine($"Expediente: {nombreExpediente}");
            Console.WriteLine();
            Console.WriteLine("InvestiCore . SELECCION DE SERVICIO");
            Console.WriteLine("____________________________________");
            Console.WriteLine("1. Investigacion documental - 80 euros");
            Console.WriteLine("2. Analisis de evidencias - 120 euros");
            Console.WriteLine("3. Investigacion empresarial - 180 euros");

            do
            {
                Console.Write("Selecciona un servicio: ");
                opcionServicio = int.Parse(Console.ReadLine());

                if (opcionServicio == 1)
                {
                    nombreServicio = "Investigacion documental";
                    precioServicio = 80;
                }
                else if (opcionServicio == 2)
                {
                    nombreServicio = "Analisis de evidencias";
                    precioServicio = 120;
                }
                else if (opcionServicio == 3)
                {
                    nombreServicio = "Investigacion empresarial";
                    precioServicio = 180;
                }
                else
                {
                    Console.WriteLine("Opcion incorrecta. Intentalo denuevo");
                }
            } while (opcionServicio < 1 || opcionServicio > 3);
        }

        else if (opcion == 2)
        {
            Console.WriteLine("Estadistica de la agencia");
        }
        else if (opcion == 3)
        {
            Console.WriteLine("Gracias por utilizar InvestiCore");
        } 
        else
        {
            Console.WriteLine("Opcion incorrecta");
        }
    

    Console.WriteLine();
} while (opcion != 3);
