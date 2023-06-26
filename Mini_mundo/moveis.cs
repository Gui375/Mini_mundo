using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_mundo
{
    class moveis : Iproduto
    {
        public string nome_produto { get; set ; }
        public double preco_produto { get ; set ; }


        public moveis()
        {
            cadastrarProduto();
        }
        public void cadastrarProduto()
        {
            Console.WriteLine("Nome do novo produto : ");
            nome_produto = Console.ReadLine();

            Console.WriteLine("Preço do produto : ");
            preco_produto = int.Parse(Console.ReadLine());
        }
    }
}
