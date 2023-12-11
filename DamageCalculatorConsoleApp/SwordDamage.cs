using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwordDamageTest
{
    class SwordDamage
    {
        public SwordDamage(int startingRoll)
        {
            roll = startingRoll;
            CalculateDamage();
        }

        private const int BASE_DAMAGE = 3;
        private const int FLAME_DAMAGE = 2;

        private int roll;
        private bool flaming;
        private bool magic;
        public int Damage { get; private set; }
        public int Roll
        {
            get
            { return roll; }
            set
            {
                roll = value;
                CalculateDamage();
            }
        }
        public bool Flaming
        {
            get
            { return flaming; }
            set
            {
                flaming = value;
                CalculateDamage();
            }
        }
        public bool Magic
        {
            get
            { return magic; }
            set
            {
                magic = value;
                CalculateDamage();
            }
        }
        private void CalculateDamage()
        {
            Damage = Roll + BASE_DAMAGE;
            if (Flaming == true)
            {
                Damage += FLAME_DAMAGE;
            }
            if (Magic == true)
                Damage = (int)(Damage * 1.75M);
        }
    }
}
