using System;
using System.Collections.Generic;
using System.Text;

namespace Estructures {
    class Estru_case {
        public void estrutura_case(int numero) {

            int caseSwitch = numero;

            switch (caseSwitch) {
                case 1:
                    Console.WriteLine("Mas pizza é caro !");
                    break;
                case 2:
                    Console.WriteLine("Mas chocolate engorda !");
                    break;
                default:
                    Console.WriteLine(" Invalido !");
                    break;
            }
        }  

    }
}
