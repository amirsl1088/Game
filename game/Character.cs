using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace game
{
    public abstract class Character
    {
        private int _health;
        public Character(string name, int power, int health)
        {
            Power = power;
            Health = health;
            Name = name;
        }
        public string Name { get; set; }
        public int Power { get; set; }

        public virtual int Health
        {
            get
            {
                return _health;
            }
            set
            {
                if (value > 100)
                {
                    throw new Exception();
                }
                _health = value;
            }
        }
        public Situation Situation { get; set; }
      
    }
    public enum Situation
    {
        live, dead
    }

}
