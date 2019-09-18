using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Individual_Part_B
{
    public class DbManager
    {
        private readonly string conn_string = @"Data Source=DESKTOP-ST6U8F5\SQLEXPRESS;Initial Catalog=Private_School;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
      
        //public object CourseStudent { get; private set; }

        public List<Students> GetStudents()//Students student
        {
            List<Students> Student = new List<Students>();
            using (SqlConnection conn = new SqlConnection(conn_string))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Student", conn))
                {
                    //Console.Write("Give me a Student: ");
                    //string input = Console.ReadLine();
                    //parameter_cmd.Parameters.Add(new SqlParameter("year", input));
                    cmd.Parameters.Add(new SqlParameter("Student", Convert.ToString(Student)));
                    using (SqlDataReader rdr =cmd.ExecuteReader())
                    {

                        while (rdr.Read())
                        {
                            int studentId = (int)rdr["StudentID"];
                            string firstName = (string)rdr["FirstName"];
                            string lastName = (string)rdr["LastName"];
                            DateTime dateOfBirth = (DateTime)rdr["DateOfBirth"];
                            decimal tuitionFees = (decimal)rdr["TuitionFees"];

                            Students student = new Students()
                            {
                                StudentID = studentId,
                                FirstName = firstName,
                                LastName = lastName, 
                                DateOfBirth = dateOfBirth,
                                TuitionFees = tuitionFees
                            };
                            Student.Add(student);
                            //cool way

                            //todos.Add(new Todo()
                            //{
                            //    Id = (int)rdr["Id"],
                            //    Title = (string)rdr["Title"],
                            //    IsCompleted = (bool)rdr["IsCompleted"]

                            //});
                        }
                    }

                }
            }

            return Student;
        }

        public List<Courses> GetCourses()
        {
            List<Courses> Course = new List<Courses>();
            using (SqlConnection conn = new SqlConnection(conn_string))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Course", conn))
                {
                    cmd.Parameters.Add(new SqlParameter("Course", Convert.ToString(Course)));
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {

                        while (rdr.Read())
                        {
                            int courseId = (int)rdr["CourseID"];
                            string title = (string)rdr["Title"];
                            string stream = (string)rdr["Stream"];
                            string type = (string)rdr["Type"];
                            DateTime startDate = (DateTime)rdr["StartDate"];
                            DateTime endDate = (DateTime)rdr["EndDate"];



                            Courses course = new Courses()
                            {
                                CourseID = courseId,
                                Title = title,
                                Stream = stream,
                                Type = type,
                                StartDate = startDate,
                                EndDate = endDate
                            };
                            Course.Add(course);
                            
                        }
                    }

                }
            }

            return Course;
        }

        public List<Assigments> GetAssigments()
        {
            List<Assigments> Assigment = new List<Assigments>();
            using (SqlConnection conn = new SqlConnection(conn_string))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Assigment", conn))
                {
                    cmd.Parameters.Add(new SqlParameter("Assigment", Convert.ToString(Assigment)));
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {

                        while (rdr.Read())
                        {
                            int assigmentId = (int)rdr["AssigmentID"];
                            string title = (string)rdr["Title"];
                            string description = (string)rdr["Description"];
                            DateTime subDateTime = (DateTime)rdr["SubDateTime"];

                            Assigments assigment = new Assigments()
                            {
                                AssigmentID = assigmentId,
                                Title = title,
                                Description = description,
                                SubDateTime = subDateTime 
                                
                            };
                            Assigment.Add(assigment);

                        }
                    }

                }
            }

            return Assigment;
        }

        public List<Trainers> GetTrainers()
        {
            List<Trainers> Trainer = new List<Trainers>();
            using (SqlConnection conn = new SqlConnection(conn_string))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("Select * From Trainer", conn))
                {
                    cmd.Parameters.Add(new SqlParameter("Trainer", Convert.ToString(Trainer)));
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {

                        while (rdr.Read())
                        {
                            int trainerId = (int)rdr["TrainerID"];
                            string firstName = (string)rdr["FirstName"];
                            string lastName = (string)rdr["LastName"];
                            string subject = (string)rdr["Subject"];

                            Trainers trainer = new Trainers()
                            {
                                TrainerID = trainerId,
                                FirstName=firstName,
                                LastName=lastName,
                                Subject = subject
                               

                            };
                            Trainer.Add(trainer);

                        }
                    }

                }
            }

            return Trainer;
        }

        //using (sqlcommand insert_cmd=new sqlcommand("insert into shippers(companyname,phone)values('peoplecert','2105555555')", conn))
        //        {
        //            int rows_affected = insert_cmd.executenonquery();
        //            console.writeline("{0} rows affected.", rows_affected);
        //        }

        public List<CourseStudents> GetCourseStudents()
        {
            List<CourseStudents> CourseStudent = new List<CourseStudents>();
            using (SqlConnection conn = new SqlConnection(conn_string))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("Select Student.StudentID,Student.FirstName,Student.LastName,Course.Title,Course.CourseID From Student Join CourseStudent On Student.StudentID = CourseStudent.StudentID Join Course On CourseStudent.CourseID = Course.CourseID Group By Student.StudentID,Student.FirstName, Student.LastName, Course.Title, Course.CourseID Having Course.CourseID < 5; ", conn))
                {
                    cmd.Parameters.Add(new SqlParameter("CourseStudent", Convert.ToString(CourseStudent)));
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {

                        while (rdr.Read())
                        {
                            int courseId = (int)rdr["CourseID"];
                            int studentId = (int)rdr["StudentID"];
                            string firstName = (string)rdr["FirstName"];
                            string lastName = (string)rdr["LastName"];
                            string title = (string)rdr["Title"];
                            
                            CourseStudents courseStudent = new CourseStudents()
                            {
                                CourseID = courseId,
                                StudentID = studentId,
                                FirstName = firstName,
                                LastName=lastName,
                                Title = title
                                                                                               
                            };
                            CourseStudent.Add(courseStudent);

                        }
                    }

                }
            }

            return CourseStudent;
        }
        

        public List<CourseAssigments> GetCourseAssigments()
        {
            List<CourseAssigments> CourseAssigment = new List<CourseAssigments>();
            using (SqlConnection conn = new SqlConnection(conn_string))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("Select Course.CourseID,Assigment.AssigmentID,Assigment.Title as [Assigment Title], Course.Title From Assigment Join CourseAssigment On Assigment.AssigmentID= CourseAssigment.CourseID Join Course On CourseAssigment.CourseID= Course.CourseID; ", conn))
                {
                    cmd.Parameters.Add(new SqlParameter("CourseAssigment", Convert.ToString(CourseAssigment)));
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {

                        while (rdr.Read())
                        {
                            int courseId = (int)rdr["CourseID"];
                            int assigmentId = (int)rdr["AssigmentID"];
                            string courseTitle = (string)rdr["Title"];
                            string  assigmentTitle = (string)rdr["Assigment Title"];
                            

                            CourseAssigments courseAssigment = new CourseAssigments()
                            {
                                CourseID=courseId,
                                AssigmentID=assigmentId,
                                Title = courseTitle,
                                AssignmentTitle=assigmentTitle

                            };
                            CourseAssigment.Add(courseAssigment);

                        }
                    }

                }
            }

            return CourseAssigment;
        }

        public List<CourseTrainers> GetCourseTrainers()
        {
            List<CourseTrainers> CourseTrainer = new List<CourseTrainers>();
            using (SqlConnection conn = new SqlConnection(conn_string))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("Select Trainer.FirstName, Trainer.LastName, Course.Title From Trainer Join CourseTrainer On Trainer.TrainerID= CourseTrainer.CourseID Join Course On CourseTrainer.CourseID= Course.CourseID", conn))
                {
                    cmd.Parameters.Add(new SqlParameter("CourseTrainer", Convert.ToString(CourseTrainer)));
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {

                        while (rdr.Read())
                        {

                            string firstName = (string)rdr["FirstName"];
                            string lastName = (string)rdr["LastName"];
                            string title = (string)rdr["Title"];
                            


                            CourseTrainers courseTrainer = new CourseTrainers()
                            {
                                FirstName=firstName,
                                LastName=lastName,
                                Title = title
                                

                            };
                            CourseTrainer.Add(courseTrainer);

                        }
                    }

                }
            }

            return CourseTrainer;
        }

        public List<StudentAssigments> GetStudentAssigments()
        {
            List<StudentAssigments> StudentAssigment = new List<StudentAssigments>();
            using (SqlConnection conn = new SqlConnection(conn_string))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("Select Course.Title, Assigment.Title as [Assignment Title], Student.FirstName, Student.LastName From Assigment Join CourseAssigment On Assigment.AssigmentID= CourseAssigment.CourseID Join Course On CourseAssigment.CourseID= Course.CourseID Join CourseStudent On CourseStudent.CourseID= Course.CourseID Join Student On Student.StudentID= CourseStudent.StudentID", conn))
                {
                    cmd.Parameters.Add(new SqlParameter("StudentAssigment", Convert.ToString(StudentAssigment)));
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {

                        while (rdr.Read())
                        {

                            string title = (string)rdr["Title"];
                            
                            string assignmentTitle = (string)rdr["Assignment Title"];
                            string firstName = (string)rdr["FirstName"];
                            string lastName = (string)rdr["LastName"];



                            StudentAssigments studentAssigment = new StudentAssigments()
                            {
                                CourseTitle = title,
                                AssignmentTitle = assignmentTitle,
                                FirstName=firstName,
                                LastName=lastName


                                
                            };
                            StudentAssigment.Add(studentAssigment);

                        }
                    }

                }
            }

            return StudentAssigment;
        }

        public List<MoreThanOne> GetMoreThanOne()
        {
            List<MoreThanOne> MoreThanOnes = new List<MoreThanOne>();
            using (SqlConnection conn = new SqlConnection(conn_string))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("Select Student.StudentID,Student.FirstName From Student Join CourseStudent On Student.StudentID = CourseStudent.StudentID Join Course On CourseStudent.CourseID = Course.CourseID Group By Student.StudentID, Student.FirstName Having Count(CourseStudent.CourseID) > 1;", conn))
                {
                    cmd.Parameters.Add(new SqlParameter("MoreThanOnes", Convert.ToString(MoreThanOnes)));
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {

                        while (rdr.Read())
                        {

                            int studentId= (int)rdr["StudentID"];                         
                            string firstName = (string)rdr["FirstName"];

                            MoreThanOne moreThanOne = new MoreThanOne()
                            {
                                StudentID = studentId,
                                FirstName = firstName
                               
                            };
                            MoreThanOnes.Add(moreThanOne);

                        }
                    }

                }
            }

            return MoreThanOnes;
        }
        public void InputDataStudent()
        {
            using (SqlConnection conn = new SqlConnection(conn_string))
            {
                conn.Open();
                using (SqlCommand insert_cmd = new SqlCommand("Insert Into Student(FirstName,LastName,DateOfBirth,TuitionFees)Values(@firstName,@lastName,@dateOfBirth,@tuitionFees)", conn))
                {
                    Console.Write("Give me the first name: ");
                    string input = Console.ReadLine();
                    insert_cmd.Parameters.Add(new SqlParameter("@firstName", input));
                    Console.Write("Give me the last name: ");
                    string input1 = Console.ReadLine();
                    insert_cmd.Parameters.Add(new SqlParameter("@lastName", input1));
                    Console.Write("Give me the Date of Birth(yyyy/mm/dd): ");
                    DateTime input2 = DateTime.Parse(Console.ReadLine());
                    insert_cmd.Parameters.Add(new SqlParameter("@dateOfBirth", input2));
                    Console.Write("Give me the Tuition Fees: ");
                    decimal input3 = Convert.ToDecimal(Console.ReadLine());
                    insert_cmd.Parameters.Add(new SqlParameter("@tuitionFees", input3));
                    insert_cmd.ExecuteNonQuery();

                }
            }
        }
        public void InputDataCourses()
        {
            using (SqlConnection conn = new SqlConnection(conn_string))
            {
                using (SqlCommand insert_cmd = new SqlCommand("Insert Into Course(Title,Stream,Type,StartDate,EndDate)Values(@title,@stream,@type,@startDate,@endDate)", conn))
                {
                    Console.Write("Enter Course Title: ");
                    string input = Console.ReadLine();
                    insert_cmd.Parameters.Add(new SqlParameter("@title", input));
                    Console.Write("Enter Course Stream: ");
                    string input1 = Console.ReadLine();
                    insert_cmd.Parameters.Add(new SqlParameter("@stream", input1));
                    Console.Write("Enter Course Type: ");
                    string input2 = Console.ReadLine();
                    insert_cmd.Parameters.Add(new SqlParameter("@type", input2));
                    Console.Write("Enter Course Starting Date(yyyy/mm/dd) : ");
                    DateTime input3 = DateTime.Parse(Console.ReadLine());
                    insert_cmd.Parameters.Add(new SqlParameter("@startDate", input3));
                    Console.Write("Enter Course Ending Date(yyyy/mm/dd) : ");
                    DateTime input4 = DateTime.Parse(Console.ReadLine());
                    insert_cmd.Parameters.Add(new SqlParameter("@endDate", input3));
                    insert_cmd.ExecuteNonQuery();

                }
            }
        }
        public void InputDataAssigments()
        {
            using (SqlConnection conn = new SqlConnection(conn_string))
            {
                using (SqlCommand insert_cmd = new SqlCommand("Insert Into Assigment(Title,Description,SubDateTime)Values(@title,@description,@subDateTime)", conn))
                {
                    Console.Write("Enter Assigment Title: ");
                    string input = Console.ReadLine();
                    insert_cmd.Parameters.Add(new SqlParameter("@title", input));
                    Console.Write("Enter Assigment Description: ");
                    string input1 = Console.ReadLine();
                    insert_cmd.Parameters.Add(new SqlParameter("@description", input1));

                    Console.Write("Enter Assigment Submission Date(yyyy/mm/dd) : ");
                    DateTime input2 = DateTime.Parse(Console.ReadLine());
                    insert_cmd.Parameters.Add(new SqlParameter("@subDateTime", input2));

                    insert_cmd.ExecuteNonQuery();

                }
            }
        }
        public void InputDataTrainers()
        {
            using (SqlConnection conn = new SqlConnection(conn_string))
            {
                using (SqlCommand insert_cmd = new SqlCommand("Insert Into Trainer(FirstName,LastName,Subject)Values(@firstName,@lastName,@subject)", conn))
                {
                    Console.Write("Enter Trainer First Name: ");
                    string input = Console.ReadLine();
                    insert_cmd.Parameters.Add(new SqlParameter("@firstName", input));
                    Console.Write("Enter Trainer Last Name: ");
                    string input1 = Console.ReadLine();
                    insert_cmd.Parameters.Add(new SqlParameter("@lastName", input1));
                    Console.Write("Enter Trainer Subject: ");
                    string input2 = Console.ReadLine();
                    insert_cmd.Parameters.Add(new SqlParameter("@Subject", input2));
                    insert_cmd.ExecuteNonQuery();

                }
            }
        }
