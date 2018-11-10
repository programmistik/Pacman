using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman
{
    public enum CharacterType
    {
        Packman,
        Enemy
    }

    public enum MovementWay
    {
        Up,
        Down,
        Left,
        Right
    }

    public interface ICharacter : IDisposable
    {
        int TotalPoints { get; set; }
        int Speed { get; set; }
        CharacterType Type { get; }
        void Move(MovementWay way);
    }
}
