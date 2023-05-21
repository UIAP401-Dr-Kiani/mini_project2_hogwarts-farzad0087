using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mini2_1
{
    class Student : Authorized_Person
    {
        static public string[] NameOfStudent { get; set; } = new string[300];
        static public string[] FamilyOfStudent { get; set; } = new string[300];

        static public string[] DateOfStudent { get; set; } = new string[300];
        static public string[] GenderOfStudent { get; set; } = new string[300];
        static public string[] FatherNameOfStudent { get; set; } = new string[300];
        static public string[] UserNameOfStudent { get; set; } = new string[300];
        static public string[] PasswordOfStudent { get; set; } = new string[300];
        static public string[] RoleOfStudent { get; set; } = new string[300];
        public int[] PassedOne { get; set; } = new int[300];
        public int[] Term { get; set; } = new int[300];
        public static int[] CodeOfDorm { get; set; } = new int[300];
        static Student[] Student1 = new Student[200];
        public int ShimiPoint { get; set; }
        public int Jado1Point { get; set; }
        public int Jado2Point { get; set; }
        public int Jado3Point { get; set; }
        public int Jado4Point { get; set; }
        public int SportPoint { get; set; }
        public bool ShimiPointb { get; set; } = false;
        public bool Jado1Pointb { get; set; } = false;
        public bool Jado2Pointb { get; set; } = false;
        public bool Jado3Pointb { get; set; } = false;
        public bool Jado4Pointb { get; set; } = false;
        public bool SportPointb { get; set; } = false;




        public static void Build()
        {

            for (int i = 0; i < 200; i++)
            {
                Student1[i] = new Student();

            }
        }
        public void AddStudent()
        {
            Console.WriteLine("Please Enter Name Of Student:");
            string NameOfStudent = Console.ReadLine();

        }
        public static void PrintStudentPortable()
        {
            Console.WriteLine("1-Students");
            Console.WriteLine("2-choose unit\n3-see score");
        }
        public static void StudentPortable()
        {
            string EntekabStudentPortable = Console.ReadLine();
            if (EntekabStudentPortable == "1")
            {
                
                Train.StudentAddStudent();
            }
            if (EntekabStudentPortable == "2")
            {
                Student.StudentAddStudentForUnit();
            }
            if (EntekabStudentPortable == "3")
            {

                Student.Printscore();
            }
        }
        public static void StudentAddStudentForUnit()
        {
            Console.WriteLine("Please enter your name");
            String Username = Console.ReadLine();
            // Console.WriteLine("Please enter your password");
            // String Password = Console.ReadLine();
            for (int i = 0; i < 300; i++)
            {
                if (Username == Student.NameOfStudent[i])
                {
                    Lesson.CooseUnitForStudent1(Student.NameOfStudent[i], i);
                    Console.WriteLine(i);
                }
            }
        }

        public static void PrintUnitsForStudents()
        {
            Lesson.PrintUnits();

        }
        public static void PrintPointOfLesson()
        {
            Console.WriteLine("1-Shimi\n2-jado1\n3-jado2\n4-jado3\n5-jado4\n6-sport");
        }
        public static void PointOfLesson()
        {
            Console.WriteLine("Please enter name of teacher");
            string Nameofteacher = Console.ReadLine();
            Console.WriteLine("Please enter name of student");
            string NameOfStudent1 = Console.ReadLine();
            for (int y = 0; y < 300; y++)
            {
                if(Nameofteacher==Teacher.FamilyOfTeacher[y])
                { 
                for (int i = 0; i < 300; i++)
                {
                    if (NameOfStudent1 == NameOfStudent[i])
                    {

                        Student.PrintPointOfLesson();
                        Console.WriteLine("Choose one");
                        string Chooseone = Console.ReadLine();

                        if (Chooseone == "1")
                        {
                            Student1[i].ShimiPoint = int.Parse(Console.ReadLine());

                            Console.WriteLine("OK");
                        }
                        if (Chooseone == "2")
                        {
                            Student1[i].Jado1Point = int.Parse(Console.ReadLine());

                            Console.WriteLine("OK");
                        }
                        if (Chooseone == "3")
                        {
                            Student1[i].Jado2Point = int.Parse(Console.ReadLine());

                            Console.WriteLine("OK");
                        }
                        if (Chooseone == "4")
                        {
                            Student1[i].Jado3Point = int.Parse(Console.ReadLine());

                            Console.WriteLine("OK");
                        }
                        if (Chooseone == "5")
                        {
                            Student1[i].Jado4Point = int.Parse(Console.ReadLine());

                            Console.WriteLine("OK");
                        }
                        if (Chooseone == "6")
                        {
                            Student1[i].SportPoint = int.Parse(Console.ReadLine());

                            Console.WriteLine("OK");
                        }

                    }

                }

            }
        }
    }
        public static void Printscore()
        {
            Console.WriteLine("Please enter name of student");
            string NameOfStudent1 = Console.ReadLine();
            for (int i = 0; i < 300; i++)
            {
                if (NameOfStudent1 == NameOfStudent[i])
                {


                    if (Student1[i].ShimiPointb == true)
                    {
                        Console.WriteLine("your shimi score is : {0} ", Student1[i].ShimiPoint);
                        
                    }
                    if (Student1[i].Jado1Pointb == true)
                    {

                        Console.WriteLine("your jado1 score is : {0} ", Student1[i].Jado1Point);
                        
                    }
                    if (Student1[i].Jado2Pointb == true)
                    {
                        Console.WriteLine("your jado2 score is : {0} ", Student1[i].Jado2Point);
                        
                    }
                    if (Student1[i].Jado3Pointb == true)
                    {

                        Console.WriteLine("your jado3 score is : {0} ", Student1[i].Jado3Point);
                        
                    }
                    if (Student1[i].Jado4Pointb == true)
                    {

                        Console.WriteLine("your jado4 score is : {0} ", Student1[i].Jado4Point);
                       
                    }
                    if (Student1[i].SportPointb ==true)
                    {
                        Console.WriteLine("your sport score is : {0} ", Student1[i].SportPoint);
                        
                    }
             
                  
                    



                }

            }

        }
       public static void Tashkhisshimi(int i)
        {
            Student1[i].ShimiPointb = true;
        }
        public static void TashkhisJado1(int i)
        {
            Student1[i].Jado1Pointb = true;
        }
        public static void TashkhisJado2(int i)
        {
            Student1[i].Jado2Pointb = true;
        }
        public static void TashkhisJado3(int i)
        {
            Student1[i].Jado3Pointb = true;
        }
        public static void TashkhisJado4(int i)
        {
            Student1[i].Jado4Pointb = true;
        }
        public static void TashkhisSport(int i)
        {
            Student1[i].SportPointb = true;
        }










    }
}
