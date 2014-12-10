using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ASCII_Dungeon
{
    public class PlayerController
    {
        int PlayerX;
        int PlayerY;
        int Rotation;
        //gibt an wo der Spieler hinsieht, 1 oben, 2 rechts, 3 unten und 4 links!

        public PlayerController(int x, int y, int r)
        {
            PlayerX = x;
            PlayerY = y;
            Rotation = r;
        }

        public void upwards()
        {
            if (Rotation != 1)
            {
                Rotation = 1;
            }
            else
            {
                //if (CollisionDetecion.isfree(x,y-1) == true)
                PlayerY -= 1;
            }
        }

        public void downwards()
        {
            if (Rotation != 3)
            {
                Rotation = 3;
            }
            else
            {
                //if (CollisionDetecion.isfree(x,y+1) == true)
                PlayerY += 1;
            }
        }

        public void rightwards()
        {
            if (Rotation != 2)
            {
                Rotation = 2;
            }
            else
            {
                //if (CollisionDetecion.isfree(x+1,y) == true)
                PlayerX += 1;
            }
        }

        public void leftwards()
        {
            if (Rotation != 4)
            {
                Rotation = 4;
            }
            else
            {
                //if (CollisionDetecion.isfree(x-1,y) == true)
                PlayerX -= 1;
            }
        }

        public void strike()
        {
            switch (Rotation)
            {
                case 1:
                    //if (CollisionDetecion.isfree(x,y-1) == true)
                    //show sword at PlayerX, PlayerY-1; upwards.
                    // else PlaySound error/wallbounce
                    break;

                case 2:
                    //if (CollisionDetecion.isfree(x+1,y) == true)
                    //show sword at PlayerX+1, PlayerY; rightwards.
                    // else PlaySound error/wallbounce
                    break;

                case 3:
                    //if (CollisionDetecion.isfree(x,y+1) == true)
                    //show sword at PlayerX, PlayerY+1; downwards.
                    // else PlaySound error/wallbounce
                    break;

                case 4:
                    //if (CollisionDetecion.isfree(x-1,y) == true)
                    //show sword at PlayerX-1, PlayerY; leftwards.
                    // else PlaySound error/wallbounce
                    break;
            }

        }
    }
}
