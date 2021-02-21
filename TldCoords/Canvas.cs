using System.Drawing;
using System.Windows.Forms;

namespace TldCoords
{
    public class Canvas : Label
    {
        private Koordinaten? _lastCoords;// = new Koordinaten() {XReal = 1234, YReal = 1234};
        private Koordinaten? _currentCoords;// = new Koordinaten() {XReal = 1000, YReal = 1000} ;
        
        public void SetCoordinates(Koordinaten coords)
        {
            if (_currentCoords?.XReal == coords.XReal && _currentCoords?.YReal == coords.YReal)
                return;
            _lastCoords = _currentCoords;
            _currentCoords = coords;
        }

        private readonly Pen _pen = new Pen(Color.Red, 5);
        
        protected override void OnPaint(PaintEventArgs e)
        {
            if (_currentCoords == null || _lastCoords == null)
            {
                base.OnPaint(e);
                return;
            }

            var g = e.Graphics;

            var n = CompassCalculator.Calculate(_lastCoords, _currentCoords);
            g.DrawLine(_pen, n.From, n.To);
            g.DrawEllipse(_pen, 47, 47, 6, 6);
          
            base.OnPaint(e);
        }
    }
}