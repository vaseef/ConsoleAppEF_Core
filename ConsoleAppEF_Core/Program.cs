using ConsoleAppEF_Core.Model;
using System;
using System.Linq;

namespace ConsoleAppEF_Core
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            using (var cotxt = new SchoolContext())
            {
                var std = new Student()
                {
                    Name = "Riyan",
                    StudentId = 10,
                    Chemistry = 50,
                    English = 51,
                    Maths = 52,
                    Physics = 53

                };


                var std2 = new Student()
                {
                    Name = "Riyan2",
                    StudentId = 10,
                    Chemistry = 50,
                    English = 51,
                    Maths = 52,
                    Physics = 53

                };
                var std3 = new Student()
                {
                    Name = "Riyan3",
                    StudentId = 10,
                    Chemistry = 50,
                    English = 51,
                    Maths = 52,
                    Physics = 53

                };

                cotxt.Students.Add(std);
                //cotxt.Students.Add(std2);
                //cotxt.Students.Add(std2);
               // cotxt.SaveChanges();

            }

            using (var cotxt = new SchoolContext())
            {
                var studentsWithSameName = cotxt.Students
                                      .Where(s => s.Name == "Riyan")
                                      .ToList();

                foreach (var a in studentsWithSameName)
                {
                    Console.Out.WriteLine($"Name: {a.Name}, Physics: {a.Physics}");
                }
            }
        }

    }
}
