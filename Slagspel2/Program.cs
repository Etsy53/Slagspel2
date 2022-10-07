using System;

using Slagspel2;


Gubbe gubbe1 = new Gubbe();
Gubbe gubbe2 = new Gubbe();
gubbe1.vapen = new Vapen();
gubbe2.vapen = new Vapen();

bool avslutad = false;



while(avslutad != true)
{
    int gubbe1AtkDmg = gubbe1.vapen.Attack();
    int gubbe2AtkDmg = gubbe2.vapen.Attack();

    gubbe1.liv -= gubbe2AtkDmg;
    gubbe2.liv -= gubbe1AtkDmg;
    Console.WriteLine($"gubbe1 liv: {gubbe1.liv}");
    Console.WriteLine($"gubbe2 liv: {gubbe2.liv}");
    if(gubbe1.liv <= 0 || gubbe2.liv <= 0)
    {
        avslutad = true;
        Console.WriteLine("Matchen är avslutad");
        if(gubbe1.liv <= 0 && gubbe2.liv <= 0)
        {
            System.Console.WriteLine("Resultat: oavgjort");       
        }
        else if(gubbe2.liv <= 0 && gubbe1.liv > 0)
        {
            System.Console.WriteLine("Resultat: gubbe1 vann");
        }
        else
        {
            System.Console.WriteLine("Resultat: gubbe2 vann");
        }
    }
    else
    {
        System.Console.WriteLine("Tryck på valfri knapp för att attackera igen");
        Console.ReadKey();
        Console.Clear();
    }

}

Console.ReadLine();