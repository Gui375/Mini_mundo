using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Mini_mundo
{
     class empregados : colaborador
    {
        public empregados() 
        {
            Console.WriteLine("Quanto ele recebe por mês ?: ");
            salario = double.Parse(Console.ReadLine()); 
        }
        public double salario { get; set; }

        public double salarioNoAno()
        {
            double soma = salario * 12;
            return soma;
        }
    }
}
