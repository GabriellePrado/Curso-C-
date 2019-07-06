using System;
using System.Collections.Generic;
using System.Text;

namespace Estructures {
    class Estru_if_else {

        public int estru_if_else(int numero) {

            Console.WriteLine("Trabalhando com a estrutura If Else !!!");

            if (numero >= 0) {


                if (numero > 10) {
                    Console.WriteLine("Seu numero é maior que 10 ");
                    if (numero < 20) {
                        Console.WriteLine("Seu numero está entre 10 e 20 ");
                    }
                    if (numero < 30) {
                        Console.WriteLine("Seu numero está entre 20 e 30 ");
                    }
                    if (numero < 40) {
                        Console.WriteLine("Seu numero está entre 30 e 40 ");
                    }
                    if (numero < 50) {
                        Console.WriteLine("Seu numero está entre 40 e 50");
                    }
                    if (numero < 60) {
                        Console.WriteLine("Seu numero está entre 50 e 60");
                    }
                    if (numero < 70) {
                        Console.WriteLine("Seu numero está entre 60 e 70");
                    }
                    if (numero < 80) {
                        Console.WriteLine("Seu numero está entre 70 e 80");
                    }
                    if (numero < 90) {
                        Console.WriteLine("Seu numero está entre 80 e 90");
                    }
                    if (numero < 100) {
                        Console.WriteLine("Seu numero está entre 90 e 100");
                    } else {
                        Console.WriteLine("Desculpe não sei contar tantos numeros !!!");
                    }
                } else {
                    Console.WriteLine("Seu numero é menor que 10");

                }
            } else {
                Console.WriteLine("Digito Invalido!!!");
            }
            return numero;
        }
    }
}
