using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace Estructures {
    class Menu {

        public void menu(int numero) {

            int escolha = numero;

            switch (escolha) {
                case 1:
                    Estru_while ew = new Estru_while();
                    Console.WriteLine("Insira um numero: ");
                    int n1 = int.Parse(Console.ReadLine());
                    ew.estrutura_while(n1);
                    break;
                case 2:
                    Estru_for ef = new Estru_for();
                    Console.WriteLine("Insira um numero: ");
                    int n2 = int.Parse(Console.ReadLine());
                    ef.estrutura_for(n2);
                    break;
                case 3:
                    Estru_if_else eif = new Estru_if_else();
                    Console.WriteLine("Insira um numero: ");
                    int n3 = int.Parse(Console.ReadLine());
                    eif.estru_if_else(n3);

                    break;

                case 4:
                    Estru_case ec = new Estru_case();
                    Console.WriteLine("Escolha uma opção: ");
                    Console.WriteLine("1 - Você gosta de pizza! ");
                    Console.WriteLine("2 - Você gosta de chocolate! ");
                    int n4 = int.Parse(Console.ReadLine());
                    ec.estrutura_case(n4);
                    break;

                default:
                    Console.WriteLine("Default case");
                    break;
            }
           
        }
    }
}
