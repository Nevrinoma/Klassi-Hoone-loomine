using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassi_Hoone_loomine
{
    public class Hoone 
    { 
    
        public int Pindala { get; set; }
        public Uks uks;
        public int Price { get;set;}
        public int NumberOfRooms{ get;set;}
        public int NumberOfFlors { get;set;}

        public Hoone(int pindala = 200;int price = 76000; int numberofrooms = 3;int numberofflors = 5)
        {
            Pindala = pindala;
            Price = price;
            NumberOfRooms = numberofrooms;
            NumberOfFlors = numberofflors;
        }
        
        public void NaitaInfo()
        {
            Console.WriteLine($"Ma olen hata, minu pindala on {Pindala} m2, price on {Price}, mul on  {NumberOfRooms}");
            
        }
        public void NaitaSaleInfo()
    {
        Console.WriteLine($"Ma olen {status}, mul on {aknad},minu Sale Price on {salePrice}");
    }
        public Uks GetUks()
        {
            return uks;
        }


    }
}
