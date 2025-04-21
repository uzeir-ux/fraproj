using System.Windows;
using System.Windows.Controls;

namespace ProjectManagerApp
{
    public partial class LoginWindow : Window
    {
        private const string SuperPassword = "supersecret";
        private PasswordWindow _passwordWindow;

        public LoginWindow()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string enteredPassword = PasswordBox.Password;

            if (enteredPassword == SuperPassword)
            {
                MessageBox.Show("Авторизация успешна!");
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Неверный пароль!");
            }
        }

        private void ShowPasswordButton_Click(object sender, RoutedEventArgs e)
        {
            if (_passwordWindow == null || !_passwordWindow.IsVisible)
            {
                _passwordWindow = new PasswordWindow(PasswordBox.Password);
                _passwordWindow.Show();
                ShowPasswordButton.Content = "Скрыть";
            }
            else
            {
                _passwordWindow.Close();
                _passwordWindow = null;
                ShowPasswordButton.Content = "Показать";
            }
        }
    }

    public class PasswordWindow : Window
    {
        public PasswordWindow(string password)
        {
            Title = "Пароль";
            Width = 200;
            Height = 100;
            WindowStartupLocation = WindowStartupLocation.CenterOwner;

            var textBlock = new TextBlock
            {
                Text = $"Ваш пароль: {password}",
                VerticalAlignment = VerticalAlignment.Center,
                HorizontalAlignment = HorizontalAlignment.Center,
                FontSize = 14
            };

            var grid = new Grid();
            grid.Children.Add(textBlock);

            this.Content = grid;
        }
    }
}