using System.Collections.Generic;

namespace MyOOP
{
    class Figure
    {
        protected List<Point> pList;

        public void Draw()
        {
            foreach (var item in pList)
            {
                item.Draw();
            }
        }
    }
}
