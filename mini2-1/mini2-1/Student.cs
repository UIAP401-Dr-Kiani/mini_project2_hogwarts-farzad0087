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
        public int PassedOne { get; set; }
        public int Term { get; set; }
        public static int[] CodeOfDorm { get; set; } = new int[300];
        static Student[] Student1 = new Student[200];
        

        public static void Build()
        {
            for(int i=0;i<200;i++)
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
        }
        public static void StudentPortable()
        {
            string EntekabStudentPortable = Console.ReadLine();
            if (EntekabStudentPortable == "1")
            {
                Train.StudentAddStudent();
            }
        }

        
    }
}
