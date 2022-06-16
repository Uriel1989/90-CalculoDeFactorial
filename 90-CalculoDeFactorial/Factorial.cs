using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _90_CalculoDeFactorial
{
    class Factorial
    {
        
        public int operacion (int num)
        {
            int resultado = num;
            for (int i = num - 1; i > 1; i--) //empiezo en num-1 y acabo en 1 (no llega a 1)
            {
                resultado *= i;
            }
            return resultado;
        }
    }
}
