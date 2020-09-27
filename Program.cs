using System;

namespace jurossimples
{
    class Program
    {
        static void Main(string[] args)
        {
            double capital;
            double taxa:
            double resultTaxa;
            double tempo;
            double juros;
            double montante;
            
            Console.Write("Digite seu valor R$: ");
            capital = double.Parse(Console.ReadLine());

            Console.Write("Digite sua taxa de juros %: ");
            taxa = double.Parse(Console.ReadLine());

            Console.Write("Digite seu tempo de parcelas: ");
            tempo = double.Parse(Console.ReadLine());
            Console.Write("\n")

            resultTaxa = taxa /100;
            juros = capital *resultTaxa * tempo;
            Console.WriteLine("Seu juros é  = {0}", juros);

            montante = capital + juros;
            Console.WriteLine("Seu montante é = {0}",montante);
            Console.Write("\n");

            Console.WriteLine("Pressione Enter para sair!");
            Console.ReadKey();
        }
    }
}
