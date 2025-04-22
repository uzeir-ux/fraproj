using System;
using System.Windows;

namespace ProjectManagerApp
{
    public partial class AddProjectWindow : Window
    {
        public event EventHandler<Project> ProjectAdded;

        public AddProjectWindow()
        {
            InitializeComponent();

            // Автозаполнение даты и ID
            DateTime now = DateTime.Now;
            DateTextBox.Text = now.ToString("yyyy-MM-dd HH:mm:ss");
            ProjectIdTextBox.Text = now.ToString("yyyyMMddHHmmss");
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            var newProject = new Project
            {
                Id = ProjectIdTextBox.Text,
                Date = DateTextBox.Text,
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
                Password = PasswordTextBox.Text
            };

            ProjectAdded?.Invoke(this, newProject);
            this.Close();
        }
    }
}
