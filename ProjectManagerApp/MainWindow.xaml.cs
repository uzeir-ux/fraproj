using System.Windows;
using System.Collections.ObjectModel;
using System.Linq;
using System.Collections.Generic;

namespace ProjectManagerApp
{
    public partial class MainWindow : Window
    {
        public ObservableCollection<Project> Projects { get; set; }
        private List<Project> _pendingUpdates = new List<Project>();
        private List<Project> _pendingDeletions = new List<Project>();

        public MainWindow()
        {
            InitializeComponent();
            Projects = new ObservableCollection<Project>();
            ProjectsDataGrid.ItemsSource = Projects;
        }

        private void AddProjectButton_Click(object sender, RoutedEventArgs e)
        {
            AddProjectWindow addProjectWindow = new AddProjectWindow();
            addProjectWindow.ProjectAdded += AddProjectToList;
            addProjectWindow.ShowDialog();
        }

        private void EditSelectedProject_Click(object sender, RoutedEventArgs e)
        {
            if (ProjectsDataGrid.SelectedItem is Project selectedProject)
            {
                EditProjectWindow editWindow = new EditProjectWindow(selectedProject);
                editWindow.ProjectUpdated += (s, updatedProject) =>
                {
                    // Добавляем в список ожидающих обновлений
                    _pendingUpdates.Add(updatedProject);
                    MessageBox.Show("Изменения будут применены после нажатия кнопки Обновить", 
                                  "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
                };
                editWindow.ShowDialog();
            }
            else
            {
                MessageBox.Show("Выберите проект для редактирования", "Ошибка", 
                              MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void DeleteSelectedProject_Click(object sender, RoutedEventArgs e)
        {
            if (ProjectsDataGrid.SelectedItem is Project selectedProject)
            {
                var result = MessageBox.Show($"Пометить проект '{selectedProject.ProjectName}' для удаления?", 
                                           "Подтверждение", 
                                           MessageBoxButton.YesNo, 
                                           MessageBoxImage.Question);
                
                if (result == MessageBoxResult.Yes)
                {
                    _pendingDeletions.Add(selectedProject);
                    MessageBox.Show("Проект будет удален после нажатия кнопки Обновить", 
                                   "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            else
            {
                MessageBox.Show("Выберите проект для удаления", "Ошибка", 
                              MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void RefreshButton_Click(object sender, RoutedEventArgs e)
        {
            // Применяем обновления
            foreach (var updatedProject in _pendingUpdates)
            {
                var existing = Projects.FirstOrDefault(p => p.Id == updatedProject.Id);
                if (existing != null)
                {
                    existing.Date = updatedProject.Date;
                    existing.ProjectName = updatedProject.ProjectName;
                    existing.Description = updatedProject.Description;
                    existing.Title = updatedProject.Title;
                    existing.Author = updatedProject.Author;
                    existing.GitLink = updatedProject.GitLink;
                    existing.Comment = updatedProject.Comment;
                }
            }

            // Применяем удаления
            foreach (var projectToDelete in _pendingDeletions)
            {
                Projects.Remove(projectToDelete);
            }

            // Очищаем очереди
            _pendingUpdates.Clear();
            _pendingDeletions.Clear();

            ProjectsDataGrid.Items.Refresh();
            MessageBox.Show("Все изменения применены", "Готово", 
                          MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void AddProjectToList(object sender, Project newProject)
        {
            if (newProject != null && !string.IsNullOrWhiteSpace(newProject.Id))
            {
                Projects.Add(newProject);
            }
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            if (_pendingUpdates.Count > 0 || _pendingDeletions.Count > 0)
            {
                var result = MessageBox.Show("Есть непримененные изменения. Выйти без сохранения?", 
                                           "Предупреждение", 
                                           MessageBoxButton.YesNo, 
                                           MessageBoxImage.Warning);
                if (result == MessageBoxResult.No)
                {
                    return;
                }
            }
            this.Close();
        }
    }
}