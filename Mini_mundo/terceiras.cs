using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_mundo
{
    public class terceiras_
    {
        public string Nome_terceira { get; set; }
        public string CNPJ { get; set; }
        public int qnt_funcionarios_contratados { get; set; }
        public double custo { get; set; }

        public void terciera()
        {
            Console.WriteLine("Nome da empresa terceira:");
            Nome_terceira = Console.ReadLine();

            Console.WriteLine("CNPJ");
            CNPJ = Console.ReadLine();

            Console.WriteLine("quantidade de funcionarios:");
            qnt_funcionarios_contratados = int.Parse(Console.ReadLine());

            Console.WriteLine("Custo por mês: ");
            custo =double.Parse(Console.ReadLine());



            Console.WriteLine("Você deseja calcular o valor de custo do ano ?");
            char escolha = char.Parse(Console.ReadLine());
            if ( escolha == 'S'|| escolha =='s')
            {
                Console.WriteLine($"Custo anual {CustoAno()}");
            }
        }

        private double CustoAno()
        {
            double custoTotal = custo * 12;
            return custoTotal;
        }
    }
}
