List<string> names = ["Janan", "Adam", "Imad"];

string name = Console.ReadLine();
//names[1] = "Janne";
names.Add("Kerem");
//names.Remove("Kerem");
for (int i = 0; i < names.Count; i++)
{
    Console.WriteLine(names[i]);
}
if (names.Contains("Janan") == true); 
{
    Console.WriteLine("Yes Janan är med i listan");
}

Console.ReadLine();
