using DamageCalculatorConsoleApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwordDamageTest
{
    class SwordDamage : WeaponDamage
    {
        public SwordDamage(int startingRoll) : base(startingRoll) { }

        private const int BASE_DAMAGE = 3;
        private const int FLAME_DAMAGE = 2;

       
        protected override void CalculateDamage()
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
