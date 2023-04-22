using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mini2_1
{
    class Dumbledor:Authorized_Person
    {
        public static void DunbledorePortablePrint()
        {
            Console.WriteLine("1-Send Letter\t 2-Exit \t 3-Add Student");

        }
        public static void DumbledorPortable()
        {
            string TashkisDumbledor = Console.ReadLine();
            if (TashkisDumbledor == "2")
            {
                Authorized_Person.Tashkisprint();
                Authorized_Person.Tashkis();
            }
            if (TashkisDumbledor == "1")
            {
                
                Authorized_Person.Tashkisprint();
                Authorized_Person.Tashkis();
            }
            if(TashkisDumbledor=="3")
            {

            }
        }

        public static void AddStudent()
        {
            string NameOfStudent = Console.ReadLine();
            for (int i = 0; i < 300; i++)
            {
                if (NameOfStudent==Human.NameOfHuman[i])
                {
                    Console.WriteLine("Hi dear {0}",Human.NameOfHuman[i]);
                }
}
        }




    }
}

