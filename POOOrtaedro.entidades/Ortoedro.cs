using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOOrtaedro.entidades
{
    public class Ortoedro
    {
        public int AristaA{ get; set; }

        public int AristaB { get; set; }

        public int AristaC { get; set; }

        public ColorRelleno Relleno { get; set; }

        public bool validarOrtoedro()
        {
            if (AristaA != AristaB && AristaB != AristaC && AristaA != AristaC )
            {
                return true;
            }
            return false;
        }

        public int GetArea() => 2 * (AristaA * AristaB + AristaB * AristaC + AristaC * AristaA);

        public int GetVolumen() => AristaA * AristaB * AristaC;


    }
}
