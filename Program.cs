using System;

namespace gastoDeCombustivel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            int tempoDeViagem, velocidadeMedia;
            double combustivel, distancia;


            Console.WriteLine("Qual a duração da viagem em horas?");
            tempoDeViagem = int.Parse(Console.ReadLine());
            Console.WriteLine($"{tempoDeViagem} horas");

            Console.WriteLine("Qual a velocidade média?");
            velocidadeMedia = int.Parse(Console.ReadLine());
            Console.WriteLine($"{velocidadeMedia} Km/h");

            distancia = velocidadeMedia * tempoDeViagem;
            combustivel = distancia / 12; // considerando que o carro faz 12 km/ litro

            Console.WriteLine($" São necessários {Math.Round(combustivel, 3)} litros de combustível!");




        }
    }
}
