using System;
using System.Windows;

namespace ProjectManagerApp
{
    public partial class AddProjectWindow : Window
    {
        public event EventHandler<Project> ProjectAdded; // Событие для передачи данных в главное окно

        public AddProjectWindow()
        {
            InitializeComponent();
        }

        // Сохранение проекта
        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            // Проверка на пустые поля
            if (string.IsNullOrWhiteSpace(IdTextBox.Text) ||
                string.IsNullOrWhiteSpace(ProjectNameTextBox.Text) || string.IsNullOrWhiteSpace(DescriptionTextBox.Text) ||
                string.IsNullOrWhiteSpace(TitleTextBox.Text) || string.IsNullOrWhiteSpace(AuthorTextBox.Text) ||
                string.IsNullOrWhiteSpace(GitLinkTextBox.Text) || string.IsNullOrWhiteSpace(CommentTextBox.Text) ||
                string.IsNullOrWhiteSpace(InstallerPathTextBox.Text) || string.IsNullOrWhiteSpace(UrlTextBox.Text) ||
                string.IsNullOrWhiteSpace(DomainTextBox.Text) || string.IsNullOrWhiteSpace(DatabaseTextBox.Text) ||
                string.IsNullOrWhiteSpace(PortTextBox.Text) || string.IsNullOrWhiteSpace(PasswordBox.Password))
            {
                MessageBox.Show("Пожалуйста, заполните все обязательные поля.");
                return;
            }

            // Создание объекта проекта с заполненными данными
            var newProject = new Project
            {
                Id = IdTextBox.Text,
                Date = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss"), // Автоматически назначаем текущую дату и время
                ProjectName = ProjectNameTextBox.Text,
                Description = DescriptionTextBox.Text,
                Title = TitleTextBox.Text,
                Author = AuthorTextBox.Text,
                GitLink = GitLinkTextBox.Text,
                Comment = CommentTextBox.Text,
                InstallerPath = InstallerPathTextBox.Text,
                Url = UrlTextBox.Text,
                Domain = DomainTextBox.Text,
                Database = DatabaseTextBox.Text,
                Port = PortTextBox.Text,
                Password = PasswordBox.Password
            };

            // Передаем проект в главное окно
            ProjectAdded?.Invoke(this, newProject);

            // Закрытие окна после добавления проекта
            this.Close();
        }

        // Отмена и закрытие окна
        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}