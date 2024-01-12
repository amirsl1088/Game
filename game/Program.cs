using game;

while (true)
{
    Console.WriteLine("choose one:\n1.add character\n2.fight");
    var input = int.Parse(Console.ReadLine()!);
    switch (input)
    {
        case 1:
            {
                Console.WriteLine("enter character name");
                var characterName = Console.ReadLine()!;
                Console.WriteLine("1-hero\n2-enemy\n3-available");
                var type = int.Parse(Console.ReadLine()!);
                Console.WriteLine("enter character power");
                var characterPower =int.Parse( Console.ReadLine()!);
                Console.WriteLine("enter character health");
                var characterHealth = int.Parse(Console.ReadLine()!); 
                Game.AddCharacter(characterName, characterPower, characterHealth, type);
                break;
            }
        case 2:
            {
                Console.WriteLine("enter attacker name");
                var attackerName = Console.ReadLine()!;
                Console.WriteLine("enter defender name");
                var defenderName = Console.ReadLine()!;
                Game.Fight(attackerName, defenderName);
                break;
            }
    }
}