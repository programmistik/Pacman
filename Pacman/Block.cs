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
    public partial class Block : Control, IBlock
    {
        public Block()
        {
            BackColor = Block_Color;
        }

        public Block(int width, int height) : this()
        {
            Width = width;
            Height = height;
        }

        public Block(int width, int height, Point location) : this(width, height)
        {
            Location = location;
        }
        public Color Block_Color { get; set; } = Color.DarkBlue;
    }
}
