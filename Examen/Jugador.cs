using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Jugador
{
    private String nombre;
    public virtual string jugar()
    {
        Console.WriteLine("Presione el numero de casilla que desea selecionar para continuar");
        String NumeroCasilla = Console.ReadLine();
        return NumeroCasilla;
    }

    public void setNombre(String nombre)
    {
        this.nombre = nombre;
    }
    public String getNombre()
    {
        return nombre;
    }
}
