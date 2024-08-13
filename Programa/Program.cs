// Cajero 
//Aquí a continuación se declaran las cuentas que estarán registradas inicialmente 
using System;
using System.IO;

    // Ruta del archivo de datos de clientes
    string filePath = @"D:\TECMILENIO\Fundamentos de Programación\datos_clientes.txt";

    // Usamos StreamReader para leer el archivo
    using (StreamReader sr = new StreamReader(filePath))
    {
        string line;

        // Leer y procesar cada línea del archivo
        while ((line = sr.ReadLine()) != null)
        {
            // Buscar el índice del primer ":" en la línea
            int index = line.IndexOf(':');

            // Verificar si se encontró ":" y procesar la línea
            if (index != -1 && index + 1 < line.Length)
            {
                string value = line.Substring(index + 1).Trim();
                Console.WriteLine(value);
            }
            else
            {
                Console.WriteLine("Formato de línea incorrecto: " + line);
            }
        }
    }

    /*using System.Reflection;
    using System.Runtime.CompilerServices;
    string line;
    StreamReader sr = new StreamReader("D:\\TECMILENIO\\Fundamentos de Programación\\datos_clientes.txt");
    line = sr.ReadLine();
    while (line != null)
    {
        if (index != -1 && index + 1 < line.Length)
        {
            string value = line.Substring(index + 1).Trim();
            Console.WriteLine(value);
        }
        else
        {
            Console.WriteLine("Formato de línea incorrecto: " + line);
        }
        Console.WriteLine(line);
        line = sr.ReadLine();
    }*/

long c1= 4242424242424240;
long c2 = 4000056655665550;
long c3 = 5555555555554440;
long c4 = 2223003122003220;
long numtar=0;

//Se asignan códigos desde un inicio para que la prueba del programa sea más práctica
int cvc1 = 736;
int cvc2 = 837;
int cvc3 = 934;
int cvc4 = 893;
int cvc=0;

//Se asigna el nombre de los usuarios de cada cuenta en orden
string u1 = "Juan Montes";
string u2 = "Pedro Zapata";
string u3 = "Ana Martínez";
string u4 = "Rogelio Guerra";

//Se asignará un monto generico a cada cuenta para que la prueba del programa sea más práctica
float s1 = 10000;
float s2 = 10000;
float s3 = 10000;
float s4 = 10000;

//Se inicializan estás variables en  0 para que cuando se inicie otro proceso no acumulen valor
int op = 0;
float retiro;
float transf;
float deposito = 0;
int valid = 0;
float residuo; 


//Se ingresan las fechas actuales por default, ya que no se tiene en PSeInt una función que calcule la fecha actual
int yearact = 24;
int mesact = 7;
int mesven = 0;
int yearven = 0;

//Aquí estaremos pidiendo al usuario que se ingrese el número de tarjeta 
Console.WriteLine("Ingresa el número de tu tarjeta ");
numtar = long.Parse(Console.ReadLine());
Console.WriteLine("Ingresa el CVC de tu tarjeta ");
cvc = Int32.Parse(Console.ReadLine());

