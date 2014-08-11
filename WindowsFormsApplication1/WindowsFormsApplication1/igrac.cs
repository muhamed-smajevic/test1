using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class igrac
    {
        private int a;
        private int b;
        public string ime;
        public igrac (string ime, int a, int b)
        {
            this.ime = ime;
            this.a = a;
            this.b = b;
        }


        public int DajA() { return a; }
        public int DajB() { return b; }
        public string DajIme() { return ime; }
        public int DajRezultat() { return a + b; }
    }
}
