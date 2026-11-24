List<Student> students = new List<Student>
{
new Student { StudentId = 1, Name = "Alice", DateOfBirth = new DateTime(2000, 5, 15) },
new Student { StudentId = 2, Name = "Bob", DateOfBirth = new DateTime(1999, 8, 25) },
new Student { StudentId = 3, Name = "Charlie", DateOfBirth = new DateTime(2001, 3, 10) }
};


List<Course> courses = new List<Course>
{
new Course {CourseId = 101, Title = "Mathematics", Credits = 4 },
new Course {CourseId = 102, Title = "Computer Science", Credits = 3 },
new Course {CourseId = 103, Title = "Physics", Credits = 4 }
};


List<Enrollment> enrollments = new List<Enrollment>
{
new Enrollment {EnrollmentId = 2, StudentId = 1, CourseId = 102, EnrollmentDate = new DateTime(2023, 1, 20) },
new Enrollment {EnrollmentId = 1, StudentId = 1, CourseId = 101, EnrollmentDate = new DateTime(2023, 1, 15) },
new Enrollment {EnrollmentId = 3, StudentId = 2, CourseId = 101, EnrollmentDate = new DateTime(2023, 1, 18) },
new Enrollment {EnrollmentId = 4, StudentId = 3, CourseId = 103, EnrollmentDate = new DateTime(2023, 1, 22) },
new Enrollment {EnrollmentId = 5, StudentId = 3, CourseId = 101, EnrollmentDate = new DateTime(2023, 1, 25) },
new Enrollment {EnrollmentId = 6, StudentId = 3, CourseId = 102, EnrollmentDate = new DateTime(2023, 1, 30) }
};


// 1
// method syntax
var res = students.