using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual_Part_B
{
    public class CourseStudents
    {
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        
        public override string ToString()
        {
            return $"{CourseID} , {StudentID} ,{FirstName} , {LastName} , {Title}";
        }
    }
}
