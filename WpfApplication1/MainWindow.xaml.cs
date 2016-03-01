using Expression.Blend.SampleData.Fields;
using System.Windows;
using System.Windows.Controls;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            UpdateContentVisibility();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.WindowState = WindowState.Minimized;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (Application.Current.MainWindow.WindowState == WindowState.Normal)
                Application.Current.MainWindow.WindowState = WindowState.Maximized;
            else
                Application.Current.MainWindow.WindowState = WindowState.Normal;
        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SubHeader.Text = (listBox.SelectedItem as Item)?.Property1;
            UpdateContentVisibility();
        }

        private void UpdateContentVisibility()
        {
            if (listBox.SelectedIndex > -1)
                FieldPresenter.Visibility = Visibility.Visible;
        }
    }
}
