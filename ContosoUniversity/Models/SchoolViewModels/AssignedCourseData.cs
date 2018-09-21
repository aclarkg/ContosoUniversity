
namespace ContosoUniversity.Models.SchoolViewModels
{
    public class AssignedCourseData // Data to create the check boxes for assigned courses by an instructor.
    {
        public int CourseID { get; set; }
        public string Title { get; set; }
        public bool Assigned { get; set; }
    }
}