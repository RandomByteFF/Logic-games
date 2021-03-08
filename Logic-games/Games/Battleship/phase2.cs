using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Logic_games.Properties;
using Logic_games.Games.Battleship;

namespace Logic_games.Games.Battleship
{
    class phase2
    {
        public phase2(TableLayoutPanel gameLP1) 
        {
            TableLayoutPanel BoardLeft= new TableLayoutPanel { BackColor = Color.Coral, Anchor = phase1.str },
            BoardRight = new TableLayoutPanel { BackColor = Color.Coral, Anchor = phase1.str };
            /*gameLP1.Controls.Add(BoardLeft, 0,0);
            gameLP1.Controls.Add(BoardRight, 1,0);*/
            playerBoard Left1 = new playerBoard(new TableLayoutPanel { Anchor = phase1.str }), Right1 = new playerBoard(new TableLayoutPanel { Anchor = phase1.str });
            playerBoard Left2 = new playerBoard(new TableLayoutPanel { Anchor = phase1.str }), Right2 = new playerBoard(new TableLayoutPanel { Anchor = phase1.str });
        }

        public phase2(TableLayoutPanel gameLP1, List<List<Ship>> inventory, int[,] PlayerMap)
        {
            gameLP1.Hide();
            TableLayoutPanel BoardLeft = new TableLayoutPanel { BackColor = Color.Coral, Anchor = phase1.str },
            BoardRight = new TableLayoutPanel { BackColor = Color.Coral, Anchor = phase1.str };
            playerBoard Left = new playerBoard(new TableLayoutPanel { Anchor = phase1.str }, inventory), Right = new playerBoard(new TableLayoutPanel { Anchor = phase1.str });
            gameLP1.Controls.Add(BoardLeft, 0, 0);
            gameLP1.Controls.Add(BoardRight, 1, 0);
            gameLP1.Show();
        }
    }
}
