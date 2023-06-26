using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_mundo
{
    public class Loja
    {

        public int Numero_loja { get; set; }
        public string Cidade { get; set; }
        public string rua { get; set; }
        public string bairro { get; set; }
        
       public Loja()
        {
            Criar_loja();
        }


        private void Criar_loja()
        {
            Console.WriteLine("Numero da nova loja: ");
            Numero_loja =int.Parse(Console.ReadLine());

            Console.WriteLine("Cidade : ");
            Cidade =Console.ReadLine();

            Console.WriteLine("Rua : ");
            rua  = Console.ReadLine();

            Console.WriteLine("Bairro : ");
            bairro  = Console.ReadLine();
                       
        }
        

    }
}
