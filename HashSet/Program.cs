
List<string> peopleList = new List<string>();
peopleList.Add("Tom");
peopleList.Add("Bob");
peopleList.Add("Mike");
peopleList.Add("Lora");
peopleList.Add("Tom");
peopleList.Add("Mike");
peopleList.Add("Lora");

string[] peopleArray = peopleList.ToArray();

HashSet<string> peopleSetFromList = new HashSet<string>(peopleList);

HashSet<string> peopleSetFromArray = new HashSet<string>(peopleArray);

foreach (var person in peopleSetFromList)
{
    Console.WriteLine(person);
}

Console.WriteLine("_____________________");

foreach (var person in peopleSetFromArray)
{
    Console.WriteLine(person);
}

HashSet<string> people = new HashSet<string>();
people.Add("Tom");
people.Add("Bob");
people.Add("Mike");
people.Add("Tom");
people.Add("Lora");
people.Add("Lora");

HashSet<string> peopleNew = new HashSet<string>();
peopleNew.Add("Alice");
peopleNew.Add("John");
peopleNew.Add("Linda");
peopleNew.Add("Tom");

people.UnionWith(peopleNew);

Console.ReadKey();