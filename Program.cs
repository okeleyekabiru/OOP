// See https://aka.ms/new-console-template for more information
using OOP.Entities;

Console.WriteLine("Hello, World!");

Person person = new Female
{
    Age = 1,
    Name = "Cloe"
};
Person person2 = new Female
{
    Age = 2,
    Name = "Cloe1"
};
Person person3 = new Male
{
    Age = 12,
    Name = "Cloe2"
};
var list = new List<Person> { person, person2, person3 };
var list2 = new List<Person>();
list2.Add(person); // index 0
list2.Add(person2);//index 1
list2.Add(person3);//index 2

foreach (var item in list)
{
    if (item.Name == "Cloe2")
    {
        Console.WriteLine($"found >> {item.Name}");
    }
}
var dic = list.ToDictionary(e => e.Name);
dic.Add("Cloe4", new Female
{
    Name = "Cloe4",
    Age = 23
});

Console.WriteLine($"found >> {dic["Cloe4"].Name}");
//Console.WriteLine(list[0].CanWalk() ? "Hurray" : "Baby");
//Console.WriteLine(list[1].CanWalk() ? "Hurray" : "Baby");
//Console.WriteLine(list[2].CanWalk() ? "Hurray" : "Baby");
////Console.WriteLine(list[3].CanWalk() ? "Hurray" : "Baby");

//foreach (var p in list2)
//{
//    if (p.CanWalk())
//    {
//        Console.WriteLine("Hiurray");
//    }
//    else
//    {
//        Console.WriteLine("Baby");
//    }
//}
//for (int i = 1; i <= list.Count; i++)
//{
//    if (list[i - 1].CanWalk())
//    {
//        Console.WriteLine("Hiurray");
//    }
//    else
//    {
//        Console.WriteLine("Baby");
//    }
//}