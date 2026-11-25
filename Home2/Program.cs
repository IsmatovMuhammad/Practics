using System.Diagnostics.Metrics;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;

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
// var res = students.Where(x => enrollments.Any(a => a.StudentId == x.StudentId && 
// courses.Any(c => c.CourseId == a.CourseId && c.Title == "Mathematics")));

// linq syntax
// var res  = from s in students join e in enrollments on s.StudentId equals e.StudentId
// join c in courses on e.CourseId equals c.CourseId
// where c.Title == "Mathematics" select s;


// 2
// method syntax
// var res = courses.Where(x => enrollments.Any(e => e.CourseId == x.CourseId &&
// students.Any(s => s.StudentId == e.StudentId && s.Name == "Charlie")));

// Linq syntax
// var res = from c in courses join e in enrollments on c.CourseId equals e.CourseId
// join s in students on e.StudentId equals s.StudentId where c.Title == "Charlie" select c;


// 3
// method syntax
// var res = students.Select(s => new
// {
//     Student = s,
//     Enrollments = enrollments.Where(e => e.StudentId == s.StudentId).ToList()
// });

// Linq syntax
// var res = from s in students 
//           from e in enrollments
//           where e.StudentId == s.StudentId
//           group e by s into g 
//           where g.Select(x => x.CourseId).Distinct().Count() > 1
//           select g.Key;


// 4
// method syntax


// 5
// Linq syntax
// var fromDate = new DateTime(2026, 1, 18);
// var minCreadit = 4;
// var res = from s in students
//           join e in enrollments on s.StudentId equals e.StudentId
//           join c in courses on e.CourseId equals c.CourseId
//           where e.EnrollmentDate >= fromDate && c.Credits >= minCreadit
//           select new {s.Name, c.Title, c.Credits, e.EnrollmentDate};


// 6
// Linq syntax
// var res = from e in enrollments
//           join s in students on e.StudentId equals s.StudentId
//           join c in courses on e.CourseId equals c.CourseId
//           where c.Credits > 1 
//           group c by c.CourseId;


// 7
// Linq syntax
// var res = from c in courses
//           select new
//           {
//               c.Title,
//               Count = (from e in enrollments
//               where e.CourseId == c.CourseId
//               select e.StudentId).Distinct().Count()
//           };


// 8
// Linq sytax
var name = "Bob";
var res = from c in courses
          where!(from e in enrollments
          join s in students on e.StudentId equals s.StudentId
          where s.Name == name && e.CourseId == c.CourseId
          select e).Any() select c;


foreach (var item in res)
{
    System.Console.WriteLine(item);
}
