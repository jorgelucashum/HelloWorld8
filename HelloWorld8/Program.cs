using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld8
{
    class Program
    {
        // toda classe em C# é uma subclasse de Object, já possuindo alguns métodos como:
        // Equals: Compara se o objeto é igual ao outro
        // ToString: converte o objeto para string 
        // GetHashCode: retorna o hash do objeto
        // GetType: retorna o tipo do objeto
        static void Main(string[] args)
        {
            Produto p1; // 'p1' = objeto
            p1 = new Produto(); // 'p1' foi instanciado servindo como objeto para utilizar os atributos e métodos da classe 'Produto'

            Console.WriteLine("Digite o nome do produto: ");
            p1.Nome = Console.ReadLine();

            Console.WriteLine("Digite o preço: ");
            p1.Preco = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade: ");
            p1.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Dados do pruduto: " + p1);
            Console.WriteLine();

            Console.WriteLine("Digite a quantidade de produtos a serem adicionadas");
            int quant = int.Parse(Console.ReadLine());
            p1.AdicionarProdutos(quant);
            Console.WriteLine("Dados atualizados: " + p1);
            Console.WriteLine();

            Console.WriteLine("Digite a quantidade de produtos a serem removidas");
            quant = int.Parse(Console.ReadLine());
            p1.RemoverProdutos(quant);
            Console.WriteLine("Dados atualizados: " + p1);
            Console.WriteLine();


            Console.ReadLine();
        }
    }
}
