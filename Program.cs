using System;

namespace Vetores_Arrays_
{
    class Program
    {
        static void Main(string[] args)
       {
           string[] listaDeCompras = {"pão", "Queijo", "Calabresa"};
           double[] preços = {0.80, 1.0, 1.1};
           int[] idades = {16, 17, 18};

           string[] nomes = new string[5]; //Nova lista de string, vazia e com 5 itens

        //    Console.WriteLine("Trocar batata por qual item");
        //    string item = Console.ReadLine();
        //    listaDeCompras[1] = item;
        //    Console.WriteLine(listaDeCompras.Length);
            Console.WriteLine("--------------------------------------");
            for (var i = 0; i < listaDeCompras.Length; i++){
                Console.WriteLine(listaDeCompras[i]);
            }
            Console.WriteLine("--------------------------------------");
            for (var i = 0; i < preços.Length; i++){
                Console.WriteLine(preços[i]);
            }
            Console.WriteLine("--------------------------------------");
            for (var i = 0; i < idades.Length; i++){
                Console.WriteLine(idades[i]);
            }

        }
    }
}
