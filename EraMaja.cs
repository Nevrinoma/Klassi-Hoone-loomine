using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassi_Hoone_loomine
{
    public class EraMaja : Hoone
    {
        string staatus;
        int pind;
        public EraMaja(int pindala = 50) : base(pindala)
        {

        }

        public Aknad(int numberofrooms = 3) : base(numberofrooms)
        {
            aknad = numberofrooms * 3;
        }

        public salePrice(int price = 76000):base(price)
        {
            SalePrice = price * 0.8;
        }

        public int Suurus
        {
            set
            {
                pind = value;
                if (pind < 50)
                {
                    staatus = "vaike maja";
                }
                else if (pind < 80)
                {
                    staatus = "keskmine maja";
                }
                else if (pind < 120)
                {
                    staatus = "suur maja";
                }
                else
                {
                    staatus = "liiga suur maja";
                }
            }
            get { return pind; }

        }

    }
}
