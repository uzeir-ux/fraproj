using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls; // Добавляем пространство имен для Button

namespace ProjectManagerApp
{
    public partial class MainWindow : Window
    {
        public ObservableCollection<Project> Projects { get; set; }

        // Буфер для изменений до нажатия "Обновить"
        private ObservableCollection<Project> _bufferedProjects;

        public MainWindow()
        {
            InitializeComponent();
            Projects = new ObservableCollection<Project>();
            _bufferedProjects = new ObservableCollection<Project>(Projects);
            ProjectsDataGrid.ItemsSource = Projects;
        }

        private void AddProjectButton_Click(object sender, RoutedEventArgs e)
        {
            AddProjectWindow addProjectWindow = new AddProjectWindow();
            addProjectWindow.ProjectAdded += AddProjectToList;
            addProjectWindow.ShowDialog();
        }

        private void AddProjectToList(object sender, Project newProject)
        {
            if (newProject != null)
            {
                _bufferedProjects.Add(newProject); // Добавляем в буфер, не в основную коллекцию
            }
        }

        private void RefreshButton_Click(object sender, RoutedEventArgs e)
        {
            Projects.Clear(); // Очищаем таблицу
            foreach (var project in _bufferedProjects)
            {
                Projects.Add(project); // Добавляем изменения в таблицу после нажатия "Обновить"
            }
            ProjectsDataGrid.Items.Refresh();
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        // Обработчик для редактирования проекта
        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            var project = button?.DataContext as Project;

            if (project != null)
            {
                // Открываем окно для редактирования
                AddProjectWindow addProjectWindow = new AddProjectWindow(project);
                addProjectWindow.ProjectAdded += (s, editedProject) =>
                {
                    if (editedProject != null)
                    {
                        // Найдем и заменим проект в буфере
                        var existingProject = _bufferedProjects.FirstOrDefault(p => p.Id == project.Id);
                        if (existingProject != null)
                        {
                            _bufferedProjects.Remove(existingProject);
                            _bufferedProjects.Add(editedProject);
                        }
                    }
                };
                addProjectWindow.ShowDialog();
            }
        }

        // Обработчик для удаления проекта
        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            var project = button?.DataContext as Project;

            if (project != null)
            {
                _bufferedProjects.Remove(project); // Удаляем проект из буфера
            }
        }
    }
}
