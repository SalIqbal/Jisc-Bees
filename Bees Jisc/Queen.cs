using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bees_Jisc
{
   public class Queen : IBee
{
    private const double MAX_HEALTH = 100;
    private double health = MAX_HEALTH;
    private bool dead = false;

    public double Health
    {
        get { return health; }
    }

    public bool Dead
    {
        get { return dead; }
    }

        public void CheckIfDead()
        {
            if (health < 20)
            {
                dead = true;
            }
        }
        public void Damage(int percentage)
    {
        if (!Dead)
        {
            health -= Math.Round((percentage / 100.0 * health),2);
           CheckIfDead();
        }
    }
}

}

