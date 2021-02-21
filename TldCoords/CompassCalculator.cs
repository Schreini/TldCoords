using System;
using System.Drawing;

namespace TldCoords
{
    public class CompassCalculator
    {
        private const int CompassSize = 50;

        public Needle Calculate(Koordinaten last, Koordinaten current)
        {
 

            current = new Koordinaten() {XReal = current.XReal - last.XReal, YReal = current.YReal - last.YReal};
            double f = Math.Max(Math.Abs(current.XReal), Math.Abs(current.YReal)) / Convert.ToDouble(CompassSize);
            if (f == 0)
            {
                
            }
            current = new Koordinaten()
            {
                XReal = Convert.ToInt32(current.XReal / f) + CompassSize,
                YReal = 100 - (Convert.ToInt32(current.YReal / f) + CompassSize)
            };
            return new Needle() {From = new Point(50, 50), To = new Point(current.XReal, current.YReal)};
        }
    }

    public record Needle
    {
        public Point From { get; set; }
        public Point To { get; set; }
    }
}