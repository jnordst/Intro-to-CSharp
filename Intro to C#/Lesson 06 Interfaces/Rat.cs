using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro_to_C_.Lesson_06_Interfaces
{
    internal class Rat : Battler, iAttack, iDamageable, iHealable, iDefeatable
        // Rat inherits from Battler and implements the iDamageable, iHealable, and iDefeatable interfaces
    {
        // Classes can implement multiple interfaces, but can only inherit from one class
        // You can use interfaces to add functionality to a class without having to inherit from a specific class
        // This is useful when you want to add functionality to a class that already inherits from another class
        // When implemented, Interfaces are like contracts that say "If you implement this interface, you must have these methods"
        // By implementing an Interface you must also implement all the methods and fields of that interface
        // By using Interfaces you can build a class that has the functionality of multiple classes without having to inherit from multiple classes
        
        // Constructor
        public Rat(string name, int hp, int maxHp, int atk, int def) : base(name, hp, maxHp, atk, def)
        {
            
        }

        // Heal() is defined in iHealable
        public string Heal(int amount)
        {
            hp += amount;

            // Make sure hp doesn't go over maxHp
            if (hp > maxHp)
            {
                hp = maxHp;
            }

            return $"{name} heals for {amount} hp!";
        }

        // TakeDamage() is defined in iDamageable
        public string TakeDamage(int damage)
        {
            // Get the true value of damage after defense is taken into account
            damage = damage - def;
            
            // Make sure damage doesn't go below 0
            if (damage < 0) damage = 0;

            // Subtract damage from hp
            hp -= damage;

            // Make sure hp doesn't go below 0
            if (hp < 0)
            {
                hp = 0;

                // Call the Defeat() method on this object if hp is 0
                return $"{name} takes {damage} damage! \n" + Defeat();
            }

            // Return the result of the damage
            return $"{name} takes {damage} damage!";
        }

        // Defeat() is defined in iDefeatable
        public string Defeat()
        {
            return $"{name} is defeated!";
        }

        public string Attack(Battler target)
        {
            // Check if the target has the iDamageable interface
            if (target is iDamageable)
            {
                // Cast the target to an iDamageable to access the TakeDamage() method
                iDamageable damageableTarget = (iDamageable)target;

                // Call the TakeDamage() method on the target
                return damageableTarget.TakeDamage(atk);
            }

            // Return a message if the target doesn't have the iDamageable interface
            return $"{name} attacks {target.name}, but doesn't do any damage!?";
        }
    }
}
