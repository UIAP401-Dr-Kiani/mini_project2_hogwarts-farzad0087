using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mini2_1
{
    class Lesson
    {
        static public int TimeOfLesson { get; set; }
        public int NumberOfStudent { get; set; }
        public int Capacity { get; set; }
        public int PresentationSemester { get; set; }
        public string NameOfLesson { get; set; }
        


        static List<string> Leasson1 = new List<string>();
        static Lesson[] Lessons = new Lesson[100];
        static Lesson[] Lessons2 = new Lesson[100];
        List<string> shimi = new List<string>();
        List<string> jado1 = new List<string>();
        List<string> jado2 = new List<string>();
        List<string> jado3 = new List<string>();
        List<string> jado4 = new List<string>();
        List<string> sport = new List<string>();

        public static void BuildTeacher()
        {
            for (int i = 0; i < 79; i++)
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

            for (int i = 0; i < 79; i++)
            {

                if (FamilyOfTeacher == Teacher.FamilyOfTeacher[i])
                {

                    ChooseUnit2();

                    Lesson.SetUnitForTeacher(FamilyOfTeacher, i);
           


                }

            }

        }
        public static void ChooseUnit2()
        {
            Console.WriteLine("Please choose unit ");
            Lesson.PrintSetUnitForTeacher();




        }
        public static void SetUnitForTeacher(String NameOfTeacher, int Code)
        {
            Console.WriteLine("salam");
            string NumberOfChoose = Console.ReadLine();
            if (NumberOfChoose == "1")
            {
                Leasson1.Add($"{NameOfTeacher} Have shimi class\nCode{Code}");
                //Console.WriteLine(Lessons[Code].shimi[0]);

            }
            if (NumberOfChoose == "2")
            {
                Leasson1.Add($"{NameOfTeacher} Have jado1 class\nCode{Code + 100}");
              //  Console.WriteLine(Lessons[Code].jado1[0]);

            }
            if (NumberOfChoose == "3")
            {
                Leasson1.Add($"{NameOfTeacher} Have jado2 class\nCode{Code + 200}");
              //  Console.WriteLine(Lessons[Code].jado2[0]);

            }
            if (NumberOfChoose == "4")
            {
                Leasson1.Add($"{NameOfTeacher} Have jado3 class\nCode{Code + 300}");
                Console.WriteLine(Lessons[Code].jado3[0]);

            }
            if (NumberOfChoose == "5")
            {
                Leasson1.Add($"{NameOfTeacher} Have jado4 class\nCode{Code + 400}");
               // Console.WriteLine(Lessons[Code].jado4[0]);

            }
            if (NumberOfChoose == "6")
            {
                Leasson1.Add($"{NameOfTeacher} Have sport class\nCode{Code + 500}");
               // Console.WriteLine(Lessons[Code].sport[0]);

            }

        }

        public static void PrintUnits()
        {
            int CodeNumber = 1;
            
            foreach(var item in Leasson1)
            {
                Console.Write("{0}-",CodeNumber);
                Console.WriteLine(item);
                CodeNumber++;
            }
           


        }
        public static void CooseUnitForStudent1(string NameOfStudent,int i)
        {
            Lesson.PrintUnits();
            Console.WriteLine("Please enter code of unit");
            int CodeOfUnit = int.Parse(Console.ReadLine());
            if(CodeOfUnit<100)
            {
                Lessons[CodeOfUnit].shimi.Add(NameOfStudent);
                Student.Tashkhisshimi(i);

            }
            if (CodeOfUnit > 100&&CodeOfUnit<200)
            {
                Lessons[CodeOfUnit-100].jado1.Add(NameOfStudent);
                Student.TashkhisJado1(i);
            }
            if (CodeOfUnit > 200 && CodeOfUnit < 300)
            {
                Lessons[CodeOfUnit - 200].jado2.Add(NameOfStudent);
                Student.TashkhisJado2(i);

            }
            if (CodeOfUnit > 300 && CodeOfUnit < 400)
            {
                Lessons[CodeOfUnit - 300].jado3.Add(NameOfStudent);
                Student.TashkhisJado3(i);

            }
            if (CodeOfUnit > 400 && CodeOfUnit <500)
            {
                Lessons[CodeOfUnit - 400].jado4.Add(NameOfStudent);
                Student.TashkhisJado4(i);

            }
            if (CodeOfUnit > 500 && CodeOfUnit < 600)
            {
                Lessons[CodeOfUnit - 500].sport.Add(NameOfStudent);
                Student.TashkhisSport(i);


            }
            Human.Print();
        }
        public static void PrintlistOfStudentForTeacher()
        {
            Lesson.PrintUnits();
            Console.WriteLine("Please enter code of unit");
            int CodeOfUnit = int.Parse(Console.ReadLine());
            if (CodeOfUnit < 100)
            {
                foreach (var item in Lessons[CodeOfUnit].shimi)
                {
                    if (item != null)
                    {
                        Console.WriteLine(item);
                    }
                }

            }
            if (CodeOfUnit > 100 && CodeOfUnit < 200)
            {
                foreach (var item in Lessons[CodeOfUnit].jado1)
                {
                    Console.WriteLine(Lessons[CodeOfUnit].jado1);
                }

            }
            if (CodeOfUnit > 200 && CodeOfUnit < 300)
            {
                foreach (var item in Lessons[CodeOfUnit].jado2)
                {
                    Console.WriteLine(item);
                }


            }
            if (CodeOfUnit > 300 && CodeOfUnit < 400)
            {
                foreach (var item in Lessons[CodeOfUnit].jado3)
                {
                    Console.WriteLine(item);
                }


            }
            if (CodeOfUnit > 400 && CodeOfUnit < 500)
            {
                foreach (var item in Lessons[CodeOfUnit].jado4)
                {
                    Console.WriteLine(item);
                }


            }
            if (CodeOfUnit > 500 && CodeOfUnit < 600)
            {
                foreach (var item in Lessons[CodeOfUnit].sport)
                {
                    Console.WriteLine(item);
                }



            }
            Human.Print();
        }
        public static void Deleteunit(int i)
        {
            if(i==1)
            {
            
            }
        }
        




    }

    class Chemistry:Lesson

    {

    }

    class Jado:Lesson
    {


    }

    class Occultism:Lesson
    {
        public static void PrintoccultismPortble()
        {
            Console.WriteLine("1-see occultism");
        }
        public static void Occultimportable()
        {
            string Number = Console.ReadLine();
            if(Number=="1")
            {
                Occultism.Printoccultism();
            }
        }
        public static int OcuultismTerm1 { get; set; } = 0;
        public static int OcuultismTerm2 { get; set; } = 0;
        public static int OcuultismTerm3 { get; set; } = 0;
        public static int OcuultismTerm4 { get; set; } = 0;
      public static void TimerOfOccultism()
        {
            OcuultismTerm1++;
            OcuultismTerm2++;
            OcuultismTerm3++;
            OcuultismTerm4++;

        }
        public static void Printoccultism()
        {
            Console.WriteLine("Number of occultism 1 : {0}",OcuultismTerm1);
            Console.WriteLine("Number of occultism 2 : {0}", OcuultismTerm2);
            Console.WriteLine("Number of occultism 3 : {0}", OcuultismTerm3);
            Console.WriteLine("Number of occultism 4 : {0}", OcuultismTerm4);
        }

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
