using System;

/// <summary>
/// Este algoritmo recebe como parametro um valor inteiro e tem como saída uma SETA de asteriscos
/// Explorando conceitos de repetição. (no caso do altoritmo, o FOR)
/// </summary>
namespace seta
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var seta = "*";
            
            int.TryParse(Console.ReadLine(), out var tam);

            var j = 0;
            var tamMeio = (tam / 2) + 1;
            var arr = new string[tamMeio];

            for (int i = 0; i < tam; i++)
            {
                if (i < tamMeio)
                {
                    arr[i] = seta;

                    Console.WriteLine(seta);
                    seta += "*";
                    continue;
                }

                j =  j == 0 ?  i - 1 : j-1;

                Console.WriteLine(arr[j-1]);
            }
        }
    }
}
