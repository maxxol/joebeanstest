using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;
using System.Windows.Media.Media3D;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for GameWindow.xaml
    /// </summary>
    public partial class GameWindow : Window
    {
        int gravity = 55;
        private bool moveLeft, moveRight, onTheGround, jump;
        private DispatcherTimer gameTimer = new DispatcherTimer();
        private List<Rectangle> itemsToRemove = new List<Rectangle>();
        private const int playerSpeed = 10;

        
        public GameWindow()
        {
            InitializeComponent();
            gameTimer.Interval = TimeSpan.FromMilliseconds(20);
            gameTimer.Tick += GameEngine;
            gameTimer.Start();
            MyCanvas.Focus();
            ImageBrush imageBrush = new ImageBrush();
            imageBrush.ImageSource = new BitmapImage(new Uri("E:\\MainProjectArcadeGame\\WpfApp1\\Images\\Mario2.png", UriKind.RelativeOrAbsolute));

        }
        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Left) moveLeft = true;
            if (e.Key == Key.Right) moveRight = true;
            if (e.Key == Key.Space)
            {
                jump = true;
            }

        }

        private void OnKeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Left) moveLeft = false;
            if (e.Key == Key.Right) moveRight = false;
            if (e.Key == Key.Space) jump = false;
            

        }

        private void GameEngine(object sender, EventArgs e)
        {
            if (Canvas.GetTop(Player) < 720)
            {
                Canvas.SetTop(Player, Canvas.GetTop(Player) + gravity);
            }
            if (Canvas.GetTop(Player) == 720)
            {
                onTheGround = true;
            }


            if (jump == true)
            {
                Canvas.SetTop(Player, Canvas.GetTop(Player) - 55);
            }
            


            if (moveLeft && Canvas.GetLeft(Player) > 0)
                Canvas.SetLeft(Player, Canvas.GetLeft(Player) - playerSpeed);
            if (moveRight && Canvas.GetLeft(Player) + Player.Width < Application.Current.MainWindow.Width)
                Canvas.SetLeft(Player, Canvas.GetLeft(Player) + playerSpeed);
            Rect playerHitBox = new Rect(Canvas.GetLeft(Player), Canvas.GetTop(Player), Player.Width, Player.Height);
        }
    }
}



