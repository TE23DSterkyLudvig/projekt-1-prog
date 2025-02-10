bool attack = false;            // om en konvertering går igenom vid val av attack.
int hälsa = 100;            // Hur mycket hälsa du har
string val;                 // Vilket val du valt gällande rikting
string attackVal = "";          //Vilken attack väljer du
int attackValNum = 0;           // vilken nummer av attack vill du göra
int mötandenum = 0;             //vilket monster man möter
int monster = 0;           //vilket monsters hp

int monsterSkada = Random.Shared.Next(10, 50);           // Hur mycket skada monster gör              
int läka = 30;                      //Hur mycket hälsa du får vid läkning

List<string> attacker = ["Peta", "Slå", "Klyva", "Skjuta"];               // De olika attackerna
List<int> skada = [Random.Shared.Next(10, 20), Random.Shared.Next(20, 40), Random.Shared.Next(30, 70), Random.Shared.Next(10, 90)];           // Hur mycket skada som vapnena gör
List<string> mötande = ["Giftorm", "Trädmonster", "Sork", "skogstroll"];
List<int> monsterHälsa = [Random.Shared.Next(80, 95), Random.Shared.Next(80, 95), Random.Shared.Next(80, 95), Random.Shared.Next(80, 95)];     // Hur mycket hälsa ett monster kan ha


System.Console.WriteLine("En dag när du är ute och vandrar i skogen så märker du plötsligt att du tappat bort dig i skogen, Du måste ta dig hem."); // Startdialog
rum();
System.Console.WriteLine($"Du har {hälsa} i hälsa och har tillgång till ett antal attacker.");
rum();
for (int i = 0; i < attacker.Count; i++) // Visar dina attacker och dess skada
{
    System.Console.WriteLine($"{attacker[i]} gör {skada[i]} i skada");
    rum();
}

System.Console.WriteLine("Hur många korsningar vill du gå i, du kan välja mellan 1 och 4"); // Låter dig välja mellan antal korsningar från 1 till 4
string antalKors = Console.ReadLine();
bool korsBool = int.TryParse(antalKors, out int antalKorsNum);
while (true)       // Kontroll för vad man kan skriva
{
    if (antalKorsNum > 4)
    {
        System.Console.WriteLine("Skriv in igen 1 till 4");
        antalKors = Console.ReadLine();
        korsBool = int.TryParse(antalKors, out antalKorsNum);
    }
    else if (antalKorsNum < 1)
    {
        System.Console.WriteLine("Skriv in igen 1 till 4");
        antalKors = Console.ReadLine();
        korsBool = int.TryParse(antalKors, out antalKorsNum);
    }
    else if (korsBool == false)
    {
        System.Console.WriteLine("Skriv in igen 1 till 4");
        antalKors = Console.ReadLine();
        korsBool = int.TryParse(antalKors, out antalKorsNum);
    }
    else
    {
        break;
    }
}



for (int i = 0; i < antalKorsNum; i++)    // Själva huvudprocessen med vägval.
{
    System.Console.WriteLine("Du når en korsning där stigen delar sig i tre. Du kan välja att gå vänster, höger eller fortsätta rakt.");
    val = Console.ReadLine();

    val = vägVal(val);

    if (val == "rakt")              // Det som händer om man väljer att gå rakt
    {
        int händelse = väghändelse(); // man hämtar ett slumptal som påverkar om det blir händelse 1, 2 eller 3
        if (händelse == 1)
        {
            hälsa = läker(hälsa, läka);
        }
        else if (händelse == 2)
        {
            hälsa = möta(mötande, mötandenum, monsterHälsa, monster, monsterSkada, hälsa, attacker, skada, attackVal, attackValNum, attack);
            if (hälsa <= 0)
            {
                System.Console.WriteLine("Du är död, tryck enter för att fortsätta.");
                Console.ReadLine();
                break;
            }
            monster++;
            mötandenum++;
        }
        else if (händelse == 3)
        {
            inget();
        }
    }
    else if (val == "vänster")                      // Det som händer om man väljer att gå vänster
    {
        int händelse = väghändelse();
        if (händelse == 1)
        {
            hälsa = läker(hälsa, läka);
        }
        else if (händelse == 2)
        {
            hälsa = möta(mötande, mötandenum, monsterHälsa, monster, monsterSkada, hälsa, attacker, skada, attackVal, attackValNum, attack);
            if (hälsa <= 0)
            {
                System.Console.WriteLine("Du är död, tryck enter för att fortsätta.");
                Console.ReadLine();
                break;
            }
            monster++;
            mötandenum++;
        }
        else if (händelse == 3)
        {
            inget();
        }
    }
    else if (val == "höger")                // Det som händer om man väljer att gå höger
    {
        int händelse = väghändelse();
        if (händelse == 1)
        {
            hälsa = läker(hälsa, läka);
        }
        else if (händelse == 2)
        {
            hälsa = möta(mötande, mötandenum, monsterHälsa, monster, monsterSkada, hälsa, attacker, skada, attackVal, attackValNum, attack);
            if (hälsa <= 0)
            {
                System.Console.WriteLine("Du är död, tryck enter för att fortsätta.");
                Console.ReadLine();
                break;
            }
            monster++;
            mötandenum++;
        }
        else if (händelse == 3)
        {
            inget();
        }
    }
}
rum();


