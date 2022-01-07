using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Player
    {
        public Player()
        {

        }
        public Player(string name, int health)
        {
            name = Name;
            health = Health;
        }

        public string Name { get; set; }
        public int Health = 5;


    }
}