//        public static void InputDataStudent()
//        {
//            Console.WriteLine("");
//            Console.Write("Enter the First Name: ");
//            string firstName = Console.ReadLine();
//            Console.Write("Enter the Last Name:");
//            string lastName = Console.ReadLine();
//            Console.Write("Enter your Date of Birth:(yy/mm/dd): ");
//            DateTime dateOfBirth = DateTime.Parse(Console.ReadLine());
//            Console.Write("Enter your Tuitions: ");
//            decimal tuitionFee = Convert.ToDecimal(Console.ReadLine());
//            Console.WriteLine("");

//            Student student = new Student(firstName, lastName, dateOfBirth, tuitionFee);
//            //Student student1 = new Student(firstName, lastName, dateOfBirth, tuitionFee);

//            Student.Students.Add(student);

//            //Student.ShowStudent(student1);
//        }
//        public static void OutputStudentData()
//        {

//            int i = 0;
//            foreach (Student student in Student.Students)
//            {
//                Console.WriteLine($"{i + 1}: {student.firstName} {student.lastName} {student.dateOfBirth} {student.tuitionFees}");
//            }
//        }
//        public static void StudentsPerCourse()
//        {
//            foreach (Student student in Student.Students)
//            {
//                foreach (Course course in student.Courses)
//                {
//                    foreach (Course course1 in Course.Courses)
//                    {
//                        if (course.title == course1.title)
//                        {
//                            Console.WriteLine($"{student.firstName} {student.lastName} has {course.title} ");
//                        }
//                    }
//                }

//            }

//        }
//        public static void MoreThanOneStudent()
//        {
//            foreach (Student student in Student.Students)
//            {

//                if (student.Courses.Count > 1)
//                {
//                    Console.Write($"{student.firstName} {student.lastName}");
//                }
//            }
//        }
//    }
//}


        //public void AddTodo(string title)
        //{
        //    using (SqlConnection conn = new SqlConnection(conn_string))
        //    {
        //        conn.Open();
        //        using (SqlCommand cmd = new SqlCommand("Insert Into Todos(Title) Values(@title)", conn))
        //        {
        //            cmd.Parameters.Add(new SqlParameter("title", title));
        //            cmd.ExecuteNonQuery();
        //        }
        //    }
        //}
        //public void Complete(int id)
        //{
        //    using (SqlConnection conn = new SqlConnection(conn_string))
        //    {
        //        conn.Open();
        //        using (SqlCommand cmd = new SqlCommand("Update Todos set IsCompleted=1 Where Id=@id", conn))
        //        {
        //            cmd.Parameters.Add(new SqlParameter("id", id));
        //            cmd.ExecuteNonQuery();
        //        }
        //    }
        //}
    }
}