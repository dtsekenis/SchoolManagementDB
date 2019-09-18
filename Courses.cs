using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual_Part_B
{
    public class Courses
    {
        public int CourseID { get; set; }
        public string Title { get; set; }
        public string Stream { get; set; }
        public string Type { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        //public static List<Students> Student = new List<Students>();
        public override string ToString()
        {
            return $"{CourseID}) {Title} || {Stream} || {Type} || {StartDate} || {EndDate}";
        }
    }
}

