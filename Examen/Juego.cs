using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Juego
{
    public bool verificarTresEnRayaGanadorJugador(String[] panelTablero)
    {
        if (panelTablero[0] == panelTablero[1] && panelTablero[1] == panelTablero[2] && panelTablero[0] == "X")
        {
            return true;
        }
        else if (panelTablero[3] == panelTablero[4] && panelTablero[4] == panelTablero[5] && panelTablero[3] == "X")
        {
            return true;
        }else if (panelTablero[6] == panelTablero[7] && panelTablero[7] == panelTablero[8] && panelTablero[6] == "X")
        {
            return true;
        }else if (panelTablero[0] == panelTablero[3] && panelTablero[3] == panelTablero[6] && panelTablero[0] == "X")
        {
            return true;
        }else if (panelTablero[1] == panelTablero[4] && panelTablero[4] == panelTablero[7] && panelTablero[1] == "X")
        {
            return true;
        }else if (panelTablero[2] == panelTablero[5] && panelTablero[5] == panelTablero[8] && panelTablero[2] == "X")
        {
            return true;
        }else if (panelTablero[0] == panelTablero[4] && panelTablero[4] == panelTablero[8] && panelTablero[0] == "X")
        {
            return true;
        }else if (panelTablero[2] == panelTablero[4] && panelTablero[4] == panelTablero[6] && panelTablero[2] == "X")
        {
            return true;
        }
        return false;
    }
    public bool verificarTresEnRayaGanadorIA(String[] panelTablero)
    {
        if (panelTablero[0] == panelTablero[1] && panelTablero[1] == panelTablero[2] && panelTablero[0] == "O")
        {
            return true;
        }
        else if (panelTablero[3] == panelTablero[4] && panelTablero[4] == panelTablero[5] && panelTablero[3] == "O")
        {
            return true;
        }
        else if (panelTablero[6] == panelTablero[7] && panelTablero[7] == panelTablero[8] && panelTablero[6] == "O")
        {
            return true;
        }
        else if (panelTablero[0] == panelTablero[3] && panelTablero[3] == panelTablero[6] && panelTablero[0] == "O")
        {
            return true;
        }
        else if (panelTablero[1] == panelTablero[4] && panelTablero[4] == panelTablero[7] && panelTablero[1] == "O")
        {
            return true;
        }
        else if (panelTablero[2] == panelTablero[5] && panelTablero[5] == panelTablero[8] && panelTablero[2] == "O")
        {
            return true;
        }
        else if (panelTablero[0] == panelTablero[4] && panelTablero[4] == panelTablero[8] && panelTablero[0] == "O")
        {
            return true;
        }
        else if (panelTablero[2] == panelTablero[4] && panelTablero[4] == panelTablero[6] && panelTablero[2] == "O")
        {
            return true;
        }
        return false;
    }
    public bool verificarMovimientoPermitido(String[]panelJuego, int opcionCasilla)
    {
        if(panelJuego[opcionCasilla] == "X" || panelJuego[opcionCasilla] == "O")
        {
            Console.WriteLine("La casilla seleccionada ya esta ocupada, por favor seleccione otra casilla");
            return false;
        }
        return true;
    }
}
