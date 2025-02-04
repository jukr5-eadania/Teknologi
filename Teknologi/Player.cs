using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teknologi
{
    public delegate void DeathEventHandler(Player p);

    public class Player
    {
        public event DeathEventHandler DeathEvent;

        protected virtual void OnDeathEvent()
        {
            DeathEvent?.Invoke(this);
        }

        private string playerName;
        private int health = 100;

        public int Health
        {
            get { return health; }
            set
            {
                health = value;
                if (health <= 0)
                {
                    OnDeathEvent();
                }
            }
        }

        public Player(string name)
        {
            this.playerName = name;
        }

        public override string ToString() { return playerName; }
    }
}
