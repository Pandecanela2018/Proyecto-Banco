﻿class BANCOoficiala1
{
    public static void Main(string[] args)

    {
        static string ContraseñaOculta()//A
        {
            string contraseñaguar = "";
            ConsoleKeyInfo key;

            do//A.1
            {
                key = Console.ReadKey(true);

                // Solo agrega caracteres a la contraseña si no es una tecla de control
                if (key.Key != ConsoleKey.Backspace && key.Key != ConsoleKey.Enter)
                {
                    contraseñaguar += key.KeyChar;
                    Console.Write("*");
                }
                else if (key.Key == ConsoleKey.Backspace && contraseñaguar.Length > 0)
                {
                    contraseñaguar = contraseñaguar.Remove(contraseñaguar.Length - 1);
                    Console.Write("\b \b");
                }
            } while (key.Key != ConsoleKey.Enter);//A.1

            Console.WriteLine();
            return contraseñaguar;
        }//A
        double Saldodecuenta = 5500, monto, cuenta, Saldotarjetacredito = 565, Gastodetarjeta, TarjetaRestante, Intereses1 = 0, Intereses2 = 0.03, Intereses3 = 0.09, Intereses4 = 0.27, Saldocancelar, monedaC, remesaR, Pago;
        string Usuario = "UsuarioPrueba", ResCorrecU, ResCorrecC, Contraseña = "3885";
        int Ntarjeta = 78631320, ResCorrecT, ResCorrecCVV, CVV = 555, opcion, diasdemora, bancos, moneda;
        do  // B = funcion Principal
        {
            Console.WriteLine(" --------------------------------------------");
            Console.WriteLine("       Ingrese su nombre de usuario: ");
            Console.WriteLine(" --------------------------------------------");
            ResCorrecU = Console.ReadLine();
            Console.WriteLine(" --------------------------------------------");
            Console.WriteLine("           Ingrese su contraseña: ");
            Console.WriteLine(" --------------------------------------------");
            ResCorrecC = ContraseñaOculta();

            if (ResCorrecC != Contraseña || ResCorrecU != Usuario) //B.1
            {
                Console.Clear();
                Console.WriteLine(" --------------------------------------------");
                Console.WriteLine("    Usuario o Contraseña es incorrecto.      ");
                Console.WriteLine("  Ingrese nuevamente su usuario y contraseña ");
                Console.WriteLine(" --------------------------------------------");
            }//B.1

        } while (ResCorrecU != Usuario && ResCorrecC != Contraseña || ResCorrecC == Contraseña && ResCorrecU != Usuario || ResCorrecC != Contraseña && ResCorrecU == Usuario);// B
        Console.Clear();

        do //C = funcion principal
        {
            Console.WriteLine("Bienvenido, " + Usuario);
            Console.WriteLine(" --------------------------------------------");
            Console.WriteLine("         ¿En que le podemos ayudar?          ");
            Console.WriteLine(" --------------------------------------------");
            Console.WriteLine("1.Enviar Remesa.\r\n2.Pago de tarjeta.\r\n3.Transferencia de banco a banco. \r\n4.Consulta de saldo. \r\n5.Deposito a la cuenta.\r\n\r\n0.Salir" + "");
            opcion = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            switch (opcion) //C.1
            {
                case 1:
                    Console.WriteLine("");
                    Console.WriteLine(" ---------------------------------------------------------------------------");
                    Console.WriteLine("      Seleccione la moneda extranjera con la que desea enviar la remesa:    ");
                    Console.WriteLine(" ---------------------------------------------------------------------------");
                    Console.WriteLine("1.Colón salvadoreño\r\n2.Lempira\r\n3.Euro\r\n4.Libra Esterlina\r\n5.Quetzales\r\n6.Yen Japones\r\n7.Dólar Australiano\r\n8.Dólar Canadiense");
                    moneda = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    switch (moneda)
                    {
                        case 1:

                            do
                            {
                                Console.WriteLine("Su saldo actual es de $" + Saldodecuenta);
                                Console.WriteLine("Ingrese el número de la cuenta a la cúal desea enviar la remesa:");
                                remesaR = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("");
                                Console.WriteLine("Ingrese el número de dólares que desea enviar en cólones salvadoreños:");
                                moneda = Convert.ToInt32(Console.ReadLine());

                                if (Saldodecuenta < moneda)
                                {
                                    Console.WriteLine("");
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
                                    Console.WriteLine("-------------------------------------------------------------");
                                    Console.WriteLine("Su cantidad de cólones salvadoreños enviados es de:" + " " + "SVC" + " " + monedaC);
                                    Console.WriteLine("                                                           ");
                                    Console.WriteLine("Remesa enviada a la cuenta:" + " " + remesaR + "                           ");
                                    Console.WriteLine("-------------------------------------------------------------");
                                    Console.WriteLine("");
                                    Console.WriteLine("Presione cualquier tecla para continuar");
                                    Console.ReadKey();
                                    Console.Clear();
                                }
                            } while (moneda > Saldodecuenta);

                            break;
                        case 2:

                            do
                            {
                                Console.WriteLine("Su saldo actual es de $" + Saldodecuenta);
                                Console.WriteLine("Ingrese el número de la cuenta a la cúal desea enviar la remesa:");
                                remesaR = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("");
                                Console.WriteLine("Ingrese el número de dólares que desea enviar en lempiras:");
                                moneda = Convert.ToInt32(Console.ReadLine());

                                if (Saldodecuenta < moneda)
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("Saldo insuficiene para enviar esta remesa");
                                    Console.WriteLine("");
                                    Console.WriteLine("Presione cualquier tecla para continuar");
                                    Console.ReadKey();
                                    Console.Clear();
                                }
                                else
                                {
                                    Saldodecuenta = Saldodecuenta - moneda;
                                    monedaC = moneda * (24.63);

                                    Console.WriteLine("");
                                    Console.WriteLine("-------------------------------------------------------------");
                                    Console.WriteLine("Su cantidad de lempiras enviados es de:" + " " + "L" + " " + monedaC + "          ");
                                    Console.WriteLine("                                                            ");
                                    Console.WriteLine("Remesa enviada a la cuenta:" + " " + remesaR + "                            ");
                                    Console.WriteLine("-------------------------------------------------------------");
                                    Console.WriteLine("");
                                    Console.WriteLine("Presione cualquier tecla para continuar");
                                    Console.ReadKey();
                                    Console.Clear();
                                }
                            } while (moneda > Saldodecuenta);
                            break;
                        case 3:

                            do
                            {
                                Console.WriteLine("Su saldo actual es de $" + Saldodecuenta);
                                Console.WriteLine("Ingrese el número de la cuenta a la cúal desea enviar la remesa:");
                                remesaR = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("");
                                Console.WriteLine("Ingrese el número de dólares que desea enviar en euros:");
                                moneda = Convert.ToInt32(Console.ReadLine());

                                if (Saldodecuenta < moneda)
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("Saldo insuficiene para enviar esta remesa");
                                    Console.WriteLine("");
                                    Console.WriteLine("Presione cualquier tecla para continuar");
                                    Console.ReadKey();
                                    Console.Clear();
                                }
                                else
                                {
                                    Saldodecuenta = Saldodecuenta - moneda;
                                    monedaC = moneda * (0.94);

                                    Console.WriteLine("");
                                    Console.WriteLine("-------------------------------------------------------------");
                                    Console.WriteLine("Su cantidad de euros enviados es de:" + " " + "EUR" + " " + monedaC + "          ");
                                    Console.WriteLine("                                                            ");
                                    Console.WriteLine("Remesa enviada a la cuenta:" + " " + remesaR + "                            ");
                                    Console.WriteLine("-------------------------------------------------------------");
                                    Console.WriteLine("");
                                    Console.WriteLine("Presione cualquier tecla para continuar");
                                    Console.ReadKey();
                                    Console.Clear();
                                }

                            } while (moneda > Saldodecuenta);

                            break;
                        case 4:

                            do
                            {
                                Console.WriteLine("Su saldo actual es de $" + Saldodecuenta);
                                Console.WriteLine("Ingrese el número de la cuenta a la cúal desea enviar la remesa:");
                                remesaR = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("");
                                Console.WriteLine("Ingrese el número de dólares que desea enviar en libras esterlinas:");
                                moneda = Convert.ToInt32(Console.ReadLine());

                                if (Saldodecuenta < moneda)
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("Saldo insuficiene para realizar esta remesa");
                                    Console.WriteLine("");
                                    Console.WriteLine("Presione cualquier tecla para continuar");
                                    Console.ReadKey();
                                    Console.Clear();
                                }
                                else
                                {
                                    Saldodecuenta = Saldodecuenta - moneda;
                                    monedaC = moneda * (0.81);

                                    Console.WriteLine("");
                                    Console.WriteLine("-------------------------------------------------------------");
                                    Console.WriteLine("Su cantidad de libras esterlinas enviados es de:" + " " + "£" + " " + monedaC + "          ");
                                    Console.WriteLine("                                                            ");
                                    Console.WriteLine("Remesa enviada a la cuenta:" + " " + remesaR + "                            ");
                                    Console.WriteLine("-------------------------------------------------------------");
                                    Console.WriteLine("");
                                    Console.WriteLine("Presione cualquier tecla para continuar");
                                    Console.ReadKey();
                                    Console.Clear();
                                }

                            } while (moneda > Saldodecuenta);

                            break;
                        case 5:
                            do
                            {
                                Console.WriteLine("Su saldo actual es de $" + Saldodecuenta);
                                Console.WriteLine("Ingrese el número de la cuenta a la cúal desea enviar la remesa:");
                                remesaR = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("");
                                Console.WriteLine("Ingrese el número de dólares que desea enviar en quetzales:");
                                moneda = Convert.ToInt32(Console.ReadLine());

                                if (Saldodecuenta < moneda)
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("Saldo insuficiene para realizar esta remesa");
                                    Console.WriteLine("");
                                    Console.WriteLine("Presione cualquier tecla para continuar");
                                    Console.ReadKey();
                                    Console.Clear();
                                }
                                else
                                {
                                    Saldodecuenta = Saldodecuenta - moneda;
                                    monedaC = moneda * (7.76);

                                    Console.WriteLine("");
                                    Console.WriteLine("-------------------------------------------------------------");
                                    Console.WriteLine("Su cantidad de quetzales enviados es de:" + " " + "Q" + " " + monedaC + "          ");
                                    Console.WriteLine("                                                            ");
                                    Console.WriteLine("Remesa enviada a la cuenta:" + " " + remesaR + "                            ");
                                    Console.WriteLine("-------------------------------------------------------------");
                                    Console.WriteLine("");
                                    Console.WriteLine("Presione cualquier tecla para continuar");
                                    Console.ReadKey();
                                    Console.Clear();
                                }
                            } while (moneda > Saldodecuenta);

                            break;
                        case 6:
                            do
                            {
                                Console.WriteLine("Su saldo actual es de $" + Saldodecuenta);
                                Console.WriteLine("Ingrese el número de la cuenta a la cúal desea enviar la remesa:");
                                remesaR = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("");
                                Console.WriteLine("Ingrese el número de dólares que desea enviar en yenes japoneses:");
                                moneda = Convert.ToInt32(Console.ReadLine());

                                if (Saldodecuenta < moneda)
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("Saldo insuficiene para realizar esta remesa");
                                    Console.WriteLine("");
                                    Console.WriteLine("Presione cualquier tecla para continuar");
                                    Console.ReadKey();
                                    Console.Clear();
                                }
                                else
                                {
                                    Saldodecuenta = Saldodecuenta - moneda;
                                    monedaC = moneda * (154.62);

                                    Console.WriteLine("");
                                    Console.WriteLine("-------------------------------------------------------------");
                                    Console.WriteLine("Su cantidad de yenes japoneses enviados es de:" + " " + "¥" + " " + monedaC + "          ");
                                    Console.WriteLine("                                                            ");
                                    Console.WriteLine("Remesa enviada a la cuenta:" + " " + remesaR + "                            ");
                                    Console.WriteLine("-------------------------------------------------------------");
                                    Console.WriteLine("");
                                    Console.WriteLine("Presione cualquier tecla para continuar");
                                    Console.ReadKey();
                                    Console.Clear();
                                }
                            } while (moneda > Saldodecuenta);

                            break;
                        case 7:
                            do
                            {
                                Console.WriteLine("Su saldo actual es de $" + Saldodecuenta);
                                Console.WriteLine("Ingrese el número de la cuenta a la cúal desea enviar la remesa:");
                                remesaR = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("");
                                Console.WriteLine("Ingrese el número de dólares que desea enviar en dólares australianos:");
                                moneda = Convert.ToInt32(Console.ReadLine());

                                if (Saldodecuenta < moneda)
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("Saldo insuficiene para realizar esta remesa");
                                    Console.WriteLine("");
                                    Console.WriteLine("Presione cualquier tecla para continuar");
                                    Console.ReadKey();
                                    Console.Clear();
                                }
                                else
                                {
                                    Saldodecuenta = Saldodecuenta - moneda;
                                    monedaC = moneda * (1.56);

                                    Console.WriteLine("");
                                    Console.WriteLine("-------------------------------------------------------------");
                                    Console.WriteLine("Su cantidad de dólares australianos enviados es de:" + " " + "AUD" + " " + monedaC + "          ");
                                    Console.WriteLine("                                                            ");
                                    Console.WriteLine("Remesa enviada a la cuenta:" + " " + remesaR + "                            ");
                                    Console.WriteLine("-------------------------------------------------------------");
                                    Console.WriteLine("");
                                    Console.WriteLine("Presione cualquier tecla para continuar");
                                    Console.ReadKey();
                                    Console.Clear();
                                }
                            } while (moneda > Saldodecuenta);

                            break;
                        case 8:

                            do
                            {
                                Console.WriteLine("Su saldo actual es de $" + Saldodecuenta);
                                Console.WriteLine("Ingrese el número de la cuenta a la cúal desea enviar la remesa:");
                                remesaR = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("");
                                Console.WriteLine("Ingrese el número de dólares que desea enviar en dólares canadienses:");
                                moneda = Convert.ToInt32(Console.ReadLine());

                                if (Saldodecuenta < moneda)
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("Saldo insuficiene para realizar esta remesa");
                                    Console.WriteLine("");
                                    Console.WriteLine("Presione cualquier tecla para continuar");
                                    Console.ReadKey();
                                    Console.Clear();
                                }
                                else
                                {
                                    Saldodecuenta = Saldodecuenta - moneda;
                                    monedaC = moneda * (1.38);

                                    Console.WriteLine("");
                                    Console.WriteLine("-------------------------------------------------------------");
                                    Console.WriteLine("Su cantidad de dólares canadienses enviados es de:" + " " + "CAD" + " " + monedaC + "          ");
                                    Console.WriteLine("                                                            ");
                                    Console.WriteLine("Remesa enviada a la cuenta:" + " " + remesaR + "                            ");
                                    Console.WriteLine("-------------------------------------------------------------");
                                    Console.WriteLine("");
                                    Console.WriteLine("Presione cualquier tecla para continuar");
                                    Console.ReadKey();
                                    Console.Clear();
                                }
                            } while (moneda > Saldodecuenta);

                            break;
                    }

                    break;
                case 2:
                    Console.WriteLine("");
                    Console.WriteLine("---------------------------------------");
                    Console.WriteLine("Ingrese el numero de la Tarjeta a pagar");
                    Console.WriteLine("---------------------------------------");
                    ResCorrecT = Convert.ToInt32(Console.ReadLine());

                    while (ResCorrecT != Ntarjeta)
                    {
                        Console.Clear();
                        Console.WriteLine("---------------------------------------");
                        Console.WriteLine("Numero de Tarjeta Equivocado");
                        Console.WriteLine("---------------------------------------");
                        Console.WriteLine("");
                        Console.WriteLine("Ingrese el numero de la Tarjeta a pagar");
                        ResCorrecT = Convert.ToInt32(Console.ReadLine());
                    }

                    if (ResCorrecT == Ntarjeta)
                    {
                        Console.Clear();
                        Console.WriteLine("--------------------------------------------------");
                        Console.WriteLine("Ingrese el numero CVV, ubicado atras de su tarjeta");
                        Console.WriteLine("--------------------------------------------------");
                        ResCorrecCVV = Convert.ToInt32(Console.ReadLine());

                        while (ResCorrecCVV != CVV)
                        {
                            Console.Clear();
                            Console.WriteLine("----------------------------------------------");
                            Console.WriteLine("Numero de CVV Equivocado");
                            Console.WriteLine("----------------------------------------------");
                            Console.WriteLine("");
                            Console.WriteLine("----------------------------------------------");
                            Console.WriteLine("Ingrese el numero CVV de la Tarjeta nuevamente");
                            ResCorrecCVV = Convert.ToInt32(Console.ReadLine());
                        }

                        if (ResCorrecCVV == CVV)
                        {
                            Console.Clear();
                            Console.WriteLine("--------------------------------------");
                            Console.WriteLine("Ingrese el monto gastado de la tarjeta");
                            Console.WriteLine("--------------------------------------");
                            Gastodetarjeta = Convert.ToDouble(Console.ReadLine());

                            while (Gastodetarjeta > Saldotarjetacredito)
                            {
                                Console.Clear();
                                Console.WriteLine("");
                                Console.WriteLine("-------------------------------------------------------");
                                Console.WriteLine("La cantidad ingresada sobrepasa el limite de la tarjeta");
                                Console.WriteLine("-------------------------------------------------------");
                                Console.WriteLine("");
                                Console.WriteLine("Ingrese nuevamente el monto gastado");
                                Console.WriteLine("-------------------------------------------------------");
                                Gastodetarjeta = Convert.ToDouble(Console.ReadLine());
                            }

                            TarjetaRestante = Saldotarjetacredito - Gastodetarjeta;

                            Console.Clear();
                            Console.WriteLine("-------------------------------------------------------");
                            Console.WriteLine("El saldo restante de credito de su tarjeta es de: $" + TarjetaRestante);
                            Console.WriteLine("-------------------------------------------------------");
                            Console.WriteLine("");
                            Console.WriteLine("Ingrese el numero de dias en mora"); //dias en mora desde que no paga la tarjeta
                            Console.WriteLine("-------------------------------------------------------");
                            diasdemora = Convert.ToInt32(Console.ReadLine());

                            if (diasdemora == 0)
                            {
                                Console.Clear();
                                Console.WriteLine("----------------------------------------------------------------------------");
                                Console.WriteLine("");
                                Console.WriteLine("Felicidades, ya que paga a tiempo su tarjeta, la tasa de intereses es del 0%");
                                Console.WriteLine("----------------------------------------------------------------------------");
                                Saldocancelar = (Intereses1 * Gastodetarjeta) + Gastodetarjeta;
                                Console.WriteLine("Por lo tanto su saldo total a cancelar es de: $" + Saldocancelar);
                                Console.WriteLine("----------------------------------------------------------------------------");
                                Pago = TarjetaRestante - Saldocancelar;
                                Console.WriteLine("El saldo restante de credito de su tarjeta es de: $" + Pago);
                                Console.WriteLine("----------------------------------------------------------------------------");
                                Console.ReadKey();
                                Console.Clear();
                            }
                            else
                            {
                                if (diasdemora > 0 && diasdemora <= 5)
                                {
                                    Console.Clear();
                                    Console.WriteLine("");
                                    Console.WriteLine("--------------------------------------------------------------");
                                    Console.WriteLine("Por los dias de mora obtenidos, la tasa de intereses es del 3%");
                                    Console.WriteLine("--------------------------------------------------------------");
                                    Saldocancelar = (Intereses2 * Gastodetarjeta) + Gastodetarjeta;
                                    Console.WriteLine("Por lo tanto su saldo total a cancelar es de: $" + Saldocancelar);
                                    Console.WriteLine("--------------------------------------------------------------");
                                    Console.WriteLine("Presione enter para pagar");
                                    Console.ReadKey();
                                    Pago = TarjetaRestante - Saldocancelar;
                                    Console.WriteLine("El saldo restante de credito de su tarjeta es de: $" + Pago);
                                    Console.WriteLine("----------------------------------------------------------------------------");
                                    Console.WriteLine("Presione Cualquier tecla para volver al menu");
                                    Console.ReadKey();
                                    Console.Clear();

                                }
                                else
                                {
                                    if (diasdemora > 5 && diasdemora <= 10)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("--------------------------------------------------------------");
                                        Console.WriteLine("");
                                        Console.WriteLine("Por los dias de mora obtenidos, la tasa de intereses es del 9%");
                                        Console.WriteLine("--------------------------------------------------------------");
                                        Saldocancelar = (Intereses3 * Gastodetarjeta) + Gastodetarjeta;
                                        Console.WriteLine("Por lo tanto su saldo total a cancelar es de: $" + Saldocancelar);
                                        Console.WriteLine("--------------------------------------------------------------");
                                        Console.WriteLine("Presione enter para pagar");
                                        Console.ReadKey();
                                        Console.WriteLine("----------------------------------------------------------------------------");
                                        Pago = TarjetaRestante - Saldocancelar;
                                        Console.WriteLine("El saldo restante de credito de su tarjeta es de: $" + Pago);
                                        Console.WriteLine("----------------------------------------------------------------------------");
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
                                            Console.WriteLine("---------------------------------------------------------------");
                                            Console.WriteLine("Por los dias de mora obtenidos, la tasa de intereses es del 27%");
                                            Console.WriteLine("---------------------------------------------------------------");
                                            Saldocancelar = (Intereses4 * Gastodetarjeta) + Gastodetarjeta;
                                            Console.WriteLine("Por lo tanto su saldo total a cancelar es de: $" + Saldocancelar);
                                            Console.WriteLine("---------------------------------------------------------------");
                                            Console.WriteLine("Presione enter para pagar");
                                            Console.ReadKey();
                                            Console.WriteLine("----------------------------------------------------------------------------");
                                            Pago = TarjetaRestante - Saldocancelar;
                                            Console.WriteLine("El saldo restante de credito de su tarjeta es de: $" + Pago);
                                            Console.WriteLine("----------------------------------------------------------------------------");
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
                case 3:
   Console.WriteLine("-------------------------------------------------");
   Console.WriteLine("      Eliga el Banco al cual desea tranferir     ");
   Console.WriteLine("-------------------------------------------------");
   Console.WriteLine("     ¿Qué banco desea hacer la transferencia?    ");
   Console.WriteLine("-------------------------------------------------");
   Console.WriteLine("     1.Davivienda 2.Cuscatlan 3.Hipotecario" + " ");
   Console.WriteLine("-------------------------------------------------");
   bancos = Convert.ToInt32(Console.ReadLine());
   Console.Clear();
   switch (bancos)
   {
       case 1:
           double costo;
           do
           {
               Console.WriteLine("-------------------------------------------------");
               Console.WriteLine("            Gracias Por elegir a Davivienda      ");
               Console.WriteLine("-------------------------------------------------");
               Console.WriteLine("       Ingrese la cantidad que desea trasferir   ");
               Console.WriteLine("-------------------------------------------------");
               costo = Convert.ToDouble(Console.ReadLine());

               if (Saldodecuenta < costo)
               {
                   Console.WriteLine("----------------------------------------------------");
                   Console.WriteLine(" Saldo insuficiene para realizar esta transferencia ");
                   Console.WriteLine("----------------------------------------------------");
                   Console.WriteLine("Presione cualquier tecla para reintenar");

                   Console.ReadKey();
                   Console.Clear();
               }
               else
               {
                   double costo_descueto = costo - (costo * 0.04);
                   Saldodecuenta = (Saldodecuenta - costo_descueto);
                   Console.WriteLine("----------------------------------------------------");
                   Console.WriteLine("             La transacción fue exitosa             ");
                   Console.WriteLine("----------------------------------------------------");
                   Console.WriteLine("     El monto a transferir a davivienda es de: ${0} ", costo_descueto);
                   Console.WriteLine("----------------------------------------------------");
                   Console.WriteLine("      EL saldo que quedo en este Banco es de: ${0}", Saldodecuenta);
                   Console.WriteLine("             Presione cualquier tecla               ");
                   Console.ReadKey();
                   Console.Clear();
               }
           } while (Saldodecuenta < costo);

           break;
       case 2:
           double costo2;
           do
           {
               Console.WriteLine("----------------------------------------------------");
               Console.WriteLine("            Gracias Por elegir a Cusclatan          ");
               Console.WriteLine("----------------------------------------------------");
               Console.WriteLine("        Ingrese la cantidad que desea trasferir     ");
               Console.WriteLine("----------------------------------------------------");
               costo2 = Convert.ToDouble(Console.ReadLine());

               if (Saldodecuenta < costo2)
               {
                   Console.WriteLine("----------------------------------------------------");
                   Console.WriteLine(" Saldo insuficiene para realizar esta transferencia ");
                   Console.WriteLine("----------------------------------------------------");
                   Console.WriteLine("Presione cualquier tecla para reintentar");
                   Console.ReadKey();
                   Console.Clear();
               }
               else
               {
                   double costo2_descueto = costo2 - (costo2 * 0.08);
                   Saldodecuenta = (Saldodecuenta - costo2_descueto);
                   Console.WriteLine("----------------------------------------------------");
                   Console.WriteLine("             La transacción fue exitosa             ");
                   Console.WriteLine("----------------------------------------------------");
                   Console.WriteLine("    El monto a transferir a Cuscatlan es de: ${0} ", costo2_descueto);
                   Console.WriteLine("----------------------------------------------------");
                   Console.WriteLine("    EL saldo que quedo en este Banco es de: ${0}", Saldodecuenta);
                   Console.ReadKey();
                   Console.Clear();

               }
           } while (Saldodecuenta < costo2);

           break;
       case 3:
           double costo3;
           do
           {
               Console.WriteLine("----------------------------------------------------");
               Console.WriteLine("            Gracias Por elegir a Hipotecario        ");
               Console.WriteLine("----------------------------------------------------");
               Console.WriteLine("         Ingrese la cantidad que desea trasferir    ");
               Console.WriteLine("----------------------------------------------------");
               costo3 = Convert.ToDouble(Console.ReadLine());


               if (Saldodecuenta < costo3)
               {
                   Console.WriteLine(" Saldo insuficiene para realizar esta transferencia ");
                   Console.WriteLine("----------------------------------------------------");
                   Console.WriteLine("vuelva a ingresar una cantidad");
                   Console.ReadKey();
                   Console.Clear();
               }


               else
               {
                   double costo3_descueto = costo3 - (costo3 * 0.08);
                   Saldodecuenta = (Saldodecuenta - costo3_descueto);
                   Console.WriteLine("----------------------------------------------------");
                   Console.WriteLine("                La transacción fue exitosa          ");
                   Console.WriteLine("----------------------------------------------------");
                   Console.WriteLine("   El monto a transferir a Hipotecario es de: ${0} ", costo3_descueto);
                   Console.WriteLine("----------------------------------------------------");
                   Console.WriteLine("    EL saldo que quedo en este Banco es de: ${0}", Saldodecuenta);
                   Console.ReadKey();
                   Console.Clear();
               }
           } while (Saldodecuenta < costo3);


           break;
   }
                    break;

                case 4:
                    Console.WriteLine("----------------------------------------------------");
                    Console.WriteLine("                Su saldo actual es de:              ");
                    Console.WriteLine("----------------------------------------------------");
                    Console.WriteLine("$" + " " + Saldodecuenta);
                    Console.WriteLine("----------------------------------------------------");
                    Console.WriteLine("");
                    Console.WriteLine("Presione cualquier tecla para continuar");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 5:
                    Console.WriteLine(" --------------------------------------------");
                    Console.WriteLine("           Ingrese el monto a ingresar:      ");
                    Console.WriteLine(" --------------------------------------------");
                    int Montoaingresar = Convert.ToInt32(Console.ReadLine());
                    Saldodecuenta = Saldodecuenta + Montoaingresar;
                    Console.WriteLine(" --------------------------------------------");
                    Console.WriteLine("           Su saldo actual es de ${0}        ", Saldodecuenta);
                    Console.WriteLine(" --------------------------------------------");
                    Console.WriteLine("Presione cualquier tecla");
                    Console.ReadKey();
                    Console.Clear();
                    break;

                case 0:
                    Console.WriteLine("----------------------------------------------------");
                    Console.WriteLine("        Muchas gracias por utilizar el Banco.       ");
                    Console.WriteLine("----------------------------------------------------");
                    break;
            }//C.1


        } while (opcion != 0); //C
    }
}





