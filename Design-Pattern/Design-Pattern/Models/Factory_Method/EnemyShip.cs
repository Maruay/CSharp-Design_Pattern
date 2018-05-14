using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Design_Pattern.Models.Factory_Method
{
    public abstract class EnemyShip
    {
        private string name;
        private double amtDamage;

        public string getName() { return name; }
        public void setName(string newName) { name = newName; }

        public double getDamage() { return amtDamage; }
        public void setDamage(double newDamage) { amtDamage = newDamage; }

        public string followHeroShip()
        {
            return getName() + " is following the hero\n";
        }

        public string displayEnemyShip()
        {
            return getName() + " is on the screen\n";
        }

        public string enemyShipShoots()
        {
            return getName() + " attacks and does " + getDamage();
        }
    }
}