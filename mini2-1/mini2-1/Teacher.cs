using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mini2_1
{
    class Teacher:Authorized_Person
    {
        
        public  string NameOfTeacher { get; set; }
        public static string[] FamilyOfTeacher { get; set; } = new string[300];
        




        public static void PrintPortableOfTeacher()
        {
            Console.WriteLine("1-Addunit\n2-watch units\n3-score");
        }
        public static void PortableOfTeacher()
        {
            string Portable = Console.ReadLine();
            if(Portable=="1")
            {
                Lesson.ChooseUnit();
            }
            if (Portable == "2")
            {
                Lesson.PrintlistOfStudentForTeacher();
            }
            if(Portable=="3")
            {
                Student.PointOfLesson();
            }

        }
      





    }
}
