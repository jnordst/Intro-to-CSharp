using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro_to_C_.Lesson_06_Interfaces
{
    internal interface iDamageable 
    {
        // Interfaces are like abstract classes, but they can only contain abstract methods
        // Interfaces can also contain properties, but they must be abstract properties
        // Interfaces are used to add functionality to a class without having to inherit from a specific class
        // Common naming convention for interfaces is to start the name with a lowercase "i"

        // By implenting this interface, any class that implements this interface must have a TakeDamage() method
        string TakeDamage(int damage);
    }
}
