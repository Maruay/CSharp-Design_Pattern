using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Design_Pattern.Models.Builder
{
    public class Robot : RobotPlan
    {
        private string robotHead;
        private string robotTorso;
        private string robotArms;
        private string robotLegs;

        public void setRobotHead(string head)
        {
            robotHead = head;
        }
        public string getRobotHead() { return robotHead; }

        public void setRobotTorso(string torso)
        {
            robotTorso = torso;
        }
        public string getRobotTorso() { return robotTorso; }

        public void setRobotArms(string arms)
        {
            robotArms = arms;
        }
        public string getRobotArms() { return robotArms; }

        public void setRobotLegs(string legs)
        {
            robotLegs = legs;
        }
        public string getRobotLegs() { return robotLegs; }
    }
}