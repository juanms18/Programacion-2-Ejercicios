using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase2_ej_1
{
    public static class Validador
    {
        public static bool Validar(float valor, float min, float max , string error)
        {
            if (valor >= min && valor <= max)
            {
                return true;
            }
            else 
            {
                Console.WriteLine (error);
                return false;
            }
        }
    }
}
