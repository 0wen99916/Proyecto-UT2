int opcion = 0;

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
            Console.WriteLine("Registro de expediente");
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
            Console.WriteLine("Opcion Incorrecta");
        }
    

    Console.WriteLine();
} while (opcion != 3);
