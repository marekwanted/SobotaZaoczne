namespace ConsoleApp1
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class SchoolModel : DbContext
    {
        public SchoolModel()
            : base("name=SchoolEntities")
        {
        }

        public virtual DbSet<Course> Course { get; set; }
      //  public virtual DbSet<OnlineCourse> OnlineCourse { get; set; }
      //  public virtual DbSet<OnsiteCourse> OnsiteCourse { get; set; }
        public virtual DbSet<Person> Person { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //todo usuwamy
            //modelBuilder.Entity<Course>()
                //.HasOptional(e => e.OnlineCourse)
                //.WithRequired(e => e.Course);

            //modelBuilder.Entity<Course>()
                //.HasOptional(e => e.OnsiteCourse)
                //.WithRequired(e => e.Course);
        }
    }
}
