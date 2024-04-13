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
                                Console.WriteLine("Eliga el Banco al cual desea tranferir sus ahorro");
                                Console.WriteLine("¿Qué banco desea hacer la transferencia?");
                                Console.WriteLine("1.Davivienda 2.Cuscatlan 3.Hipotecario" + "");
                                bancos = Convert.ToString(Console.ReadLine());
                                Console.Clear();
                                switch (bancos.ToLower())
                                {
                                    case "davivienda":
                                        Console.WriteLine("Gracias Por elegir a Davivienda");
                                        Console.WriteLine("Ingrese la cantidad que desea trasferir");
                                        double costo = Convert.ToDouble(Console.ReadLine());
                                        double costo_descueto = costo - (costo * 0.04);
                                        Saldodecuenta = (Saldodecuenta - costo_descueto);
                                        Console.WriteLine("La transacción fue exitosa");
                                        Console.WriteLine("********************************");
                                        Console.WriteLine("El monto a transferir a davivienda es de: ${0} ", costo_descueto);
                                        Console.WriteLine("********************************");
                                        Console.WriteLine("EL saldo que quedo en este Banco es de: ${0}", Saldodecuenta);
                                        Console.WriteLine("Seleccione otra opcion para continuar");
                                        opcion = Convert.ToInt32(Console.ReadLine());
                                        Console.Clear();
                                        break;
                                    case "cusclatan":
                                        Console.WriteLine("Gracias Por elegir a Cusclatan");
                                        Console.WriteLine("Ingrese la cantidad que desea trasferir");
                                        double costo2 = Convert.ToDouble(Console.ReadLine());
                                        double costo2_descueto = costo2 - (costo2 * 0.08);
                                        Saldodecuenta = (Saldodecuenta - costo2_descueto);
                                        Console.WriteLine("La transacción fue exitosa");
                                        Console.WriteLine("********************************");
                                        Console.WriteLine("El monto a transferir a Cuscatlan es de: ${0} ", costo2_descueto);
                                        Console.WriteLine("********************************");
                                        Console.WriteLine("EL saldo que quedo en este Banco es de: ${0}", Saldodecuenta);
                                        Console.WriteLine("Seleccione otra opcion para continuar");
                                        opcion = Convert.ToInt32(Console.ReadLine());
                                        Console.Clear();
                                        break;
                                    case "hipotecario":
                                        Console.WriteLine("Gracias Por elegir a Hipotecario");
                                        Console.WriteLine("Ingrese la cantidad que desea trasferir");
                                        double costo3 = Convert.ToDouble(Console.ReadLine());
                                        double costo3_descueto = costo3 - (costo3 * 0.08);
                                        Saldodecuenta = (Saldodecuenta - costo3_descueto);
                                        Console.WriteLine("La transacción fue exitosa");
                                        Console.WriteLine("********************************");
                                        Console.WriteLine("El monto a transferir a Hipotecario es de: ${0} ", costo3_descueto);
                                        Console.WriteLine("********************************");
                                        Console.WriteLine("EL saldo que quedo en este Banco es de: ${0}", Saldodecuenta);
                                        Console.WriteLine("Seleccione otra opcion para continuar");
                                        opcion = Convert.ToInt32(Console.ReadLine());
                                        Console.Clear();
                                        break;


                                }
                                Console.Clear();
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


