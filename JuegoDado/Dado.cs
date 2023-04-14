using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuegoDado
{
    class Dado
    {
        private static Random random = new Random();

        public static int Lanzar()
        {
            return random.Next(1, 7);
        }
    }
}
