using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_mundo
{
     class diretor : colaborador
    {
        gerente gerente = new gerente();    
        

        public double ajustarcomissao(double por)
        {
            return gerente.comissao = por;
        }

    }
}
