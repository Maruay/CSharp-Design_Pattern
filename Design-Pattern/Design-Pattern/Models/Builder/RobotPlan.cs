using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Design_Pattern.Models.Builder
{
    public interface RobotPlan
    {
        void setRobotHead(string head);
        void setRobotTorso(string torso);
        void setRobotArms(string arms);
        void setRobotLegs(string legs);
    }
}