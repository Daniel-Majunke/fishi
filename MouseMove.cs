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
       
        public MouseMove(List<Coordinates> coordinateList)
        {
            Random rnd = new Random();
            var randomCoordFromList = rnd.Next(0, coordinateList.Count);
            var x = coordinateList[randomCoordFromList].X;
            var y = coordinateList[randomCoordFromList].Y;

            MouseMoveToPoint(x, y);
        }

        private void MouseMoveToPoint(int x, int y)
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
