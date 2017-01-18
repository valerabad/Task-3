using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Screen screen = new Screen(new Point(100,100));
            Ball ball = new Ball(new Point(1,1),screen);

            for (int i = 0; i < 30; i++)
            {
                ball.Move();
                Console.WriteLine(ball.ShowCurrentPoints());
            }
       
            foreach (var item in ball.historyMotionList)
            {
                Console.WriteLine(item.ToString());
            }
          
            Console.ReadKey();
        }
    }
}
