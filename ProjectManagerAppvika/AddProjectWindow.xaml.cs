using System;
using System.Windows;

namespace ProjectManagerApp
{
    public partial class AddProjectWindow : Window
    {
        public event EventHandler<Project> ProjectAdded;

        public AddProjectWindow(Project project = null)
        {
            InitializeComponent();

            // Если проект передан, заполняем поля
            if (project != null)
            {
                ProjectIdTextBox.Text = project.Id; // Заполняем ID проекта, если передан проект
                ProjectNameTextBox.Text = project.ProjectName;
                DescriptionTextBox.Text = project.Description;
                TitleTextBox.Text = project.Title;
                AuthorTextBox.Text = project.Author;
                GitLinkTextBox.Text = project.GitLink;
                CommentTextBox.Text = project.Comment;
                InstallerPathTextBox.Text = project.InstallerPath;
                UrlTextBox.Text = project.Url;
                DomainTextBox.Text = project.Domain;
                DatabaseTextBox.Text = project.Database;
                PortTextBox.Text = project.Port;
                PasswordTextBox.Password = project.Password;
            }
            else
            {
                // Если проект не передан, назначаем ID с текущей датой и временем
                ProjectIdTextBox.Text = DateTime.Now.ToString("yyyyMMddHHmmss");
            }
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            // Создаем новый проект или редактируем существующий
            Project newProject = new Project
            {
                Id = ProjectIdTextBox.Text, // ID берется из текстового поля
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
                Password = PasswordTextBox.Password
            };

            // Вызов события для добавления нового проекта
            ProjectAdded?.Invoke(this, newProject); 
            this.Close(); // Закрыть окно
        }
    }
}
