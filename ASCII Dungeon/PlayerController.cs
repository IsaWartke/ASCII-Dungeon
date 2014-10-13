using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class PlayerController
    {
        int PlayerX;
        int PlayerY;
        Map _map;

        public PlayerController(int x, int y, Map map)
        {
            PlayerX = x;
            PlayerY = y;
            _map = map;
        }

        public void InitPlayer()
        {
            _map.GetTile(PlayerX, PlayerY).State = 21;
        }

        public delegate void InputEvent(ConsoleKeyInfo keyInfo);

        public event InputEvent OnKeyPress;

        public bool MoveCheck()
        {

            if (Console.KeyAvailable)
            {
                if (OnKeyPress != null)
                {
                    OnKeyPress.Invoke(Console.ReadKey());
                }
                return true;
            }
            return false;
        }

        public void HandleKey(ConsoleKeyInfo keyInfo)
        {
            switch (keyInfo.Key)
            {
                case ConsoleKey.UpArrow:
                    {
                        if (_map.GetTile(PlayerX, PlayerY).State == 21)
                        {
                            _map.GetTile(PlayerX, PlayerY).NextRoundState = 0;
                            PlayerY -= 1;
                            _map.GetTile(PlayerX, PlayerY).NextRoundState = 21;
                        }
                        else
                        {
                            _map.GetTile(PlayerX, PlayerY).NextRoundState = 21;
                        }
                    }
                    break;

                case ConsoleKey.DownArrow:
                    {
                        if (_map.GetTile(PlayerX, PlayerY).State == 22)
                        {
                            _map.GetTile(PlayerX, PlayerY).NextRoundState = 0;
                            PlayerY += 1;
                            _map.GetTile(PlayerX, PlayerY).NextRoundState = 22;
                        }
                        else
                        {
                            _map.GetTile(PlayerX, PlayerY).NextRoundState = 22;
                        }
                    }
                    break;

                case ConsoleKey.LeftArrow:
                    {
                        if (_map.GetTile(PlayerX, PlayerY).State == 23)
                        {
                            _map.GetTile(PlayerX, PlayerY).NextRoundState = 0;
                            PlayerX -= 1;
                            _map.GetTile(PlayerX, PlayerY).NextRoundState = 23;
                        }
                        else
                        {
                            _map.GetTile(PlayerX, PlayerY).NextRoundState = 23;
                        }
                    }
                    break;

                case ConsoleKey.RightArrow:
                    {
                        if (_map.GetTile(PlayerX, PlayerY).State == 24)
                        {
                            _map.GetTile(PlayerX, PlayerY).NextRoundState = 0;
                            PlayerX += 1;
                            _map.GetTile(PlayerX, PlayerY).NextRoundState = 24;
                        }
                        else
                        {
                            _map.GetTile(PlayerX, PlayerY).NextRoundState = 24;
                        }
                    }
                    break;

                //case ConsoleKey.Spacebar:
                //{

                //}
                //break;
            }
        }

    }

}
