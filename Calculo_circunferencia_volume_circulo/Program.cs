using System;
using System.Globalization;

namespace Calculo_circunferencia_volume_circulo
{
    class Program
    { 
    
         static void Main(string[] args)
         {
            //Pedindo os valores do raio para o usuário.
            Console.WriteLine("Entre com valor do raio:");
            //Computando e armazenando o valor do raio.
            double raio = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            //Chamando os metodos para calcular a circunferência e volume, jogando o valor do raio necessário.
            double circ = Calculadora.Circunferencia(raio);
            double volume = Calculadora.Volume(raio);

            //exibindo os resultados da circunferência, volume e valor de PI.
            Console.WriteLine("Circuferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: " + Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture));
         }
    }
}
