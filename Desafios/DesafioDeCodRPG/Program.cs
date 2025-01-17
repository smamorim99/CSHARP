int heroesLifePoints = 10;
int monsterLifePoints = 10;

Random dice = new ();
do{
        int roll = dice.Next(1,10);
        monsterLifePoints = monsterLifePoints - roll;
        Console.WriteLine($"Monster was demage and lost {roll} life points, and now has {monsterLifePoints} points ");
      
            if (monsterLifePoints > 0){
                roll = dice.Next(1,10);
                heroesLifePoints = heroesLifePoints - roll;
                Console.WriteLine($"Heroe was demage and lost {roll} life points, and now has {heroesLifePoints} points");
            }    
}
while ( monsterLifePoints > 0 && heroesLifePoints >0);
Console.WriteLine(heroesLifePoints > monsterLifePoints? "hero wins" : "monster Wins");