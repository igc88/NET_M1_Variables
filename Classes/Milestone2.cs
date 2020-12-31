using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_M1 {
    class Milestone2 {
        public void init() {
            double number = 1.2345;
            float f = (float)number;
            int i = (int)number;
            string s=number.ToString();

            Console.WriteLine("Float: {0}", f);
            Console.WriteLine("Int: {0}", i);
            Console.WriteLine("String: {0}", s);
        }
    }
}
