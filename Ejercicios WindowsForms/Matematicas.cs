using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formularios
{
    class Matematicas: Operaciones
    {
        private int num1;
        private int num2;

        public Matematicas(int num1, int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }
        public int suma()
        {
            return num1 + num2;
        }
        public int resta()
        {
            return num1 - num2;
        }
        public int multiplicacion()
        {
            return num1 * num2;
        }
        public int division()
        {
            return num1 / num2;
        }
        public int resto()
        {
            return num1 % num2;
        }

    }
}
