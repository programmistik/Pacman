using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Pacman
{
    public interface IDots : IDisposable
    {
        int Points { get; }
        Color Dot_Color { get; set; }
    }
}
