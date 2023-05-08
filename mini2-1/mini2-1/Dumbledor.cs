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
                Train.AddStudent();
            }
        }

       


        static public void printf()
        {
            /* for (int i = 0; i < 300; i++)
             {
                 if (std1[i].Leter[0] != null)
                 {

                     Console.WriteLine(std1[i].Leter[0]);
                     Console.WriteLine("-------------------------------------------------------------");
                 }
             }*/
            Console.WriteLine(Authorized_Person.baggage[0]);
        }

        

    }
}

