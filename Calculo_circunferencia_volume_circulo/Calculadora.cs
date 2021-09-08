using System;
using System.Collections.Generic;
using System.Text;

namespace Calculo_circunferencia_volume_circulo
{
   public class Calculadora
   {
        //Dando valor de PI.
        public double Pi = 3.14;

        //Calculando Circunferência.
        public double Circunferencia(double r)
        {
            return 2.0 * Pi * r;
        }

        //Calculando Volume.
        public double Volume(double r)
        {
            return 4.0 / 3.0 * Pi * r * r * r;
        }
   }
}
