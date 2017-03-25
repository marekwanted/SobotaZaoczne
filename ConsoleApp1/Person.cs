namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Person")]
    public abstract partial class Person
    {
        public int PersonID { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        //todo: Usuwamy Discriminator bo nie jest ju¿ d³u¿ej potrzebny, 
        //todo: szukany Discriminator jest pobierany z NAZWY klasy pochodnej.
        //[Required]
        //[StringLength(50)]
        //public string Discriminator { get; set; }
    }

    internal class Instructor : Person
    {
        public DateTime? HireDate { get; set; }
    }

    internal class Student : Person
    {
        public DateTime? EnrollmentDate { get; set; }
    }
}