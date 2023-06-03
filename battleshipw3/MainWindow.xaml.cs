using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace battleshipw3
{
    public partial class MainWindow : Window
    {
        private int[,] MyArrayPlace;
        private int[,] EnemyArrayPlace;
        EnemyShips enemyShips;
        private readonly int row = 10;
        private readonly int col = 10;
        Random random;
        public MainWindow()
        {
            InitializeComponent();
            InitializationArray();
            enemyShips = new EnemyShips();
            random = new Random();
        }
        private void InitializationArray()
        {
            MyArrayPlace = new int[row, col];
            EnemyArrayPlace = new int[row, col];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Button buttonMe = new Button() { Content = "Click", Background = Brushes.Wheat, FontSize = 7, Foreground = Brushes.BlueViolet };
                    gridMe.Children.Add(buttonMe);
                    Grid.SetRow(buttonMe, i);
                    Grid.SetColumn(buttonMe, j);
                    buttonMe.Click += ButtonMe_Click;
                    Button buttonEnemy = new Button() { Content = "Click", Background = Brushes.Wheat, FontSize = 7, Foreground = Brushes.BlueViolet };
                    gridEnemy.Children.Add(buttonEnemy);
                    Grid.SetRow(buttonEnemy, i);
                    Grid.SetColumn(buttonEnemy, j);
                    buttonEnemy.Click += ButtonEnemy_Click;
                }
            }
        }
        private void ButtonEnemy_Click(object sender, RoutedEventArgs e)
        {
            double value = ((Button)sender).Opacity;
            if (value == 1.1)
            {
                ((Button)sender).Background = Brushes.Red;
            }
            else
            {
                ((Button)sender).Background = Brushes.Blue;
            }
            checkOurWin();
            shotToGridMe();
           
        }
        private void checkOurWin() 
        {
            if (gridEnemy.Children.OfType<Button>().All(b => b.Opacity == 1.1 && b.Background == Brushes.Red))
            {
                MessageBox.Show("You have won congratulations!");
            }
        }
        private void checkEnemyWin()
        {
                if (gridMe.Children
      .OfType<Button>()
      .All(bu => bu.Opacity > 1d && bu.Background == Brushes.Red))
                {
                    MessageBox.Show("The computer has won!");
                }
        }
        private void ButtonMe_Click(object sender, RoutedEventArgs e)
        {
            ((Button)sender).Background = Brushes.DeepPink;
            ((Button)sender).Opacity = 1.1;
        }
        private void shotToGridMe()
        {
            var x = random.Next(0, 100);
            while  (gridMe.Children.OfType<Button>().Any(but => but.Background != Brushes.Red && but.Background != Brushes.Blue && but.Background != Brushes.Wheat && but.Background != Brushes.DeepPink))
                {
                x = random.Next(0, 100);
            }
            if (((Button)gridMe.Children[x]).Background == Brushes.DeepPink || ((Button)gridMe.Children[x]).Background == Brushes.Red)
                        {
                            ((Button)gridMe.Children[x]).Background = Brushes.Red;
                        }
                        else 
                        {
                            ((Button)gridMe.Children[x]).Background = Brushes.Blue;
                        }
            checkEnemyWin();
        }
        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            enemyShips.RandomShip(gridEnemy);
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            gridEnemy.Children.Clear();
            gridMe.Children.Clear();
            InitializationArray();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
            instructionsTextblock.Foreground = Brushes.BlueViolet;
            instructionsTextblock.FontSize = 11;
            instructionsTextblock.Text = "Welcome to battleships! To start please begin by placing your ships through clicking on your grid's buttons. Once a space has been filled it will " +
                "appear in a dark pink color. Once finished press the Randomize comp. button so the computer randomly fills their own coordinate grid with ships. Then begin firing at the enemy grid. " +
                "Red squares will indicate that you have hit a ship. Blue squares indicate misses. The colors appearing on your board after you hit the enemies ship will indicate the same. To completely reset" +
                " press the New Game button. Have fun playing!!!";
        }
    }
}