using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mini2_1
{
    class Room
    {

        public static string[] Pureblood {get;set;}=new string [300];
        public static string[] Halfblood { get; set; } = new string[300];
        public static int[] Purebloodfloor { get; set; } = new int[300];
        public static int[] Purebloodroom { get; set; } = new int[300];
        public static int[] Purebloodbed { get; set; } = new int[300];
        public static int Purebloodfloorf { get; set; } = 1;
        public static int Purebloodroomr { get; set; } = 1;
        public static int Purebloodbedb { get; set; } = 1;
        public static void Kind(string Nameofstudent)
        {
            int number = 0;
                
                        Pureblood[0] = Student.NameOfStudent[number];
                        Room.Setinformationpureblood(0);
                        Room.PrintInformation(0);
            number++;
                    


              
        }
        public static void Setinformationpureblood(int i)
        {
            if(Purebloodbedb==4)
            {
                
                Purebloodroomr++;
                Purebloodbedb = 0;
            }
            else
            {
               
                Purebloodbedb++;
            }
            if(Purebloodroomr==5)
            {
               
                Purebloodfloorf++;
                Purebloodroomr = 0;
            }
           

        }
        public static void PrintInformation(int i)
        {
            Console.WriteLine("your floor is : {0}",Room.Purebloodfloor[i]);
            Console.WriteLine("your room is : {0}", Room.Purebloodroom[i]);
            Console.WriteLine("your bednumber is : {0}", Room.Purebloodbed[i]);
        }
    }
}
