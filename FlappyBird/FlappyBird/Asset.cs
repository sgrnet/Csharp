using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace FlappyBird
{
    class Asset
    {
        public Point[][] FlyState;

        public Asset(Point[][] flyState)
        {
            FlyState = flyState;
        }
    }
}
