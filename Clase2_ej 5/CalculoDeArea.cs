using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase2_ej_5
{
   public static class CalculoDeArea
    {


        public static double CalculoCuadrado(double lado)
        {

            return Math.Pow(lado, 2);

        }


        public static double CalculoTriangulo(double baseTriangulo, double altura)
        {

            return (baseTriangulo * altura) / 2;    
        
        }

        public static double CalculoCirculo(double radio)
        { 
        
        return Math.PI * Math.Pow(radio, 2);
        
        }



    }
}
