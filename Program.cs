﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassi_Hoone_loomine
{
    static class Program
    {
        static void Main(string[] args)
        {
            EraMaja majake = new EraMaja();
            Inimene mees = new Inimene("Marco");
            majake.uks = new Uks("must");
            mees.hoone = majake;
            mees.NaitaInfo();
            mees.NaitaSaleInfo();





            Console.ReadLine();
        }
    }

}
