class BANCO
{
    public static void Main(string[] args)
    {
        double Saldodecuenta = 5500, monto, cuenta, Saldotarjetacredito = 350, Gastodetarjeta, TarjetaRestante,Intereses1 = 0, Intereses2 = 0.03, Intereses3 = 0.09, Intereses4 = 0.27, Saldocancelar, monedaC, remesaR;// Aqui vamos a definir todo las variables que vamos a utilizar para decimales o se que este parametro son para "double" 
        string Usuario = "UsuarioPrueba", bancos, ResCorrecU, ResCorrecC, Contraseña = "3885";
        int  Ntarjeta = 78631320, ResCorrecT, ResCorrecCVV, CVV = 555,opcion, diasdemora, moneda;
        do  // A = funcion Principal
        {
            Console.WriteLine(" --------------------------------------------");
            Console.WriteLine("       Ingrese su nombre de usuario: ");
            Console.WriteLine(" --------------------------------------------");
            ResCorrecU = Console.ReadLine();
            Console.WriteLine(" --------------------------------------------");
            Console.WriteLine("           Ingrese su contraseña: ");
            Console.WriteLine(" --------------------------------------------");
            ResCorrecC = Convert.ToString(Console.ReadLine());
            Console.WriteLine(" --------------------------------------------");

            if (ResCorrecC != Contraseña || ResCorrecU != Usuario) //A.1
            {
                Console.Clear();
                Console.WriteLine(" --------------------------------------------");
                Console.WriteLine("    Usuario o Contraseña es incorrecto.      ");
                Console.WriteLine("  Ingrese nuevamente su usuario y contraseña ");
                Console.WriteLine(" --------------------------------------------");
            }//A.1

        } while (ResCorrecU != Usuario && ResCorrecC != Contraseña || ResCorrecC == Contraseña && ResCorrecU != Usuario || ResCorrecC != Contraseña && ResCorrecU == Usuario);// A
        Console.Clear();

        do //B = funcion principal
        {
            Console.WriteLine("Bienvenido, " + Usuario);
            Console.WriteLine(" --------------------------------------------");
            Console.WriteLine("         ¿En que le podemos ayudar?          ");
            Console.WriteLine(" --------------------------------------------");
            Console.WriteLine("1.Depósitos a mí cuenta\r\n2.Realizar transacciones\r\n3.Retiro de cuenta\r\n4.Envío de remesas al extranjero\r\n5.Prestamos\r\n6.Transferencia a otros bancos\r\n7.Consultar saldo actual\r\n0.Salir" + "");
            opcion = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            switch (opcion) //B.1
            {
                //jejee2es
                case 1:
                    Console.WriteLine(" --------------------------------------------");
                    Console.WriteLine("Ingrese el monto a ingresar:");
                    Console.WriteLine(" --------------------------------------------");
                    int Montoaingresar = Convert.ToInt32(Console.ReadLine());
                    if (Montoaingresar > Saldodecuenta)
                    {
                        Console.WriteLine(" --------------------------------------------");
                        Console.WriteLine("               Saldo insuficiente            ");
                        Console.WriteLine(" --------------------------------------------");
                        Console.WriteLine("  Ingrese la cantidad de acuerdo a su saldo  ");
                        Console.WriteLine(" --------------------------------------------");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    Saldodecuenta = Saldodecuenta + Montoaingresar;
                    Console.WriteLine(" --------------------------------------------");
                    Console.WriteLine("           Su saldo actual es de ${0}        ", Saldodecuenta);
                    Console.WriteLine(" --------------------------------------------");
                    Console.WriteLine("Presione cualquier tecla");
                    Console.ReadKey();
                    Console.Clear();
                    break;

                case 2:
                    do
                    {
                        Console.WriteLine(" --------------------------------------------");
                        Console.WriteLine("        Ingrese la cuenta a transferir");
                        Console.WriteLine(" --------------------------------------------");
                        cuenta = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(" --------------------------------------------");
                        Console.WriteLine("        Ingrese el monto a transferir        ");
                        Console.WriteLine(" --------------------------------------------");
                        monto = Convert.ToDouble(Console.ReadLine());
                        if (monto > Saldodecuenta)
                        {
                            Console.WriteLine(" --------------------------------------------");
                            Console.WriteLine("    Ingrese un monto de acuerdo a su saldo   ");
                            Console.WriteLine(" --------------------------------------------");
                            Console.WriteLine("   Presione cualquier tecla para continuar   ");
                            Console.WriteLine(" --------------------------------------------");
                            Console.ReadKey();
                            Console.Clear();
                        }
                    } while (monto > Saldodecuenta);

                    Saldodecuenta = (Saldodecuenta - monto);
                    Console.WriteLine(" --------------------------------------------");
                    Console.WriteLine("          La transacción fue exitosa         ");
                    Console.WriteLine(" --------------------------------------------");
                    Console.WriteLine("        El monto a transferir: ${0}          ", monto);
                    Console.WriteLine(" --------------------------------------------");
                    Console.WriteLine("      Cuenta de transferencia: {0} ", cuenta  );
                    Console.WriteLine(" --------------------------------------------");
                    Console.WriteLine("           Su saldo es de : ${0}             ", Saldodecuenta);
                    Console.WriteLine(" --------------------------------------------");
                    Console.WriteLine("Presione cualquier tecla");
                    Console.ReadKey();
                    Console.Clear();

                    break;
                case 3:
                    Console.WriteLine(" --------------------------------------------");
                    Console.WriteLine("           Ingrese el monto a retirar        ");
                    Console.WriteLine(" --------------------------------------------");
                    monto = Convert.ToDouble(Console.ReadLine());
                    if (monto > Saldodecuenta)
                    {
                        Console.WriteLine(" ------------------------------------------------------------------------------------");
                        Console.WriteLine("Ingrese el monto a retirar correctamente, debe de ser menor o igual a su saldo  ${0} ", Saldodecuenta);
                        Console.WriteLine(" ------------------------------------------------------------------------------------");
                        Console.Clear();
                    }
                    else
                    {
                        Saldodecuenta = Saldodecuenta - monto;
                        Console.WriteLine(" --------------------------------------------");
                        Console.WriteLine("        El monto a retirar es de ${0}        ", monto);
                        Console.WriteLine(" --------------------------------------------");
                        Console.WriteLine("           Su saldo actual es ${0}           ", Saldodecuenta);
                        Console.WriteLine(" --------------------------------------------");
                        Console.WriteLine("    Presione cualquier tecla para continuar  ");
                        Console.ReadKey();
                        Console.Clear();

                    }
                    break;
                
                                    case 5:
                               Console.WriteLine("");
                    Console.WriteLine("Ingrese el numero de la Tarjeta a pagar");
                    ResCorrecT = Convert.ToInt32(Console.ReadLine());

                    while (ResCorrecT != Ntarjeta)
                    {
                        Console.Clear();
                        Console.WriteLine("Numero de Tarjeta Equivocado");
                        Console.WriteLine("");
                        Console.WriteLine("Ingrese el numero de la Tarjeta a pagar");
                        ResCorrecT = Convert.ToInt32(Console.ReadLine());
                    }

                    if (ResCorrecT == Ntarjeta)
                    {
                        Console.Clear();
                        Console.WriteLine("Ingrese el numero CVV, ubicado atras de su tarjeta");
                        ResCorrecCVV = Convert.ToInt32(Console.ReadLine());

                        while (ResCorrecCVV != CVV)
                        {
                            Console.Clear();
                            Console.WriteLine("Numero de CVV Equivocado");
                            Console.WriteLine("");
                            Console.WriteLine("Ingrese el numero CVV de la Tarjeta nuevamente");
                            ResCorrecCVV = Convert.ToInt32(Console.ReadLine());
                        }

                        if (ResCorrecCVV == CVV) 
                        {
                            Console.Clear();
                            Console.WriteLine("Ingrese el monto gastado de la tarjeta");
                            Gastodetarjeta = Convert.ToDouble(Console.ReadLine());

                            while (Gastodetarjeta>Saldotarjetacredito)
                            {
                                Console.Clear();
                                Console.WriteLine("");
                                Console.WriteLine("La cantidad ingresada sobrepasa el limite de la tarjeta");
                                Console.WriteLine("");
                                Console.WriteLine("Ingrese nuevamente el monto gastado");
                                Gastodetarjeta = Convert.ToDouble(Console.ReadLine());
                            }

                            TarjetaRestante = Saldotarjetacredito - Gastodetarjeta;

                            Console.Clear();
                            Console.WriteLine("El saldo restante de credito de su tarjeta es de: $" + TarjetaRestante);
                            Console.WriteLine("");
                            Console.WriteLine("Ingrese el numero de dias en mora"); //dias en mora desde que no paga la tarjeta
                            diasdemora = Convert.ToInt32(Console.ReadLine());

                            if (diasdemora == 0)
                            {
                                Console.Clear();
                                Console.WriteLine("");
                                Console.WriteLine("Felicidades, ya que paga a tiempo su tarjeta, la tasa de intereses es del 0%");
                                Saldocancelar = (Intereses1 * Gastodetarjeta) + Gastodetarjeta;
                                Console.WriteLine("Por lo tanto su saldo total a cancelar es de: $" + Saldocancelar);
                                Console.WriteLine("--------------------------------");
                                Console.ReadKey();
                                Console.Clear();
                            }
                            else
                            {
                                if (diasdemora > 0 && diasdemora <= 5)
                                {
                                    Console.Clear();
                                    Console.WriteLine("");
                                    Console.WriteLine("Por los dias de mora obtenidos, la tasa de intereses es del 3%");
                                    Saldocancelar = (Intereses2 * Gastodetarjeta) + Gastodetarjeta;
                                    Console.WriteLine("Por lo tanto su saldo total a cancelar es de: $" + Saldocancelar);
                                    Console.WriteLine("--------------------------------");
                                    Console.WriteLine("Presione Cualquier tecla para volver al menu");
                                    Console.ReadKey();
                                    Console.Clear();

                                }
                                else
                                {
                                    if (diasdemora > 5 && diasdemora <= 10)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("");
                                        Console.WriteLine("Por los dias de mora obtenidos, la tasa de intereses es del 9%");
                                        Saldocancelar = (Intereses3 * Gastodetarjeta) + Gastodetarjeta;
                                        Console.WriteLine("Por lo tanto su saldo total a cancelar es de: $" + Saldocancelar);
                                        Console.WriteLine("--------------------------------");
                                        Console.WriteLine("Presione Cualquier tecla para volver al menu");
                                        Console.ReadKey();
                                        Console.Clear();
                                    }
                                    else
                                    {
                                        if (diasdemora > 10)
                                        {
                                            Console.Clear();
                                            Console.WriteLine("");
                                            Console.WriteLine("Por los dias de mora obtenidos, la tasa de intereses es del 27%");
                                            Saldocancelar = (Intereses4 * Gastodetarjeta) + Gastodetarjeta;
                                            Console.WriteLine("Por lo tanto su saldo total a cancelar es de: $" + Saldocancelar);
                                            Console.WriteLine("--------------------------------");
                                            Console.WriteLine("Presione Cualquier tecla para volver al menu");
                                            Console.ReadKey();
                                            Console.Clear();
                                        }
                                    }
                                }
                            }
                        }
                    }
                    break;
                case 6:
                    Console.WriteLine("-------------------------------------------------");
                    Console.WriteLine("Eliga el Banco al cual desea tranferir sus ahorro");
                    Console.WriteLine("-------------------------------------------------");
                    Console.WriteLine("     ¿Qué banco desea hacer la transferencia?    ");
                    Console.WriteLine("-------------------------------------------------");
                    Console.WriteLine("     1.Davivienda 2.Cuscatlan 3.Hipotecario" + " ");
                    Console.WriteLine("-------------------------------------------------");
                    bancos = Console.ReadLine();
                    Console.Clear();
                    switch (bancos.ToLower())
                    {
                        case "davivienda":
                            Console.WriteLine("-------------------------------------------------");
                            Console.WriteLine("            Gracias Por elegir a Davivienda      ");
                            Console.WriteLine("-------------------------------------------------");
                            Console.WriteLine("       Ingrese la cantidad que desea trasferir   ");
                            Console.WriteLine("-------------------------------------------------");
                            double costo = Convert.ToDouble(Console.ReadLine());
                            double costo_descueto = costo - (costo * 0.04);
                            Saldodecuenta = (Saldodecuenta - costo_descueto);
                            if (Saldodecuenta < costo_descueto)
                            {
                                Console.WriteLine("----------------------------------------------------");
                                Console.WriteLine(" Saldo insuficiene para realizar esta transferencua ");
                                Console.WriteLine("----------------------------------------------------");
                                Console.WriteLine("Presione cualquier tecla para continuar");
                                Console.ReadKey();
                                Console.Clear();
                            }
                            else
                            {
                                Console.WriteLine("----------------------------------------------------");
                                Console.WriteLine("             La transacción fue exitosa             ");
                                Console.WriteLine("----------------------------------------------------");
                                Console.WriteLine("     El monto a transferir a davivienda es de: ${0} ", costo_descueto);
                                Console.WriteLine("----------------------------------------------------");
                                Console.WriteLine("      EL saldo que quedo en este Banco es de: ${0}", Saldodecuenta);
                                Console.WriteLine("             Presione cualquier tecla               " );
                                Console.ReadKey();
                                Console.Clear();
                            }
                            break;
                        case "cuscatlan":
                            Console.WriteLine("----------------------------------------------------");
                            Console.WriteLine("            Gracias Por elegir a Cusclatan          ");
                            Console.WriteLine("----------------------------------------------------");
                            Console.WriteLine("        Ingrese la cantidad que desea trasferir     ");
                            Console.WriteLine("----------------------------------------------------");
                            double costo2 = Convert.ToDouble(Console.ReadLine());
                            double costo2_descueto = costo2 - (costo2 * 0.08);
                            Saldodecuenta = (Saldodecuenta - costo2_descueto);
                            if (Saldodecuenta < costo2_descueto)
                            {
                                Console.WriteLine("----------------------------------------------------");
                                Console.WriteLine(" Saldo insuficiene para realizar esta transferencua ");
                                Console.WriteLine("----------------------------------------------------");
                                Console.WriteLine("Presione cualquier tecla para continuar");
                                Console.ReadKey();
                                Console.Clear();
                            }
                            else
                            {
                                Console.WriteLine("----------------------------------------------------");
                                Console.WriteLine("             La transacción fue exitosa             ");
                                Console.WriteLine("----------------------------------------------------");
                                Console.WriteLine("    El monto a transferir a Cuscatlan es de: ${0} ", costo2_descueto);
                                Console.WriteLine("----------------------------------------------------");
                                Console.WriteLine("    EL saldo que quedo en este Banco es de: ${0}", Saldodecuenta);
                                Console.ReadKey();
                                Console.Clear();

                            }
                            break;
                        case "hipotecario":
                            Console.WriteLine("----------------------------------------------------");
                            Console.WriteLine("            Gracias Por elegir a Hipotecario        ");
                            Console.WriteLine("----------------------------------------------------");
                            Console.WriteLine("         Ingrese la cantidad que desea trasferir    ");
                            Console.WriteLine("----------------------------------------------------");
                            double costo3 = Convert.ToDouble(Console.ReadLine());
                            double costo3_descueto = costo3 - (costo3 * 0.08);
                            Saldodecuenta = (Saldodecuenta - costo3_descueto);
                            if (Saldodecuenta < costo3_descueto)
                            {
                                Console.WriteLine(" Saldo insuficiene para realizar esta transferencua ");
                                Console.WriteLine("----------------------------------------------------");
                                Console.WriteLine("Presione cualquier tecla para continuar");
                                Console.ReadKey();
                                Console.Clear();
                            }
                            else
                            {
                                Console.WriteLine("----------------------------------------------------");
                                Console.WriteLine("                La transacción fue exitosa          ");
                                Console.WriteLine("----------------------------------------------------");
                                Console.WriteLine("   El monto a transferir a Hipotecario es de: ${0} ", costo3_descueto);
                                Console.WriteLine("----------------------------------------------------");
                                Console.WriteLine("    EL saldo que quedo en este Banco es de: ${0}", Saldodecuenta);
                                Console.ReadKey();
                                Console.Clear();

                            }

                            break;
                    }
                    break;

                case 7: 
                    Console.WriteLine("Su saldo actual es de:");
                    Console.WriteLine("");
                    Console.WriteLine("--------------------");
                    Console.WriteLine("| $" + Saldodecuenta + " " + "dólares    |");
                    Console.WriteLine("--------------------");
                    Console.WriteLine("");
                    Console.WriteLine("Presione cualquier tecla para continuar");
                    Console.ReadKey();
                    Console.Clear();

                    break;
                case 0:
                    Console.WriteLine("----------------------------------------------------");
                    Console.WriteLine("        Muchas gracias por utilizar el Banco.       ");
                    Console.WriteLine("----------------------------------------------------");
                    break;
            }//B.1


        } while (opcion != 0); //B
 }   }





