int hälsa = 100;            // Hur mycket hälsa du har
string val;                 // Vilket val du valt gällande rikting
int monsterSkada = Random.Shared.Next(10,30);           // Hur mycket skada monster gör
int läka = 20;                      //Hur mycket hälsa du får vid läkning

List<string> attacker = ["Peta","Slå","Klyva", "Skjuta"];               // De olika attackerna
List<int> skada = [Random.Shared.Next(10,20),Random.Shared.Next(20,40),Random.Shared.Next(30,70),Random.Shared.Next(10,100)];           // Hur mycket skada som vapnena gör

System.Console.WriteLine("En dag när du är ute och vandrar i skogen så märker du plötsligt att du tappat bort dig i skogen, Du måste ta dig hem.");
System.Console.WriteLine($"Du har {hälsa} i hälsa och har tillgång till ett antal attacker.");
for (int i = 0; i < attacker.Count; i++)
{
    System.Console.WriteLine($"{attacker[i]} gör {skada[i]} i skada");
}






Console.ReadLine();

static void vägVal(string val){
while(true){
System.Console.WriteLine("Du når en korsning där stigen delar sig i tre. Du kan välja att gå vänster, höger eller fortsätta rakt fram.");
val = Console.ReadLine();
if (val.ToLower() == "vänster"){
    System.Console.WriteLine($"Du väljer att gå {val}");
    return;
}
else if(val.ToLower() == "höger"){
    System.Console.WriteLine($"Du väljer att gå {val}");
    return;
}
}
}
