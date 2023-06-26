using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Mini_mundo
{
    public class menu
    {
        
        gerente gerente_ = new gerente();
        diretor diretor_ = new diretor();
        List<Loja> Lista_loja = new List<Loja>();
        List<Roupas> Novos__produtos = new List<Roupas>();  
        List<moveis> Novos_moveis =  new List<moveis>();
        List<terceiras_> empresastec = new List<terceiras_>();
        
        public void _menu()
        {
            #region menu
            bool sair = false;
            while (!sair)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Registrar novo colaborador");
                Console.WriteLine("2. Cadastrar nova loja: ");
                Console.WriteLine("3. Mostrar Loja");
                Console.WriteLine("------------------------------------");
                Console.WriteLine("4. cadastrar nova roupa");
                Console.WriteLine("5. mostrar roupas");
                Console.WriteLine("6. ajustar comissão do vendedor");
                Console.WriteLine("------------------------------------");
                Console.WriteLine("7. Cadastrar Moveis");
                Console.WriteLine("8. mostrar moveis");
                Console.WriteLine("------------------------------------");
                Console.WriteLine("9. Cadastrar empregados");
                Console.WriteLine("------------------------------------");
                Console.WriteLine("10. Cadastrar Empresas terceiras");
                Console.WriteLine("------------------------------------");
                Console.WriteLine("11. Sair");
                Console.WriteLine();

                Console.Write("Selecione uma opção: ");
                string entrada = Console.ReadLine();
                Console.WriteLine();

                switch (entrada)
                {
                    case "1":
                        #region menu_colaborador
                        Console.WriteLine("G - Gerente");
                        Console.WriteLine("D - Diretor");
                        Console.WriteLine("Qual colaborador novo você deseja cadastrar ?: ");
                        char escolha =  char.Parse(Console.ReadLine());
                        switch (escolha)
                        {
                            case 'G':
                                gerente_.RegistrarColab();
                                Console.WriteLine("Calcular custo de empregados");
                                char custo = char.Parse(Console.ReadLine());    
                                if(custo == 'S' || custo == 's')
                                {
                                    Console.WriteLine("Quantos empregados você deseja contratar?: ");
                                    int numeroEMP = int.Parse(Console.ReadLine());

                                    Console.WriteLine("Qual será o salario desses empregados? " +
                                        "OBS : Pode ser alterado depois pelo pessoal do financeiro. Apenas uma estimativa de custo");
                                    double salario = double.Parse(Console.ReadLine());


                                    Console.WriteLine($"Estimativa de custos: {gerente_.contratarEmpregados(numeroEMP,salario)}");
                                }
                                break;

                            case 'D':
                                diretor_.RegistrarColab();
                                break;
                        }
                        #endregion

                        break;
                    case "2":
                        
                        if (diretor_.nome == null)
                        {
                            Console.WriteLine("Não tem diretor para cadastrar!");
                        }
                        else
                        {
                            bool teste_logico = false;
                            while (teste_logico == false)
                            {
                                
                                Console.WriteLine($"Qual o numero da nova loja que o diretor {diretor_.nome} irá registrar  ?");
                                Loja nova_loja = new Loja();
                                Lista_loja.Add( nova_loja );
                                Console.WriteLine("Deseja cadastrar uma nova loja ?");
                                char novaescolha = char.Parse(Console.ReadLine());
                                if (novaescolha == 'N' || novaescolha =='n')
                                {
                                    teste_logico = true;
                                }
                            }
                            
                                            
                        }
                        break;

                    case "3":
                        if (Lista_loja.Count <= 0)    
                        Console.WriteLine("não a nada para ser mostrado");
                        
                        foreach (var item in Lista_loja)
                        {
                            Console.WriteLine("------------------------------------");
                            Console.WriteLine($"Numero da loja cadastrada pelo Diretor {diretor_.nome}: {item.Numero_loja}");
                            Console.WriteLine($"Bairro da loja: {item.bairro}");
                            Console.WriteLine($"Cidade da loja: {item.Cidade}");
                            Console.WriteLine("------------------------------------");
                        }
                        Console.WriteLine("Deseja mostrar as lojas ordenadas de forma cresente?");
                        char escolhaOrdena = char.Parse(Console.ReadLine());
                        if(escolhaOrdena == 'S' || escolhaOrdena == 's')
                        {
                           List<Loja> ListaLojaOrd= Lista_loja.OrderBy(x => x).ToList();
                            foreach (var item in ListaLojaOrd)
                            {
                                Console.WriteLine("------------------------------------");
                                Console.WriteLine($"Numero da loja cadastrada pelo Diretor {diretor_.nome}: {item.Numero_loja}");
                                Console.WriteLine("------------------------------------");
                            }
                        }
                            break;
                    case "4":
                        if (gerente_.nome==null)
                        {
                            Console.WriteLine("Não existe gerente para cadastrar produtos ! ");
                        }
                        bool teste_logico2 = false;
                        while (teste_logico2 == false) 
                        {
                            Console.WriteLine($"Qual a nova roupa que o gerente {gerente_.nome} irá registrar  ?");
                            Roupas nova_produto = new Roupas();
                            Novos__produtos.Add(nova_produto);
                            Console.WriteLine("Deseja cadastrar uma nova roupa ?");
                            char novaescolha2 = char.Parse(Console.ReadLine());
                            if (novaescolha2 == 'N' || novaescolha2 == 'n')
                            {
                                teste_logico2 = true;
                            }
                        }

                        break;
                    case "5":
                        if (Novos__produtos.Count <= 0)
                        {
                            Console.WriteLine("não a nada para ser mostrado");
                            break;
                        }

                        foreach (var item in Novos__produtos)
                        {
                            Console.WriteLine("------------------------------------");
                            Console.WriteLine($"Nome da roupa cadastrada pelo gerente {gerente_.nome}: {item.nome_produto}");
                            Console.WriteLine($"Preço do produto: {item.preco_produto}");
                            Console.WriteLine("------------------------------------");
                        }
                        Console.WriteLine("Deseja mostrar as roupas ordenadas de forma cresente por valor ?");
                        char escolhaOrden = char.Parse(Console.ReadLine());
                        if (escolhaOrden == 'S' || escolhaOrden == 's')
                        {
                            List<Roupas> ListaprodOrd = Novos__produtos.OrderBy(x => x.preco_produto).ToList();
                            foreach (var item in ListaprodOrd)
                            {
                                Console.WriteLine("------------------------------------");
                                Console.WriteLine($"Numero da roupa ordenada pelo gerente {gerente_.nome}: {item.preco_produto}");
                                Console.WriteLine("------------------------------------");
                            }
                        }
                        //Console.WriteLine("encontrar uma roupa expecifica ?");
                        //char achar = char.Parse(Console.ReadLine());
                        //if (achar == 'S' || achar == 's')
                        //{
                        //    Console.WriteLine("Roupa que deseja encontrar: ");
                        //    string roupa = Console.ReadLine();                  
                        //    Console.WriteLine(Novos__produtos.Find(x => x.nome_produto.Contains(roupa)));
                        //}

                        break;
                    case "6":

                        if (diretor_.nome == null || gerente_.nome==null)
                        {
                            Console.WriteLine("Não existe gerente ou diretor cadastrado para esta operação: ");
                            break;
                        }
                        Console.WriteLine($"Diretor {diretor_.nome} irá ajustar a comissão do gerente {gerente_.nome}");
                        double comissao = int.Parse(Console.ReadLine());
                       Console.WriteLine($"valor da comissão do gerente {gerente_.nome}: {diretor_.ajustarcomissao(comissao)}");
                        break;

                    case "7":
                        if (gerente_.nome == null)
                        {
                            Console.WriteLine("Não existe gerente para cadastrar produtos ! ");
                        }
                        bool teste_logico3 = false;
                        while (teste_logico3 == false)
                        {
                            Console.WriteLine($"Qual o novo movel que o gerente {gerente_.nome} irá registrar  ?");
                            moveis novoMovel= new moveis();
                            Novos_moveis.Add(novoMovel);
                            Console.WriteLine("Deseja cadastrar um novo movel ?");
                            char novaescolha2 = char.Parse(Console.ReadLine());
                            if (novaescolha2 == 'N' || novaescolha2 == 'n')
                            {
                                teste_logico2 = true;
                            }
                        }
                        break;

                    case "8":
                        if (Novos_moveis.Count <= 0) 
                        {
                            Console.WriteLine("não a nada para ser mostrado");
                            break;
                        }
                            

                        foreach (var item in Lista_loja)
                        {
                            Console.WriteLine("------------------------------------");
                            Console.WriteLine($"Numero da loja cadastrada pelo Diretor {diretor_.nome}: {item.Numero_loja}");
                            Console.WriteLine($"Bairro da loja: {item.bairro}");
                            Console.WriteLine($"Cidade da loja: {item.Cidade}");
                            Console.WriteLine("------------------------------------");
                        }
                        Console.WriteLine("Deseja mostrar os moveis ordenados de forma cresente?");
                        char moveisORd = char.Parse(Console.ReadLine());
                        if (moveisORd == 'S' || moveisORd == 's')
                        {
                            List<moveis> ListamovOrd = Novos_moveis.OrderBy(x => x).ToList();
                            foreach (var item in ListamovOrd)
                            {
                                Console.WriteLine("------------------------------------");
                                Console.WriteLine($"Numero da roupa cadastrada pelo gerente {gerente_.nome}: {item.preco_produto}");
                                Console.WriteLine("------------------------------------");
                            }
                        }
                        break;

                    case "9":
                        empregados empregado = new empregados();
                        empregado.RegistrarColab();

                        Console.WriteLine("Você deseja calcular o rendimento do salario do novo empregado? ");
                        char calc = char.Parse(Console.ReadLine());
                        if(calc =='S' || calc =='s')
                        {
                            Console.WriteLine($"Salario em 12 meses: {empregado.salarioNoAno()}");
                        }

                        break;

                    case "10":
                        if (diretor_.nome == null)
                        {
                            Console.WriteLine("É necessario um diretor para contratar uma terceira !");
                            break;
                        }
                        bool teste_terceira = false;
                        while (teste_terceira == false)
                        {

                            Console.WriteLine($"Qual o numero da nova loja que o diretor {diretor_.nome} irá registrar  ?");
                            terceiras_ nova_terceira = new terceiras_();
                            nova_terceira.terciera();
                            empresastec.Add(nova_terceira) ;
                            Console.WriteLine("Deseja cadastrar uma nova loja ?");
                            char novaescolha = char.Parse(Console.ReadLine());
                            if (novaescolha == 'N' || novaescolha == 'n')
                            {
                                teste_terceira = true;
                            }
                        }

                        Console.WriteLine("Deseja visualizar as empresas terceiras contratadas");
                        char todas_empresas = char.Parse(Console.ReadLine());   
                        if (todas_empresas == 'S' || todas_empresas == 's')
                        {
                            foreach (var item in empresastec)
                            {
                                Console.WriteLine("------------------------------------");
                                Console.WriteLine($"Nome terceira: {item.Nome_terceira}");
                                Console.WriteLine($"CNPJ terceira: {item.CNPJ}");
                                Console.WriteLine("------------------------------------");


                            }
                        }
                        break;

                    case "11":
                        Console.WriteLine("Saindo...");
                        sair = true;
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Selecione novamente.");
                        break;
                }

                Console.WriteLine();
            }


            #endregion
        }
    }
}
