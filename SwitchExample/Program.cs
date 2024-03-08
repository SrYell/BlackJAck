// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information
using System.Drawing;
System.Random random = new System.Random();

Console.WriteLine("Hello, World!");
int totalJugador = 0;
int totalDealer = 0;
int num = 0;
int platziCoins = 1000;
int platziCoinsApostadas;
string controlOtraCarta = "";
string message = "";
string switchControl = "menu";
string SiONo;
string Devolver ="";
//Blackjack, Juntar 21 pidiendo, en casa de pasarte de 21 pierdes.
//cartas o en caso de tener menos
//de 21 igual tener mayor puntuación que el dealer

while (true)
{
    Console.Clear();
    Console.WriteLine("Welcome al P L A T Z I N O\n" + "Estas son las reglas:" + "Cada ronda apostarás platziCoins, las monedas del casino\n" + "Puedes apostar un mínimo de 100 platziCoins, y como máximo el valor total que posees \n" + "Si ganas, duplicaras el valor de lo apostado, si pierdes, se te restará el doble de lo que arriesgaste,\n ¿estás listo para empezar?\nY/N");
    SiONo = Console.ReadLine();
    switch (SiONo)
    {
        case "Y" or "y" or "si" or "SI":
            break;
        case "N" or "n" or "no" or "NO":
            Console.WriteLine("Al entrar al casino estás obligado a jugar, lo lamento mucho");
            break;

    }

    Console.WriteLine("¿Cuántos PlatziCoins deseas apostar?\n" +
        $"Ingresa un número entero, valor total: {platziCoins}\n" +
        "Recuerda que si llegas a 0 pierdes.");
    platziCoinsApostadas = Convert.ToInt32(Console.ReadLine());


while (platziCoins > 0)
    {
        totalDealer = 0;
        totalJugador = 0;

        switch (switchControl)
        {
            case "menu":
                Console.WriteLine("Escriba ‘21’ para jugar al 21");
                switchControl = Console.ReadLine();
                break;
            case "21":
                do
                {

                    num = random.Next(1, 12);
                    totalJugador = totalJugador + num;
                    Console.WriteLine("Toma tu carta, jugador");
                    Console.WriteLine("El número que te salio fue: " + num);
                    Console.WriteLine("¿Deseas otra carta?");
                    controlOtraCarta = Console.ReadLine();

                } while (controlOtraCarta == "Si" || controlOtraCarta == "si" || controlOtraCarta == "yes" || controlOtraCarta == "Yes");

                totalDealer = random.Next(12, 23);
                Console.WriteLine("Tu tienes: " + totalJugador);
                Console.WriteLine("El Dealer tiene: " + totalDealer);
                if (totalJugador > totalDealer && totalJugador < 22 || totalDealer >= 22)
                {
                    Console.WriteLine("Venciste al dealer, felicidades");
                    platziCoins = platziCoins + (platziCoinsApostadas * 2);
                    Console.WriteLine($"Tus platziCoins actuales son: {platziCoins}");
                    Console.WriteLine("¿Deseas apostar otro valor?");
                    SiONo = Console.ReadLine();
                    switch (SiONo)
                    {
                        case "si":
                            if (platziCoins < 0)
                            {
                                break;
                            }
                            Console.WriteLine("Inserta el valor a apostar:");
                            platziCoinsApostadas = Convert.ToInt32(Console.ReadLine());
                            break;
                        case "no":
                            break;
                    }
                    switchControl = "menu";

                }
                else if (totalJugador >= 22)
                {
                    Console.WriteLine("Perdiste vs el dealer, te pasaste de 21");
                    platziCoins = platziCoins - (platziCoinsApostadas * 2);
                    Console.WriteLine($"Tus platziCoins actuales son: {platziCoins}");
                    Console.WriteLine("¿Deseas apostar otro valor?");
                    SiONo = Console.ReadLine();
                    switch (SiONo)
                    {
                        case "si":
                            if (platziCoins < 0)
                            {
                                break;
                            }
                            Console.WriteLine("Inserta el valor a apostar:");
                            platziCoinsApostadas = Convert.ToInt32(Console.ReadLine());
                            break;
                        case "no":
                            break;
                    }
                    switchControl = "menu";
                }
                else if (totalJugador <= totalDealer)
                {
                    Console.WriteLine("Perdiste vs el dealer, lo siento");
                    platziCoins = platziCoins - (platziCoinsApostadas * 2);
                    Console.WriteLine($"Tus platziCoins actuales son: {platziCoins}");
                    Console.WriteLine("¿Deseas apostar otro valor?");
                    SiONo = Console.ReadLine();
                    switch (SiONo)
                    {
                        case "si":
                            if(platziCoins < 0)
                            {
                                break;
                            }
                            Console.WriteLine("Inserta el valor a apostar:");
                            platziCoinsApostadas = Convert.ToInt32(Console.ReadLine());
                            break;
                        case "no":
                            break;
                    }
                    switchControl = "menu";
                }
                else if (totalJugador >= 22 && totalDealer >= 22)
                {
                    Console.WriteLine("Ninguno de los dos gana, se reparte la baraja");
                    Console.WriteLine($"Tus platziCoins actuales son: {platziCoins}");
                    Console.WriteLine("¿Deseas apostar otro valor?");
                    SiONo = Console.ReadLine();
                    switch (SiONo)
                    {
                        case "si":
                            if (platziCoins < 0)
                            {
                                break;
                            }
                            Console.WriteLine("Inserta el valor a apostar:");
                            platziCoinsApostadas = Convert.ToInt32(Console.ReadLine());
                            break;
                        case "no":
                            break;
                    }
                    switchControl = "menu";
                }
                else
                {
                    message = "condición no válida";
                    switchControl = "menu";
                }
                break;
            default:
                Console.WriteLine("Valor ingresado no válido en el C A S I N O");
                switchControl = "menu";
                break;
        }

    }
    if (platziCoins == 0)
    {
        Console.WriteLine("Perdiste todas tus fichas, lo lamento mucho, Dale a enter para volver a intentarlo!");
        Console.ReadLine();
      }
    if (platziCoins < 0)
    {
        Console.WriteLine("Perdiste todas tus fichas, ¡Y ENCIMA LE QUEDASTE DEBIENDO AL CASINO! ¡LARGO DE AQUI!");
        Console.ReadLine();
        return 0;
    }
}