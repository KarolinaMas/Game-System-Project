using GameSystem.Models;

namespace GameSystem.Models
{
    public class Warrior : Character
    {
        public int ArmorRating { get; set; }
        public int Rage { get; set; }

        public override int TakeDamage(int damage)
        {
            int reducedDamage = damage - ArmorRating;

            if (reducedDamage < 0)
                reducedDamage = 0;

            return base.TakeDamage(reducedDamage);
        }

        public override void UseSpecialAbility()
        {
            Rage = 3;
            Console.WriteLine($"{Name} has activated Berserker Rage!");
        }

        public override int Attack(Character target)
        {
            ArgumentNullException.ThrowIfNull(target);

            int damage = AttackPower;

            if (Rage > 0)
            {
                Rage--;
                damage *= 2;
            }

            return target.TakeDamage(damage);
        }
    }
}
