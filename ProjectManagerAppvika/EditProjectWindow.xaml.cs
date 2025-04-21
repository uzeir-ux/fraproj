using System;
using System.Windows;

namespace ProjectManagerApp
{
    public partial class EditProjectWindow : Window
    {
        public event EventHandler<Project> ProjectUpdated;
        private Project _originalProject;
        private Project _tempProject;

        public EditProjectWindow(Project project)
        {
            InitializeComponent();
            _originalProject = project;
            _tempProject = new Project
            {
                Id = project.Id,
                Date = project.Date,
                ProjectName = project.ProjectName,
                Description = project.Description,
                Title = project.Title,
                Author = project.Author,
                GitLink = project.GitLink,
                Comment = project.Comment
            };

            // Заполняем поля данными
            IdTextBox.Text = _tempProject.Id;
            ProjectNameTextBox.Text = _tempProject.ProjectName;
            DescriptionTextBox.Text = _tempProject.Description;
            TitleTextBox.Text = _tempProject.Title;
            AuthorTextBox.Text = _tempProject.Author;
            GitLinkTextBox.Text = _tempProject.GitLink;
            CommentTextBox.Text = _tempProject.Comment;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            // Обновляем временный проект
            _tempProject.ProjectName = ProjectNameTextBox.Text;
            _tempProject.Description = DescriptionTextBox.Text;
            _tempProject.Title = TitleTextBox.Text;
            _tempProject.Author = AuthorTextBox.Text;
            _tempProject.GitLink = GitLinkTextBox.Text;
            _tempProject.Comment = CommentTextBox.Text;
            _tempProject.Date = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");

            ProjectUpdated?.Invoke(this, _tempProject);
            this.Close();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}