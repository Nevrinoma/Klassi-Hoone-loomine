using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassi_Hoone_loomine
{
    public class KorteriteMaja : Hoone
    {
        public KorteriteMaja(int numberofflors = 5) : base(numberofflors)
        {
            Console.WriteLine($"Mul on {numberofflors}");
        }
    }
}
