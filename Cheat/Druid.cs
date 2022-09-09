using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheat
{
    internal class Druid
    {
        public int Hp { get; set; }

        public delegate void WarMessage(string message);

        private WarMessage War;

        public bool isDeath { get; set; }


        public Druid(int hp, WarMessage warMessage)
        {
            Hp = hp;
            War = warMessage;
        }

        public void GetDammage(int a)
        {
            Hp -= a;

            if (Hp <= 0)
            {
                War?.Invoke("I'm dead");
                isDeath = true;
            }
            
            else War?.Invoke("Our fight will be continue!");

        }
    }
}
