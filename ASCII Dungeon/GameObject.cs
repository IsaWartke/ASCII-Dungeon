using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCII_Dungeon
{
    public abstract class GameObject
    {
        public GameObject()
        {

        }
        protected abstract void Move();

        public void Render() { }
    }
}
