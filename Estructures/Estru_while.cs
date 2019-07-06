using System;
using System.Collections.Generic;
using System.Text;

namespace Estructures {
    class Estru_while {
        public int i;
        public int estrutura_while(int numero) {

            Console.WriteLine("Trabalhando com a estrutura While");
            while (i < numero) {
                Console.WriteLine("isso se repetira " + numero + " vezes");
                Console.WriteLine(i);
                i++;
            }
            return numero;
        }
    }
}
