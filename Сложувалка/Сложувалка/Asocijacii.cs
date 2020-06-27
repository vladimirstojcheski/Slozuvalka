using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сложувалка
{
    class Asocijacii
    {
        public Dictionary<String[], String[]> A { get; set; }
        public Dictionary<String[], String[]> B { get; set; }
        public Dictionary<String[], String[]> V { get; set; }
        public Dictionary<String[], String[]> G { get; set; }
        public String[] final { get; set; }

        public Asocijacii(Dictionary<String[], String[]> A,
            Dictionary<String[], String[]> B, Dictionary<String[], String[]> V,
            Dictionary<String[], String[]> G, String[] final)
        {
            this.A = A;
            this.B = B;
            this.V = V;
            this.G = G;
            this.final = final;
        }

    }
}
