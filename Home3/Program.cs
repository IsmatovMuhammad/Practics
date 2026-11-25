List<Person> persons = new List<Person>
{
    new Person
    {
        Name="Abdullo",
        Age=16
    },

    new Person
    {
        Name="Muso",
        Age=16
    },

    new Person
    {
        Name="Muhamad",
        Age=17
    },

    new Person
    {
        Name="Saad",
        Age=13
    },

    new Person
    {
        Name="Hikmat",
        Age=16
    },
};

List<Car> cars = new List<Car>()
{
    new Car 
    { 
        Model = "BMW", 
        Year = 2020 
    },

    new Car 
    { 
        Model = "Mercedes", 
        Year = 2022 
    },

    new Car 
    { 
        Model = "Toyota", 
        Year = 2020 
    },

    new Car 
    { 
        Model = "Audi", 
        Year = 2023 
    },

    new Car 
    { 
        Model = "Honda", 
        Year = 2022 
    }
};

List<Book> books = new List<Book>
{
    
    new Book 
    { 
        Title = "C#", 
        Author = "Albahari" 
    },

    new Book 
    { 
        Title = "C#", 
        Author = "Albahari" 
    },

    new Book 
    { 
        Title = "LINQ", 
        Author = "Rattz" 
    }
};

//1 method syntex
// List<int> ints = [3,1,4,1,5,9,2,6];
// var res = ints.OrderBy(x=>x).ToList();
// int i = res.Count/2;
// if (res.Count % 2 == 0)
// {
//     Console.WriteLine(new[] {res[i-1],res[i]}.Average());
// }   

// else
// {
//     Console.WriteLine(res.ElementAt(i));
// }

//query syntex
// List<int> ints = [3, 1, 4, 1, 5, 9, 2, 6];
// var res = (from x in ints
//             orderby x
//             select x).ToList();
// int i=res.Count()/2;
// if (res.Count() % 2 == 0)
// {
//     Console.WriteLine(new[] {res[i-1],res[i]}.Average());
// }
// else
// {
//     Console.WriteLine(res.ElementAt(i));
// }

//2 method syntex
// List<int> A = [1,2,3,4];
// List<int> B = [2,3,5,6];
// List<int> C = [2,3,7,8];
// var res = A.Intersect(B).Intersect(C);
// foreach (var item in res)
// {
//     Console.Write(item+" ");
// }

//query synetx
// List<int> A = [1,2,3,4];
// List<int> B = [2,3,5,6];
// List<int> C = [2,3,7,8];
// var res = from x in A
//             where B.Contains(x) && C.Contains(x)
//             select x;
// foreach (var item in res)
// {
//     Console.Write(item+" ");
// }

//3 method syntex
// List<int> ints = [1,2,3,1,2,5,6];
// int sum = 0;
// int max=-9999;
// for (int i = 1; i < ints.Count; i++)
// {
//     if (ints[i] > ints[i - 1])
//     {
//         sum+=ints[i];
//     }

//     else
//     {
//         sum=ints[i];
//     }

//     if (sum > max)
//     {
//         max=sum;
//     }
// }
// Console.WriteLine(max);

//query syntex
// List<int> ints = [1,2,3,1,2,5,6];
// var res = from x in ints
//             select x;
// foreach (var item in ints)
// {
// int max=-9999;
// int sum=0;
//     for (int i = 1; i < ints.Count; i++)
//     {
//         if (ints[i] > ints[i - 1])
//         {
//             sum+=ints[i];
//         }

//         else
//         {
//             sum=ints[i];
//         }

//         if (sum > max)
//         {
//             max=sum;
//         }
//     }
//     Console.WriteLine(max);
//     break;
// }


// 4
// method syntax