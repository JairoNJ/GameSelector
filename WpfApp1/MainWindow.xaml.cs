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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SetUpGame();
        }

        private void SetUpGame()
        {
            List<String> animales = new List<string>()
            {
                "🦮","🦮",
                "🦁","🦁",
                "🐸","🐸",
                "🦑","🦑",
                "🐦‍🔥","🐦‍🔥",
                "🦈","🦈",
                "🦄","🦄",
                "🐣","🐣"
            };

            Random random = new Random();

            foreach(TextBlock textBox in mainGrid.Children.OfType<TextBlock>())
            {
                int index = random.Next(animales.Count);
                string nextAnimal = animales[index];
                textBox.Text = nextAnimal;
                animales.RemoveAt(index);
            }
        }
    }
}
