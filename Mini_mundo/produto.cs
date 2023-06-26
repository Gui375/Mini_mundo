using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_mundo
{
    interface Iproduto
    {
        string nome_produto { get; set; }
        double preco_produto { get; set; }

        void cadastrarProduto();
    }
}

