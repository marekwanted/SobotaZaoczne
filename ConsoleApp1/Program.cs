using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //todo TPH 
            using (var context = new SchoolModel())
            {
              //  context.Database.Log = Console.WriteLine;

                context.Person
                   .OfType<Instructor>()
                   .ToList()
                   .ForEach(x => Console.WriteLine(x.FirstName));

                Console.WriteLine("--------------");

                context.Person
                    .OfType<Student>()
                    .ToList()
                    .ForEach(x=>Console.WriteLine(x.FirstName));
            }
        }
    }
}