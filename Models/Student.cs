using System.ComponentModel.DataAnnotations.Schema;

namespace UTBBackendApi.Models
{
    [Table("Student")]
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int CurrentSemester { get; set; }
        public int FacultyId { get; set; }
        public DateTime EnrollmentDate { get; set; }
    }
}
