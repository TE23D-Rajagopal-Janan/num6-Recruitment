Console.WriteLine("Vilka vill du recrutera fotbolslaget, välj av följande kandidater");

//string name = Console.ReadLine();
//names[1] = "Janne";
//names.Add("Kerem");
//names.Remove("Kerem");
List<string> names2 = [];
List<string> names = ["Janan", "Adam", "Imad"];

for (int i = 0; i < names.Count; i++)
{
    Console.WriteLine($"{i + 1}. " + names[i]);
}
string val1 = Console.ReadLine();
int s = 0;
int.TryParse(val1, out s);

    names.RemoveAt(s);
    names2.Add(s);

Console.WriteLine(string.Join("\n", names));
Console.WriteLine(string.Join("\n", names2));
Console.ReadLine();
//if (names.Contains("Janan") == true); 
//{
// Console.WriteLine("Yes Janan är med i listan");
//}


