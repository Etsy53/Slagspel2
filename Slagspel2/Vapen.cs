using System;

namespace Slagspel2
{
    public class Vapen
    {

        public int minDamage = 10;
        public int maxDamage = 34;
        public string namn;

        private Random generator = new Random();
        
        public int Attack()
        {
            return generator.Next(minDamage, maxDamage);
        }
    }
}