//Se valida en este SI que el número de tarjeta sea correcto
if (numtar == c1)
{
    //Este SI condicional validará que el codigo coincida con la tarjeta asignada 
    if (cvc==cvc1)
    {
        Console.WriteLine("Bienvenido: " + u1);
        //INICIO del desarrollo para cada número de tarjeta
        //Aquí se validará que la tarjeta no este vencida
        Console.WriteLine("Ingresa el mes de vencimiento de la tarjeta en el siguiente formato: 01,02,...,12");
        mesven = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Ingresa los 2 últimos dígitos del año de vencimiento de tu tarjeta");
        yearven = Int32.Parse(Console.ReadLine());
        //Condicional SI que valida que la tarjeta no esta vencida
        if(yearven<yearact)
        {
            Console.WriteLine("Su plástico ha vencido, pase a ventanilla para obtener uno nuevo.");
        }
        else
        {
            if(mesven<mesact)
            {
                Console.WriteLine("Su plástico ha vencido, pase a ventanilla para obtener uno nuevo.");
            }
        }
        //Fin del condicional para validar vencimiento

        //Inicia el desarrollo de cada número de tarjeta para el c1
        do
        {
            Console.WriteLine("Elige la opción de la transacción que deseas realizar: \n 1. Retiro de dinero\n 2. Transferencia de fondos\n 3. Depósito de fondos\n 4. Consulta de saldos\n 5. Salir");
            op=Int32.Parse(Console.ReadLine());

            //Se inicia el menú de opciones 
            switch(op)
            {
                case 1:
                    Console.WriteLine("Ingrese la cantidad que desea retirar");
                    retiro=float.Parse(Console.ReadLine());
                    //se valida que la cantidad que se desea retirar no supere el saldo de la cuenta 
                    if(retiro>s1)
                    {
                        Console.WriteLine("Fondos insuficientes.");
                    }
                    else
                    {
                        //Se descuenta el monto a retirar de el saldo actual 
                        s1 = s1 - retiro;
                        Console.WriteLine("Su retiro se esta realizando puede tomar su dinero de la bandeja \n" + "Su nuevo balance es: $" + s1);
                        Console.WriteLine("Si desea realizar alguna otra operación ingrese 1, de lo contrario ingrese 2 para salir");
                        valid=Int32.Parse(Console.ReadLine());
                    }
                    break;
                //Fin proceso de Retiro de dinero

                //Se inicia el proceso de transferir fondos
                case 2:
                    Console.WriteLine("Ingresa el número de tarjeta a la cual quieres realizar la Transferencia de fondos");
                    numtar=long.Parse(Console.ReadLine());
                    //Se inicia condicional para validar el número de tarjeta que sea existente 
                    if(numtar==c1)
                    {
                        Console.WriteLine("Ingresa la cantidad que deseas transferir");
                        transf=float.Parse(Console.ReadLine());
                        //Aquí validamos si se cuenta con los fondos suficientes para realizar la transacción 
                        if(transf>s1)
                        {
                            Console.WriteLine("Fondos insuficientes.");
                        }
                        else
                        {
                            s1=s1 - transf;
                            Console.WriteLine("Su transacción ha sido exitosa \n" + "Su nuevo balance es: $" +s1);
                            Console.WriteLine("Si desea realizar alguna otra operación ingrese 1, de lo contrario ingrese 2 para salir");
                            valid=Int32.Parse(Console.ReadLine());
                        }
                    }
                    else
                    {
                        if(numtar==c2)
                        {
                            Console.WriteLine("Ingresa la cantidad que deseas transferir");
                            transf = float.Parse(Console.ReadLine());
                            //Aquí validamos si se cuenta con los fondos suficientes para realizar la transacción 
                            if (transf > s1)
                            {
                                Console.WriteLine("Fondos insuficientes.");
                            }
                            else
                            {
                                s1 = s1 - transf;
                                Console.WriteLine("Su transacción ha sido exitosa\n" + "Su nuevo balance es: $" +s1);
                                Console.WriteLine("Si desea realizar alguna otra operación ingrese 1, de lo contrario ingrese 2 para salir");
                                valid = Int32.Parse(Console.ReadLine());
                            }
                        }
                        else
                        {
                            if(numtar==c3)
                            {
                                Console.WriteLine("Ingresa la cantidad que deseas transferir");
                                transf = float.Parse(Console.ReadLine());
                                //Aquí validamos si se cuenta con los fondos suficientes para realizar la transacción 
                                if (transf > s1)
                                {
                                    Console.WriteLine("Fondos insuficientes.");
                                }
                                else
                                {
                                    s1 = s1 - transf;
                                    Console.WriteLine("Su transacción ha sido exitosa\n" + "Su nuevo balance es: $" +s1);
                                    Console.WriteLine("Si desea realizar alguna otra operación ingrese 1, de lo contrario ingrese 2 para salir");
                                    valid = Int32.Parse(Console.ReadLine());
                                }
                            }
                            else
                            {
                                if(numtar==c4)
                                {
                                    Console.WriteLine("Ingresa la cantidad que deseas transferir");
                                    transf = float.Parse(Console.ReadLine());
                                    //Aquí validamos si se cuenta con los fondos suficientes para realizar la transacción 
                                    if (transf > s1)
                                    {
                                        Console.WriteLine("Fondos insuficientes.");
                                    }
                                    else
                                    {
                                        s1 = s1 - transf;
                                        Console.WriteLine("Su transacción ha sido exitosa\n" + "Su nuevo balance es: $" +s1);
                                        Console.WriteLine("Si desea realizar alguna otra operación ingrese 1, de lo contrario ingrese 2 para salir");
                                        valid = Int32.Parse(Console.ReadLine());
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("El número de tarjeta a la que quiere transferir no existe");
                                }
                            }
                        }
                    }
                    break;
                //Fin proceso de transferir fondos 

                //Se inicia el proceso de realizar un deposito
                case 3: 
                    Console.WriteLine("Ingresa el número de tarjeta a la cual quieres realizar el Depósito de fondos");
                    numtar=long.Parse(Console.ReadLine());
                    //Se inicia condicional para validar el número de tarjeta que sea existente 
                    if (numtar==c1)
                    {
                        Console.WriteLine("Ingresa la cantidad que deseas depositar, ¡SOLO SE ACEPTAN BILLETES!");
                        deposito=float.Parse(Console.ReadLine());
                        //Aquí se valida que al dividir la cantidad entre 10 el residuo sea 0
                        residuo=deposito%10;
                        //Aquí se válida que no se ingresen monedas
                        while(residuo!=0)
                        {
                            Console.WriteLine("Error, no se aceptan monedas, modifique la cantidad");
                            deposito = float.Parse(Console.ReadLine());
                            residuo = deposito % 10;
                        }
                        Console.WriteLine("Ingrese los billetes en la bandeja");
                        Console.WriteLine("Deposito realizado exitosamente por la cantidad de: $" + deposito);
                        Console.WriteLine("Si desea realizar alguna otra operación ingrese 1, de lo contrario ingrese 2 para salir");
                        valid=Int32.Parse(Console.ReadLine());
                    }
                    else
                    {
                        if(numtar==c2)
                        {
                            Console.WriteLine("Ingresa la cantidad que deseas depositar, ¡SOLO SE ACEPTAN BILLETES!");
                            deposito = float.Parse(Console.ReadLine());
                            //Aquí se valida que al dividir la cantidad entre 10 el residuo sea 0
                            residuo = deposito % 10;
                            //Aquí se válida que no se ingresen monedas
                            while (residuo != 0)
                            {
                                Console.WriteLine("Error, no se aceptan monedas, modifique la cantidad");
                                deposito = float.Parse(Console.ReadLine());
                                residuo = deposito % 10;
                            }
                            Console.WriteLine("Ingrese los billetes en la bandeja");
                            Console.WriteLine("Deposito realizado exitosamente por la cantidad de: $" +deposito);
                            Console.WriteLine("Si desea realizar alguna otra operación ingrese 1, de lo contrario ingrese 2 para salir");
                            valid = Int32.Parse(Console.ReadLine());
                        }
                        else
                        {
                            if(numtar==c3)
                            {
                                Console.WriteLine("Ingresa la cantidad que deseas depositar, ¡SOLO SE ACEPTAN BILLETES!");
                                deposito = float.Parse(Console.ReadLine());
                                //Aquí se valida que al dividir la cantidad entre 10 el residuo sea 0
                                residuo = deposito % 10;
                                //Aquí se válida que no se ingresen monedas
                                while (residuo != 0)
                                {
                                    Console.WriteLine("Error, no se aceptan monedas, modifique la cantidad");
                                    deposito = float.Parse(Console.ReadLine());
                                    residuo = deposito % 10;
                                }
                                Console.WriteLine("Ingrese los billetes en la bandeja");
                                Console.WriteLine("Deposito realizado exitosamente por la cantidad de: $" +deposito);
                                Console.WriteLine("Si desea realizar alguna otra operación ingrese 1, de lo contrario ingrese 2 para salir");
                                valid = Int32.Parse(Console.ReadLine());
                            }
                            else
                            {
                                if(numtar==c4)
                                {
                                    Console.WriteLine("Ingresa la cantidad que deseas depositar, ¡SOLO SE ACEPTAN BILLETES!");
                                    deposito = float.Parse(Console.ReadLine());
                                    //Aquí se valida que al dividir la cantidad entre 10 el residuo sea 0
                                    residuo = deposito % 10;
                                    //Aquí se válida que no se ingresen monedas
                                    while (residuo != 0)
                                    {
                                        Console.WriteLine("Error, no se aceptan monedas, modifique la cantidad");
                                        deposito = float.Parse(Console.ReadLine());
                                        residuo = deposito % 10;
                                    }
                                    Console.WriteLine("Ingrese los billetes en la bandeja");
                                    Console.WriteLine("Deposito realizado exitosamente por la cantidad de: $" +deposito);
                                    Console.WriteLine("Si desea realizar alguna otra operación ingrese 1, de lo contrario ingrese 2 para salir");
                                    valid = Int32.Parse(Console.ReadLine());
                                }
                                else
                                {
                                    Console.WriteLine("El número de tarjeta a la que quiere realizar el depósito no existe");
                                }
                            }
                        }
                    }
                    break;
                //Fin Proceso de realizar un depósito

                //Se inicia el proceso de consultar el saldo
                case 4:
                    //Escribir el saldo en un archivo 
                    try
                    {
                        Console.WriteLine("Su saldo actual es de: $" + s1);
                        StreamWriter sw= new StreamWriter ("D:\\TECMILENIO\\Fundamentos de Programación\\Archivos_Cajero\\SaldoCliente.txt");
                        sw.WriteLine("Su saldo es de: $" + s1);
                        sw.Close();
                        
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Ocurrió un error al generar el archivo:");
                        Console.WriteLine(e.Message);
                    }
                    finally
                    {
                        Console.WriteLine("Imprimiendo recibo...");
                    }
                    Console.WriteLine("Si desea realizar alguna otra operación ingrese 1, de lo contrario ingrese 2 para salir");
                    valid = Int32.Parse(Console.ReadLine());
                    break;
                //Fin proceso de consultar saldo

                //Inicio proceso de salir del menú
                case 5:
                    Console.WriteLine("Gracias por usar nuestro cajero");
                    valid = 2;
                    break;
                //Fin proceso salir del menú	

                //Mensaje que mostrará de error en caso de que la opción no sea válida
                default:
                    Console.WriteLine("La opción elegida es incorrecta");
                    break;
                    //Finaliza menú de opciones
            }
        } while (valid != 2);
        //Fin de desarrollo para cada número de tarjeta
    }
    else
    {
        Console.WriteLine("El CVC que ingresaste es incorrecto, ingresalo de nuevo");
    }
}
else
{
    if(numtar==c2)
    {
        //Este SI condicional validará que el codigo coincida con la tarjeta asignada 
        if (cvc == cvc2)
        {
            Console.WriteLine("Bienvenido: " + u2);
            //INICIO del desarrollo para cada número de tarjeta
            //Aquí se validará que la tarjeta no este vencida
            Console.WriteLine("Ingresa el mes de vencimiento de la tarjeta en el siguiente formato: 01,02,...,12");
            mesven = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa los 2 últimos dígitos del año de vencimiento de tu tarjeta");
            yearven = Int32.Parse(Console.ReadLine());
            //Condicional SI que valida que la tarjeta no esta vencida
            if (yearven < yearact)
            {
                Console.WriteLine("Su plástico ha vencido, pase a ventanilla para obtener uno nuevo.");
            }
            else
            {
                if (mesven < mesact)
                {
                    Console.WriteLine("Su plástico ha vencido, pase a ventanilla para obtener uno nuevo.");
                }
            }
            //Fin del condicional para validar vencimiento

            //Inicia el desarrollo de cada número de tarjeta para el c1
            do
            {
                Console.WriteLine("Elige la opción de la transacción que deseas realizar: \n 1. Retiro de dinero\n 2. Transferencia de fondos\n 3. Depósito de fondos\n 4. Consulta de saldos\n 5. Salir");
                op = Int32.Parse(Console.ReadLine());

                //Se inicia el menú de opciones 
                switch (op)
                {
                    case 1:
                        Console.WriteLine("Ingrese la cantidad que desea retirar");
                        retiro = float.Parse(Console.ReadLine());
                        //se valida que la cantidad que se desea retirar no supere el saldo de la cuenta 
                        if (retiro > s2)
                        {
                            Console.WriteLine("Fondos insuficientes.");
                        }
                        else
                        {
                            //Se descuenta el monto a retirar de el saldo actual 
                            s2 = s2 - retiro;
                            Console.WriteLine("Su retiro se esta realizando puede tomar su dinero de la bandeja \n" + "Su nuevo balance es: $" +s2);
                            Console.WriteLine("Si desea realizar alguna otra operación ingrese 1, de lo contrario ingrese 2 para salir");
                            valid = Int32.Parse(Console.ReadLine());
                        }
                        break;
                    //Fin proceso de Retiro de dinero

                    //Se inicia el proceso de transferir fondos
                    case 2:
                        Console.WriteLine("Ingresa el número de tarjeta a la cual quieres realizar la Transferencia de fondos");
                        numtar = long.Parse(Console.ReadLine());
                        //Se inicia condicional para validar el número de tarjeta que sea existente 
                        if (numtar == c1)
                        {
                            Console.WriteLine("Ingresa la cantidad que deseas transferir");
                            transf = float.Parse(Console.ReadLine());
                            //Aquí validamos si se cuenta con los fondos suficientes para realizar la transacción 
                            if (transf > s2)
                            {
                                Console.WriteLine("Fondos insuficientes.");
                            }
                            else
                            {
                                s2 = s2 - transf;
                                Console.WriteLine("Su transacción ha sido exitosa\n" + "Su nuevo balance es: $" +s2);
                                Console.WriteLine("Si desea realizar alguna otra operación ingrese 1, de lo contrario ingrese 2 para salir");
                                valid = Int32.Parse(Console.ReadLine());
                            }
                        }
                        else
                        {
                            if (numtar == c2)
                            {
                                Console.WriteLine("Ingresa la cantidad que deseas transferir");
                                transf = float.Parse(Console.ReadLine());
                                //Aquí validamos si se cuenta con los fondos suficientes para realizar la transacción 
                                if (transf > s2)
                                {
                                    Console.WriteLine("Fondos insuficientes.");
                                }
                                else
                                {
                                    s2 = s2 - transf;
                                    Console.WriteLine("Su transacción ha sido exitosa\n" + "Su nuevo balance es: $" +s2);
                                    Console.WriteLine("Si desea realizar alguna otra operación ingrese 1, de lo contrario ingrese 2 para salir");
                                    valid = Int32.Parse(Console.ReadLine());
                                }
                            }
                            else
                            {
                                if (numtar == c3)
                                {
                                    Console.WriteLine("Ingresa la cantidad que deseas transferir");
                                    transf = float.Parse(Console.ReadLine());
                                    //Aquí validamos si se cuenta con los fondos suficientes para realizar la transacción 
                                    if (transf > s2)
                                    {
                                        Console.WriteLine("Fondos insuficientes.");
                                    }
                                    else
                                    {
                                        s2 = s2 - transf;
                                        Console.WriteLine("Su transacción ha sido exitosa\n" + "Su nuevo balance es: $" +s2);
                                        Console.WriteLine("Si desea realizar alguna otra operación ingrese 1, de lo contrario ingrese 2 para salir");
                                        valid = Int32.Parse(Console.ReadLine());
                                    }
                                }
                                else
                                {
                                    if (numtar == c4)
                                    {
                                        Console.WriteLine("Ingresa la cantidad que deseas transferir");
                                        transf = float.Parse(Console.ReadLine());
                                        //Aquí validamos si se cuenta con los fondos suficientes para realizar la transacción 
                                        if (transf > s2)
                                        {
                                            Console.WriteLine("Fondos insuficientes.");
                                        }
                                        else
                                        {
                                            s2 = s2 - transf;
                                            Console.WriteLine("Su transacción ha sido exitosa\n" + "Su nuevo balance es: $" +s2);
                                            Console.WriteLine("Si desea realizar alguna otra operación ingrese 1, de lo contrario ingrese 2 para salir");
                                            valid = Int32.Parse(Console.ReadLine());
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("El número de tarjeta a la que quiere transferir no existe");
                                    }
                                }
                            }
                        }
                        break;
                    //Fin proceso de transferir fondos 

                    //Se inicia el proceso de realizar un deposito
                    case 3:
                        Console.WriteLine("Ingresa el número de tarjeta a la cual quieres realizar el Depósito de fondos");
                        numtar = long.Parse(Console.ReadLine());
                        //Se inicia condicional para validar el número de tarjeta que sea existente 
                        if (numtar == c1)
                        {
                            Console.WriteLine("Ingresa la cantidad que deseas depositar, ¡SOLO SE ACEPTAN BILLETES!");
                            deposito = float.Parse(Console.ReadLine());
                            //Aquí se valida que al dividir la cantidad entre 10 el residuo sea 0
                            residuo = deposito % 10;
                            //Aquí se válida que no se ingresen monedas
                            while (residuo != 0)
                            {
                                Console.WriteLine("Error, no se aceptan monedas, modifique la cantidad");
                                deposito = float.Parse(Console.ReadLine());
                                residuo = deposito % 10;
                            }
                            Console.WriteLine("Ingrese los billetes en la bandeja");
                            Console.WriteLine("Deposito realizado exitosamente por la cantidad de: $" +deposito);
                            Console.WriteLine("Si desea realizar alguna otra operación ingrese 1, de lo contrario ingrese 2 para salir");
                            valid = Int32.Parse(Console.ReadLine());
                        }
                        else
                        {
                            if (numtar == c2)
                            {
                                Console.WriteLine("Ingresa la cantidad que deseas depositar, ¡SOLO SE ACEPTAN BILLETES!");
                                deposito = float.Parse(Console.ReadLine());
                                //Aquí se valida que al dividir la cantidad entre 10 el residuo sea 0
                                residuo = deposito % 10;
                                //Aquí se válida que no se ingresen monedas
                                while (residuo != 0)
                                {
                                    Console.WriteLine("Error, no se aceptan monedas, modifique la cantidad");
                                    deposito = float.Parse(Console.ReadLine());
                                    residuo = deposito % 10;
                                }
                                Console.WriteLine("Ingrese los billetes en la bandeja");
                                Console.WriteLine("Deposito realizado exitosamente por la cantidad de: $" +deposito);
                                Console.WriteLine("Si desea realizar alguna otra operación ingrese 1, de lo contrario ingrese 2 para salir");
                                valid = Int32.Parse(Console.ReadLine());
                            }
                            else
                            {
                                if (numtar == c3)
                                {
                                    Console.WriteLine("Ingresa la cantidad que deseas depositar, ¡SOLO SE ACEPTAN BILLETES!");
                                    deposito = float.Parse(Console.ReadLine());
                                    //Aquí se valida que al dividir la cantidad entre 10 el residuo sea 0
                                    residuo = deposito % 10;
                                    //Aquí se válida que no se ingresen monedas
                                    while (residuo != 0)
                                    {
                                        Console.WriteLine("Error, no se aceptan monedas, modifique la cantidad");
                                        deposito = float.Parse(Console.ReadLine());
                                        residuo = deposito % 10;
                                    }
                                    Console.WriteLine("Ingrese los billetes en la bandeja");
                                    Console.WriteLine("Deposito realizado exitosamente por la cantidad de: $" +deposito);
                                    Console.WriteLine("Si desea realizar alguna otra operación ingrese 1, de lo contrario ingrese 2 para salir");
                                    valid = Int32.Parse(Console.ReadLine());
                                }
                                else
                                {
                                    if (numtar == c4)
                                    {
                                        Console.WriteLine("Ingresa la cantidad que deseas depositar, ¡SOLO SE ACEPTAN BILLETES!");
                                        deposito = float.Parse(Console.ReadLine());
                                        //Aquí se valida que al dividir la cantidad entre 10 el residuo sea 0
                                        residuo = deposito % 10;
                                        //Aquí se válida que no se ingresen monedas
                                        while (residuo != 0)
                                        {
                                            Console.WriteLine("Error, no se aceptan monedas, modifique la cantidad");
                                            deposito = float.Parse(Console.ReadLine());
                                            residuo = deposito % 10;
                                        }
                                        Console.WriteLine("Ingrese los billetes en la bandeja");
                                        Console.WriteLine("Deposito realizado exitosamente por la cantidad de: $" +deposito);
                                        Console.WriteLine("Si desea realizar alguna otra operación ingrese 1, de lo contrario ingrese 2 para salir");
                                        valid = Int32.Parse(Console.ReadLine());
                                    }
                                    else
                                    {
                                        Console.WriteLine("El número de tarjeta a la que quiere realizar el depósito no existe");
                                    }
                                }
                            }
                        }
                        break;
                    //Fin Proceso de realizar un depósito

                    //Se inicia el proceso de consultar el saldo
                    case 4:
                        //Escribir el saldo en un archivo 
                        try
                        {
                            Console.WriteLine("Su saldo actual es de: $" + s2);
                            StreamWriter sw = new StreamWriter("D:\\TECMILENIO\\Fundamentos de Programación\\Archivos_Cajero\\SaldoCliente.txt");
                            sw.WriteLine("Su saldo es de: $" + s2);
                            sw.Close();

                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Ocurrió un error al generar el archivo:");
                            Console.WriteLine(e.Message);
                        }
                        finally
                        {
                            Console.WriteLine("Imprimiendo recibo...");
                        }
                        Console.WriteLine("Si desea realizar alguna otra operación ingrese 1, de lo contrario ingrese 2 para salir");
                        valid = Int32.Parse(Console.ReadLine());
                        break;
                    //Fin proceso de consultar saldo

                    //Inicio proceso de salir del menú
                    case 5:
                        Console.WriteLine("Gracias por usar nuestro cajero");
                        valid = 2;
                        break;
                    //Fin proceso salir del menú	

                    //Mensaje que mostrará de error en caso de que la opción no sea válida
                    default:
                        Console.WriteLine("La opción elegida es incorrecta");
                        break;
                        //Finaliza menú de opciones
                }
            } while (valid != 2);
            //Fin de desarrollo para cada número de tarjeta
        }
        else
        {
            Console.WriteLine("El CVC que ingresaste es incorrecto, ingresalo de nuevo");
        }
    }
    else
    {
        if(numtar==c3)
        {
            //Este SI condicional validará que el codigo coincida con la tarjeta asignada 
            if (cvc == cvc3)
            {
                Console.WriteLine("Bienvenido: " + u3);
                //INICIO del desarrollo para cada número de tarjeta
                //Aquí se validará que la tarjeta no este vencida
                Console.WriteLine("Ingresa el mes de vencimiento de la tarjeta en el siguiente formato: 01,02,...,12");
                mesven = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Ingresa los 2 últimos dígitos del año de vencimiento de tu tarjeta");
                yearven = Int32.Parse(Console.ReadLine());
                //Condicional SI que valida que la tarjeta no esta vencida
                if (yearven < yearact)
                {
                    Console.WriteLine("Su plástico ha vencido, pase a ventanilla para obtener uno nuevo.");
                }
                else
                {
                    if (mesven < mesact)
                    {
                        Console.WriteLine("Su plástico ha vencido, pase a ventanilla para obtener uno nuevo.");
                    }
                }
                //Fin del condicional para validar vencimiento

                //Inicia el desarrollo de cada número de tarjeta para el c1
                do
                {
                    Console.WriteLine("Elige la opción de la transacción que deseas realizar: \n 1. Retiro de dinero\n 2. Transferencia de fondos\n 3. Depósito de fondos\n 4. Consulta de saldos\n 5. Salir");
                    op = Int32.Parse(Console.ReadLine());

                    //Se inicia el menú de opciones 
                    switch (op)
                    {
                        case 1:
                            Console.WriteLine("Ingrese la cantidad que desea retirar");
                            retiro = float.Parse(Console.ReadLine());
                            //se valida que la cantidad que se desea retirar no supere el saldo de la cuenta 
                            if (retiro > s3)
                            {
                                Console.WriteLine("Fondos insuficientes.");
                            }
                            else
                            {
                                //Se descuenta el monto a retirar de el saldo actual 
                                s3 = s3 - retiro;
                                Console.WriteLine("Su retiro se esta realizando puede tomar su dinero de la bandeja \n" + "Su nuevo balance es: $" +s3);
                                Console.WriteLine("Si desea realizar alguna otra operación ingrese 1, de lo contrario ingrese 2 para salir");
                                valid = Int32.Parse(Console.ReadLine());
                            }
                            break;
                        //Fin proceso de Retiro de dinero

                        //Se inicia el proceso de transferir fondos
                        case 2:
                            Console.WriteLine("Ingresa el número de tarjeta a la cual quieres realizar la Transferencia de fondos");
                            numtar = long.Parse(Console.ReadLine());
                            //Se inicia condicional para validar el número de tarjeta que sea existente 
                            if (numtar == c1)
                            {
                                Console.WriteLine("Ingresa la cantidad que deseas transferir");
                                transf = float.Parse(Console.ReadLine());
                                //Aquí validamos si se cuenta con los fondos suficientes para realizar la transacción 
                                if (transf > s3)
                                {
                                    Console.WriteLine("Fondos insuficientes.");
                                }
                                else
                                {
                                    s3 = s3 - transf;
                                    Console.WriteLine("Su transacción ha sido exitosa\n" + "Su nuevo balance es: $" +s3);
                                    Console.WriteLine("Si desea realizar alguna otra operación ingrese 1, de lo contrario ingrese 2 para salir");
                                    valid = Int32.Parse(Console.ReadLine());
                                }
                            }
                            else
                            {
                                if (numtar == c2)
                                {
                                    Console.WriteLine("Ingresa la cantidad que deseas transferir");
                                    transf = float.Parse(Console.ReadLine());
                                    //Aquí validamos si se cuenta con los fondos suficientes para realizar la transacción 
                                    if (transf > s3)
                                    {
                                        Console.WriteLine("Fondos insuficientes.");
                                    }
                                    else
                                    {
                                        s3 = s3 - transf;
                                        Console.WriteLine("Su transacción ha sido exitosa\n" + "Su nuevo balance es: $" +s3);
                                        Console.WriteLine("Si desea realizar alguna otra operación ingrese 1, de lo contrario ingrese 2 para salir");
                                        valid = Int32.Parse(Console.ReadLine());
                                    }
                                }
                                else
                                {
                                    if (numtar == c3)
                                    {
                                        Console.WriteLine("Ingresa la cantidad que deseas transferir");
                                        transf = float.Parse(Console.ReadLine());
                                        //Aquí validamos si se cuenta con los fondos suficientes para realizar la transacción 
                                        if (transf > s3)
                                        {
                                            Console.WriteLine("Fondos insuficientes.");
                                        }
                                        else
                                        {
                                            s3 = s3 - transf;
                                            Console.WriteLine("Su transacción ha sido exitosa\n" + "Su nuevo balance es: $" +s3);
                                            Console.WriteLine("Si desea realizar alguna otra operación ingrese 1, de lo contrario ingrese 2 para salir");
                                            valid = Int32.Parse(Console.ReadLine());
                                        }
                                    }
                                    else
                                    {
                                        if (numtar == c4)
                                        {
                                            Console.WriteLine("Ingresa la cantidad que deseas transferir");
                                            transf = float.Parse(Console.ReadLine());
                                            //Aquí validamos si se cuenta con los fondos suficientes para realizar la transacción 
                                            if (transf > s3)
                                            {
                                                Console.WriteLine("Fondos insuficientes.");
                                            }
                                            else
                                            {
                                                s3 = s3 - transf;
                                                Console.WriteLine("Su transacción ha sido exitosa\n" + "Su nuevo balance es: $" +s3);
                                                Console.WriteLine("Si desea realizar alguna otra operación ingrese 1, de lo contrario ingrese 2 para salir");
                                                valid = Int32.Parse(Console.ReadLine());
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("El número de tarjeta a la que quiere transferir no existe");
                                        }
                                    }
                                }
                            }
                            break;
                        //Fin proceso de transferir fondos 

                        //Se inicia el proceso de realizar un deposito
                        case 3:
                            Console.WriteLine("Ingresa el número de tarjeta a la cual quieres realizar el Depósito de fondos");
                            numtar = long.Parse(Console.ReadLine());
                            //Se inicia condicional para validar el número de tarjeta que sea existente 
                            if (numtar == c1)
                            {
                                Console.WriteLine("Ingresa la cantidad que deseas depositar, ¡SOLO SE ACEPTAN BILLETES!");
                                deposito = float.Parse(Console.ReadLine());
                                //Aquí se valida que al dividir la cantidad entre 10 el residuo sea 0
                                residuo = deposito % 10;
                                //Aquí se válida que no se ingresen monedas
                                while (residuo != 0)
                                {
                                    Console.WriteLine("Error, no se aceptan monedas, modifique la cantidad");
                                    deposito = float.Parse(Console.ReadLine());
                                    residuo = deposito % 10;
                                }
                                Console.WriteLine("Ingrese los billetes en la bandeja");
                                Console.WriteLine("Deposito realizado exitosamente por la cantidad de: $" +deposito);
                                Console.WriteLine("Si desea realizar alguna otra operación ingrese 1, de lo contrario ingrese 2 para salir");
                                valid = Int32.Parse(Console.ReadLine());
                            }
                            else
                            {
                                if (numtar == c2)
                                {
                                    Console.WriteLine("Ingresa la cantidad que deseas depositar, ¡SOLO SE ACEPTAN BILLETES!");
                                    deposito = float.Parse(Console.ReadLine());
                                    //Aquí se valida que al dividir la cantidad entre 10 el residuo sea 0
                                    residuo = deposito % 10;
                                    //Aquí se válida que no se ingresen monedas
                                    while (residuo != 0)
                                    {
                                        Console.WriteLine("Error, no se aceptan monedas, modifique la cantidad");
                                        deposito = float.Parse(Console.ReadLine());
                                        residuo = deposito % 10;
                                    }
                                    Console.WriteLine("Ingrese los billetes en la bandeja");
                                    Console.WriteLine("Deposito realizado exitosamente por la cantidad de: $" +deposito);
                                    Console.WriteLine("Si desea realizar alguna otra operación ingrese 1, de lo contrario ingrese 2 para salir");
                                    valid = Int32.Parse(Console.ReadLine());
                                }
                                else
                                {
                                    if (numtar == c3)
                                    {
                                        Console.WriteLine("Ingresa la cantidad que deseas depositar, ¡SOLO SE ACEPTAN BILLETES!");
                                        deposito = float.Parse(Console.ReadLine());
                                        //Aquí se valida que al dividir la cantidad entre 10 el residuo sea 0
                                        residuo = deposito % 10;
                                        //Aquí se válida que no se ingresen monedas
                                        while (residuo != 0)
                                        {
                                            Console.WriteLine("Error, no se aceptan monedas, modifique la cantidad");
                                            deposito = float.Parse(Console.ReadLine());
                                            residuo = deposito % 10;
                                        }
                                        Console.WriteLine("Ingrese los billetes en la bandeja");
                                        Console.WriteLine("Deposito realizado exitosamente por la cantidad de: $" +deposito);
                                        Console.WriteLine("Si desea realizar alguna otra operación ingrese 1, de lo contrario ingrese 2 para salir");
                                        valid = Int32.Parse(Console.ReadLine());
                                    }
                                    else
                                    {
                                        if (numtar == c4)
                                        {
                                            Console.WriteLine("Ingresa la cantidad que deseas depositar, ¡SOLO SE ACEPTAN BILLETES!");
                                            deposito = float.Parse(Console.ReadLine());
                                            //Aquí se valida que al dividir la cantidad entre 10 el residuo sea 0
                                            residuo = deposito % 10;
                                            //Aquí se válida que no se ingresen monedas
                                            while (residuo != 0)
                                            {
                                                Console.WriteLine("Error, no se aceptan monedas, modifique la cantidad");
                                                deposito = float.Parse(Console.ReadLine());
                                                residuo = deposito % 10;
                                            }
                                            Console.WriteLine("Ingrese los billetes en la bandeja");
                                            Console.WriteLine("Deposito realizado exitosamente por la cantidad de: $" +deposito);
                                            Console.WriteLine("Si desea realizar alguna otra operación ingrese 1, de lo contrario ingrese 2 para salir");
                                            valid = Int32.Parse(Console.ReadLine());
                                        }
                                        else
                                        {
                                            Console.WriteLine("El número de tarjeta a la que quiere realizar el depósito no existe");
                                        }
                                    }
                                }
                            }
                            break;
                        //Fin Proceso de realizar un depósito

                        //Se inicia el proceso de consultar el saldo
                        case 4:
                            //Escribir el saldo en un archivo 
                            try
                            {
                                Console.WriteLine("Su saldo actual es de: $" + s3);
                                StreamWriter sw = new StreamWriter("D:\\TECMILENIO\\Fundamentos de Programación\\Archivos_Cajero\\SaldoCliente.txt");
                                sw.WriteLine("Su saldo es de: $" + s3);
                                sw.Close();

                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Ocurrió un error al generar el archivo:");
                                Console.WriteLine(e.Message);
                            }
                            finally
                            {
                                Console.WriteLine("Imprimiendo recibo...");
                            }
                            Console.WriteLine("Si desea realizar alguna otra operación ingrese 1, de lo contrario ingrese 2 para salir");
                            valid = Int32.Parse(Console.ReadLine());
                            break;
                        //Fin proceso de consultar saldo

                        //Inicio proceso de salir del menú
                        case 5:
                            Console.WriteLine("Gracias por usar nuestro cajero");
                            valid = 2;
                            break;
                        //Fin proceso salir del menú	

                        //Mensaje que mostrará de error en caso de que la opción no sea válida
                        default:
                            Console.WriteLine("La opción elegida es incorrecta");
                            break;
                            //Finaliza menú de opciones
                    }
                } while (valid != 2);
                //Fin de desarrollo para cada número de tarjeta
            }
            else
            {
                Console.WriteLine("El CVC que ingresaste es incorrecto, ingresalo de nuevo");
            }
        }
        else
        {
            if(numtar==c4)
            {
                //Este SI condicional validará que el codigo coincida con la tarjeta asignada 
                if (cvc == cvc4)
                {
                    Console.WriteLine("Bienvenido: " + u4);
                    //INICIO del desarrollo para cada número de tarjeta
                    //Aquí se validará que la tarjeta no este vencida
                    Console.WriteLine("Ingresa el mes de vencimiento de la tarjeta en el siguiente formato: 01,02,...,12");
                    mesven = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Ingresa los 2 últimos dígitos del año de vencimiento de tu tarjeta");
                    yearven = Int32.Parse(Console.ReadLine());
                    //Condicional SI que valida que la tarjeta no esta vencida
                    if (yearven < yearact)
                    {
                        Console.WriteLine("Su plástico ha vencido, pase a ventanilla para obtener uno nuevo.");
                    }
                    else
                    {
                        if (mesven < mesact)
                        {
                            Console.WriteLine("Su plástico ha vencido, pase a ventanilla para obtener uno nuevo.");
                        }
                    }
                    //Fin del condicional para validar vencimiento

                    //Inicia el desarrollo de cada número de tarjeta para el c1
                    do
                    {
                        Console.WriteLine("Elige la opción de la transacción que deseas realizar: \n 1. Retiro de dinero\n 2. Transferencia de fondos\n 3. Depósito de fondos\n 4. Consulta de saldos\n 5. Salir");
                        op = Int32.Parse(Console.ReadLine());

                        //Se inicia el menú de opciones 
                        switch (op)
                        {
                            case 1:
                                Console.WriteLine("Ingrese la cantidad que desea retirar");
                                retiro = float.Parse(Console.ReadLine());
                                //se valida que la cantidad que se desea retirar no supere el saldo de la cuenta 
                                if (retiro > s4)
                                {
                                    Console.WriteLine("Fondos insuficientes.");
                                }
                                else
                                {
                                    //Se descuenta el monto a retirar de el saldo actual 
                                    s4 = s4 - retiro;
                                    Console.WriteLine("Su retiro se esta realizando puede tomar su dinero de la bandeja \n" + "Su nuevo balance es: $" +s4);
                                    Console.WriteLine("Si desea realizar alguna otra operación ingrese 1, de lo contrario ingrese 2 para salir");
                                    valid = Int32.Parse(Console.ReadLine());
                                }
                                break;
                            //Fin proceso de Retiro de dinero

                            //Se inicia el proceso de transferir fondos
                            case 2:
                                Console.WriteLine("Ingresa el número de tarjeta a la cual quieres realizar la Transferencia de fondos");
                                numtar = long.Parse(Console.ReadLine());
                                //Se inicia condicional para validar el número de tarjeta que sea existente 
                                if (numtar == c1)
                                {
                                    Console.WriteLine("Ingresa la cantidad que deseas transferir");
                                    transf = float.Parse(Console.ReadLine());
                                    //Aquí validamos si se cuenta con los fondos suficientes para realizar la transacción 
                                    if (transf > s4)
                                    {
                                        Console.WriteLine("Fondos insuficientes.");
                                    }
                                    else
                                    {
                                        s4 = s4 - transf;
                                        Console.WriteLine("Su transacción ha sido exitosa\n" + "Su nuevo balance es: $" +s4);
                                        Console.WriteLine("Si desea realizar alguna otra operación ingrese 1, de lo contrario ingrese 2 para salir");
                                        valid = Int32.Parse(Console.ReadLine());
                                    }
                                }
                                else
                                {
                                    if (numtar == c2)
                                    {
                                        Console.WriteLine("Ingresa la cantidad que deseas transferir");
                                        transf = float.Parse(Console.ReadLine());
                                        //Aquí validamos si se cuenta con los fondos suficientes para realizar la transacción 
                                        if (transf > s4)
                                        {
                                            Console.WriteLine("Fondos insuficientes.");
                                        }
                                        else
                                        {
                                            s4 = s4 - transf;
                                            Console.WriteLine("Su transacción ha sido exitosa\n" + "Su nuevo balance es: $" +s4);
                                            Console.WriteLine("Si desea realizar alguna otra operación ingrese 1, de lo contrario ingrese 2 para salir");
                                            valid = Int32.Parse(Console.ReadLine());
                                        }
                                    }
                                    else
                                    {
                                        if (numtar == c3)
                                        {
                                            Console.WriteLine("Ingresa la cantidad que deseas transferir");
                                            transf = float.Parse(Console.ReadLine());
                                            //Aquí validamos si se cuenta con los fondos suficientes para realizar la transacción 
                                            if (transf > s4)
                                            {
                                                Console.WriteLine("Fondos insuficientes.");
                                            }
                                            else
                                            {
                                                s4 = s4 - transf;
                                                Console.WriteLine("Su transacción ha sido exitosa\n" + "Su nuevo balance es: $" +s4);
                                                Console.WriteLine("Si desea realizar alguna otra operación ingrese 1, de lo contrario ingrese 2 para salir");
                                                valid = Int32.Parse(Console.ReadLine());
                                            }
                                        }
                                        else
                                        {
                                            if (numtar == c4)
                                            {
                                                Console.WriteLine("Ingresa la cantidad que deseas transferir");
                                                transf = float.Parse(Console.ReadLine());
                                                //Aquí validamos si se cuenta con los fondos suficientes para realizar la transacción 
                                                if (transf > s4)
                                                {
                                                    Console.WriteLine("Fondos insuficientes.");
                                                }
                                                else
                                                {
                                                    s4 = s4 - transf;
                                                    Console.WriteLine("Su transacción ha sido exitosa\n" + "Su nuevo balance es: $" +s4);
                                                    Console.WriteLine("Si desea realizar alguna otra operación ingrese 1, de lo contrario ingrese 2 para salir");
                                                    valid = Int32.Parse(Console.ReadLine());
                                                }
                                            }
                                            else
                                            {
                                                Console.WriteLine("El número de tarjeta a la que quiere transferir no existe");
                                            }
                                        }
                                    }
                                }
                                break;
                            //Fin proceso de transferir fondos 

                            //Se inicia el proceso de realizar un deposito
                            case 3:
                                Console.WriteLine("Ingresa el número de tarjeta a la cual quieres realizar el Depósito de fondos");
                                numtar = long.Parse(Console.ReadLine());
                                //Se inicia condicional para validar el número de tarjeta que sea existente 
                                if (numtar == c1)
                                {
                                    Console.WriteLine("Ingresa la cantidad que deseas depositar, ¡SOLO SE ACEPTAN BILLETES!");
                                    deposito = float.Parse(Console.ReadLine());
                                    //Aquí se valida que al dividir la cantidad entre 10 el residuo sea 0
                                    residuo = deposito % 10;
                                    //Aquí se válida que no se ingresen monedas
                                    while (residuo != 0)
                                    {
                                        Console.WriteLine("Error, no se aceptan monedas, modifique la cantidad");
                                        deposito = float.Parse(Console.ReadLine());
                                        residuo = deposito % 10;
                                    }
                                    Console.WriteLine("Ingrese los billetes en la bandeja");
                                    Console.WriteLine("Deposito realizado exitosamente por la cantidad de: $" +deposito);
                                    Console.WriteLine("Si desea realizar alguna otra operación ingrese 1, de lo contrario ingrese 2 para salir");
                                    valid = Int32.Parse(Console.ReadLine());
                                }
                                else
                                {
                                    if (numtar == c2)
                                    {
                                        Console.WriteLine("Ingresa la cantidad que deseas depositar, ¡SOLO SE ACEPTAN BILLETES!");
                                        deposito = float.Parse(Console.ReadLine());
                                        //Aquí se valida que al dividir la cantidad entre 10 el residuo sea 0
                                        residuo = deposito % 10;
                                        //Aquí se válida que no se ingresen monedas
                                        while (residuo != 0)
                                        {
                                            Console.WriteLine("Error, no se aceptan monedas, modifique la cantidad");
                                            deposito = float.Parse(Console.ReadLine());
                                            residuo = deposito % 10;
                                        }
                                        Console.WriteLine("Ingrese los billetes en la bandeja");
                                        Console.WriteLine("Deposito realizado exitosamente por la cantidad de: $" +deposito);
                                        Console.WriteLine("Si desea realizar alguna otra operación ingrese 1, de lo contrario ingrese 2 para salir");
                                        valid = Int32.Parse(Console.ReadLine());
                                    }
                                    else
                                    {
                                        if (numtar == c3)
                                        {
                                            Console.WriteLine("Ingresa la cantidad que deseas depositar, ¡SOLO SE ACEPTAN BILLETES!");
                                            deposito = float.Parse(Console.ReadLine());
                                            //Aquí se valida que al dividir la cantidad entre 10 el residuo sea 0
                                            residuo = deposito % 10;
                                            //Aquí se válida que no se ingresen monedas
                                            while (residuo != 0)
                                            {
                                                Console.WriteLine("Error, no se aceptan monedas, modifique la cantidad");
                                                deposito = float.Parse(Console.ReadLine());
                                                residuo = deposito % 10;
                                            }
                                            Console.WriteLine("Ingrese los billetes en la bandeja");
                                            Console.WriteLine("Deposito realizado exitosamente por la cantidad de: $" +deposito);
                                            Console.WriteLine("Si desea realizar alguna otra operación ingrese 1, de lo contrario ingrese 2 para salir");
                                            valid = Int32.Parse(Console.ReadLine());
                                        }
                                        else
                                        {
                                            if (numtar == c4)
                                            {
                                                Console.WriteLine("Ingresa la cantidad que deseas depositar, ¡SOLO SE ACEPTAN BILLETES!");
                                                deposito = float.Parse(Console.ReadLine());
                                                //Aquí se valida que al dividir la cantidad entre 10 el residuo sea 0
                                                residuo = deposito % 10;
                                                //Aquí se válida que no se ingresen monedas
                                                while (residuo != 0)
                                                {
                                                    Console.WriteLine("Error, no se aceptan monedas, modifique la cantidad");
                                                    deposito = float.Parse(Console.ReadLine());
                                                    residuo = deposito % 10;
                                                }
                                                Console.WriteLine("Ingrese los billetes en la bandeja");
                                                Console.WriteLine("Deposito realizado exitosamente por la cantidad de: $" +deposito);
                                                Console.WriteLine("Si desea realizar alguna otra operación ingrese 1, de lo contrario ingrese 2 para salir");
                                                valid = Int32.Parse(Console.ReadLine());
                                            }
                                            else
                                            {
                                                Console.WriteLine("El número de tarjeta a la que quiere realizar el depósito no existe");
                                            }
                                        }
                                    }
                                }
                                break;
                            //Fin Proceso de realizar un depósito

                            //Se inicia el proceso de consultar el saldo
                            case 4:
                                //Escribir el saldo en un archivo 
                                try
                                {
                                    Console.WriteLine("Su saldo actual es de: $" + s4);
                                    StreamWriter sw = new StreamWriter("D:\\TECMILENIO\\Fundamentos de Programación\\Archivos_Cajero\\SaldoCliente.txt");
                                    sw.WriteLine("Su saldo es de: $" + s4);
                                    sw.Close();

                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine("Ocurrió un error al generar el archivo:");
                                    Console.WriteLine(e.Message);
                                }
                                finally
                                {
                                    Console.WriteLine("Imprimiendo recibo...");
                                }
                                Console.WriteLine("Si desea realizar alguna otra operación ingrese 1, de lo contrario ingrese 2 para salir");
                                valid = Int32.Parse(Console.ReadLine());
                                break;
                            //Fin proceso de consultar saldo

                            //Inicio proceso de salir del menú
                            case 5:
                                Console.WriteLine("Gracias por usar nuestro cajero");
                                valid = 2;
                                break;
                            //Fin proceso salir del menú	

                            //Mensaje que mostrará de error en caso de que la opción no sea válida
                            default:
                                Console.WriteLine("La opción elegida es incorrecta");
                                break;
                                //Finaliza menú de opciones
                        }
                    } while (valid != 2);
                    //Fin de desarrollo para cada número de tarjeta
                }
                else
                {
                    Console.WriteLine("El CVC que ingresaste es incorrecto, ingresalo de nuevo");
                }
            }
            else
            {
                Console.WriteLine("El número de tarjeta que ingresaste no existe");
            }
        }
    }
}
