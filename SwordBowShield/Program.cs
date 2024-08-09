using System;


public class Enemy
{
    public string Class_type;
    public int Sword_chance;
    public int Shield_chance;
    public int Bow_chance;


    public Enemy(String class_type, int sword_chance, int shield_chance, int bow_chance)
    {
        this.Class_type = class_type;
        this.Sword_chance = sword_chance;
        this.Bow_chance = bow_chance;
        this.Shield_chance = shield_chance;
    }

    


}
public class Sword_Shield_Bow
{
    public static void Main()
    {
        Enemy e1 = new Enemy("Adventurer",3,6,9);
        Enemy e2 = new Enemy("Archer",5,7,9);
        Enemy e3 = new Enemy("Swordsman",2,4,9);
        Enemy e4 = new Enemy("Archer",2,7,9);
        Enemy e5 = new Enemy("Paladin",4,8,9);
        Enemy e6 = new Enemy("Rogue",4,8,9);
        Enemy e7 = new Enemy("Crossbowman",1,5,9);
        Random rnd = new Random();
        Random rnd2 = new Random();
        bool alive = true;
        int playerhp = 5;
        int enemyhp  = 3;
        int killcount = 0;
        Console.WriteLine("===================");
		Console.WriteLine("Your Journey Begins");
		Console.WriteLine("===================");

        string[] name = {e1.Class_type,e2.Class_type,e3.Class_type,e4.Class_type,e5.Class_type,e6.Class_type,e7.Class_type};
        int[] xsword_chance = {e1.Sword_chance,e2.Sword_chance,e3.Sword_chance,e4.Sword_chance,e5.Sword_chance,e6.Sword_chance,e7.Sword_chance,};
        int[] xbow_chance = {e1.Bow_chance,e2.Bow_chance,e3.Bow_chance,e4.Bow_chance,e5.Bow_chance,e6.Bow_chance,e7.Bow_chance,};
        int[] xshield_chance = {e1.Shield_chance,e2.Shield_chance,e3.Shield_chance,e4.Shield_chance,e5.Shield_chance,e6.Shield_chance,e7.Shield_chance,};

        while(alive){
            int encounter = rnd.Next(6);
            Console.WriteLine("You have encountered a " + name[encounter]);
            bool InCombat = true;
            enemyhp = 3;
            while(InCombat)
            {
                Console.WriteLine("What weapon will you use?");
                Console.WriteLine("||Sword//Bow//Shield||");

                int enemyroll = rnd2.Next(8);

                switch(Console.ReadLine())
                {
                    case "Sword":
                        if(enemyroll<xsword_chance[encounter])
                        {
                        Console.WriteLine("The enemy used a sword");
                        Console.WriteLine("Draw");
                        }else if(enemyroll<xbow_chance[encounter]){
                        Console.WriteLine("The enemy used a bow");
                        Console.WriteLine("Lose");
                        playerhp--;
                        Console.WriteLine("Your Hp = " + playerhp);
                        }else if(enemyroll<xshield_chance[encounter]){
                        Console.WriteLine("The enemy used a shield");
                        Console.WriteLine("Win");
                        enemyhp--;
                        Console.WriteLine("Enemy Hp = " + enemyhp);
                        };
                        break;
                    case "Bow":
                        if(enemyroll<xsword_chance[encounter]){
                        Console.WriteLine("The enemy used a sword");
                        Console.WriteLine("Win");
                        enemyhp--;
                        Console.WriteLine("Enemy Hp = " + enemyhp);
                        }else if(enemyroll<xbow_chance[encounter]){
                        Console.WriteLine("The enemy used a bow");
                        Console.WriteLine("Draw");
                        }else if(enemyroll<xshield_chance[encounter]){
                        Console.WriteLine("The enemy used a shield");
                        Console.WriteLine("Lose");
                        playerhp--;
                        Console.WriteLine("Your Hp = " + playerhp);
                        };
                        break;
                    case "Shield":
                        if(enemyroll<xsword_chance[encounter]){
                        Console.WriteLine("The enemy used a sword");
                        Console.WriteLine("Lose");
                        playerhp--;
                        Console.WriteLine("Your Hp = " + playerhp);
                        }else if(enemyroll<xbow_chance[encounter]){
                        Console.WriteLine("The enemy used a bow");
                        Console.WriteLine("Win");
                        enemyhp--;
                        Console.WriteLine("Enemy Hp = " + enemyhp);
                        }else if(enemyroll<xshield_chance[encounter]){
                        Console.WriteLine("The enemy used a shield");
                        Console.WriteLine("Draw");
                        };
                        break;
                    case "Exit":
                        alive = false;
                        InCombat = false;
                        break;
                    default:
                        Console.WriteLine("Invalid");
                        break;
                }

                if(playerhp == 0){
                    Console.WriteLine("=============");
		            Console.WriteLine("You have died");
		            Console.WriteLine("=============");
                    alive = false;
                    InCombat = false;
                }else if(enemyhp == 0){
                    Console.WriteLine("=============");
		            Console.WriteLine("You have Won!");
		            Console.WriteLine("=============");
                    killcount++;
                        if(killcount == 3){
                        Console.WriteLine("You have been healed.");
                        playerhp = 5;
                    };
                    InCombat = false;
                }else continue;
            }
        }   


        Console.ReadKey();



    }

}

