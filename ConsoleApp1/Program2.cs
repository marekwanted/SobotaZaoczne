using System;
using System.Linq;

namespace ConsoleApp1
{
    internal class Program2
    {
        private static void Main(string[] args)
        {
            //todo TPT
            using (var context = new SchoolModel())
            {
                context.Database.Log = Console.WriteLine;

                context.Course.Add(new OnlineCourse
                {
                    Credits = 1000,
                    DepartmentID = 1,
                    Title = "P4",
                    URL = "http:/"
                });

                Console.WriteLine(context.Course
                    .OfType<OnlineCourse>()
                    .Count());
                context.SaveChanges();
            }
        }
    }
}