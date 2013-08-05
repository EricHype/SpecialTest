using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialCore
{
    public class Character
    {
        public string Name { get; set; }
        public int Hp { get; set; }
        public int Level { get; set; }

        //attributes
        public int Strength { get; set; }
        public int Perception { get; set; }
        public int Endurance { get; set; }
        public int Charisma { get; set; }
        public int Intelligence { get; set; }
        public int Agility { get; set; }
        public int Luck { get; set; }

        //skills
        public int Lockpick { get; set; }

    }
}
