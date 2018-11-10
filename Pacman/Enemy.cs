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
    public delegate void Enemy_Movement(object sender, Point location);
    public delegate void Enemy_PacmanCatched(object sender);

    public partial class Enemy : Control, ICharacter
    {
        public event Enemy_Movement Enemy_Movement;
        public event Enemy_PacmanCatched Enemy_PacmanCatched;

        Pacman _pacman = null;

        public Enemy()
        {
            Height = Width = 40;
        }

        public Enemy(Pacman pacman) : this()
        {
            _pacman = pacman;
            Enemy_Movement += new Enemy_Movement(Enemy_Enemy_Movement);
        }

        void Enemy_Enemy_Movement(object sender, Point location)
        {
            if (_pacman.Location == location)
            {
                Enemy_PacmanCatched?.Invoke(this);

                _pacman.Catched(this);
            }
        }
        public CharacterType Type { get; } = CharacterType.Enemy;

        public new void Move(MovementWay way)
        {
            switch (way)
            {
                case MovementWay.Up:
                    Location = new Point(Location.X, Location.Y - Speed);
                    break;

                case MovementWay.Down:
                    Location = new Point(Location.X, Location.Y + Speed);
                    break;

                case MovementWay.Left:
                    Location = new Point(Location.X - Speed, Location.Y);
                    break;

                case MovementWay.Right:
                    Location = new Point(Location.X + Speed, Location.Y);
                    break;
            }

            if (_pacman != null)
            {
                Enemy_Movement(this, Location);
                return;
            }

            Enemy_Movement?.Invoke(this, Location);

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            DrawCharacter.Draw(ref e, Type);

            base.OnPaint(e);
        }

        public int TotalPoints
        {
            get
            {
                return 0;
            }
            set
            {
            }
        }
        public int Speed { get; set; } = 20;
    }
}
