using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro_to_C_.Lesson_06_Interfaces
{
    internal abstract class Battler
    {
        // This is just a base class

        public string name { get; protected set; }

        public int hp { get; protected set; }

        public int maxHp { get; protected set; }

        public int atk { get; protected set; }

        public int def { get; protected set; }

        public Battler(string name, int hp, int maxHp, int atk, int def)
        {
            this.name = name;
            this.hp = hp;
            this.maxHp = hp;
            this.atk = atk;
            this.def = def;
        }
    }
}
