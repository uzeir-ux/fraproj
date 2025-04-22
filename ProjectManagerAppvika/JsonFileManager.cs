using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace ProjectManagerApp
{
    public class JsonFileManager
    {
        private string _filePath;

        public JsonFileManager(string filePath)
        {
            _filePath = filePath;
        }

        // Чтение списка проектов из JSON-файла
        public List<Project> LoadProjects()
        {
            if (!File.Exists(_filePath))
            {
                return new List<Project>(); // Если файл не существует, возвращаем пустой список
            }

            var jsonString = File.ReadAllText(_filePath);
            return JsonSerializer.Deserialize<List<Project>>(jsonString) ?? new List<Project>();
        }

        // Сохранение списка проектов в JSON-файл
        public void SaveProjects(List<Project> projects)
        {
            var jsonString = JsonSerializer.Serialize(projects, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(_filePath, jsonString);
        }
    }
}
