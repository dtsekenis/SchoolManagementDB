using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual_Part_B
{
    class Program
    {
        static void Main(string[] args)
        {
            DbManager db = new DbManager();
            int option1, option2, option3;
            string answer;
            
            //db.InputDataCourses();
            //db.InputDataAssigments();
            //db.InputDataTrainers();

            //List<Courses> c = db.GetCourses();

            //Console.WriteLine("--courses list--");
            //foreach (var item in c)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine();

            //List<Assigments> ass = db.GetAssigments();

            //Console.WriteLine("--assigments list--");
            //foreach (var item in ass)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine();

            //List<Trainers> t = db.GetTrainers();

            //Console.WriteLine("--trainers list--");
            //foreach (var item in t)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine();

            //List<CourseStudents> cd = db.GetCourseStudents();

            //Console.WriteLine("--students per courses--");
            //foreach (var item in cd)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine();

            //List<CourseAssigments> ca = db.GetCourseAssigments();

            //Console.WriteLine("--assigments per courses--");
            //foreach (var item in ca)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine();

            //List<CourseTrainers> ct = db.GetCourseTrainers();

            //Console.WriteLine("--trainers per courses--");
            //foreach (var item in ct)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine();

            //List<StudentAssigments> sa = db.GetStudentAssigments();

            //Console.WriteLine("--assigments per courses per students--");
            //foreach (var item in sa)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine();

            //Console.WriteLine("--students in more than 1 course--");
            //foreach (var item in sco)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine();

            do
                {
                    do
                    {
                        Console.WriteLine("");
                        Console.WriteLine("1) Create an Entry: ");
                        Console.WriteLine("2) Preview Entries: ");
                        Console.WriteLine("3) Exit: ");

                        Console.Write("Choose an option: ");
                    } while (!int.TryParse(Console.ReadLine(), out option1));

                        MainMenu mainMenu = (MainMenu)option1;

                        switch (mainMenu)
                        {


                            case MainMenu.AddEntity:
                    
                            do
                            {
                                do
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("1) Create a new Student: ");
                                    Console.WriteLine("2) Create a new Course: ");
                                    Console.WriteLine("3) Create a new Trainer: ");
                                    Console.WriteLine("4) Create a new Assigment: ");
                                    Console.WriteLine("5) Previous Menu<== ");

                                    Console.Write("Choose an option: ");

                                } while (!int.TryParse(Console.ReadLine(), out option2));

                                AddEntity addEntity = (AddEntity)option2;

                                switch (addEntity)
                                {
                                    case AddEntity.AddStudent:
                                        db.InputDataStudent();
                                        break;
                                    case AddEntity.AddCourse:
                                        db.InputDataCourses();
                                        //Console.WriteLine("2) Create a new Course ");
                                        break;
                                    case AddEntity.AddTrainer:
                                        db.InputDataTrainers();
                                        //Console.WriteLine("3) Create a new Trainer ");
                                        break;
                                   case AddEntity.AddAssigment:
                                        db.InputDataAssigments();
                                        //Console.WriteLine("4) Create a new Assigment ");
                                        break;
                                    case AddEntity.PreviousMenu:
                                        break;
                                }
                            } while (option2 != 5);
                            break;
                       
                        case MainMenu.ShowData:
                            //Console.WriteLine("2) Preview ");
                            do
                            {
                                do
                                {
                                    Console.WriteLine("1) Show me Students: ");
                                    Console.WriteLine("2) Show me Course: ");
                                    Console.WriteLine("3) Show me Trainers: ");
                                    Console.WriteLine("4) Show me Assigments: ");
                                    Console.WriteLine("5) Previous Menu<== ");

                                    Console.Write("Choose an option: ");
                                } while (!int.TryParse(Console.ReadLine(), out option3));

                                ShowData showData = (ShowData)option3;

                                switch (showData)
                                {
                                    case ShowData.ShowStudent:
                                        Console.WriteLine("");
                                        List<Students> s = db.GetStudents();

                                       Console.WriteLine("--students list--");
                                        foreach (var item in s)
                                        {
                                            Console.WriteLine(item);
                                        }

                                        Console.WriteLine("");
                                        Console.WriteLine("Students per Course: ");
                                        List<CourseStudents> cd = db.GetCourseStudents();

                                        //Console.WriteLine("--students per courses--");
                                        foreach (var item in cd)
                                        {
                                            Console.WriteLine(item);
                                        }
                                        Console.WriteLine();

                                    //Student.StudentsPerCourse();
                                    
                                        Console.WriteLine("More than one Student per Course: ");
                                        Console.WriteLine(" ");
                                    List<MoreThanOne> sco = db.GetMoreThanOne();
                                    //Console.WriteLine("--students in more than 1 course--");
                                    foreach (var item in sco)
                                    {
                                        Console.WriteLine(item);
                                    }
                                    Console.WriteLine();
                                    //Student.MoreThanOneStudent();
                                    Console.Write("");
                                        break;
                                   case ShowData.ShowCourse:
                                        Console.WriteLine("");

                                    List<Courses> c = db.GetCourses();

                                    Console.WriteLine("--courses list--");
                                    foreach (var item in c)
                                    {
                                        Console.WriteLine(item);
                                    }
                                    Console.WriteLine();
                                    Console.WriteLine("");
                                        break;
                                   case ShowData.ShowTrainer:
                                    List<Trainers> t = db.GetTrainers();

                                    Console.WriteLine("--trainers list--");
                                    foreach (var item in t)
                                    {
                                        Console.WriteLine(item);
                                    }
                                    Console.WriteLine();

                                    List<CourseTrainers> ct = db.GetCourseTrainers();

                                    Console.WriteLine("--trainers per courses--");
                                    foreach (var item in ct)
                                    {
                                        Console.WriteLine(item);
                                    }
                                    Console.WriteLine();

                                    //Trainer.OutputTrainerData();
                                    //Trainer.TrainersPerCourse();
                                    break;
                                    case ShowData.ShowAssigment:
                                    //Assigment.OutputAssigmentData();
                                    List<Assigments> ass = db.GetAssigments();

                                    Console.WriteLine("--assigments list--");
                                    foreach (var item in ass)
                                    {
                                        Console.WriteLine(item);
                                    }
                                    Console.WriteLine();
                                    Console.WriteLine("");
                                    //Console.WriteLine(" Assigments Per Course Per Student: ");
                                    List<CourseAssigments> ca = db.GetCourseAssigments();

                                    Console.WriteLine("--assigments per courses--");
                                    foreach (var item in ca)
                                    {
                                        Console.WriteLine(item);
                                    }
                                    Console.WriteLine();
                                    
                                     //Assigment.AssigmentsPerCourse();
                                  
                                     //Console.WriteLine(" Assigments Per Student: ");

                                    Console.WriteLine("");
                                    //Assigment.AssigmentsPerStudent();
                                    List<StudentAssigments> sa = db.GetStudentAssigments();

                                    Console.WriteLine("--assigments per courses per students--");
                                    foreach (var item in sa)
                                    {
                                        Console.WriteLine(item);
                                    }
                                    Console.WriteLine();

                                    break;
                                    case ShowData.PreviousMenu:
                                        break;
                                }
                            } while (option3 != 5);
                            break;
                        case MainMenu.Exit:
                            break;
                        default:
                            break;
                    }
                } while (option1 != 3);
            }
        }
    }

