using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Task_3
{
    class Screen
    {
        public Point limitPoints { get; set; }
        public Screen(Point limitPoints)
        {
            this.limitPoints = limitPoints;
        }
    }
}
