using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_mundo
{
    abstract class colaborador
    {
        public string nome  { get; protected set; }
        public string cpf { get; protected set; }
        public int Nivel { get; protected set; } // qual seu nivel dentro da empresa
        public string departametno { get; set; }// pertence a qual departamento 



        virtual public void RegistrarColab() 
        {
            Console.WriteLine("Nome : ");
            nome = Console.ReadLine();

            Console.WriteLine("CPF : ");
            cpf = Console.ReadLine();

            Console.WriteLine("Qual seu nivel? : ");
            Nivel = int.Parse(Console.ReadLine());

            Console.WriteLine("Departamento : ");
            departametno = Console.ReadLine();


        }


    }
}
