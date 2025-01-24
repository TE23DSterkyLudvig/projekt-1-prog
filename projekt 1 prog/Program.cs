int hälsa = 150;            // Hur mycket hälsa du har
string val;                 // Vilket val du valt gällande rikting
int attackVal;             //Vilken attack väljer du
int monsterSkada = Random.Shared.Next(10, 40);           // Hur mycket skada monster gör
int monsterHälsa = Random.Shared.Next (100, 140);               // Hur mycket hälsa ett monster kan ha
int läka = 50;                      //Hur mycket hälsa du får vid läkning

List<string> attacker = ["Peta", "Slå", "Klyva", "Skjuta"];               // De olika attackerna
List<int> skada = [Random.Shared.Next(10, 20), Random.Shared.Next(20, 40), Random.Shared.Next(30, 70), Random.Shared.Next(10, 100)];           // Hur mycket skada som vapnena gör
List<int> mötande = [Random.Shared.Next(1,3), Random.Shared.Next(1,3), Random.Shared.Next(1,3)];

System.Console.WriteLine("En dag när du är ute och vandrar i skogen så märker du plötsligt att du tappat bort dig i skogen, Du måste ta dig hem.");
rum();
System.Console.WriteLine($"Du har {hälsa} i hälsa och har tillgång till ett antal attacker.");
rum();
for (int i = 0; i < attacker.Count; i++)
{
    System.Console.WriteLine($"{attacker[i]} gör {skada[i]} i skada");
    rum();
}
System.Console.WriteLine("Du når en korsning där stigen delar sig i tre. Du kan välja att gå vänster, höger eller fortsätta rakt.");
val = Console.ReadLine();

val = vägVal(val);

if(val == "rakt"){

}








Console.ReadLine();




static string vägVal(string val)                //Väljer vilken väg som man vill gå
{
    while (true)
    {

        if (val.ToLower() == "vänster")
        {
            System.Console.WriteLine($"Du väljer att gå {val}");
            return val;
        }
        else if (val.ToLower() == "höger")
        {
            System.Console.WriteLine($"Du väljer att gå {val}");
            return val;
        }
        else if (val.ToLower() == "rakt")
        {
            System.Console.WriteLine($"Du väljer att gå {val}");
            return val;
        }
        else
        {
            System.Console.WriteLine("Skriv vänster, höger eller rakt");
            val = Console.ReadLine();
        }
    }
}
static void rum()                      // Tidsrum mellan meningar.
{
    Thread.Sleep(800);
}

static int monsterStrid(int hälsa, int monsterSkada, int monsterHälsa, List<string> attacker, List<int> skada, int attackVal){
    while(true){
        hälsa -= monsterSkada;
        monsterHälsa -= skada[attackVal];
        System.Console.WriteLine($"Monstret har {monsterHälsa} i hälsa kvar");
        System.Console.WriteLine($"Du har {hälsa} i hälsa kvar");
        if 
    }
}
