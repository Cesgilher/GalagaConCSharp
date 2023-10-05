using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalagaConC_
{
    public class Board
    {
        private int id;
        private Alien[] aliens;
        private PlayerShip playerShip;

        public int Id { get => id; set => id = value; }
        public Alien[] Aliens { get => aliens; set => aliens = value; }
        public PlayerShip PlayerShip { get => playerShip; set => playerShip = value; }


        public void CreateShip() { }
        public void Update() { }
        public void DeleteShip() { }
        public void CheckEnemyShip(Ship ship) { }
        public void Shoot(Ship ship) { }
        public void MoveShip(Ship ship) { }
        public void MoveAliens() { }

    }
}
