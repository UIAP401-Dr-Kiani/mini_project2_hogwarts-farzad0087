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

    class Sport:Lesson
    {

    }

}
