List<Employee> employees = new List<Employee>()
{
    new Employee
    {
        Id = 1,
        FullName = "Muhammad",
        LastName = "Ismatov",
        Age = 17,
        Salary = 10000,
        Experience = 4
    },

    new Employee
    {
        Id = 2,
        FullName = "Muso",
        LastName = "Safarov",
        Age = 16,
        Salary = 1000,
        Experience = 0
    },
    new Employee
    {
        Id = 3,
        FullName = "Abdullo",
        LastName = "Kholov",
        Age = 16,
        Salary = 3000,
        Experience = 1
    }
};

// 1
// method syntax
// var emp = employees.Select(x => x.Salary);

// Linq syntax
// var emp = from x in employees
//             select x.Salary;


// 2
// method syntax
// var emp = employees.Where(x => x.FullName.Length > 5).Select(x => x.FullName);

// Linq syntax
// var emp = from x in employees where x.FullName.Length > 5 select x.FullName;


// 3
// method syntax
// var emp = employees.Where(x => x.Age > employees[0].Age).Select(x => x.FullName);

// Linq syntax
// var emp = from x in employees where x.Age > employees[0].Age select x.FullName;


// 4
// method syntax
// var emp = employees.Where(x => x.Experience * 2 == x.Age);

// linq syntax
// var emp = from x in employees where x.Experience * 2 ==x.Age select x;


// 5
//method syntax
// var emp = employees.Where(x => x.Salary > 1000).Select(x => new { x.FullName, x.Salary }).Take(3);

// linq syntax
// var emp = from x in employees where x.Salary > 1000 select new { x.FullName, x.Salary };


// foreach (var item in emp)
// {
//     System.Console.WriteLine(item);
// }