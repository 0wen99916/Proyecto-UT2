int opcion = 0;
string nombreCliente = "";
string nombreExpediente = "";
int opcionServicio = 0;
string nombreServicio = "";
decimal precioServicio = 0;
bool extraInforme = false;
bool extraCronologico = false;
bool extraDocumental = false;
int opcionModalidad = 0;
decimal precioExtras = 0;
decimal subtotal = 0;
decimal descuento = 0;
decimal suplemento = 0;
decimal total = 0;
decimal dineroEntregado = 0;
decimal cambio = 0;

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

            Console.WriteLine();                                                  
            Console.WriteLine("SERVICIOS ADICIONALES");                           
            Console.WriteLine("____________________________________");            
            Console.WriteLine("1. Informe detallado - 25 euros");                 
            Console.WriteLine("2. Clasificacion cronologica de evidencias - 35"); 
            Console.WriteLine("3. Revision documental adicional - 20 euros");     
            Console.WriteLine("0. Finalizar seleccion de servicios extras");     

            int opcionExtra = -1;
            do
            {
                Console.WriteLine("Selecciona un extra: ");

                opcionExtra = int.Parse(Console.ReadLine());

                if (opcionExtra == 1)
                {
                    if (!extraInforme)
                    {
                        extraInforme = true;
                        Console.WriteLine("Informe detallado añadido");
                    }
                    else
                    {
                        Console.WriteLine("Este extra ya ha sido contratado");
                    }
                }
                else if (opcionExtra == 2)
                {
                    if (!extraCronologico)
                    {
                        extraCronologico = true;
                        Console.WriteLine("Clasificacion cronologica añadida");
                    }
                    else
                    {
                        Console.WriteLine("Este extra ya ha sido contratado");
                    }
                }
                else if (opcionExtra == 3)
                {
                    if (!extraDocumental)
                    {
                        extraDocumental = true;
                        Console.WriteLine("Revision documental añadida");
                    }
                    else
                    {
                        Console.WriteLine("Este extra ya ha sido contratado");
                    }
                }
                else if (opcionExtra != 0)
                {
                    Console.WriteLine("Opcion incorrecta");
                }

            } while (opcionExtra != 0);

            Console.WriteLine();
            Console.WriteLine("MODALIDAD DE CONTRATACION");
            Console.WriteLine("1. Normal (Sin suplemento)");
            Console.WriteLine("2. Urgente (20% adicional)");

            do
            {
                Console.WriteLine("Seleccion una modalidad");
                opcionModalidad = int.Parse(Console.ReadLine());

                if (opcionModalidad == 1)
                {
                    Console.WriteLine("Modalidad normal seleccionada");
                }
                else if (opcionModalidad == 2)
                {
                    Console.WriteLine("Modalidad urgente seleccionada");
                }
                else
                {
                    Console.WriteLine("Opcion Incorrecta. Intentalo de nuevo");
                }
            } while (opcionModalidad != 1 && opcionModalidad != 2);

            Console.WriteLine();
            Console.WriteLine("CALCULO IMPORTE");
            precioExtras = 0;

            if (extraInforme)
            {
                precioExtras = precioExtras + 25;
            }

            if (extraCronologico)
            {
                precioExtras = precioExtras + 35;
            }

            if (extraDocumental)
            {
                precioExtras = precioExtras + 20;
            }

            subtotal = precioServicio + precioExtras;

            descuento = 0;
            if (subtotal > 200)
            {
                descuento = subtotal * 0.10m;
            }

            total = subtotal - descuento;
            suplemento = 0;

            if (opcionModalidad == 2)
            {
                suplemento = total * 0.20m;
            }

            total = total + suplemento;

            Console.WriteLine($"Precio de servicio: {precioServicio} euros");
            Console.WriteLine($"Precio de los extras: {precioExtras} euros");
            Console.WriteLine($"Subtotal: {subtotal} euros");
            Console.WriteLine($"Descuento: {descuento} euros");
            Console.WriteLine($"Suplemento urgente: {suplemento} euros");
            Console.WriteLine($"TOTAL A PAGAR: {total} euros");

            Console.WriteLine();
            Console.WriteLine("COBRO EXPEDIENTE");

            do
            {
                Console.Write($"El importe total es {total:F2} euros. Introduce el dinero entregado: ");
                dineroEntregado = decimal.Parse(Console.ReadLine());

                if (dineroEntregado < total)
                {
                    Console.WriteLine("DInero insuficiente. Introduce una cantidad mayor o igual al total");
                }
            } while (dineroEntregado < total);

            cambio = dineroEntregado - total;
            Console.WriteLine("Pago realizado correctamente");
            Console.WriteLine($"Cambio a devolver: {cambio:F2} euros");

            Console.WriteLine();
            Console.WriteLine("==========================");
            Console.WriteLine("InvestiCore - Justificante");
            Console.WriteLine("==========================");
            Console.WriteLine($"Cliente: {nombreCliente}");
            Console.WriteLine($"Expediente: {nombreExpediente}");
            Console.WriteLine("--------------------------------");
            Console.WriteLine($"Servicio contratado: {nombreServicio}");
            Console.WriteLine($"Servicio contratado: {precioServicio:F2} euros");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("SERVICIOS ADICIONALES");

            if (extraInforme)
            {
                Console.WriteLine("Informe detallado: 25 euros");
            }
            if (extraCronologico)
            {
                Console.WriteLine("Clasificacion cronologica: 35 euros");
            }
            if (extraDocumental)
            {
                Console.WriteLine("Revision documental adicional: 20 euros");    
            }
            Console.WriteLine("--------------------------------");

            if (opcionModalidad == 1)
            {
                Console.WriteLine("Modalidad: Normal");
            }
            else
            {
                Console.WriteLine("Modalidad: Urgente");
            }

            Console.WriteLine($"Subtotal: {subtotal:F2} euros");
            Console.WriteLine($"Descuento: {descuento:F2} euros");
            Console.WriteLine($"Suplemento: {suplemento:F2} euros");
            Console.WriteLine("--------------------------------");
            Console.WriteLine($"TOTAL: {total:F2} euros");
            Console.WriteLine($"Dinero entregado: {dineroEntregado:F2} euros");
            Console.WriteLine($"Cambio: {cambio:F2} euros");
            Console.WriteLine("==============================================");
            Console.WriteLine("          GRACIAS POR SU CONFIANZA");
            Console.WriteLine("==============================================");
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
