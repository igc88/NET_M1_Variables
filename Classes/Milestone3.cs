using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_M1 {
    class Milestone3 {
        public void init() {
            int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int aux = numeros[0];
            for (int i = 0; i < numeros.Length - 1; i++) {
                numeros[i] = numeros[i + 1];
            }
            numeros[numeros.Length - 1] = aux;

            Console.Write("{ ");
            for (int i=0; i<numeros.Length;i++) {
                Console.Write(numeros[i] + " ");
            }
            Console.Write("}");
        }
    }
}
