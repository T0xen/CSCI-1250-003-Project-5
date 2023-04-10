using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot_Cave_Fights
{
    internal class YourRobot
    {
        private string robotName;
        private string[] studentNames;
        private double attack;
        private double defense;
        private double speed;
        private double constitution;
        private double health;
        private string primaryColor;
        private string secondaryColor;

        public YourRobot(string robotName, string[] studentNames, double attack, double defense, double speed, double constitution, double health, string primaryColor, string secondaryColor)
        {
            this.robotName = robotName; // Big Buff Vampire
            this.studentNames = studentNames; // Samuel, Shane, JL
            this.attack = attack; // 13, could increase to 16 and drop defense to 10; 10 attack = 10 damage
            this.defense = defense; // 13, could drop to 10
            this.speed = speed; // 1
            this.constitution = constitution; // 13
            this.health = health; // con * 10 = 130 HP
            this.primaryColor = primaryColor; // #000000
            this.secondaryColor = secondaryColor; // #000000
        }

        public ActionResult Attack(IRobot opponent)
        {
            // To Do
        }

        public ActionResult CustomAction1(IRobot opponent) // Lifesteal attack using 80% of attack stat and returns health equal to 20% of attack stat
        {
            // To Do
        }

        public ActionResult CustomAction2(IRobot opponent)
        {
            // To Do
        }

        public ActionResult CustomAction3(IRobot opponent)
        {
            // To Do
        }

        public ActionResult CustomAction4(IRobot opponent)
        {
            // To Do
        }

    }


}
