using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalagaConC_
{
    public class PlayerShip : Ship
    {
        bool Shield { get; set; };

        public PlayerShip( int id, object render, object hitbox, int[] position, Projectile projectile) : this(id, render, hitbox, position, projectile, true)
        { }
        public PlayerShip(int id, object render, object hitbox, int[] position, Projectile projectile, bool shield = true) 
        {
            this.Id = id;
            this.Render = render;
            this.Hitbox = hitbox;
            this.Position = position;
            this.Projectile = projectile;
            this.Shield = shield;
            
        
        
        }
    }
}
