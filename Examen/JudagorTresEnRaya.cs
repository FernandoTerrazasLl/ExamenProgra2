﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class JudagorTresEnRaya:Jugador
{
    public void jugadorsetNombre(string nombre)
    {
        setNombre(nombre);
    }
    public override string jugar()
    {
        Console.WriteLine("Presione el numero de casilla que desea selecionar para continuar");
        String NumeroCasilla = Console.ReadLine();
        return NumeroCasilla;
    }
}
