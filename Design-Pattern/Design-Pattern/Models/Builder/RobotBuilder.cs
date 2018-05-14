using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Design_Pattern.Models.Builder
{
    public interface RobotBuilder
    {
        void buildRobotHead();
        void buildRobotTorso();
        void buildRobotArms();
        void buildRobotLegs();
        Robot getRobot();
    }
}