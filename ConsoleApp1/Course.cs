namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Course")]
    public abstract partial class Course
    {
        //todo !!  !! !! !! 
       // [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseID { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        public int Credits { get; set; }

        public int DepartmentID { get; set; }

        //todo usuwamy niepotrzebne sk³adniki
        //public virtual OnlineCourse OnlineCourse { get; set; }

        //public virtual OnsiteCourse OnsiteCourse { get; set; }
    }
}
