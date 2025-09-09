namespace PTI;
class Program

    static void Main(string[] args)
    {
        GerenciadorLoja ger = new GerenciadorLoja();

        int opcao = 0;

        do
        {
            Console.WriteLine("\n --Loja de celulares-- ");
            Console.WriteLine("1. Novo");
            Console.WriteLine("2. Listar");
            Console.WriteLine("3. Remover");
            Console.WriteLine("4. Entrada Estoque");
            Console.WriteLine("5. Saída Estoque");
            Console.WriteLine("0. Sair");
            opcao = Convert.ToInt32(Console.ReadLine());


            if (opcao == 1)
            {
                Celular celular = new Celular();

                Console.WriteLine("Informea marca do celular: ");
                celular.Marca = Console.ReadLine();

                Console.WriteLine("informe o preço do celular: ");
                celular.Preco = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Informe o modelo do celular: ");
                celular.Modelo = Console.ReadLine();

                Console.WriteLine("Informe a cor do celular: ");
                celular.Cor = Console.ReadLine();

                celular.Estoque = 0;


                ger.Novo(celular);
            }
            
            
            else if (opcao == 2)
            {
                Console.WriteLine("--Lista de celulares--");
                ger.Listar();
            }
            
            
            else if (opcao == 3)
            {
                Console.WriteLine("Digite o número do celular que deseja remover do estoque: ");
                int indice = Convert.ToInt32(Console.ReadLine()) - 1;
                if (indice >= 0 && indice < ger.EstoqueCelulares())
                {
                    ger.Remover(indice);
                    Console.WriteLine("Celular removido com sucesso. ");
                }
                else
                {
                    Console.WriteLine("Número inválido. Nenhum celular removido.");
                }
            }
                
                
                else if (opcao == 4)
                {
                    Console.WriteLine("Digite o num do celular para entrada de estoque:");
                    int indice = Convert.ToInt32(Console.ReadLine()) - 1;
                }
                if (indice >= 0 && indice < ger.EstoqueCelulares())
                {
                    Console.WriteLine("Digite a quantidade para entrada no estoque:");
                    int quantidade = Convert.ToInt32(Console.ReadLine());

                    ger.EntradaEstoque(indice, quantidade);
                    Console.WriteLine("Estoque atualizado com sucesso.");
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Nenhuma atualização de estoque realizada.");
                }
        }
    

                else if (opcao == 5)
                {
                    Console.WriteLine("Digite o num do celular para saída do estoque:");
                    int indice = Convert.ToInt32(Console.ReadLine()) - 1;
                
                if (indice >= 0 && indice < ger.EstoqueCelulares())
                {
                    Console.WriteLine("Digite a quantidade de saída de estoque:");
                     int quantidade = Convert.ToInt32(Console.ReadLine());

                        if (quantidade <= ger.VerificarEstoque(indice))
                     {
                        ger.SaidaEstoque(indice, quantidade);
                        Console.WriteLine("Estoque atualizado.");
                     }
                     
                        else
                     {
                        Console.WriteLine("Quantidade de saída excede o estoque.");
                     }
                }
                     
                     else
                        {
                            Console.WriteLine("Inválido. Nenhuma atualização de estoque realizada.");
                        }
                     }
                
    } while (opcao != 0);
                
                         
    



    

