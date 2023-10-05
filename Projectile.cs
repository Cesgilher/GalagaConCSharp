using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalagaConC_
{
    public class Projectile
    {
        private int id;
        private object render;
        private int damage;
        private int[] position;

        public int Id { get => id; set => id = value; }
        public object Render { get => render; set => render = value; }
        public int Damage { get => damage; set => damage = value; }
        public int[] Position { get => position; set => position = value; }
    }
}
