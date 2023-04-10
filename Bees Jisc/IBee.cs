using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bees_Jisc
{
    public interface IBee
    {
        double Health { get; }
        bool Dead { get; }
        void Damage(int percentage);

        void CheckIfDead();
        
    }
}
