using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game
{
     class Game
    {
        private static List<Character> _characters = new();  
        public static void AddCharacter(string name,int power,int health,int type)
        {
            if (type == 1)
            {
                var hero = new Hero(name, power, health);
                _characters.Add(hero);
            }
            if (type == 2)
            {
                var enemy = new Enemy(name, power, health);
                _characters.Add(enemy);
            }
            if (type == 3)
            {
                var available = new Available(name, power, health);
                _characters.Add(available);
            }
        }
        public static void Fight(string attacker,string defender)
        {
            var attackerr = _characters.Find(_ => _.Name == attacker);
            var defenderr = _characters.Find(_ => _.Name == defender);
            var power = attackerr.Power;
            var health = defenderr.Health;
            var result = health - power;
            if (result <= 0)
            {
                defenderr.Situation = Situation.dead;
                Console.WriteLine($"defender health={result},defender situation={defenderr.Situation}");
            }
            else
            {
                defenderr.Situation = Situation.live;
                Console.WriteLine($"defender health={result},defender situation{defenderr.Situation}");
            }
        }
    }
}
