Console.Write("What day of the week is it? ");
string Day = Console.ReadLine();

if (Day.ToUpper().Trim() == "FRIDAY")
{
    Console.WriteLine("");
    Console.WriteLine("Yippie, thats so skibidi!!!!");
}
else if (Day.ToUpper().Trim() == "MONDAY")
{
    Console.WriteLine("");
    Console.WriteLine(" >:(  not skibidi!!!");
}
else if (Day.ToUpper().Trim() == "TUESDAY")
{
    Console.WriteLine("");
    Console.WriteLine("Atleast its not monday!!!");
}
else if (Day.ToUpper().Trim() == "WEDNESDAY")
{
    Console.WriteLine("");
    Console.WriteLine("Half way through the school week!");
}
else if (Day.ToUpper().Trim() == "THURSDAY")
{
    Console.WriteLine("");
    Console.WriteLine("Its almost friday!!!1!!1!!11!");
}
else if (Day.ToUpper().Trim() == "SATURDAY")
{
    Console.WriteLine("");
    Console.WriteLine("WEEKEND WOOOOOOOOOOOOOOOO!!!!!!!!!!!!!!!");
}
else if (Day.ToUpper().Trim() == "SUNDAY")
{
    Console.WriteLine("");
    Console.WriteLine("school tomorrow  :(");
}
else
{
    Console.WriteLine("Thats not even a day!! >:(");
}