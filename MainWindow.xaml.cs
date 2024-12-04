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

namespace WpfApp5
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
        private void OnLikesClick(object sender, RoutedEventArgs e)
        {
            try
            {
                string[] names = NamesTextBox.Text.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < names.Length; i++)
                {
                    names[i] = names[i].Trim();
                }

                string result = Likes(names);

                ResultTextBlock.Text = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        public string Likes(string[] names)
        {
            if (names.Length == 0)
            {
                return "no one likes this";
            }
            if (names.Length == 1)
            {
                return $"{names[0]} likes this";
            }
            if (names.Length == 2)
            {
                return $"{names[0]} and {names[1]} like this";
            }
            if (names.Length == 3)
            {
                return $"{names[0]}, {names[1]} and {names[2]} like this";
            }
            return $"{names[0]}, {names[1]} and {names.Length - 2} others like this";
        }
    }
}