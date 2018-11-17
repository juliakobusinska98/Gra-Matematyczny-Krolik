using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matematyczny_Krolik
{
    public class Class1
    {
        public int x;
        public int y;
        public Class1(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public void Losowanie()
        {

            Random rnd = new Random();
            x = rnd.Next(100);
            y = rnd.Next(100);
        }

        
    }
}
