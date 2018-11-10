using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pacman
{
    public partial class Dots : Control, IDots
    {
        public Dots()
        {
            Width = Height = 30;
        }

        public Dots(int point) : this()
        {
            Points = point;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Pen p = new Pen(Dot_Color);
            e.Graphics.FillEllipse(p.Brush, 15, 15, 10, 10);

            base.OnPaint(e);
        }
        public int Points { get; private set; } = 100;
        public Color Dot_Color { get; set; } = Color.Yellow;

        public new void Dispose()
        {
            Points = 0;
            Dispose(true);
        }

    }
}
