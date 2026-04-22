namespace GameSystem.Models
{
    public abstract class Character
    {
        public required string Name { get; set; }
        public int Level { get; set; }
        public int Health { get; set; }
        public int MaxHealth { get; set; }
        public int AttackPower { get; set; }

        public abstract string GetClass();

        public virtual int Attack(Character target)
        {
            ArgumentNullException.ThrowIfNull(target);

            target.Health -= AttackPower;

            if (target.Health < 0)
                target.Health = 0;

            return target.Health;
        }

        public virtual int TakeDamage(int damage)
        {
            Health -= damage;

            if (Health < 0)
                Health = 0;

            return Health;
        }

        public bool IsAlive()
        {
            return Health > 0;
        }

        public virtual void UseSpecialAbility() { }

        public abstract void DisplayStats();
    }
}
