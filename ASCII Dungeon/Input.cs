using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCII_Dungeon
{
    class Input
    {

        public delegate void InputEvent(ConsoleKeyInfo key);

        public event InputEvent OnUpKey;
        public event InputEvent OnDownKey;
        public event InputEvent OnLeftKey;
        public event InputEvent OnRightKey;
        public event InputEvent OnSpaceKey;

        public bool KeyStroke()
        {
            if (Console.KeyAvailable)
            {
                if (OnUpKey != null)
                {
                    OnUpKey.Invoke(Console.ReadKey());            
                }

                if (OnDownKey != null)
                {
                    OnDownKey.Invoke(Console.ReadKey());
                }

                if (OnLeftKey != null)
                {
                    OnLeftKey.Invoke(Console.ReadKey());
                }

                if (OnRightKey != null)
                {
                    OnRightKey.Invoke(Console.ReadKey());
                }

                if (OnSpaceKey != null)
                {
                    OnSpaceKey.Invoke(Console.ReadKey());
                }
                return true;                
                    
            }
            return false;
        }

        /*
        Input.OnUpKey += Player.UpKey;
        Input.OnDownKey += Player.DownKey;
        Input.OnLeftKey += Player.LeftKey;
        Input.OnRightKey += Player.RightKey;
        Input.OnSpaceKey += Player.SpaceKey;
        
        
        */
    }
}
