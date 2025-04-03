using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class JugadorIA
{
    Juego juego;
    public JugadorIA()
    {
        juego = new Juego();
    }

    public int jugar(string[] panelJuego)
    {
        while (true)
        {
            Random rnd = new Random();
            int casilla = rnd.Next(0, 9);
            if(juego.verificarMovimientoPermitido(panelJuego,casilla))
            {
                return casilla;
            }
        }
    }
}
