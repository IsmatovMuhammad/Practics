List<Student> students = new List<Student>
{
    new Student
    {
        Id = 1,
        FirstName = "Ali",
        LastName = "Karimov",
        Age = 18,
        Gender = "Male",
        Status = "Active",
        DateOfStart = new DateTime(2024, 9, 1),
        DateOfFinish = new DateTime(2027, 6, 1)
    },
    new Student
    {
        Id = 2,
        FirstName = "Sofia",
        LastName = "Rahimova",
        Age = 20,
        Gender = "Female",
        Status = "Active",
        DateOfStart = new DateTime(2023, 9, 1),
        DateOfFinish = new DateTime(2026, 6, 1)
    },
    new Student
    {
        Id = 3,
        FirstName = "Muhammad",
        LastName = "Saidov",
        Age = 17,
        Gender = "Male",
        Status = "Inactive",
        DateOfStart = new DateTime(2025, 1, 15),
        DateOfFinish = new DateTime(2028, 1, 15)
    },
    new Student
    {
        Id = 4,
        FirstName = "Madina",
        LastName = "Sharifova",
        Age = 19,
        Gender = "Female",
        Status = "Active",
        DateOfStart = new DateTime(2024, 2, 1),
        DateOfFinish = new DateTime(2027, 2, 1)
    }
};

//1
// var stu = students.Where(x => x.Gender == "Male").Select(x => x.FirstName);
// foreach (var item in stu)
// var stu = from s in students
//         where s.Gender == "Male"
//         select s.FirstName;


//2
// var result = students.Where(s => s.Status == "Inactive");


// var result = from s in students
//              where s.Status == "Inactive"
//              select s;


//3
// var result = students.Where(s => s.DateOfStart.Year > 2000);

// var result = from s in students
//             where s.DateOfStart.Year > 2000
//             select s;


//4
// var result = students.Where(s => s.Status == "Active" && s.Age > 20);

// var result = from s in students
//             where s.Status == "Active" && s.Age > 20
//             select s;



//5
// var result = students.Where(s =>
//     s.DateOfStart.Year - s.DateOfFinish.Year == 16);


// var result = from s in students
//             where s.DateOfStart.Year - s.DateOfFinish.Year == 16
//             select s;



//6
// var result = students.Where(s =>
//     s.DateOfStart.Year - s.DateOfFinish.Year >= 18);


// var result = from s in students
//             where s.DateOfStart.Year - s.DateOfFinish.Year >= 18
//             select s;


//7
// var result = students.Where(s =>
//     s.FirstName.StartsWith("A") ||
//     s.FirstName.StartsWith("I"));


// var result = from s in students
//             where s.FirstName.StartsWith("A") ||
//             s.FirstName.StartsWith("I")
//             select s;



//8
// var result = students.Where(s =>
//     s.FirstName[0] == s.LastName[0]);

// var result = from s in students
//             where s.FirstName[0] == s.LastName[0]
//             select s;


//9
// var result = students.Where(s =>
//     s.DateOfFinish.AddYears(18) >= s.DateOfStart &&
//     s.DateOfFinish.AddYears(18) <= s.DateOfFinish);


// var result = from s in students
//             where s.DateOfFinish.AddYears(18) >= s.DateOfStart &&
//             s.DateOfFinish.AddYears(18) <= s.DateOfFinish
//             select s;


//10
// var result = students.Where(s =>
//     s.Gender != "Female" &&
//     s.Status == "Active" &&
//     (DateTime.Now - s.DateOfStart).TotalDays > 730 &&
//     s.Age < 16);

// var result = from s in students
//             where s.Gender != "Female" &&
//             s.Status == "Active" &&
//             (DateTime.Now - s.DateOfStart).TotalDays > 730 &&
//             s.Age < 16
//             select s;
// foreach (var s in result)
// {
//     Console.WriteLine($"{s.FirstName} {s.LastName}");
// }