using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Design_Pattern.Models.Builder
{
    public class NewRobotBuilder : RobotBuilder
    {
        private Robot robot;

        public NewRobotBuilder()
        {
            this.robot = new Robot();
        }

        public void buildRobotHead()
        {
            this.robot.setRobotHead("Big Head");
        }
        public void buildRobotTorso()
        {
            this.robot.setRobotTorso("Slim Torso");
        }
        public void buildRobotArms()
        {
            this.robot.setRobotArms("Big Arms");
        }
        public void buildRobotLegs()
        {
            this.robot.setRobotLegs("Small Legs");
        }
        public Robot getRobot()
        {
            return this.robot;
        }
    }
}