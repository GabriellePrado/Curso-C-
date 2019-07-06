using System;
using System.Globalization;

namespace Estructures {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine(" ----------- Estruturas logicas !!!  ------------");
            Menu escolhaMenu = new Menu();

            Console.WriteLine("Qual estrutura lógica você deseja testar ? ");
            Console.WriteLine(" Escolha uma opção abaixo: ");
            Console.WriteLine(" 1 - While ");
            Console.WriteLine(" 2 - For  ");
            Console.WriteLine(" 3 - If - Else ");
            Console.WriteLine(" 4 - Switch Case");
            Console.WriteLine(" ----------------------------------------------------- ");
            int n = int.Parse(Console.ReadLine());  
            escolhaMenu.menu(n);


        }



        /*string nome = "gabi";
        int idade = 20;
        //signo ideia 
        double saldo = 50;

        Console.WriteLine(" -- Bem Vindo!! --");
        //split
        Console.WriteLine("Digite uma frase: ");

        string frase = Console.ReadLine();
        string[] vetor = frase.Split(' ');

        for (int i = 0; i < vetor.Length; i++) {

            string frase_separada = vetor[i];
            Console.WriteLine("Voce escreveu: " + frase_separada);


        
        Console.WriteLine("Digite seu nome: ");
        nome = Console.ReadLine();
        Console.WriteLine("Digite sua idade: ");
        idade = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite um valor: ");
        saldo = double.Parse(Console.ReadLine());

        saldo = saldo * 55.325;
        //placeholder
        Console.WriteLine("A {0} tem {1} anos e tem {2:F2} reais na conta", nome, idade, saldo);
        //interpolação
        Console.WriteLine($"A {nome} tem {idade} anos e tem {saldo:F2} reais na conta");
        //concatenação
        Console.WriteLine("A " + nome + "tem " + idade + " anos " + "e tem " + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais na conta");


          int a = 0;

          while (a < 100) {

              Console.Write( a + " ");
              a = a + 1;
          }
          if (a == 100) {
              Console.WriteLine(" ");

              Console.WriteLine("SUCESSO!");

          } else {
              Console.WriteLine("FALHOU!!");
          }
          */

    }


}
