using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_mundo
{
    class gerente : colaborador
    {
        public double comissao { get; set; }


        public double contratarEmpregados(int numEMP, double salario)
        {
           double custo = numEMP * salario;
            return custo;
        }
    }
}
