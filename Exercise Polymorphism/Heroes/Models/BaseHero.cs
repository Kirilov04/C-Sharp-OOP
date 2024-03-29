﻿namespace Heroes.Models
{
    public abstract class BaseHero
    {
        public string Name { get; protected set; }
        public int Power { get; protected set; }

        public abstract string CastAbility();

        public BaseHero(string name, int power)
        {
            Name = name;
            Power = power;
        }

    }
}
