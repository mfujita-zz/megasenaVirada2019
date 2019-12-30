using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaSenaEstatisticas
{
    class Dados
    {
        public int b1 { get; set; }
        public int b2 { get; set; }
        public int b3 { get; set; }
        public int b4 { get; set; }
        public int b5 { get; set; }
        public int b6 { get; set; }

        public Dados(int _b1, int _b2, int _b3, int _b4, int _b5, int _b6)
        {
            b1 = _b1;
            b2 = _b2;
            b3 = _b3;
            b4 = _b4;
            b5 = _b5;
            b6 = _b6;
        }
    }
}
