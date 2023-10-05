using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalagaConC_
{
    public abstract class Ship
    {
        private int id;
        private string render;
        private object hitbox;
        private int[] position;
        private Projectile projectile;

        public int Id { get => id; set => id = value; }
        public string Render { get => render; set => render = value; }
        public object Hitbox { get => hitbox; set => hitbox = value; }
        public int[] Position { get => position; set => position = value; }
        public Projectile Projectile { get => projectile; set => projectile = value; }
        
    }
}
