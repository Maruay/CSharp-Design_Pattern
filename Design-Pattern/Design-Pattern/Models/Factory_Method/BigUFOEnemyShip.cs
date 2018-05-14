using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Design_Pattern.Models.Factory_Method
{
    public class BigUFOEnemyShip : EnemyShip
    {
        public BigUFOEnemyShip()
        {
            setName("Big UFO Enemy Ship");
            setDamage(40.0);
        }
    }
}