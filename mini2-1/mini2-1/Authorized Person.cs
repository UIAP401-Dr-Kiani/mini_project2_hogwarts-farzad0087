using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mini2_1
{
    enum Pet
    {
        rat = 1, cat, raw
    }
    enum Kind
    {
        teacher, student,
    }
    class Authorized_Person : Human
    {
      static  public string CodeOfRoom { get; set; }
       static public bool baggage { get; set; }
     static   public string[] Leter { get; set; } = new string[100];
       

        static public void Tashkisprint()
        {
            Console.WriteLine("                                             Welcome to hugward");
            Console.WriteLine("Please choose one:");
            Console.WriteLine();
            Console.WriteLine("Student(s)\t          Teacher(t)\t        Dumbledor(d)");
        }
        static public void Tashkis()
        {
            string Tashkis = Console.ReadLine();
            if (Tashkis == "s")
            {

            }
            if (Tashkis == "t")
            {
            }
            if (Tashkis == "D")
            {
                Dumbledor.DunbledorePortablePrint();
                Dumbledor.DumbledorPortable();
            }

        }









    }
   


    class Teacher : Authorized_Person
    {
       static public bool SameClass { get; set; }
    }
}

