using System;
using System.IO;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Ball
    {
        Point points { get; set; }
        Screen screen { get; set; }
        Random rndm;
        readonly string logFilePath;
        public List<Point> historyMotionList { get; set; }
        public Ball(Point startPoints, Screen screen)
        {
            historyMotionList = new List<Point>();
            logFilePath = @"C:\Users\vab\Documents\visual studio 2015\Projects\Task 3\Task 3\logFile.txt";
            this.screen = screen;
            this.rndm = new Random();
            if ((startPoints.X < screen.limitPoints.X) && (startPoints.Y < screen.limitPoints.Y))
            {
                this.points = startPoints;              
            }
            else
                points = new Point(screen.limitPoints.X + 1, screen.limitPoints.Y + 1);           
            //historyMotionList.Add(this.points);
        }

        private void WriteToLogFile(Point unlimitedPoints)
        {                       
                using (StreamWriter file = new StreamWriter(logFilePath, true))
                {
                    file.WriteLine("Incorrect points is {0}", unlimitedPoints);
                    file.WriteLine("Movement before going abroad:");
                    foreach (var item in historyMotionList)
                    {
                        //Console.WriteLine(item.ToString());
                        file.WriteLine("Date {0} {1}", DateTime.Now, item);
                     }
                
                }                         
        }

        public void Move()
        {
            Point randomPoints = new Point(rndm.Next(0,120), rndm.Next(0,120));
            try
            {
                if ((randomPoints.X < screen.limitPoints.X) && (randomPoints.Y < screen.limitPoints.Y))
                {                   
                    historyMotionList.Add(this.points);
                    this.points = randomPoints;                   
                }
                else
                {

                    throw new Exception("Ball touched the border");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                WriteToLogFile(randomPoints);
            }
            
        }

        public string ShowCurrentPoints()
        {
            return this.GetType().ToString() + " - " + points.ToString();
        }
    }
}
