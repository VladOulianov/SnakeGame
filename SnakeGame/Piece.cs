using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace SnakeGame
{
    class Piece : Label
    {
        public Piece(int x, int y)
        {
            Location = new System.Drawing.Point(x, y);
            Size = new System.Drawing.Size(20, 20);
            BackColor = Color.Orange;
            Enabled = false;
        }
    }
}
