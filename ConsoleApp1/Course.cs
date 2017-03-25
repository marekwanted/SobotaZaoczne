using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1
{



    [Table("Course")]
    public abstract class Course
    {
        //todo !!  !! !! !! 
        // [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseID { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        public int Credits { get; set; }

        public int DepartmentID { get; set; }

        //public virtual OnsiteCourse OnsiteCourse { get; set; }
        //public virtual OnlineCourse OnlineCourse { get; set; }

        //todo usuwamy niepotrzebne sk³adniki
    }
}