namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    //todo :COURSE
    [Table("OnlineCourse")]
    public partial class OnlineCourse:Course
    {
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        //public int CourseID { get; set; }

        [Required]
        [StringLength(100)]
        public string URL { get; set; }

        //public virtual Course Course { get; set; }
    }
}
