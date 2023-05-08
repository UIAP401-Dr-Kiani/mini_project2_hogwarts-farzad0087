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
        static public int [] CodeOfRoom { get; set; } = new int [300];
        static public bool[] baggage { get; set; } = new bool[300];
        public string[] Leter { get; set; } = new string[300];
        



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
                Student.PrintStudentPortable();
                Student.StudentPortable();
            }
            if (Tashkis == "t")
            {
                Teacher.PrintPortableOfTeacher();
                Teacher.PortableOfTeacher();
            }
            if (Tashkis == "d")
            {
                Dumbledor.DunbledorePortablePrint();
                Dumbledor.DumbledorPortable();
            }

        }
        public static void SetBagagge(int i)
        { 
            Console.WriteLine("Do you have baggage ?\nYes(0)\nNo(1)");
            int getbaggage=int.Parse(Console.ReadLine());
            if( getbaggage==0 )
            {
                Authorized_Person.baggage[i]= true;
            }
            if(getbaggage == 1)
            {
                Authorized_Person.baggage[i] = false;
            }
        }








    }
  
}

