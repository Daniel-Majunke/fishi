using System;
using System.Collections.Generic;

using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fishbot
{

    class MouseMove
    {
        public MouseMove()
        {
            Control control = new Control();
            Point cursorPos = Cursor.Position;
            Point coordinate = new Point(500,1000);
            
            cursorPos.X = control.PointToScreen(coordinate).X;
            cursorPos.Y = control.PointToScreen(coordinate).Y;
            Cursor.Position = cursorPos;
        }
    }
}
