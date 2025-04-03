using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

internal class Inferfaz
{
    private String[] panelJuego;
    private JugadorIA jugadorIA;
    private Juego juego;
    public Inferfaz()
    {
        Random rnd = new Random();
        panelJuego = new String[9];
        jugadorIA = new JugadorIA();
        juego = new Juego();
        for (int i = 0; i < panelJuego.Length; i++)
        {
            panelJuego[i] = " ";
        }

    }
    public void inicio()
    {
        bienvenida();
        inferfazGrafica();

    }
    public void bienvenida()
    {
        Console.WriteLine("Bienvenido al juego de tres en raya");
        Console.WriteLine("Para jugar, ingrese el número de la casilla donde desea colocar su ficha");
        Console.WriteLine("El tablero tiene la siguiente estructura:");
        Console.WriteLine("0|1|2");
        Console.WriteLine("3|4|5");
        Console.WriteLine("6|7|8");
        Console.WriteLine("Usted jugador jugara  con el simbolo X");
        Console.WriteLine("Preparese para jugar");
    }
    public void inferfazGrafica()
    {
        while (true)
        {
            while (panelJuego[0] == " " || panelJuego[1] == " " || panelJuego[2] == " " || panelJuego[3] == " " || panelJuego[4] == " " || panelJuego[5] == " " || panelJuego[6] == " " || panelJuego[7] == " " || panelJuego[8] == " ")
            {
                if (juego.verificarTresEnRayaGanadorJugador(panelJuego))
                {
                    Console.WriteLine("Felicidades, ha ganado el juego");
                    break;
                }
                if (juego.verificarTresEnRayaGanadorIA(panelJuego))
                {
                    Console.WriteLine("Haz perdido el juego");
                    break;
                }

                mostrarPanelJuego(panelJuego);
                while (true)
                {
                    int casilla = 0;
                    Console.WriteLine("El tablero tiene la siguiente estructura:");
                    Console.WriteLine("0|1|2");
                    Console.WriteLine("3|4|5");
                    Console.WriteLine("6|7|8");
                    Console.WriteLine("Presione el numero de casilla que desea selecionar para continuar");
                    
                    String NumeroCasilla = Console.ReadLine();
                    if (int.TryParse(NumeroCasilla, out casilla))
                    {
                        if (!juego.verificarMovimientoPermitido(panelJuego, casilla))
                        {
                            continue;
                        }
                        if (casilla >= 0 && casilla < 9)
                        {
                            panelJuego[casilla] = "X";
                            break;
                        }
                        else
                        {
                            Console.WriteLine("El numero de casilla ingresado no es valido");
                            continue;
                        }
                    }
                    else
                    {
                        Console.WriteLine("El valor ingresado no es un numero");
                        continue;
                    }
                   
                }
                mostrarPanelJuego(panelJuego);
                
                Console.WriteLine("A continuacion jugara la IA");
                int OpcionIA = jugadorIA.jugar(panelJuego);
                panelJuego[OpcionIA] = "O";
            }


            Console.WriteLine("El juego ha terminado en Empate");
            while (true)
            {
                Console.WriteLine("Desea volver a jugar? (S/N)");
                String respuesta = Console.ReadLine();
                if (respuesta.ToLower().Equals("s"))
                {
                    for (int i = 0; i < panelJuego.Length; i++)
                    {
                        panelJuego[i] = " ";
                    }
                    break;
                }
                else if (respuesta.Equals("N") || respuesta.Equals("n"))
                {
                    return;
                }
                else
                {
                    Console.WriteLine("ingresa una opcion valida");
                }
            }
   
        }
    }
    public void mostrarPanelJuego(string[] panelJuego)
    {
        for (int i = 0; i < panelJuego.Length; ++i)
        {
            Console.Write(panelJuego[i]);
            if (i % 3 == 2)
            {
                Console.WriteLine();
            }
            else
            {
                Console.Write("|");
            }
        }
    }
    
}
