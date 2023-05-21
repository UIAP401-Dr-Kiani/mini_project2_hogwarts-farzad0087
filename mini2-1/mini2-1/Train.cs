using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace mini2_1
{
    class Train
    {
        public string[] Ticket { get; set; } = new string[300];
        static int CodeOfCabin = 1;
        static int CodeOfChair = 1;
        static int MakeStudent = 0;
       public static bool CheckTrain = true;
        public static int CheckTrainInt = 1;
        static Train[] std1 = new Train[300];

        

       
        public static void Timetrain2(int i)
        {
            
            if (CheckTrain ==true)
            {
                
                Student.SendInformationOfStudent(i);
                Console.WriteLine("Have a good trip");
               
            }
            if (CheckTrain == false)
            {
                Console.WriteLine("sorry there is no train please try 2 minutes later");
            }
        }
        public static void Timetrain3()
        {
            if(Train.CheckTrainInt %2==0)
            {
                Train.CheckTrain = false;
            }
            if (Train.CheckTrainInt % 2 != 0)
            {
                Train.CheckTrain = true;
            }



        }
     









        public static void BuildStudent()
        {

            for (int i = 0; i < 300; i++)
            {
                std1[i] = new Train();
            }


        }
        public static void AddStudent()
        {
            Console.Write("Please enter name of student :");
            string NameOfStudent = Console.ReadLine();
            for (int i = 0; i < 300; i++)
            {
                if (NameOfStudent == Human.NameOfHuman[i])
                {
                    if (NameOfStudent == Human.NameOfHuman[i])
                    {
                        

                        std1[i].Ticket[0] = $"Hi {Human.NameOfHuman[i]} Welcome to hogwarts \nyor username is : {Human.UserNameOfHuman[i]}\nyour password is :{Human.PasswordOfHuman[i]}\nyour Cabin code is :{CodeOfCabin}\nypur chaircode is : {CodeOfChair}";
                        
                        CodeOfChair++;
                        if (CodeOfChair == 5)
                        {
                            CodeOfCabin++;
                            CodeOfChair = 1;
                        }
                        
                        MakeStudent++;

                        Console.WriteLine("The invitation sended");
                        Console.WriteLine("-------------------------------------------------------------");
                    }

                }
            }

        }
        
        public static void StudentAddStudent()
        {
            Console.WriteLine("Please enter your name");
            String Username = Console.ReadLine();
           // Console.WriteLine("Please enter your password");
           // String Password = Console.ReadLine();
            for (int i = 0; i < 300; i++)
            {
                if (Username == Human.NameOfHuman[i])
                {
                    //if (Password == Human.PasswordOfHuman[i])
                    //{
                    if (std1[i].Ticket[0] != null)
                    {
                        Console.WriteLine(std1[i].Ticket[0]);
                        Human.Print();
                        Room.Kind(Username);
                        Console.WriteLine("-------------------------------------------------------------");
                        Train.CheckGo(i);

                        Console.WriteLine("-------------------------------------------------------------");
                    }
                    else
                    {
                        Console.WriteLine("sorry you dont have ticket");
                        Student.PrintStudentPortable();
                        Student.StudentPortable();
                        Console.WriteLine("-------------------------------------------------------------");
                    }
                        

                   // }

                }
            }

        }
       public static void CheckGo(int i)
        {
            
            Console.WriteLine("Do you want to get on the train ?");
            Console.WriteLine("1-yes\n2-no");
            string CheckGo = Console.ReadLine();
            if (CheckGo == "1")
            {
                Train.Timetrain2(i);
            }
            if (CheckGo == "2")
            {
            }
            else
            {

            }
            Console.WriteLine("-------------------------------------------------------------");
        }
          

    }
}
