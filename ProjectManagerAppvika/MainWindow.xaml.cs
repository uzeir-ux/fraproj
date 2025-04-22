using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace ProjectManagerApp
{
    public partial class MainWindow : Window
    {
        public ObservableCollection<Project> Projects { get; set; }
        private ObservableCollection<Project> PendingChanges { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            Projects = new ObservableCollection<Project>();
            PendingChanges = new ObservableCollection<Project>();
            ProjectsDataGrid.ItemsSource = Projects;
        }

        private void AddProjectButton_Click(object sender, RoutedEventArgs e)
        {
            AddProjectWindow addProjectWindow = new AddProjectWindow();
            addProjectWindow.ProjectAdded += AddProjectToPending;
            addProjectWindow.ShowDialog();
        }

        private void AddProjectToPending(object? sender, Project newProject)
        {
            if (newProject != null)
            {
                PendingChanges.Add(newProject);
            }
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void RefreshButton_Click(object sender, RoutedEventArgs e)
        {
            foreach (var pending in PendingChanges)
            {
                Projects.Add(pending);
            }
            PendingChanges.Clear();
            ProjectsDataGrid.Items.Refresh();
        }

        private void EditProject(Project project)
        {
            AddProjectWindow editWindow = new AddProjectWindow(); // no parameter constructor
            editWindow.ProjectAdded += (s, updatedProject) =>
            {
                var existing = Projects.IndexOf(project);
                if (existing >= 0)
                {
                    Projects[existing] = updatedProject;
                }
            };
            editWindow.ShowDialog();
        }

        private void DeleteProject(Project project)
        {
            if (Projects.Contains(project))
            {
                Projects.Remove(project);
            }
        }

        private void ProjectsDataGrid_LoadingRow(object sender, DataGridRowEventArgs e)
        {
            if (e.Row.Item is Project project)
            {
                DataGridTemplateColumn actionColumn = new DataGridTemplateColumn
                {
                    Header = "Действия",
                    CellTemplate = (DataTemplate)Resources["ActionTemplate"]
                };
                if (!ProjectsDataGrid.Columns.Contains(actionColumn))
                    ProjectsDataGrid.Columns.Add(actionColumn);
            }
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            var project = (sender as Button)?.DataContext as Project;
            if (project != null)
                EditProject(project);
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            var project = (sender as Button)?.DataContext as Project;
            if (project != null)
                DeleteProject(project);
        }
    }
}