if (hälsa <= 0)       // om man förlorar spelet
{
    System.Console.WriteLine("Du förlorade! ha");
}
else if (hälsa > 0)      // Om man överlever spelet
{
    System.Console.WriteLine($"Grattis du klarade spelet med {hälsa} kvar i hp");
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


static void inget()                         //när inget händer i en korsning
{
    System.Console.WriteLine("Inget händer.");
}

static int läker(int hälsa, int läka)                       //När man läker i en korsning
{
    System.Console.WriteLine($"Du hittar en läkande flaska och läker {läka} i hälsa.");
    hälsa += läka;

    return hälsa;
}


static int möta(List<string> mötande, int mötandenum, List<int> monsterHälsa, int monster, int monsterSkada, int hälsa, List<string> attacker, List<int> skada, string attackVal, int attackValNum, bool attack)            //Processen när man möter ett monster och sedan slåss mot det
{
    System.Console.WriteLine($"Du möter en {mötande[mötandenum]} som kommer upp för att attackera.");
    rum();
    System.Console.WriteLine($"{mötande[mötandenum]} har {monsterHälsa[monster]} i hälsa och gör {monsterSkada} i skada");
    rum();
    hälsa = monsterStrid(hälsa, monsterSkada, monsterHälsa, attacker, skada, attackVal, attackValNum, monster, attack);
    hälsa = Math.Max(0, hälsa);
    System.Console.WriteLine($"Du har {hälsa} kvar i hälsa");
    return hälsa;
}




static int monsterStrid(int hälsa, int monsterSkada, List<int> monsterHälsa, List<string> attacker, List<int> skada, string attackVal, int attackValNum, int monster, bool attack) //Själva monsterstriden
{
    while (true)
    {
        for (int i = 0; i < attacker.Count; i++)            // Skriver ut vilka attacker du har
        {
            System.Console.WriteLine($"Du kan använda {attacker[i]} som gör {skada[i]} i skada");
        }
        System.Console.WriteLine($"Du har {hälsa} i hälsa.");                   // Dialog innan strid
        System.Console.WriteLine($"Monstret har {monsterHälsa[monster]} i hälsa.");
        System.Console.WriteLine("Vilken attack vill du använda? Skriv 1 nummer 1 till 4.");
        attackVal = Console.ReadLine();
        attack = int.TryParse(attackVal, out attackValNum);

        while (true)
        {            // Kollar så att att man väljer en attack
            if (attackValNum > 4)
            {
                System.Console.WriteLine("Skriv ett nummer mellan 1 och 4");
                attackVal = Console.ReadLine();
                attack = int.TryParse(attackVal, out attackValNum);
            }
            else if (attackValNum < 1)
            {
                System.Console.WriteLine("Skriv ett nummer mellan 1 och 4");
                attackVal = Console.ReadLine();
                attack = int.TryParse(attackVal, out attackValNum);
            }
            else if (attack == false)
            {
                System.Console.WriteLine("Skriv ett nummer mellan 1 och 4");
                attackVal = Console.ReadLine();
                attack = int.TryParse(attackVal, out attackValNum);
            }
            else
            {
                break;
            }
        }
        attackValNum--;


        hälsa -= monsterSkada;                              //Själva attackfasen börjar
        System.Console.WriteLine($"Monster gör {monsterSkada} i skada på dig");
        rum();
        monsterHälsa[monster] -= skada[attackValNum];
        System.Console.WriteLine($"Du skadar monstret med {attacker[attackValNum]} och gör {skada[attackValNum]} på monstret");
        rum();

        System.Console.WriteLine($"Monstret har {Math.Max(0, monsterHälsa[monster])} i hälsa kvar");  //så att monstret inte får negativt i hälsa
        rum();
        System.Console.WriteLine($"Du har {hälsa} i hälsa kvar");
        rum();

        if (monsterHälsa[monster] > 0)
        {       // gör så att det bara sägs när monstret lever
            System.Console.WriteLine("skriv valfritt för nästa runda");
        }
        else
        {
            System.Console.WriteLine("Skriv valfritt för att återgå till vägen");
        }
        Console.ReadLine();
        Console.Clear();

        if (monsterHälsa[monster] <= 0)
        {
            System.Console.WriteLine("Du Dödade monstret");
            return hälsa;
        }
        else if (hälsa <= 0)
        {
            System.Console.WriteLine("Du är död");                        //att spelat avslutas om man dör.           
            return hälsa;
        }
    }
}

static int väghändelse()
{//gör så att det sker olika händelser för riktningarna varje gång     
    int händelseval = Random.Shared.Next(1, 4);
    return händelseval;
}
