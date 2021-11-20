using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos {
    public class FormatandoNumero {
        public static void Executar() {
            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1"));    // Formata para apenas uma casa decimal
            Console.WriteLine(valor.ToString("C")); // Transforma em um valor monetário(moeda de acordo com o sistema)
            Console.WriteLine(valor.ToString("P")); // Transforma em um valor porcentual
            Console.WriteLine(valor.ToString("#.##"));

            CultureInfo cultura = new CultureInfo("en-US"); // Define o formato do país
            Console.WriteLine(valor.ToString("C3", cultura));   // Formata para o tipo da cultura no formato de dinheiro

            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10")); // Completa até ter 10 digitos no total
        }
    }
}
