class BANCO
{
    public static void Main(string[] args)
    {

        double Saldodecuenta = 5000;// Aqui vamos a definir todo las variables que vamos a utilizar para decimales o se que este parametro son para "double" 
        int opcion;
        string Usuario = "UsuarioPrueba";
        int Contraseña = 3885;
        bool intentoCorrecto = true;
        String bancos;
        do
        {
            Console.Write("Ingrese su nombre de usuario: ");
            string usuarioR = Console.ReadLine();

            Console.Write("Ingrese su contraseña: ");
            int contraseñaR = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            if (usuarioR == Usuario && contraseñaR == Contraseña)
            {
                Console.WriteLine("Bienvenido, " + Usuario);
                Console.WriteLine("******************************");
                Console.WriteLine("* ¿En que le podemos ayudar? *");
                Console.WriteLine("******************************");
                Console.WriteLine("1.Depósitos a mí cuenta\r\n2.Realizar transacciones\r\n3.Retiro de cuenta\r\n4.Mantener cajas de seguridad\r\n5.Dar asesoramiento financiero\r\n6.Consulta de cuenta\r\n7.Transferencia con comision\r\n8.Salir" + "");
                opcion = Convert.ToInt32(Console.ReadLine());

                while (opcion != 8)
                {


                    if (opcion < 8)
                    {

                        switch (opcion)
                        {

                            case 1:
                                Console.WriteLine("Ingrese el monto a ingresar:");
                                int Montoaingresar = Convert.ToInt32(Console.ReadLine());
                                Saldodecuenta = Saldodecuenta + Montoaingresar;
                                Console.WriteLine("Su saldo actual es de ${0} ", Saldodecuenta);
                                Console.WriteLine("Seleccione otra opcion para continuar");
                                opcion = Convert.ToInt32(Console.ReadLine());
                                Console.Clear();
                                break;

                            case 2:
                                Console.WriteLine("Ingrese la cuenta a transferir");
                                double cuenta = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("Ingrese el monto a transferir");
                                double monto = Convert.ToDouble(Console.ReadLine());
                                Saldodecuenta = (Saldodecuenta - monto);
                                Console.WriteLine("La transacción fue exitosa");
                                Console.WriteLine("********************************");
                                Console.WriteLine("El monto a transferir: ${0} ", monto);
                                Console.WriteLine("********************************");
                                Console.WriteLine("Cuenta de transferencia: {0} ", cuenta);
                                Console.WriteLine("********************************");
                                Console.WriteLine("Su saldo es de : ${0}", Saldodecuenta);
                                Console.WriteLine("Seleccione otra opcion para continuar");
                                opcion = Convert.ToInt32(Console.ReadLine());
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
                                    Console.WriteLine("**************************************");
                                    Console.WriteLine("El monto a retirar es de ${0}", monto);
                                    Console.WriteLine("**************************************");
                                    Console.WriteLine("Su saldo actual es ${0}", Saldodecuenta);
                                    Console.WriteLine("**************************************");
                                    Console.WriteLine("Seleccione otra opcion para continuar");
                                    opcion = Convert.ToInt32(Console.ReadLine());
                                    Console.Clear();
                                }
                                break;

                            case 4:
                                Console.WriteLine("");
                                Console.WriteLine("Ingrese ");
                                Console.WriteLine("¿Que desea hacer?");
                                opcion = Convert.ToInt32(Console.ReadLine());
                                Console.Clear();
                                break;
                            case 5:
                                Console.WriteLine("");
                                Console.WriteLine("Ingrese ");
                                Console.WriteLine("¿Que desea hacer?");
                                opcion = Convert.ToInt32(Console.ReadLine());
                                Console.Clear();
                                break;
                            case 6:
                                Console.WriteLine("");
                                Console.WriteLine("Ingrese ");
                                Console.WriteLine("¿Que desea hacer?");
                                opcion = Convert.ToInt32(Console.ReadLine());
                                Console.Clear();
                                break;
                            case 7:
                                
                                break;
                            case 8:

                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ingrese la opción correcta");
                        return;
                    }


                }
            }
            else
            {
                Console.WriteLine("Usuario o contraseña incorrectos. Intente nuevamente.");
            }
            Console.WriteLine("***********");
            Console.WriteLine("*Feliz día*");
            Console.WriteLine("***********");
        } while (intentoCorrecto);



    }




}


