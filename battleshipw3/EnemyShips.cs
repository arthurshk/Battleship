using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
namespace battleshipw3
{
    class EnemyShips
    {
        Random rand = new Random();
        public int x; 
        public void RandomShip(Grid grid)
        {
            for (int i = 0; i < 1; i++)
            {
                x = rand.Next(1, 97);
                ((Button)grid.Children[x]).Opacity = 1.1;
                x = x + 1;
                ((Button)grid.Children[x]).Opacity = 1.1;
                x = x + 1;
                ((Button)grid.Children[x]).Opacity = 1.1;
                x = x + 1;
                ((Button)grid.Children[x]).Opacity = 1.1;
            }
            for (int a = 0; a < 2; a++)
                {
                x = rand.Next(1, 98);
                ((Button)grid.Children[x]).Opacity = 1.1;
                x = x + 1;
                ((Button)grid.Children[x]).Opacity = 1.1;
                x = x + 1;
                ((Button)grid.Children[x]).Opacity = 1.1;
            }
                for (int a = 0; a < 3; a++)
                {
                x = rand.Next(1, 99);
                ((Button)grid.Children[x]).Opacity = 1.1;
                x = x + 1;
                ((Button)grid.Children[x]).Opacity = 1.1;
            }
                    for (int a = 0; a < 4; a++)
                    {
                x = rand.Next(1, 100);
                ((Button)grid.Children[x]).Opacity = 1.1;
            }
            }
        }
    }