using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mini2_1
{
    class Human
    {
        static public string[] NameOfHuman { get; set; } = new string[300];
        static public string[] FamilyOfHuman { get; set; } = new string[300];
        static public string[] DateOfBirthday { get; set; } = new string[300];
        static public string[] GenderOfHuman { get; set; } = new string[300];
        static public string[] FatherNameOfHuman { get; set; } = new string[300];
        static public string[] UserNameOfHuman { get; set; } = new string[300];
        static public string[] PasswordOfHuman { get; set; } = new string[300];
        static public string[] RoleOfHuman { get; set; } = new string[300];
        static int Sethuman = 0;
        static int Sethuman1 = 0;
       
        static int x = 0;
    

        static IList<string> StudentLIst = new List<string>();
        public Human()
        {
            
            Train.BuildStudent();
            Human.SendInformationOfTeacher();
            Lesson.BuildTeacher();
          
           
            
        }

     public static void SetHuman(string name,string family,string username,string password)
        {
            
                Human.NameOfHuman[Sethuman] = name;
            Human.FamilyOfHuman[Sethuman]= family;
            Human.UserNameOfHuman[Sethuman]= username;
            Human.PasswordOfHuman[Sethuman]= password;
           
            
            Sethuman++;
        }
        public static void SetHuman1( string date, string gender, string father, string role)
        {

           
            Human.DateOfBirthday[Sethuman1] = date;
            Human.GenderOfHuman[Sethuman1] = gender;
            Human.FatherNameOfHuman[Sethuman1] = father;
            Human.RoleOfHuman[Sethuman1] = role;
            
            Sethuman1++;
            
        }
        public static void SendInformationOfStudent(int i)
        {
           
            
                if (Human.RoleOfHuman[i] == "student")
                {
                    
                        
                        Student.NameOfStudent[x] = NameOfHuman[i];
                        Student.FamilyOfStudent[x] = FamilyOfHuman[i];
                        Student.DateOfStudent[x] = DateOfBirthday[i];
                        Student.GenderOfStudent[x] = GenderOfHuman[i];
                        Student.FatherNameOfStudent[x] = FatherNameOfHuman[i];
                        Student.UserNameOfStudent[x] = UserNameOfHuman[i];
                        Student.PasswordOfStudent[x] = PasswordOfHuman[i];
                        Student.RoleOfStudent[x] = RoleOfHuman[i];
                        x++;
                       
                   
                    
                   
                    
                    
               
            }
            }
        public static void SendInformationOfTeacher()
        {
            int i = 0;
            for (int y = 0; y < 300; y++)
            {

                if (Human.RoleOfHuman[y] == "teacher")
                {
                    Teacher.FamilyOfTeacher[i] = FamilyOfHuman[y];

                    i++;

                }
            }
        }
      
        public static void Print()
        {
            Console.WriteLine("-------------------------------------------------------------");
        }




    }
       

    }

