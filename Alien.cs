using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalagaConC_
{
    public class Alien : Ship
    {
        public Alien(int id, object render, object hitbox, int[] position, Projectile projectile) : this(id, render, hitbox, position, projectile, 1)
        { }
        public Alien(int id, object render, object hitbox, int[] position, Projectile projectile, int health)
        { }
    }

}
