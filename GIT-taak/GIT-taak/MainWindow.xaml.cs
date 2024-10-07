using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GIT_taak
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void redColorImage_MouseEnter(object sender, MouseEventArgs e)
        {
            mainWindow.Background = Brushes.Red;
        }

        private void redColorImage_MouseLeave(object sender, MouseEventArgs e)
        {
            mainWindow.Background = Brushes.LightGray;
        }

        private void yellowColorImage_MouseEnter(object sender, MouseEventArgs e)
        {
            mainWindow.Background = Brushes.Yellow;
        }

        private void yellowColorImage_MouseLeave(object sender, MouseEventArgs e)
        {
            mainWindow.Background = Brushes.LightGray;
        }

        private void greenColorImage_MouseEnter(object sender, MouseEventArgs e)
        {
            mainWindow.Background = Brushes.Green;
        }

        private void greenColorImage_MouseLeave(object sender, MouseEventArgs e)
        {
            mainWindow.Background = Brushes.LightGray;
        }

        private void blueColorImage_MouseEnter(object sender, MouseEventArgs e)
        {
            mainWindow.Background = Brushes.Blue;
        }

        private void blueColorImage_MouseLeave(object sender, MouseEventArgs e)
        {
            mainWindow.Background = Brushes.LightGray;
        }

        private void redColorImage_MouseDown(object sender, MouseButtonEventArgs e)
        {
            colorCodeInfoTextBox.Text = "#FF0000";
            colorInfoTextBox.Text = "Rood is de kleur van warmte";
        }

        private void yellowColorImage_MouseDown(object sender, MouseButtonEventArgs e)
        {
            colorCodeInfoTextBox.Text = "#FFFF00";
            colorInfoTextBox.Text = "Geel is de kleur van levenslust";
        }

        private void greenColorImage_MouseDown(object sender, MouseButtonEventArgs e)
        {
            colorCodeInfoTextBox.Text = "#008000";
            colorInfoTextBox.Text = "Groen is de kleur van genezing";
        }

        private void blueColorImage_MouseDown(object sender, MouseButtonEventArgs e)
        {
            colorCodeInfoTextBox.Text = "#0000FF";
            colorInfoTextBox.Text = "Blauw is de kleur van intelligentie";
        }
    }
}