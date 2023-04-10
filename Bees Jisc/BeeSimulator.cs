using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bees_Jisc
{
    public class BeeSimulator
    {
        private List<IBee> bees;
        public List<IBee> Bees
        {
            get { return bees; }
        }

        public BeeSimulator()
        {
            bees = new List<IBee>();

            //adding 10 oof each type of bees to common list
            bees.AddRange(Enumerable.Range(1, 10).Select(i => new Queen()));
            bees.AddRange(Enumerable.Range(1, 10).Select(i => new Drone()));
            bees.AddRange(Enumerable.Range(1, 10).Select(i => new Worker()));
        }       

        public void RandomDamage()
        {
            Random rnd = new Random();
            foreach (IBee bee in bees)
            {
                int damagePercentage = rnd.Next(0, 81);
                bee.Damage(damagePercentage);
            }
        }

        public List<IBee> GetBeeStatus()
        {
            return bees;
        }



    }

}
