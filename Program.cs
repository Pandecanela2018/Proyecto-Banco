class BANCO
{
    public static void Main(string[] args)
    {
        double Saldodecuenta = 5500, monto, cuenta, Saldotarjetacredito = 350, Gastodetarjeta, TarjetaRestante,Intereses1 = 0, Intereses2 = 0.03, Intereses3 = 0.09, Intereses4 = 0.27, Saldocancelar, monedaC;// Aqui vamos a definir todo las variables que vamos a utilizar para decimales o se que este parametro son para "double" 
        string Usuario = "UsuarioPrueba", bancos, ResCorrecU;
        int Contraseña = 3885, ResCorrecC, Ntarjeta = 78631320, ResCorrecT, ResCorrecCVV, CVV = 555,opcion, diasdemora, moneda;
        do  // A = funcion Principal
        {

            Console.Write("Ingrese su nombre de usuario: ");
            ResCorrecU = Console.ReadLine();
            
            Console.Write("Ingrese su contraseña: ");
            ResCorrecC = Convert.ToInt32(Console.ReadLine());

            if (ResCorrecC != Contraseña || ResCorrecU != Usuario) //A.1
            {
                Console.Clear();
                Console.WriteLine(" --------------------------------------------");
                Console.WriteLine("|   Usuario o Contraseña es incorrecto.      |");
                Console.WriteLine("| Ingrese nuevamente su usuario y contraseña |");
                Console.WriteLine(" --------------------------------------------");
            }//A.1

        } while (ResCorrecU != Usuario && ResCorrecC != Contraseña || ResCorrecC == Contraseña && ResCorrecU != Usuario || ResCorrecC != Contraseña && ResCorrecU == Usuario);// A
        Console.Clear();

        do //B = funcion principal
        {
            Console.WriteLine("Bienvenido, " + Usuario);
            Console.WriteLine("--------------------------------");
            Console.WriteLine("| ¿En que le podemos ayudar?   |");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("1.Depósitos a mí cuenta\r\n2.Realizar transacciones\r\n3.Retiro de cuenta\r\n4.Envío de remesas al extranjero\r\n5.Prestamos\r\n6.Transferencia a otros bancos\r\n7.Consultar saldo actual\r\n0.Salir" + "");
            opcion = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            switch (opcion) //B.1
            {
                //jeje
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
                            Console.WriteLine("Presione cualquier tecla para continuar");
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
                        Console.WriteLine("Presione cualquier tecla para continuar");
                        Console.ReadKey();
                        Console.Clear();

                    }
                    break;
                case 4:
                    Console.WriteLine("");
Console.WriteLine("Seleccione la moneda extranjera con la que desea enviar la remesa:");
Console.WriteLine("1.Colón salvadoreño\r\n2.Lempira\r\n3.Euro\r\n4.Libra Esterlina\r\n5.Quetzales\r\n6.Yen Japones\r\n7.Dólar Australiano\r\n8.Dólar Canadiense");
moneda = Convert.ToInt32(Console.ReadLine());
Console.Clear();

switch (moneda)
{
    case 1:
        Console.WriteLine("");
        Console.WriteLine("Ingrese el número de dólares que desea enviar en cólones salvadoreños:");
        moneda = Convert.ToInt32(Console.ReadLine());
       
        if (Saldodecuenta < moneda)
        {
            Console.WriteLine("Saldo insuficiene para enviar esta remesa");
            Console.WriteLine("");
            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadKey();
            Console.Clear();
        }
        else
        {
            Saldodecuenta = Saldodecuenta - moneda;
            monedaC = moneda * (8.73);

            Console.WriteLine("");
            Console.WriteLine("Su cantidad de cólones salvadoreños enviados es de:" + " " + monedaC);
            Console.WriteLine("");
            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadKey();
            Console.Clear();
        }
                                   
        break;
    case 2:
        Console.WriteLine("");
        Console.WriteLine("Ingrese el número de dólares que desea enviar en lempiras:");
        moneda = Convert.ToInt32(Console.ReadLine());

        if (Saldodecuenta < moneda)
        {
            Console.WriteLine("Saldo insuficiene para enviar esta remesa");
            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadKey();
            Console.Clear();
        }
        else
        {
            Saldodecuenta = Saldodecuenta - moneda;
            monedaC = moneda * (24.63);

            Console.WriteLine("");
            Console.WriteLine("Su cantidad de lempiras enviados es de" + " " + monedaC);
            Console.WriteLine("");
            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadKey();
            Console.Clear();
        }
        break;
    case 3:
        Console.WriteLine("");
        Console.WriteLine("Ingrese el número de dólares que desea enviar en euros:");
        moneda = Convert.ToInt32(Console.ReadLine());

        if (Saldodecuenta < moneda)
        {
            Console.WriteLine("Saldo insuficiene para enviar esta remesa");
            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadKey();
            Console.Clear();
        }
        else
        {
            Saldodecuenta = Saldodecuenta - moneda;
            monedaC = moneda * (0.94);

            Console.WriteLine("");
            Console.WriteLine("Su cantidad de euros enviados es de" + " " + monedaC);
            Console.WriteLine("");
            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadKey();
            Console.Clear();
        }
        break;
    case 4:
        Console.WriteLine("");
        Console.WriteLine("Ingrese el número de dólares que desea enviar en libras esterlinas:");
        moneda = Convert.ToInt32(Console.ReadLine());

        if (Saldodecuenta < moneda)
        {
            Console.WriteLine("Saldo insuficiene para realizar esta remesa");
            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadKey();
            Console.Clear();
        }
        else
        {
            Saldodecuenta = Saldodecuenta - moneda;
            monedaC = moneda * (0.81);

            Console.WriteLine("");
            Console.WriteLine("Su cantidad de libras esterlinas enviadas es de" + " " + monedaC);
            Console.WriteLine("");
            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadKey();
            Console.Clear();
        }
        break;
    case 5:
        Console.WriteLine("");
        Console.WriteLine("Ingrese el número de dólares que desea enviar en quetzales:");
        moneda = Convert.ToInt32(Console.ReadLine());

        if (Saldodecuenta < moneda)
        {
            Console.WriteLine("Saldo insuficiene para realizar esta remesa");
            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadKey();
            Console.Clear();
        }
        else
        {
            Saldodecuenta = Saldodecuenta - moneda;
            monedaC = moneda * (7.76);

            Console.WriteLine("");
            Console.WriteLine("Su cantidad de quetzales enviados es de" + " " + monedaC);
            Console.WriteLine("");
            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadKey();
            Console.Clear();
        }
        break;
    case 6:
        Console.WriteLine("");
        Console.WriteLine("Ingrese el número de dólares que desea enviar en yenes japoneses:");
        moneda = Convert.ToInt32(Console.ReadLine());

        if (Saldodecuenta < moneda)
        {
            Console.WriteLine("Saldo insuficiene para realizar esta remesa");
            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadKey();
            Console.Clear();
        }
        else
        {
            Saldodecuenta = Saldodecuenta - moneda;
            monedaC = moneda * (154.62);

            Console.WriteLine("");
            Console.WriteLine("Su cantidad de yenes japoneses enviados es de" + " " + monedaC);
            Console.WriteLine("");
            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadKey();
            Console.Clear();
        }
        break;
    case 7:
        Console.WriteLine("");
        Console.WriteLine("Ingrese el número de dólares que desea enviar en dólares australianos:");
        moneda = Convert.ToInt32(Console.ReadLine());

        if (Saldodecuenta < moneda)
        {
            Console.WriteLine("Saldo insuficiene para realizar esta remesa");
            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadKey();
            Console.Clear();
        }
        else
        {
            Saldodecuenta = Saldodecuenta - moneda;
            monedaC = moneda * (1.56);

            Console.WriteLine("");
            Console.WriteLine("Su cantidad de dólares australianos enviados es de" + " " + monedaC);
            Console.WriteLine("");
            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadKey();
            Console.Clear();
        }
        break;
    case 8:
        Console.WriteLine("");
        Console.WriteLine("Ingrese el número de dólares que desea enviar en dólares canadienses:");
        moneda = Convert.ToInt32(Console.ReadLine());

        if (Saldodecuenta < moneda)
        {
            Console.WriteLine("Saldo insuficiene para realizar esta remesa");
            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadKey();
            Console.Clear();
        }
        else
        {
            Saldodecuenta = Saldodecuenta - moneda;
            monedaC = moneda * (1.38);

            Console.WriteLine("");
            Console.WriteLine("Su cantidad de dólares canadienses enviados es de" + " " + monedaC);
            Console.WriteLine("");
            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadKey();
            Console.Clear();
        }
        break;
}
                    break;
                case 5:
                 Console.WriteLine("");
                 Console.WriteLine("Ingrese el numero de la Tarjeta a pagar");
                ResCorrecT = Convert.ToInt32(Console.ReadLine());

                if (ResCorrecT==Ntarjeta)
{
                Console.WriteLine("Ingrese el numero CVV, ubicado atras de su tarjeta");
                 ResCorrecCVV = Convert.ToInt32(Console.ReadLine());

                 if (ResCorrecCVV == CVV);
                 {
                    Console.WriteLine("Ingrese el monto gastado de la tarjeta (dentro del rango de $0 a $350)");
                    Gastodetarjeta = Convert.ToDouble(Console.ReadLine());

                    TarjetaRestante = Saldotarjetacredito - Gastodetarjeta;

                    Console.WriteLine("El saldo restante de credito de su tarjeta es de:" + TarjetaRestante);
                    Console.WriteLine("");
                    Console.WriteLine("Ingrese el numero de dias en mora"); //dias en mora desde que no paga la tarjeta
                    diasdemora = Convert.ToInt32(Console.ReadLine());

                        if (diasdemora == 0)
                        {
                            Console.WriteLine("Felicidades, ya que paga a tiempo su tarjeta, la tasa de intereses es del 0%");
                            Saldocancelar = (Intereses1 * Gastodetarjeta) + Gastodetarjeta;
                            Console.WriteLine("Por lo tanto su saldo total a cancelar es de: " + Saldocancelar);
                            Console.WriteLine("--------------------------------");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else
                        {
                            if (diasdemora > 0 && diasdemora <= 5)
                            {
                                Console.WriteLine("Por los dias de mora obtenidos, la tasa de intereses es del 3%");
                                Saldocancelar = (Intereses2 * Gastodetarjeta) + Gastodetarjeta;
                                Console.WriteLine("Por lo tanto su saldo total a cancelar es de: " + Saldocancelar);
                                Console.WriteLine("--------------------------------");
                                Console.WriteLine("Presione Cualquier tecla para volver al menu");
                                Console.ReadKey();
                                Console.Clear();

                            }
                            else
                            {
                                if (diasdemora > 5 && diasdemora <= 10)
                                {
                                    Console.WriteLine("Por los dias de mora obtenidos, la tasa de intereses es del 9%");
                                    Saldocancelar = (Intereses3 * Gastodetarjeta) + Gastodetarjeta;
                                    Console.WriteLine("Por lo tanto su saldo total a cancelar es de: " + Saldocancelar);
                                    Console.WriteLine("--------------------------------");
                                    Console.WriteLine("Presione Cualquier tecla para volver al menu");
                                    Console.ReadKey();
                                    Console.Clear();
                                }
                                else
                                {
                                    if (diasdemora > 10)
                                    {
                                        Console.WriteLine("Por los dias de mora obtenidos, la tasa de intereses es del 27%");
                                        Saldocancelar = (Intereses4 * Gastodetarjeta) + Gastodetarjeta;
                                        Console.WriteLine("Por lo tanto su saldo total a cancelar es de: " + Saldocancelar);
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
                else
                {
                    Console.WriteLine("Numero de Tarjeta Incorrecto");
                    Console.WriteLine("Presione Cualquier tecla para volver al menu");
                    Console.ReadKey();
                    Console.Clear(); 
    
                }break;
                case 6:
                    Console.WriteLine("Eliga el Banco al cual desea tranferir sus ahorro");
                    Console.WriteLine("¿Qué banco desea hacer la transferencia?");
                    Console.WriteLine("1.Davivienda 2.Cuscatlan 3.Hipotecario" + "");
                    bancos = Console.ReadLine();
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
                            Console.WriteLine("--------------------------------");
                            Console.WriteLine("El monto a transferir a davivienda es de: ${0} ", costo_descueto);
                            Console.WriteLine("--------------------------------");
                            Console.WriteLine("EL saldo que quedo en este Banco es de: ${0}", Saldodecuenta);
                            Console.WriteLine("Seleccione otra opcion para continuar");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case "cuscatlan":
                            Console.WriteLine("Gracias Por elegir a Cusclatan");
                            Console.WriteLine("Ingrese la cantidad que desea trasferir");
                            double costo2 = Convert.ToDouble(Console.ReadLine());
                            double costo2_descueto = costo2 - (costo2 * 0.08);
                            Saldodecuenta = (Saldodecuenta - costo2_descueto);
                            Console.WriteLine("La transacción fue exitosa");
                            Console.WriteLine("--------------------------------");
                            Console.WriteLine("El monto a transferir a Cuscatlan es de: ${0} ", costo2_descueto);
                            Console.WriteLine("--------------------------------");
                            Console.WriteLine("EL saldo que quedo en este Banco es de: ${0}", Saldodecuenta);
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case "hipotecario":
                            Console.WriteLine("Gracias Por elegir a Hipotecario");
                            Console.WriteLine("Ingrese la cantidad que desea trasferir");
                            double costo3 = Convert.ToDouble(Console.ReadLine());
                            double costo3_descueto = costo3 - (costo3 * 0.08);
                            Saldodecuenta = (Saldodecuenta - costo3_descueto);
                            Console.WriteLine("La transacción fue exitosa");
                            Console.WriteLine("--------------------------------");
                            Console.WriteLine("El monto a transferir a Hipotecario es de: ${0} ", costo3_descueto);
                            Console.WriteLine("--------------------------------");
                            Console.WriteLine("EL saldo que quedo en este Banco es de: ${0}", Saldodecuenta);
                            Console.ReadKey();
                            Console.Clear();
                        break;
                    }
                    break;
                case 7: 
                    Console.WriteLine("Su saldo actual es de:");
                    Console.WriteLine(Saldodecuenta + " " + "dólares");
                    Console.WriteLine("");
                    Console.WriteLine("Presione cualquier tecla para continuar");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 0:
                
                    Console.WriteLine("Muchas gracias por utilizar el banco.");
                 break;
            }//B.1


        } while (opcion != 0); //B
 }   }





