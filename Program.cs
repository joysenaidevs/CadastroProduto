using System;

namespace CadastroProduto
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] produto = new string[3]; //serão 10 produtos (colocar 3 para teste de programa)
            float[] preco = new float[3];
            bool [] promocao = new bool [3];

            //cadastrando produto - IMPORTANTE DEIXAR AS VARIAVEIS FORA DA REPETICAO
            int escolha;
            int contador = 0;

            do
            {
                Console.WriteLine("Menu Inicial");
                Console.WriteLine("Selecione uma opção");
                Console.WriteLine("[1] - Cadastrar produto");
                Console.WriteLine("[2] - Listar o Produto");
                Console.WriteLine("[0] - Mostrar o menu");
                escolha = int.Parse(Console.ReadLine());

           
        

                switch (escolha)
                {
                    case 1:
                        //Cadastrar Produto
                            string resposta;
                            do
                            {
                                if(contador<3)
                                {
                                    Console.WriteLine($"Digite o {contador+1}º produto");
                                    produto[contador] = Console.ReadLine();
                                    Console.WriteLine($"Digite o preco dos produto");
                                    preco[contador] = float.Parse(Console.ReadLine());
                                    Console.WriteLine($"Este produto esta em promocao? s/n");
                                    promocao[contador] = bool.Parse(Console.ReadLine());
                                    


                                    contador++;

                                }else{
                                    Console.WriteLine("Limite excedido");
                                }

                                    Console.WriteLine("Voce gostaria de cadastrar novamente? s/n");
                                    resposta = Console.ReadLine();

                            }while (resposta == "s");
                        break;
                    case 2:
                    //Listar Produtos
                        for (var i = 0; i <3; i++)
                        {
                            Console.WriteLine($"Produtos {produto[i]}");
                        }
                        break;
                    case 0:
                    //Mostrar menu
                        break;
                    default:
                        Console.WriteLine("Opção invalida");
                        break;
                  
                }
                
            }while (escolha != 0);
            

            //funcoes
           
        


          

          
            


        }
    }
}
