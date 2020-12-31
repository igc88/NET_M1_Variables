using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_M1 {
    class Milestone1 {
        public void fase1() {
            string nombre = "Iago";
            string apellido1 = "González";
            string apellido2 = "Contreras";

            int dia = 12;
            int mes = 1;
            int any = 1988;

            Console.WriteLine("{0} {1} {2}", nombre, apellido1, apellido2);
            Console.WriteLine("{0}/{1}/{2}", dia, mes, any);
        }

        public void fase23() {
            const int anyTraspas = 1948;
            int contador = 0;

            bool cumpleTraspas = false;

            string bisiesto = "El año de nacimiento es bisiesto.";
            string noBisiesto = "El año de mi nacimiento NO es bisiesto.";

            Console.WriteLine("Años bisestos entre 1948 y 1988: ");

            for (int i=anyTraspas; i<=1988; i++) {
                if (DateTime.IsLeapYear(i)) {
                    if (i == 1988) cumpleTraspas = true;

                    Console.WriteLine(i);

                    contador++;
                };
            }

            Console.WriteLine("Entre {0} y {1} hay {2} años bisiestos.", anyTraspas, 1988, contador);

            if (cumpleTraspas) {
                Console.WriteLine(bisiesto); 
            } else {
                Console.WriteLine(noBisiesto);
            };
        }

        public void fase4() {
            string nombre = "Iago González Contreras";
            string fechaNacimiento = "12/01/1988";

            string bisiesto = "El año de nacimiento es bisiesto.";
            string noBisiesto = "El año de mi nacimiento NO es bisiesto.";

            Console.WriteLine("Mi nombre es: {0}", nombre);
            Console.WriteLine("Nací el {0}", fechaNacimiento);

            if (DateTime.IsLeapYear(1988)) {
                Console.WriteLine(bisiesto);
            } else {
                Console.WriteLine(noBisiesto);
            };
        }
    }
}
