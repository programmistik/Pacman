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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //PacmanGroupBox.Controls.Clear();
            //PacmanGroupBox.Refresh();

            //GameInitialization();
        }

        Dots[] dots = new Dots[100];
        Block[] blocks = new Block[19];

        private void button1_Click(object sender, EventArgs e)
        {

            PacmanGroupBox.Controls.Clear();
            PacmanGroupBox.Refresh();

            GameInitialization();

            ActiveControl = null;

        }

        void GameInitialization()
        {
            Pacman pack = new Pacman(ref dots, ref blocks);
            pack.Pacman_PointsChanged += new Pacman_PointsChanged(pack_Pacman_PointsChanged);
            pack.Pacman_Messages += new Pacman_Messages(pack_Pacman_Messages);
            pack.Location = new Point(100, 100);

            PacmanGroupBox.Controls.Add(pack);

            LoadDots();
            LoadBlocks();

            Enemy ghost = new Enemy(pack);
           
            ghost.Location = new Point(280, 300);
          //  ghost.Enemy_Movement += new Enemy_Movement(ghost, ghost.Location);
            ghost.Move(MovementWay.Down);
            PacmanGroupBox.Controls.Add(ghost);
            //ghost.Move(MovementWay.Down);
            //ghost.Move(MovementWay.Down);
            //ghost.Move(MovementWay.Down);
            //ghost.Move(MovementWay.Down);
            //ghost.Move(MovementWay.Down);
            //ghost.Move(MovementWay.Down);
        }

        void LoadBlocks()
        {
            Block top = new Block(560, 20, new Point(20, 20));
            Block left = new Block(20, 480, new Point(20, 20));
            Block right = new Block(20, 480, new Point(560, 20));
            Block down = new Block(560, 20, new Point(20, 480));


            Block b = new Block(100, 20, new Point(80, 80));
            Block b1 = new Block(20, 100, new Point(80, 80));

            Block b2 = new Block(100, 20, new Point(420, 80));
            Block b3 = new Block(20, 100, new Point(500, 80));

            Block b9 = new Block(20, 100, new Point(80, 320));
            Block b10 = new Block(100, 20, new Point(80, 420));

            Block b11 = new Block(100, 20, new Point(420, 420));
            Block b12 = new Block(20, 100, new Point(500, 320));

            ////////////////////////////////////////////////

            Block b4 = new Block(20, 100, new Point(260, 100));
            Block b5 = new Block(20, 100, new Point(320, 100));

            Block b6 = new Block(180, 20, new Point(220, 240));

            Block b7 = new Block(20, 100, new Point(260, 300));
            Block b8 = new Block(20, 100, new Point(320, 300));

            Block b13 = new Block(20, 60, new Point(160, 220));
            Block b14 = new Block(20, 60, new Point(440, 220));


            blocks[0] = b;
            blocks[1] = b1;
            blocks[2] = b2;
            blocks[3] = b3;
            blocks[4] = b4;
            blocks[5] = b5;
            blocks[6] = b6;
            blocks[7] = b7;
            blocks[8] = b8;
            blocks[9] = b9;
            blocks[10] = b10;
            blocks[11] = b11;
            blocks[12] = b12;
            blocks[13] = b13;
            blocks[14] = b14;
            blocks[15] = top;
            blocks[16] = left;
            blocks[17] = down;
            blocks[18] = right;

            PacmanGroupBox.Controls.AddRange(blocks);
        }

        void LoadDots()
        {
            Dots d = new Dots();
            d.Location = new Point(40, 40);
            Dots d1 = new Dots();
            d1.Location = new Point(80, 40);
            Dots d2 = new Dots();
            d2.Location = new Point(120, 40);
            Dots d3 = new Dots();
            d3.Location = new Point(160, 40);

            Dots d4 = new Dots();
            d4.Location = new Point(200, 40);
            Dots d5 = new Dots();
            d5.Location = new Point(240, 40);
            Dots d6 = new Dots();
            d6.Location = new Point(280, 40);
            Dots d7 = new Dots();
            d7.Location = new Point(320, 40);

            Dots d8 = new Dots();
            d8.Location = new Point(360, 40);
            Dots d9 = new Dots();
            d9.Location = new Point(400, 40);
            Dots d10 = new Dots();
            d10.Location = new Point(440, 40);
            Dots d11 = new Dots();
            d11.Location = new Point(480, 40);

            Dots d12 = new Dots(300);
            d12.Dot_Color = Color.BlueViolet;
            d12.Location = new Point(40, 80);
            Dots d13 = new Dots();
            d13.Location = new Point(40, 120);
            Dots d14 = new Dots();
            d14.Location = new Point(40, 160);
            Dots d15 = new Dots();
            d15.Location = new Point(40, 200);

            Dots d16 = new Dots();
            d16.Location = new Point(40, 240);
            Dots d17 = new Dots();
            d17.Location = new Point(40, 280);
            Dots d18 = new Dots();
            d18.Location = new Point(40, 320);
            Dots d19 = new Dots();
            d19.Location = new Point(40, 360);

            Dots d20 = new Dots();
            d20.Location = new Point(40, 400);
            Dots d21 = new Dots();
            d21.Location = new Point(40, 440);
            Dots d22 = new Dots();
            d22.Location = new Point(80, 440);
            Dots d23 = new Dots();
            d23.Location = new Point(120, 440);

            Dots d24 = new Dots();
            d24.Location = new Point(160, 440);
            Dots d25 = new Dots();
            d25.Location = new Point(200, 440);
            Dots d26 = new Dots();
            d26.Location = new Point(240, 440);
            Dots d27 = new Dots();
            d27.Location = new Point(280, 440);

            Dots d28 = new Dots();
            d28.Location = new Point(320, 440);
            Dots d29 = new Dots();
            d29.Location = new Point(360, 440);
            Dots d30 = new Dots();
            d30.Location = new Point(400, 440);
            Dots d31 = new Dots();
            d31.Location = new Point(440, 440);

            Dots d32 = new Dots(200);
            d32.Dot_Color = Color.BlueViolet;
            d32.Location = new Point(480, 440);
            Dots d33 = new Dots();
            d33.Location = new Point(520, 440);
            Dots d34 = new Dots();
            d34.Location = new Point(520, 40);
            Dots d35 = new Dots();
            d35.Location = new Point(520, 80);


            Dots d36 = new Dots();
            d36.Location = new Point(520, 120);
            Dots d37 = new Dots();
            d37.Location = new Point(520, 160);
            Dots d38 = new Dots();
            d38.Location = new Point(520, 200);
            Dots d39 = new Dots();
            d39.Location = new Point(520, 240);

            Dots d40 = new Dots();
            d40.Location = new Point(520, 280);
            Dots d41 = new Dots();
            d41.Location = new Point(520, 320);
            Dots d42 = new Dots();
            d42.Location = new Point(520, 360);
            Dots d43 = new Dots();
            d43.Location = new Point(520, 400);

            Dots d48 = new Dots();
            d48.Location = new Point(100, 320);
            Dots d49 = new Dots();
            d49.Location = new Point(100, 360);
            Dots d50 = new Dots();
            d50.Location = new Point(140, 360);
            Dots d51 = new Dots(500);
            d51.Dot_Color = Color.Red;
            d51.Location = new Point(400, 380);


            Dots d44 = new Dots();
            d44.Location = new Point(520, 280);
            Dots d45 = new Dots();
            d45.Location = new Point(520, 320);
            Dots d46 = new Dots();
            d46.Location = new Point(520, 360);
            Dots d47 = new Dots();
            d47.Location = new Point(520, 400);


            dots[0] = d;
            dots[1] = d1;
            dots[2] = d3;
            dots[3] = d2;

            dots[4] = d4;
            dots[5] = d5;
            dots[6] = d6;
            dots[7] = d7;

            dots[8] = d8;
            dots[9] = d9;
            dots[10] = d10;
            dots[11] = d11;

            dots[12] = d12;
            dots[13] = d13;
            dots[14] = d14;
            dots[15] = d15;

            dots[16] = d16;
            dots[17] = d17;
            dots[18] = d18;
            dots[19] = d19;

            dots[20] = d20;
            dots[21] = d21;
            dots[22] = d22;
            dots[23] = d23;

            dots[24] = d24;
            dots[25] = d25;
            dots[26] = d26;
            dots[27] = d27;

            dots[28] = d28;
            dots[29] = d29;
            dots[30] = d30;
            dots[31] = d31;

            dots[32] = d32;
            dots[33] = d33;
            dots[34] = d34;
            dots[35] = d35;

            dots[36] = d36;
            dots[37] = d37;
            dots[38] = d38;
            dots[39] = d39;

            dots[40] = d40;
            dots[41] = d41;
            dots[42] = d42;
            dots[43] = d43;
            dots[48] = d48;
            dots[49] = d49;
            dots[50] = d50;
            dots[51] = d51;

            PacmanGroupBox.Controls.AddRange(dots);

        }

        void pack_Pacman_Messages(object sender, string messages)
        {
            MessageBox.Show(messages);
            button1_Click(sender, null);
        }

        void pack_Pacman_PointsChanged(object sender, int totalPoints)
        {
            label1.Text = totalPoints.ToString();
        }



        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    {
                        (PacmanGroupBox.Controls[0] as ICharacter).Move(MovementWay.Up);
                        ActiveControl = null;
                        break;
                    }
                case Keys.Down:
                    {
                        (PacmanGroupBox.Controls[0] as ICharacter).Move(MovementWay.Down);
                        ActiveControl = null;
                        break;
                    }
                case Keys.Left:
                    {
                        (PacmanGroupBox.Controls[0] as ICharacter).Move(MovementWay.Left);
                        ActiveControl = null;
                        break;
                    }
                case Keys.Right:
                    {
                        (PacmanGroupBox.Controls[0] as ICharacter).Move(MovementWay.Right);
                        ActiveControl = null;
                        break;
                    }
                //------------------------
                case Keys.W:
                    {
                        (PacmanGroupBox.Controls[0] as ICharacter).Move(MovementWay.Up);
                        break;
                    }
                case Keys.S:
                    {
                        (PacmanGroupBox.Controls[0] as ICharacter).Move(MovementWay.Down);
                        break;
                    }
                case Keys.A:
                    (PacmanGroupBox.Controls[0] as ICharacter).Move(MovementWay.Left);
                    break;

                case Keys.D:
                    {
                        (PacmanGroupBox.Controls[0] as ICharacter).Move(MovementWay.Right);
                        break;
                    }
            }
            
        }
        //---------------------------------
        private void Form1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Right:
                case Keys.Left:
                case Keys.Down:
                case Keys.Up:
                    {
                        e.IsInputKey = true;
                        break;
                    }
            }
        }

        
    }
}
