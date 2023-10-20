using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalagaConC_.Models
{
    public class PlayerShip : Ship
    {
        bool Shield { get; set; }

        public PlayerShip(int id, object render, object hitbox, int[] position, Projectile projectile) : this(id, render, hitbox, position, projectile, true)
        { }
        public PlayerShip(int id, object render, object hitbox, int[] position, Projectile projectile, bool shield = true)
        {
            Id = id;
            Render = render;
            Hitbox = hitbox;
            Position = position;
            Projectile = projectile;
            Shield = shield;



        }
    }
}
