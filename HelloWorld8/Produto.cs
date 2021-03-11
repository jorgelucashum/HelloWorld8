using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization; // usado para converter 'CultureInfo.InvariantCulture' 
namespace HelloWorld8
{
    class Produto
    {
        public string Nome; //atributo com primeira letra maiusculo dentro em classe fora da main
        public int Quantidade;
        public double Preco;

        public double ValorTotalEmEsqtoque()
        {
            return Quantidade * Preco;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade; // Quantidade = Quantidade + quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade; // Quantidade = Quantidade - quantidade;
        }

        public override string ToString() // método usado para retornar a váriavel 'p1' nas informações em String
        {
            return Nome + ", R$:" + Preco.ToString("F2", CultureInfo.InvariantCulture) + ", " + Quantidade + " " +
                "Unidades, total R$:" + ValorTotalEmEsqtoque().ToString("F2", CultureInfo.InvariantCulture); // converter as ',' para '.' (padrão internacional)
        }

    }
}
