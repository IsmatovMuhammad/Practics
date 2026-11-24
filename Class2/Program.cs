List<Person> people = new List<Person>(){
    new Person
    {
        Id = 1,
        FullName = "Muhammad",
        Age = 17,
        CityId = 1
    },

    new Person
    {
        Id = 2,
        FullName = "Muso",
        Age = 16,
        CityId = 2
    },
    new Person
    {
        Id = 3,
        FullName = "Abdullo",
        Age = 16,
        CityId = 3
    }
};

List<City> cities = new List<City>(){
    new City
    {
        Id = 1,
        Name = "Tashkent"
    },

    new City
    {
        Id = 2,
        Name = "Samarkand"
    },
    new City
    {
        Id = 3,
        Name = "Bukhara"
    }
};


// 1
// method syntax
// var res = people.Where(x => x.Age > 25);

// Linq syntax
// var res = from x in people where x.Age > 25 select x;


// 2
// method syntax
// var res = people.OrderByDescending(x => x.Age).ThenBy(x => x.FullName);

// Linq syntax
// var res = from x in people orderby x.Age, x.FullName select x;


// 3
// method syntax
// var res = people.OrderBy(x => x.FullName).Select(x => new { x.FullName});

// Linq syntax
// var res = from x in people orderby x.FullName select x.FullName;


// 5
// method syntax
// var res = people.Sum(x => x.Age);

// Linq syntax
// var res = (from x in people where x.Age > 25 select x.Age).Sum();

// Console.WriteLine(res);

// 6
// method syntax
// var res = people.GroupBy(x => char.ToUpper(x.FullName[0]))
// .Select(g => new {g.Key, Count = g.Count() });

// Linq syntax
// var res = from x in people group x by char.ToUpper(x.FullName[0])into g
// select new {g.Key, Count = g.Count()};

// 7
// method syntax
// var res = people.GroupBy(x => x.CityId).Max(x => x.Count());

// Linq syntax
// var res = (from x in people group x by x.CityId into g
// orderby g.Count() descending
// select g).First();


// 8
// method syntax
// var res = people.Where(x => x.Age >= 2 && x.Age <= 7).;

// foreach (var item in res)
// {
//     System.Console.WriteLine(item);
// }