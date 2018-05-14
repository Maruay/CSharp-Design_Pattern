using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Design_Pattern.Models.Builder
{
    public class RobotEngineer
    {
        private RobotBuilder robotBuilder;

        public RobotEngineer(RobotBuilder robotBuilder)
        {
            this.robotBuilder = robotBuilder;
        }

        public Robot getRobot()
        {
            return this.robotBuilder.getRobot();
        }

        public void makeRobot()
        {
            this.robotBuilder.buildRobotHead();
            this.robotBuilder.buildRobotTorso();
            this.robotBuilder.buildRobotArms();
            this.robotBuilder.buildRobotLegs();
        }
    }
}