using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalagaConC_
{
    public class Alien : Ship
    {
        public int Health { get; set; };

        public Alien(int id, object render, object hitbox, int[] position, Projectile projectile) : this(id, render, hitbox, position, projectile, 1)
        { }
        public Alien(int id, object render, object hitbox, int[] position, Projectile projectile, int health = 1)
        {
            this.Id = id;
            this.Render = render;
            this.Hitbox = hitbox;
            this.Position = position;
            this.Projectile = projectile;
            this.Health= health;



        }
    }

}
