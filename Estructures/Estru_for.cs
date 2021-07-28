using System;
using System.Collections.Generic;
using System.Text;

namespace Estructures {
    class Estru_for {
        public int estrutura_for(int numero) {

            Console.WriteLine("Trabalhando com a estrutura For");
            for (int i = 0; i < numero; i++) {
                Console.WriteLine("isso se repetira " + numero + " vezes");
                Console.WriteLine(i);
                // Console.WriteLine(numero);
            }
            return numero;

        }
    }
}
