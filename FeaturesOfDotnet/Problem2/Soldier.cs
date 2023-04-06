

using DynamicExpresso;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeaturesOfDotnet.Problem2
{
    public delegate void play(int c);
    internal class Soldier
    {

        private string _soldierNumber;
        private int _coins;

        public Soldier(string soldierNumber, int coins)
        {
            _soldierNumber = soldierNumber;
            _coins = coins;
        }
        public string SoldierNumber { get {  return _soldierNumber; }  set { _soldierNumber = value; } } 
        public int Coins { get { return _coins; } set { _coins = value; } }

        public void Playgame(int coins)
        {
            
        }
    }
}
