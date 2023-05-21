using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace mini2_1
{
    class Program
    {

        static void Main(string[] args)
        {

            
           
            using (StreamReader file = new StreamReader("file.tsv.tsv"))
            {
                string ln;


                while ((ln = file.ReadLine()) != null)
                {
                    string[] human = ln.Split('\t').ToArray<string>();

                    /*
                    human[0] = ln;

                    human[1] = ln;
                    human[2] = ln;
                    human[3] = ln;
                    human[4] = ln;
                    human[5] = ln;
                    human[6] = ln;
                    human[7] = ln;
                    human[8] = ln;
                    */
                    Human.SetHuman(human[0], human[1], human[5], human[6]);
                    Human.SetHuman1(human[2], human[3], human[4], human[8]);
                }
                file.Close();
            }
            
            
            Student.Build();
            Human h1 = new Human();
             
            Console.WriteLine("Main thread: starting a timer");
            Timer t = new Timer(ComputeBoundOp, 5, 0, 30000);
            Timer d = new Timer(ComputeBoundUp, 5, 0, 10000);

            Console.WriteLine("Main thread: Doing other work here...");
                while (true)
                {
                    Authorized_Person.Tashkisprint();
                    Authorized_Person.Tashkis();
                }
            Console.ReadKey();
        }
       
            private static void ComputeBoundOp(Object state)
            {
            Train.Timetrain3();
            Train.CheckTrainInt ++;
            }
            private static void ComputeBoundUp(Object state)
            {
            Occultism.TimerOfOccultism();
            }

    }
       
       
    }

