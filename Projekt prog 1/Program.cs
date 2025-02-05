// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// alla jävla kriteriers program i olika metoder
static void Hej()
{
  Console.WriteLine("Hej!");
}
static void inut()
{
    string input = Console.ReadLine();
    Console.WriteLine(input);
}





// Menyn för att välja alternativ
bool isRunning = true;
while (isRunning)
{
    Console.WriteLine(@"
    Detta är en lista över våra betygs kriterier
    skriv in nummret eller namnet på den för att köra en demo verision av ett program
    som innhålelr de specifika koden

1(Print)
2(input-print) 
    ");

    string input = Console.ReadLine();
    if(input == "1")
    {
        Hej();
    }
    else if(input == "2")
    {
        inut();
    }

   Console.ReadLine(); 
}
