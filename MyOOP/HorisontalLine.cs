using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOOP
{
    class HorisontalLine
    {
        List<Point> pList;

        public HorisontalLine(int xLeft, int xRight, int y, char sym) {
            pList = new List<Point>();
            for (int x = xLeft; x <= xRight; x++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }

            
        }

        public void Draw() {
            foreach (var item in pList)
            {
                item.Draw();
            }
        }
    }
}
