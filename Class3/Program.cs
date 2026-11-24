using System.Data.Common;
using System.Security.Cryptography.X509Certificates;

List<Person> people = new List<Person>()
{
    new Person
    {
        Id = 1,
        FullName = "Ismatov Muhammad",
        Age = 17
    },
    new Person
    {
        Id = 2,
        FullName = "Abdullo Kholov",
        Age = 16
    },
    new Person
    {
        Id = 3,
        FullName = "Safarov Muso",
        Age = 16
    },
};


// 1
// method syntax
// var person = people.Where(x => x.Age > 30);

// Linq syntax
// var person = from x in people where x.Age >= 30 select new{x.FullName, x.Age};

// 2
// method syntax
// var person = people.GroupBy(x => x.Age).ToDictionary(a => a.Key, a => a.Count());

// var person = (from x in people group x by x.Age into g orderby g.Key select(g.Key, g.Count())).ToList(); 

// 3
// method syntax
// var person = people.OrderByDescending(x => x.Age).Take(5);

// linq syntax
// var person = (from x in people orderby x.Age descending select new{x.FullName, x.Age}).Take(5); 


// 4
// method syntax
// var person = people.AsParallel().Where(x => x.Age > 25).ToList();

// Linq syntax
// var person = (from x in people.AsParallel() where x.Age > 25 select x).ToList();


// 5
// method syntax

// foreach (var item in person)
// {
//     System.Console.WriteLine(item.FullName + " " + item.Age);
// }