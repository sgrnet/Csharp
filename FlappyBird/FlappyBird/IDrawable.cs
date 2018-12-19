using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace FlappyBird
{
    interface IDrawable
    {
        bool Draw(Point pos);
        bool Clear(Point pos);
        
    }
}
