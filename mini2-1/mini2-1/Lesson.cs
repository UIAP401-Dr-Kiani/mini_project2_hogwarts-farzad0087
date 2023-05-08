using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mini2_1
{
    class Lesson
    {
        public int TimeOfLesson { get; set; }
       public int NumberOfStudent { get; set; }
         public int Capacity { get; set; }
        public int PresentationSemester { get; set; }
public string NameOfLesson { get; set; }
        
      
       static List<string> Leasson1 = new List<string>();
        static Lesson[] Lessons = new Lesson[100];
        List<string> shimi = new List<string>();
        List<string> jado1 = new List<string>();
        List<string> jado2 = new List<string>();
        List<string> jado3 = new List<string>();
        List<string> jado4 = new List<string>();
        List<string> sport = new List<string>();

        public static void BuildTeacher()
        {
            for (int i = 0; i <100; i++)
            {
                Lessons[i] = new Lesson();
            }
        }



        
        
        public static void PrintSetUnitForTeacher()
        {

            Console.WriteLine("1-shimi\n2-jado1\n3-jado2\n4-jado3\n5-jado4\n6-sport");
         

        }
        public static void ChooseUnit()
        {
            Console.WriteLine("Please enter your family");
            String FamilyOfTeacher = Console.ReadLine();

            for (int i = 0; i < 300; i++)
            {
                if (FamilyOfTeacher==Teacher.FamilyOfTeacher[i])
                {

                    ChooseUnit2();

                    Lesson.SetUnitForTeacher(FamilyOfTeacher,i);
                    

                }

            }

        }
        public static void ChooseUnit2()
        {
            Console.WriteLine("Please choose unit ");
            Lesson.PrintSetUnitForTeacher();
           
         
            

        }
        public static void SetUnitForTeacher(String NameOfTeacher,int Code)
        {
            Console.WriteLine("salam");
            string NumberOfChoose = Console.ReadLine();
            if (NumberOfChoose == "1")
            {
                Lessons[Code].shimi.Add($"{NameOfTeacher} Have shimi class\nCode{Code}");
                Console.WriteLine(Lessons[Code].shimi[0]);

            }
            if (NumberOfChoose == "2")
            {
                Lessons[Code].jado1.Add($"{NameOfTeacher} Have jado1 class\nCode{Code+100}");
                Console.WriteLine(Lessons[Code].jado1[0]);

            }
            if (NumberOfChoose == "3")
            {
                Lessons[Code].jado2.Add($"{NameOfTeacher} Have jado2 class\nCode{Code+200}");
                Console.WriteLine(Lessons[Code].jado2[0]);

            }
            if (NumberOfChoose == "4")
            {
                Lessons[Code].jado3.Add($"{NameOfTeacher} Have jado3 class\nCode{Code+300}");
                Console.WriteLine(Lessons[Code].jado3[0]);

            }
            if (NumberOfChoose == "5")
            {
                Lessons[Code].jado4.Add($"{NameOfTeacher} Have jado4 class\nCode{Code+400}");
                Console.WriteLine(Lessons[Code].jado4[0]);

            }
            if (NumberOfChoose == "6")
            {
                Lessons[Code].sport.Add($"{NameOfTeacher} Have sport class\nCode{Code+500}");
                Console.WriteLine(Lessons[Code].sport[0]);

            }

        }



    }

    class Chemistry:Lesson

    {

    }

    class Botanical:Lesson
    {

    }

    class Occultism:Lesson
    {

    }

    class Sport : Lesson
    {
       static List<string> Sport1 = new List<string>();
        public static void SetTerm1()
        {
            for (int i = 0; i < 50; i++)
            {
                Sport1.Add(Student.NameOfStudent[i]);
            }
        }

        public static void Print()
        {
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine(Sport1[i]);
            }
        }
    }

}
