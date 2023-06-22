using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATIVIDADE07
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor;

            Console.WriteLine(" \n\n ---INSIRA O VALOR:");
               valor=int.Parse( Console.ReadLine());
             if (valor>1)
            {
                Console.WriteLine(" \n\n VALOR ESTÁ CORRETO!!");
            }

            Console.WriteLine(" \n\n ESCOLHA UMA OPÇÃO: ");
            Console.WriteLine("--CAFÉ EXPRESSO");
            Console.WriteLine("--CAPUCCINO");
            Console.WriteLine("--MOCACCINO");
            Console.WriteLine("--AGUÁ QUENTE \n \n ");
               Console.ReadLine();
            if(valor > 1)
            {
                Console.WriteLine("----TUDO CERTO PODE RETIRAR!");
            }

            
            
            
            
            Console.ReadKey();
        }
    }
}
