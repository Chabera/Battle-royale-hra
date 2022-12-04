using ConsoleApp2;


Bojovnik Jakub = new Bojovnik("Jakub");
Bojovnik Enemy = new Bojovnik("Enemy", 100);
Bojovnik Knight = new Bojovnik("Knight", 130);
Enemy.Jmeno = "Enemy";

Console.WriteLine(Jakub.GetJmeno());
Console.WriteLine(Jakub.HP + " HP");
Console.WriteLine("");
Console.Write("S kým chceš bojovat?");
string userChoice = Console.ReadLine();

/*Console.WriteLine("Je " + Jakub.Jmeno + " naživu ? " + Jakub.IsAlive); */



if (userChoice == "enemy")
{
    Jakub.AttackFighter(Enemy);
    Enemy.AttackFighter(Jakub, true);

    Console.WriteLine(Jakub.Jmeno + " má " + Jakub.HP + " HP");
    Console.WriteLine(Enemy.Jmeno + " má " + Enemy.HP + " HP");

    bool BojovnikAttackFirst;
    if (Random.Shared.Next(0, 1) == 1)
    {

    }
}
else if (userChoice == "knight")
{
    Jakub.AttackKnight(Knight);
    Knight.AttackKnight(Jakub, true);

    Console.WriteLine(Jakub.Jmeno + " má " + Jakub.HP + " HP");
    Console.WriteLine(Knight.Jmeno + " má " + Knight.HP + " HP");

    bool BojovnikAttackKnight;
    if (Random.Shared.Next(0, 1) == 1)
    {

    }

    Console.Write("Chceš dohrát boj? ");
    string vyber = Console.ReadLine();

    if (vyber == "ano")
    {

    }
    else
    {
        if (Jakub.HP > Knight.HP)
        {
            Console.WriteLine(Jakub.Jmeno + " vyhrál!");
        }
        else if (Jakub.HP < Knight.HP)
        {
            Console.WriteLine(Jakub.Jmeno + " prohál :(");
        }
    }
}








