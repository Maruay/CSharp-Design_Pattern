using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Design_Pattern.Models.Builder
{
    public class OldRobotBuilder : RobotBuilder
    {
        private Robot robot;

        public OldRobotBuilder(){
            this.robot = new Robot();
        }

        public void buildRobotHead()
        {
            robot.setRobotHead("Tin Head");
        }

        public void buildRobotTorso(){
            robot.setRobotTorso("Tin Torso");
        }
        
        public void buildRobotArms(){
            robot.setRobotArms("Tin Arms");
        }

        public void buildRobotLegs()
        {
            robot.setRobotLegs("Tin Legs");
        }

        public Robot getRobot()
        {
            return this.robot;
        }
    }
}