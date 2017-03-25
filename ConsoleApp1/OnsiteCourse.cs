using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1
{
    [Table("OnsiteCourse")]
    public class OnsiteCourse : Course
    {
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        //public int CourseID { get; set; }

        [Required]
        [StringLength(50)]
        public string Location { get; set; }

        [Required]
        [StringLength(50)]
        public string Days { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime Time { get; set; }

        //public virtual Course Course { get; set; }
    }
}