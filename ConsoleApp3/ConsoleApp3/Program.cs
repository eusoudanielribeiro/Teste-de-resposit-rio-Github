using System;

namespace ConsoleApp3
{
    class Program
    {
        class Fila
        {
            public Fila()   // construtor
            {
                info = 0;
                next = null;
            }

            public void Insere (int n, ref Fila START, ref Fila END)
            {
                this.info = n;
                if (START == null)
                    START = END = this;
                else
                {
                    END.next = this;
                    END = this;
                }
            }

            public void Remove (ref Fila START, ref Fila END)
            {
                START = START.next;
            }



            private int info;
            Fila next;
        }

        static void Main(string[] args)
        {
            Fila START; //Apontar para o endereço do primeiro objeto da Fila
            Fila END;   //Apontar para o endereço do último objeto da Fila
            Fila FF;    //Apontar para o endereço do objeto da Fila
            int n;
            START = END = null;

            for (int i = 0; i < 3; i++)
            {
                FF = new Fila();
                Console.Write("Digite um valor:");
                n = int.Parse(Console.ReadLine());
                FF.Insere(n, ref START, ref END);

            }

            START.Remove(ref START, ref END);
        }
    }
}
