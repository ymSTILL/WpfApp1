using System.Windows;

namespace _2026_WpfApp1
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

        private void okButton_Click(object sender, RoutedEventArgs e)
        {
            string name = nameTextBox.Text;
            string telphone = telTextBox.Text;
            string message = $"Name: {name}\nTelphone: {telphone}";
            MessageBox.Show(message, "我的資訊", MessageBoxButton.OK);
        }

        private void computeButton_Click(object sender, RoutedEventArgs e)
        {
            int n = int.Parse(numberTextBox.Text);

            string result = "";
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                    result += $"{i}*{j}={i * j}\t\t";
                result += "\n";
            }
            resultTextBlock.Text = result;
        }
    }
}