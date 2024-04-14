class BANCO
{
    public static void Main(string[] args)
    {

        double Saldodecuenta = 5500, monto, cuenta;// Aqui vamos a definir todo las variables que vamos a utilizar para decimales o se que este parametro son para "double" 
        int opcion;
        string Usuario = "UsuarioPrueba", bancos, ResCorrecU;
        int Contraseña = 3885, ResCorrecC;
        do
        {
            Console.Write("Ingrese su nombre de usuario: ");
            ResCorrecU = Console.ReadLine();

            Console.Write("Ingrese su contraseña: ");
            ResCorrecC = Convert.ToInt32(Console.ReadLine());

            if (ResCorrecC != Contraseña || ResCorrecU != Usuario)
            {
                Console.Clear();
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("Usuario o Contraseña es incorrecto.");
                Console.WriteLine("Ingrese nuevamente su usuario y contraseña");
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("Presione cualquier tecla para volver a ingresar sus datos");
                Console.ReadKey();
                Console.Clear();
            }

        } while (ResCorrecU != Usuario && ResCorrecC != Contraseña);
        Console.Clear();

        do
        {
            Console.WriteLine("Bienvenido, " + Usuario);
            Console.WriteLine("--------------------------------");
            Console.WriteLine("| ¿En que le podemos ayudar?   |");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("1.Depósitos a mí cuenta\r\n2.Realizar transacciones\r\n3.Retiro de cuenta\r\n4.Mantener cajas de seguridad\r\n5.Dar asesoramiento financiero\r\n6.Consulta de cuenta\r\n7.Transferencia a otros bancos\r\n8.Salir" + "");
            opcion = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            switch (opcion)
            {

                case 1:

                    Console.WriteLine("Ingrese el monto a ingresar:");
                    int Montoaingresar = Convert.ToInt32(Console.ReadLine());
                    if (Montoaingresar > Saldodecuenta)
                    {
                        Console.WriteLine("Saldo insuficiente");
                        Console.WriteLine("Ingrese la cantidad de acuerdo a su saldo");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    Saldodecuenta = Saldodecuenta + Montoaingresar;
                    Console.WriteLine("Su saldo actual es de ${0} ", Saldodecuenta);
                    Console.WriteLine("Presione cualquier tecla");
                    Console.ReadKey();
                    Console.Clear();
                    break;

                case 2:
                    do
                    {
                        Console.WriteLine("Ingrese la cuenta a transferir");
                        Console.WriteLine("--------------------------------");
                        cuenta = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("--------------------------------");
                        Console.WriteLine("Ingrese el monto a transferir");
                        Console.WriteLine("--------------------------------");
                        monto = Convert.ToDouble(Console.ReadLine());
                        if (monto > Saldodecuenta)
                        {
                            Console.WriteLine("Ingrese un monto de acuerdo a su saldo");
                            Console.WriteLine("Presione cualquier tecla");
                            Console.ReadKey();
                            Console.Clear();
                        }
                    } while (monto > Saldodecuenta);

                    Saldodecuenta = (Saldodecuenta - monto);
                    Console.WriteLine("La transacción fue exitosa");
                    Console.WriteLine("--------------------------------");
                    Console.WriteLine("El monto a transferir: ${0} ", monto);
                    Console.WriteLine("--------------------------------");
                    Console.WriteLine("Cuenta de transferencia: {0} ", cuenta);
                    Console.WriteLine("--------------------------------");
                    Console.WriteLine("Su saldo es de : ${0}", Saldodecuenta);
                    Console.WriteLine("Presione cualquier tecla");
                    Console.ReadKey();
                    Console.Clear();

                    break;
                case 3:
                    Console.WriteLine("Ingrese el monto a retirar");
                    monto = Convert.ToDouble(Console.ReadLine());
                    if (monto > Saldodecuenta)
                    {
                        Console.WriteLine("Ingrese el monto a retirar correctamente, debe de ser menor o igual a su saldo  ${0} ", Saldodecuenta);
                        Console.Clear();
                    }
                    else
                    {
                        Saldodecuenta = Saldodecuenta - monto;
                        Console.WriteLine("--------------------------------");
                        Console.WriteLine("El monto a retirar es de ${0}", monto);
                        Console.WriteLine("--------------------------------");
                        Console.WriteLine("Su saldo actual es ${0}", Saldodecuenta);
                        Console.WriteLine("--------------------------------");
                        Console.WriteLine("Presione cualquier tecla");
                        Console.ReadKey();
                        Console.Clear();

                    }
                    break;

                case 4:
                    Console.WriteLine("");
                    Console.WriteLine("Ingrese ");
                    Console.WriteLine("¿Que desea hacer?");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 5:
                    Console.WriteLine("");
                    Console.WriteLine("Ingrese ");
                    Console.WriteLine("¿Que desea hacer?");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 6:
                    Console.WriteLine("");
                    Console.WriteLine("Ingrese ");
                    Console.WriteLine("¿Que desea hacer?");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 7:
                    
                    break;
                case 8:
                    Console.WriteLine("Muchas gracias por utilizar el banco.");
                    Console.WriteLine("Presione cualquier tecla.");
                    Console.ReadKey();
                    break;
            }
            Console.WriteLine("Ingrese Correctamente la opcion del menu");
            Console.WriteLine("Presione cualquier tecla");
            Console.ReadKey();
            Console.Clear();



        } while (opcion != 8);



    }




}


