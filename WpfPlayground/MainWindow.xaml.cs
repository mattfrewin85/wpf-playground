using System.Windows;

namespace WpfPlayground
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

        private void SettingsButton_Click(object sender, RoutedEventArgs e)
        {
            SettingsWindow newWindow = new SettingsWindow();
            newWindow.ShowDialog();
        }

        private void HoverCardButton_Click(object sender, RoutedEventArgs e)
        {
            HoverCardWindow newWindow = new HoverCardWindow();
            newWindow.ShowDialog();
        }
    }
}