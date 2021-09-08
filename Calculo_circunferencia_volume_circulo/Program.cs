using System;
using System.Globalization;

namespace Calculo_circunferencia_volume_circulo
{
    class Program
    {
        //Dando valor do Pi.
        static double Pi= 3.14;

         static void Main(string[] args)
         {
            //Pedindo os valores do raio para o usuário.
            Console.WriteLine("Entre com valor do raio:");
            //Computando e armazenando o valor do raio.
            double raio = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            //Dando valor do PI.

            //Chamando os metodos para calcular a circunferência e volume, jogando o valor do raio necessário.
            double circ = Circuferencia(raio);
            double volume = Volume(raio);

            //exibindo os resultados da circunferência, volume e valor de PI.
            Console.WriteLine("Circuferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: " +Pi.ToString("F2", CultureInfo.InvariantCulture));
         }
        //Definindo o método para calcular a circunferência.
        static double Circuferencia(double r)
        {
            return 2.0 * Pi * r;
        }
        //Definindo o método para calcular a volume.
        static double Volume(double r)
        {
            return 4.0 / 3.0 * Pi * r * r * r;
        }
    }
}
