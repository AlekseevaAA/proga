using System.Windows;

namespace nast
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(first.Text) || string.IsNullOrEmpty(second.Text))
                MessageBox.Show("Введите значения");

            bool parse1 = int.TryParse(first.Text, out int a);
            bool parse2 = int.TryParse(second.Text, out int b);
            if (parse1 && parse2)
            {
                var ans = a + b;
                MessageBox.Show(ans.ToString());
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(first.Text) || string.IsNullOrEmpty(second.Text))
                MessageBox.Show("Введите значения");

            bool parse1 = int.TryParse(first.Text, out int a);
            bool parse2 = int.TryParse(second.Text, out int b);
            if (parse1 && parse2)
            {
                var ans = a - b;
                MessageBox.Show(ans.ToString());
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(first.Text) || string.IsNullOrEmpty(second.Text))
                MessageBox.Show("Введите значения");

            bool parse1 = int.TryParse(first.Text, out int a);
            bool parse2 = int.TryParse(second.Text, out int b);

            if (parse1 && parse2)
            {
                var ans = a * b;
                MessageBox.Show(ans.ToString());
            }
        }

       

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(first.Text) || string.IsNullOrEmpty(second.Text))
                MessageBox.Show("Введите значения");

            bool parse1 = float.TryParse(first.Text, out float a);
            bool parse2 = float.TryParse(second.Text, out float b);

            if (b == 0)
            {
                MessageBox.Show("Нельзя делить на 0");
                return;
            }

            if (parse1 && parse2)
            {
                var ans = a / b;
                MessageBox.Show(ans.ToString());
            }
        }
    }
}
