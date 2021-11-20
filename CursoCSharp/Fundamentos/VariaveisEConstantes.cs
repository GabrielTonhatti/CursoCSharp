using System;

namespace CursoCSharp.Fundamentos
{
    public class VariaveisEConstantes
    {
        public static void Executar()
        {
            // área da circunferência
            double raio = 4.5;
            const double PI = 3.14;

            raio = 5.5;
            // PI = 3.1415;

            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("Área é " + area);

            // Tipos internos

            bool estaChovendo = true;
            Console.WriteLine("Está chovendo " + estaChovendo);

            byte idade = 45; // Entre 0 e +255, Não aceita valor negativo
            Console.WriteLine("Idade " + idade);

            sbyte saldoDeGols = sbyte.MinValue; // Entre -128 até +127
            Console.WriteLine("Saldo de Gols " + saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("Salário " + salario); // Entre -32.768 até +32.767
            Console.WriteLine(nint.MaxValue); // Entre 0 até +65535

            int menorValorInt = int.MinValue; // Mais usado dos inteiros!
            Console.WriteLine("Menor int " + menorValorInt); // Entre -2.147.483.648 até +2.147.483.647

            uint populacaoBrasileira = 207_600_000; // Não aceita valor negativo, entre 0 até 4.294.967.295
            Console.WriteLine("População Brasileira " + populacaoBrasileira);

            long menorValorLong = long.MinValue; // Entre -9.223.372.036.854.775.808 até +9.223.372.036.854.775.807
            Console.WriteLine("Menor long " + menorValorLong);

            ulong
                populacaoMundial = 7_600_000_000; // Não aceita valor negativo, entre 0 até +18.446.744.073.709.551.615
            Console.WriteLine("População Mundial " + populacaoMundial);

            float precoComputador = 1299.99F; // Entre -3,4028235E+38 até +3,4028235E+38
            Console.WriteLine("Preço Computador " + precoComputador);

            double
                valorDeMercadoApple =
                    1_000_000_000_000.00; // Entre -1,7976931348623157E+308 até +1,7976931348623157E+308, Mais usado dos reais!
            Console.WriteLine("Valor Apple " + valorDeMercadoApple);

            decimal distanciaEntreEstrelas = decimal.MaxValue;  // Entre -79.228.162.514.264.337.593.543.950.335 até +79.228.162.514.264.337.593.543.950.335
            Console.WriteLine("Distância entre Estrelas " + distanciaEntreEstrelas);

            char letra = 'b';
            Console.WriteLine("Lertra " + letra);

            string texto = "Seja bem vindo ao Curso de C#!";
            Console.WriteLine(texto);

        }
    }
}
