namespace GameSystem.Models
{
    public abstract class Character
    {
        public string Name { get; set; }
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
        }
    }
}
