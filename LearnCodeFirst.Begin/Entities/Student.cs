using System;
using System.Data.Entity.ModelConfiguration;

namespace LearnCodeFirst.Begin.Entities
{
    public class Student
    {
        public int PersonId { get; set; }
        public virtual Person Person { get; set; }
        public string CollegeName { get; set; }
        public DateTime EnrollmentDate { get; set; }
    }

    public class StudentMap : EntityTypeConfiguration<Student>
    {
        public StudentMap()
        {
            HasRequired(o => o.Person).WithOptional(o => o.Student);

            HasKey(o => o.PersonId);

            Property(o => o.CollegeName).HasMaxLength(50).IsRequired();
        }
    }
}
