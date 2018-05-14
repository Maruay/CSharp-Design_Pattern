using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Design_Pattern.Models.Factory_Method
{
    public class EnemyShipFactory
    {
        public EnemyShip makeEnemyShip(string newEnemyType)
        {
            EnemyShip newEnemy = null;

            if (newEnemyType.Equals("U"))
            {
                return new UFOEnemyShip();
            }
            else if (newEnemyType.Equals("R"))
            {
                return new RocketEnemyShip();
            }
            else if (newEnemyType.Equals("B"))
            {
                return new BigUFOEnemyShip();
            }
            else
            {
                return null;
            }
        }
    }
}