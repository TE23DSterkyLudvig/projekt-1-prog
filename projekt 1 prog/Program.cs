﻿using System.ComponentModel;

int hälsa = 150;            // Hur mycket hälsa du har
string val;                 // Vilket val du valt gällande rikting
string attackVal = "";          //Vilken attack väljer du
int attackValNum = 0;           // vilken nummer av attack vill du göra
int mötandenum = 0;             //vilket monster man möter
int monster = 0;           //vilket monsters hp

int monsterSkada = Random.Shared.Next(10, 50);           // Hur mycket skada monster gör              
int läka = 30;                      //Hur mycket hälsa du får vid läkning

List<string> attacker = ["Peta", "Slå", "Klyva", "Skjuta"];               // De olika attackerna
List<int> skada = [Random.Shared.Next(10, 20), Random.Shared.Next(20, 40), Random.Shared.Next(30, 70), Random.Shared.Next(10, 100)];           // Hur mycket skada som vapnena gör
List<string> mötande = ["Giftorm", "Trädmonster", "Sork", "skogstroll"];
List<int> monsterHälsa = [Random.Shared.Next(80, 95), Random.Shared.Next(80, 95), Random.Shared.Next(80, 95), Random.Shared.Next(80, 95)];     // Hur mycket hälsa ett monster kan ha


System.Console.WriteLine("En dag när du är ute och vandrar i skogen så märker du plötsligt att du tappat bort dig i skogen, Du måste ta dig hem.");
rum();
System.Console.WriteLine($"Du har {hälsa} i hälsa och har tillgång till ett antal attacker.");
rum();
for (int i = 0; i < attacker.Count; i++)
{
    System.Console.WriteLine($"{attacker[i]} gör {skada[i]} i skada");
    rum();
}


for (int i = 0; i < mötande.Count; i++)
{
    System.Console.WriteLine("Du når en korsning där stigen delar sig i tre. Du kan välja att gå vänster, höger eller fortsätta rakt.");
val = Console.ReadLine();

val = vägVal(val); 

 if (val == "rakt")
{
  int händelse = väghändelse() ;
  if (händelse == 1){
     hälsa = läker(hälsa, läka);
  }
   else if(händelse == 2){
    möta();
    if (hälsa <= 0){
        System.Console.WriteLine("Du är död, tryck enter för att avlsuta.");
        Console.ReadLine(); 
        Environment.Exit(0) ;
         }
  monster++;
  
   }
   else if(händelse == 3){
    inget();
   }
}
else if (val == "vänster")
{
    int händelse = väghändelse() ;
  if (händelse == 1){
     hälsa = läker(hälsa, läka);
  }
   else if(händelse == 2){
    möta();
  monster++;
   }
   else if(händelse == 3){
    inget();
   }
}
else if (val == "höger")
{
   int händelse = väghändelse() ;
  if (händelse == 1){
     hälsa = läker(hälsa, läka);
  }
   else if(händelse == 2){
    möta();
  monster++;
   }
   else if(händelse == 3){
    inget();
   }   
}  
}
rum();
System.Console.WriteLine($"Grattis du klarade spelet med {hälsa} kvar i hp");












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


static void inget(){
    System.Console.WriteLine("Inget händer.");
}

static int läker(int hälsa, int läka){
    System.Console.WriteLine($"Du hittar en läkande flaska och läker {läka} i hälsa.");
    hälsa += läka;
    return hälsa;
}


void möta(){
    System.Console.WriteLine($"Du möter en {mötande[mötandenum]} som kommer upp för att attackera.");
    rum();
    System.Console.WriteLine($"{mötande[mötandenum]} har {monsterHälsa[monster]} i hälsa och gör {monsterSkada} i skada");
    rum();
    hälsa = monsterStrid(hälsa, monsterSkada, monsterHälsa, attacker, skada, attackVal, attackValNum, monster);
    System.Console.WriteLine($"Du har {hälsa} kvar i hälsa");
    monster++;
    mötandenum++;
}




static int monsterStrid(int hälsa, int monsterSkada, List<int> monsterHälsa, List<string> attacker, List<int> skada, string attackVal, int attackValNum, int monster)
{
    while (true)
    {   
        for (int i = 0; i < attacker.Count; i++)
        {
            System.Console.WriteLine($"Du kan använda {attacker[i]} som gör {skada[i]} i skada");
        }
        System.Console.WriteLine("Vilken attack vill du använda? Skriv 1 nummer 1 till 4.");
        attackVal = Console.ReadLine();
        int.TryParse(attackVal, out attackValNum);
        attackValNum--;


        hälsa -= monsterSkada;
        System.Console.WriteLine($"Monster gör {monsterSkada} i skada på dig");
        Thread.Sleep(800);
        monsterHälsa[monster] -= skada[attackValNum];
        System.Console.WriteLine($"Du skadar monstret med {attacker[attackValNum]} och gör {skada[attackValNum]} på monstret");
        Thread.Sleep(800);
        //Math.Max(0,monsterHälsa[monster])
        System.Console.WriteLine($"Monstret har {Math.Max(0,monsterHälsa[monster])} i hälsa kvar");  //så att monstret inte får negativt i hälsa
        //System.Console.WriteLine($"Monstret har {monsterHälsa[monster]} i hälsa kvar");
        Thread.Sleep(800);
        System.Console.WriteLine($"Du har {hälsa} i hälsa kvar");
        Thread.Sleep(800);
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

static int väghändelse(){       //gör det random vad som händer vilket håll man går
     int händelseval = Random.Shared.Next(1,4);
    return händelseval;
}
