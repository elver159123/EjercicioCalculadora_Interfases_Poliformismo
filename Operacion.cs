using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioCalculadora
{
    internal interface Operacion
    {
        int sumar();
        int restar();
        int multiplicar();
        int dividir();
    }
}
