using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int max_elem = 10;
            int topo = -1;
            int n, i, escolha, achou;
            int[] pilha = new int[max_elem];
            do
            {
                Console.Clear();
                Console.WriteLine(" Menu Principal");
                Console.WriteLine("(1) - Insere um elemento na Pilha");
                Console.WriteLine("(2) - Remove um elemento da Pilha");
                Console.WriteLine("(3) - Consulta um elemento da Pilha");
                Console.WriteLine("(4) - Lista os elementos da Pilha");
                Console.WriteLine("(5) - Para SAIR");
                escolha = int.Parse(Console.ReadLine());
                switch (escolha)
                {
                    case 1: // Insere um elemento na Pilha
                        Console.Clear();
                        if (topo < (max_elem - 1))
                        {
                            Console.Write("Entre com um numero : ");
                            n = int.Parse(Console.ReadLine());
                            topo++;
                            pilha[topo] = n;
                        }
                        else
                        {
                            Console.WriteLine("Pilha cheia!");
                            Console.ReadKey();
                        }
                        break;
                    case 2: // Remove um elemento da Pilha
                        Console.Clear();
                        if (topo == -1)
                            Console.WriteLine("Pilha vazia!");
                        else
                        {
                            Console.WriteLine(pilha[topo]);
                            topo--;
                        }
                        Console.ReadKey();
                        break;
                    case 3: // Consulta um elemento da Pilha
                        Console.Clear();
                        if (topo == -1)
                            Console.WriteLine("Pilha vazia!");
                        else
                        {
                            Console.Write("Digite valor para pesquisa : ");
                            n = int.Parse(Console.ReadLine());
                            achou = 0;
                            i = 0;
                            do
                            {
                                if (n == pilha[i])
                                    achou = 1;
                            else
                                    i++;
                            } while (i <= topo && achou == 0);
                            if (achou == 0)
                                Console.WriteLine("Elemento nao existe!");
                            else
                                Console.WriteLine("Elemento encontrato na posicao {0} ", i + 1);
                        }
                        Console.ReadKey();
                        break;
                    case 4: // Lista os elementos da Pilha
                        Console.Clear();
                        if (topo == -1)
                            Console.WriteLine("Pilha vazia!");
                        else
                        {
                            for (i = 0; i <= topo; i++)
                                Console.WriteLine(pilha[i]);
                        }
                        Console.ReadKey();
                        break;
                    case 5: // Sair do programa
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Opcao Incorreta!");
                        Console.ReadKey();
                        break;
                }
            } while (escolha != 5);
        }
    }
}
