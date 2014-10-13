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

    }
}
