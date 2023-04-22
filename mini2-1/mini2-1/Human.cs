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
        static public string FamilyOfHuman { get; set; }
        static public string DateOfBirthday { get; set; }
        static public string GenderOfHuman { get; set; }
        static public string FatherNameOfHuman { get; set; }
        static public string UserNameOfHuman { get; set; }
        static public string PasswordOfHuman { get; set; }
        static public string RoleOfHuman { get; set; }
       static int i = 0;
       
        public static void SetHuman(string name)
        {
            
                Human.NameOfHuman[i] = name;
            i++;
        }



    }
}
