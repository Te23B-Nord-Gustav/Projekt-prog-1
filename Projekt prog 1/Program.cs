// See https://aka.ms/new-console-template for more information
using System.Formats.Asn1;
using System.Reflection;
using System.Runtime.Intrinsics.Arm;

Console.WriteLine("Hello, World!");

// alla jävla kriteriers program i olika metoder
static void Hej() // detta är en metod skit coolt vi definerar vad den heter och att de är en metod såkalrt 
{
  Console.WriteLine("Hej!"); // sedan här så inuti {} så skriver vi va fan vi vill
// den ska göra bokstavligen ba ett nytt program som vi kan anropa när vi vill
}
static void inut()
{
    Console.WriteLine("Skriv något");
    string input = Console.ReadLine();
    Console.WriteLine("Programmets output");
    Console.WriteLine(input);
}
static void datatyper()
{
    int resultat;
    Console.WriteLine(@"
    Data typer kan vara tex text(string) eller siffror(int) som programmet inte gillar att ta in
    men med lite programerings magi så funkar det. Börja med att skriva en siffra
     ");
    string siffrainput = Console.ReadLine();
    int.TryParse(siffrainput, out resultat);

    resultat = resultat + resultat; // jag har fått slut på ider på vad jag ska kommentera så den här tar intergern x2 helt otroligt jag vet tack.

    Console.WriteLine(@"
    Här är din sifftra x2 --> " + resultat );
    Console.WriteLine(@"
    Med en siffra kan man göra matte eller skriva kod som behöver matte.
    Testa nu att tex skriva in ditt namn eller ett ord 
    ");
    string textinput = Console.ReadLine();
    Console.WriteLine(@"
    Det här är ditt namn/ord du skrev in --> " + textinput);

}
static void typkonv()
{
    // asså man behöver inte använda @ på alla write eller writelines men tycker det ser nice ut så de ajde
    Console.WriteLine(@"
    Typ konvertering är det vi gjorde i data typer efter som c# inte vill kunna lägg in en readline input i en interger
    variabel.Så lägger vi in den i en string variabel sedan med tryparse så gör vi en ny int variabel.
    fråga inte hur de går till bara gud vet
    Så skriv in en siffra så ska jag demonstrera.");
    int inputint;
    string input = Console.ReadLine();
    Console.WriteLine(@"´
    Här är din input i text form --> "+input);
    int.TryParse(input, out inputint); //gör om string till int i en ny variabel
    Console.Write(@"
    Men om vi försöker plussa den med sig själv så händer detta --> ");
    Console.Write(input+input);
    Console.WriteLine(@"
    Den skriver bara ut variabeln två gånger men efter vi konverterar den till int med
    int.TryParse(input, out nyavariabeln);
    ");
    
    Console.Write(@"
    så händer detta ''wow de funkar!'' --> "+ (inputint+inputint));
    
}
static void if_else()
{
    Console.WriteLine(@"
    If och Else är riktigt basic basicly vi tar en input man kan göra detta med siffror eleler text.
    Sedan använder vi if vilekt basicly bara är ''if varibel = något gör detta och else är allt annat än if''

    if (variabel == något) { gör detta}
    else { gör ngt annat }
    vi säger du behöver skriva in den ultra hemliga koden 1234 och om du inte gör det så får du inte det hemliga smset
    och programmet stängs(den här inte hela)
");
string input = Console.ReadLine();
if (input == "1234")
{
    Console.WriteLine(@"
    woa du gjorde actually det du skulle helt otroligt ");
}
else
{
    Console.WriteLine(@"
    du skrev antigenn fel eller tycker du rolig efter som du inte skrev in rätt i if satsen
    så körs else och då händer detta womp womp program terminated");
}

}
static void while_for()
{
    Console.WriteLine(@"
    okej så nu vi börjar göra lite bättre skit eller snarare anvenbart loopar det finns två sätt att göra det på while 
    loopar som är baserade på en int variabel du gjorde inan loopen och for loopar där den skapar en ny int variabel
    
    basicly while'' while varibel < 10 variabel++ vilekt plussar på 1 tills variabelns värde är 10
    basicly for är samma sak fast man den är inte lika lätt att förstå då den set ut så här
    for (int variabel; variabel < 10; variabel++)
    där första biten är din variabel sen andra är hur loopen vet att den ska forsätta köra och tredje är
    vad den ska göra efter varjegång den körs obs inte om den e klar
    
    vi börjar med while där du behöver skriva åter igen rätt kod 1234 in i en variabel för att få den att sluta köra");

    string input = "";
    while (input != "1234")
    {Console.WriteLine("    skriv koden"); // en while loop väldigt sälsynt och svårt nej men de ne loop som körs till koden skrivs in 
        input = Console.ReadLine();
    }
    Console.WriteLine(@"
    woa du klara det så nu körs inte den loopen längre
    
    Nu for loop dem är inte det du skulle använda för att göra de vi nyss gjorde utan mer för att göra någto repetetivt 
    så som räkna från 0 till 10 vilket vi ska göra");

    Thread.Sleep(5000); // omg jag spammar denna den här fina biten kod är min fru asså får allt att bli finare

    for (int i = 0; i<=10; i++)
    {
        Console.WriteLine("    nu körs lopen en ny gång och här är nuvarande nummret -->" + i);
        Thread.Sleep(500); // det här har vi ju inte lärt oss men gud alla borde kunna får koden att köra finare "är direkt taget från google grovt plagierat btw"
    }
    

}
static void metoder(string text)
{
    Console.WriteLine(@"
    woila det är typ den sjunde metoden. Men kortfattat är en metod ungefär en del av ditt program
    som körs bara när du anropar den
    det ser ut så här

    Static void metodensnamn()
    {här all din kod för denna metod}
    
    Sedan anropar du den med hjälp av 
    metodensnamn();
    Det här använder vi för att köra programmet när du skriver in en siffra kör programmet
    den metoden/alternativet du valt");
    // Thread.Sleep(15000);
    Console.WriteLine(@"
    Med parametrar är det ungefär samma men att vi skriver 
    static void metodensnamn(string variabel)
    variabeln är något vi sedan bestämmer när vi skriver koden för att anropa eller med en input
    och då kan den variabeln användas i metoden
    när vi anropar metoden med metodensnamn(vad vi vill variabeln sak vara obs tänk på int och string);
   
    i mitt fall nu så var jag skit hungrig så jag skrev -->" + text);
    // Thread.Sleep(15000);
    Console.WriteLine(@"
    Returnering är jobbigare att förklara så jag tror jag skippar den för nu");

    // här är själva returnerings programmet
    static int Multi(int a, int b)
    {   
    int resultat = a*b;
    return resultat;
    }
    // här är returenen i guess
    int area = Multi(6, 7);
    Console.WriteLine(@"
    men som alltid är svaret "+area);

}
static void listray(){
    List<string> Namn = ["kalle", "balle"];
    Console.WriteLine(@"
    Listor och arrayer är något otroligt stort omrråde så jag går bara igenom det grundläggande

    En lista ser ut så här  List<datatyp> listansman = [];
    med exempel i blir det  List<string> Namn = [''kalle'', ''balle'']; 
    btw '' ska vara "" men c# gillar inte att jag skriver acutal koden
    men när vi skriver ut listan ser det ut såhär");

    foreach (string namn in Namn){
        Console.Write(namn+" ");
    }

    Console.WriteLine(@"
    et vi kan göra dock är att lägga till namn skriv ditt namn ensälla");

    Namn.Add(Console.ReadLine());

    Console.WriteLine(@"
    okej nu när du skrev in ditt namn eller trolla så ser det ut så här när vi skriver ut listan");

    foreach (string namn in Namn){
        Console.Write(namn+" ");
    }
}



// Menyn för att välja alternativ
bool isRunning = true;
while (isRunning)
{
    Console.WriteLine(@"
    Detta är en lista över några av våra betygs kriterier(det som förväntas vara med i detta projekt)
    skriv in nummret eller namnet på den för att köra en demo verision av ett program
    som innhålelr de specifika koden
    
    !Skriv exit för att avsluta programmet btw! Och tryck enter så fort programmet pausar så den kan gå vidare!");

Thread.Sleep(500);

    Console.WriteLine(@"
    1(Print) TestX
    2(input-print) TestX
    3(Variabler, olika datatyper)
    4(Typkonvertering(forsättning på 3an))
    5(if och else satser)
    6(while och for loopar)
    7(metoder,Parametrar,Returnering) 
    ");

    string input = Console.ReadLine();
    if(input == "exit")
    {
        break;
    }
    // ska inte ljuga har inte orkat komma på något bättre sätt att göra denna delen ksnk  med typ list eller arrayer
    else if(input == "1")
    {
        Hej();
    }
    else if(input == "2")
    {
        inut();
    }
    else if(input == "3")
    {
        datatyper();
    }
    else if(input == "4")
    {
        typkonv();
    }
    else if(input == "5")
    {
        if_else();
    }
    else if (input == "6")
    {
        while_for();
    }
    else if (input == "7")
    {
        metoder("hamburgare");
    }
    else if (input == "8")
    {
        listray();
    }
    else {
        Console.WriteLine("du måste actually skriva in ngt va trodde du skulle hända");
    }

   Console.ReadLine(); 
}
