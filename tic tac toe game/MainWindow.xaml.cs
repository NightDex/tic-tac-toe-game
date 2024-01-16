
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace tic_tac_toe_game
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Player_order playerMark;
        GameLogic game = new GameLogic();
        
        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void gameFinnished(bool ifwon)
        {
            if (ifwon)
            {
                if (game.winnerMark == "nobody")
                {
                    textBoxWinner.Text = $"Nobody won :(";
                    textBoxWinner.Visibility = Visibility.Visible;
                }
                else
                {
                    textBoxWinner.Text = $"Congradulations! Player {game.winnerMark} won!";
                    textBoxWinner.Visibility = Visibility.Visible;
                }
                
            }
            else
            {
                return;
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(button1.Content as string))
            {
                return;
            }

            
            button1.Content = playerMark.PlayerMark();
            game.GetMark("b1", button1.Content.ToString());
            gameFinnished(game.IfWonGame());

        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(button2.Content as string))
            {
                return;
            }

            button2.Content = playerMark.PlayerMark();
            game.GetMark("b2", button2.Content.ToString());
            gameFinnished(game.IfWonGame());
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(button3.Content as string))
            {
                return;
            }

            button3.Content = playerMark.PlayerMark();
            game.GetMark("b3", button3.Content.ToString());
            gameFinnished(game.IfWonGame());
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(button4.Content as string))
            {
                return;
            }

            button4.Content = playerMark.PlayerMark();
            game.GetMark("b4", button4.Content.ToString());
            gameFinnished(game.IfWonGame());
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(button5.Content as string))
            {
                return;
            }

            button5.Content = playerMark.PlayerMark();
            game.GetMark("b5", button5.Content.ToString());
            gameFinnished(game.IfWonGame());
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(button6.Content as string))
            {
                return;
            }

            button6.Content = playerMark.PlayerMark();
            game.GetMark("b6", button6.Content.ToString());
            gameFinnished(game.IfWonGame());
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(button7.Content as string))
            {
                return;
            }
            
            button7.Content = playerMark.PlayerMark();
            game.GetMark("b7", button7.Content.ToString());
            gameFinnished(game.IfWonGame());
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(button8.Content as string))
            {
                return;
            }

            button8.Content = playerMark.PlayerMark();
            game.GetMark("b8", button8.Content.ToString());
            gameFinnished(game.IfWonGame());
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(button9.Content as string))
            {
                return;
            }

            button9.Content = playerMark.PlayerMark();
            game.GetMark("b9", button9.Content.ToString());
            gameFinnished(game.IfWonGame());
        }

        private void checkBoxX_Checked(object sender, RoutedEventArgs e)
        {
            if (checkBoxO.IsChecked == true)
            {
                checkBoxO.IsChecked = false;
            }
        }

        private void checkBoxO_Checked(object sender, RoutedEventArgs e)
        {
            if (checkBoxX.IsChecked == true)
            {
                checkBoxX.IsChecked = false;
            }
        }

        private void buttonStart_Click(object sender, RoutedEventArgs e)
        {
            if (checkBoxO.IsChecked == false && checkBoxX.IsChecked == false)
            {
                return;
            }
            else
            {
                checkBoxX.Visibility = Visibility.Collapsed;
                checkBoxO.Visibility = Visibility.Collapsed;
                rectabgleFront.Visibility = Visibility.Collapsed;
                buttonStart.Visibility = Visibility.Collapsed;

                if (checkBoxX.IsChecked == true)
                {
                    playerMark = new Player_order("X","O");                    
                }
                else
                {
                    playerMark = new Player_order("O", "X");
                    
                }
            }
        }

        private void textBoxWinner_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }

        
    }
