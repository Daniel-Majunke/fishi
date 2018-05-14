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
        private int X { get; set; }
        private int Y { get; set; }

        public MouseMove(int x, int y)
        {
            X = x;
            Y = y;

            moveMouseToPosition(X, Y);


        }


        private void moveMouseToPosition(int x, int y)
        {
            Control control = new Control();
            Point cursorPos = Cursor.Position;
            Point coordinate = new Point(x, y);

            cursorPos.X = control.PointToScreen(coordinate).X;
            cursorPos.Y = control.PointToScreen(coordinate).Y;
            Cursor.Position = cursorPos;

        }

    }
}