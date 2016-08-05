using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Robocode;
using Robocode.Util;

namespace JRP
{
    class PotterRobot : Robot
    {
        private bool movingForward = false;

        // The main method of your robot containing robot logics
        public override void Run()
        {

            // -- Initialization of the robot --
            // Set colors

            // Infinite loop making sure this robot runs till the end of the battle round
            while (true)
            {
                // -- Commands that are repeated forever --
                while (true)
                {
                    TurnGunLeft(5);
                }
            }
        }

        // Robot event handler, when the robot sees another robot
        public override void OnScannedRobot(ScannedRobotEvent e)
        {
            if (e.Distance < 50 && Energy > 50)
            {
                Fire(3);
            } // otherwise, fire 1.
            else
            {
                Fire(1);
            }

            // Call scan again, before we turn the gun
            Scan();
        }

        public void HitRobotEvent(HitRobotEvent e)
        {
            
        }

        public override void OnHitByBullet(HitByBulletEvent e)
        {

            Random r = new Random();
            var value = r.Next(0, 1);

            if (value == 0)
            {
                TurnRight(30);
            }
            else
            {
                TurnLeft(30);
            }
            
            Ahead(65);
            Scan();
        }

        public void HitWallEvent(HitWallEvent e)
        {

        }
    }
}
