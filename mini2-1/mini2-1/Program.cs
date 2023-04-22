using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    Human.SetHuman(human[0]);
                }
                file.Close();
            }

            // Authorized_Person.Tashkisprint();
            // Authorized_Person.Tashkis();


            // Console.WriteLine(Human.NameOfHuman[0]);
            // Console.WriteLine(Human.NameOfHuman[1]);
            Dumbledor.AddStudent();

            Console.ReadKey();
        }
       
       
    }
}
