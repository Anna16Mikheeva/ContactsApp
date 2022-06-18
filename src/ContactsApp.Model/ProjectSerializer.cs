using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Environment;

namespace ContactsApp.Model
{
    public class ProjectSerializer
    {
        // <summary>
        /// Экземляр класса потока.
        /// </summary>
        private Stream stream;

        // <summary>
        /// Путь до папки, в которую сохраняется текстовый файл.
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// Сохраняет данные из экземпляра класса в userdata.json.
        /// </summary>
        public void SaveToFile(Project project)
        {
            if (FileName == null)
            {
                Directory.CreateDirectory(FileName);
                if (!File.Exists(FileName + "\\userdata.json"))
                {
                    File.Create(FileName + "\\userdata.json");
                }
            }
            //Создаём экземпляр сериализатора.
            JsonSerializer serializer = new JsonSerializer();
            //Открываем поток для записи в файл с указанием пути.
            using (stream = File.Open(@FileName, FileMode.OpenOrCreate, FileAccess.Write))
            {
                StreamWriter _streamWriter = new StreamWriter(stream);
                using (JsonWriter _writer = new JsonTextWriter(_streamWriter))
                {
                    //Вызываем сериализацию и передаем объект, который хотим сериализовать.
                    serializer.Serialize(_writer, project);
                }
            }
        }

        /// <summary>
        /// Выгружает данные их userdata.json.
        /// </summary>
        public Project LoadFromFile()
        {
            //Создаём переменную, в которую поместим результат
            //десериализации.
            Project project = null;
            if (FileName == null)
            {
                Directory.CreateDirectory(FileName);
                if (!File.Exists(FileName + "\\userdata.json"))
                {
                    File.Create(FileName + "\\userdata.json");
                }
            }
            try
            {
                //Создаём экземпляр сериализатора.
                JsonSerializer serializer = new JsonSerializer();
                //Открываем поток для чтения из файла с указанием пути.
                using (stream = File.Open(@FileName, FileMode.OpenOrCreate, FileAccess.Read))
                {
                    StreamReader _streamReader = new StreamReader(stream);
                    using (JsonReader _reader = new JsonTextReader(_streamReader))
                    {
                        //Вызываем десериализацию и явно преобразуем результат в
                        //целевой тип данных.
                        project = (Project)serializer.Deserialize(_reader, typeof(Project));
                    }
                }
            }
            catch
            {
                project = new Project();
            }
            if (project == null)
            {
                project = new Project();
            }
            return project;
        }

        public ProjectSerializer()
        {
            FileName = Environment.GetFolderPath(SpecialFolder.ApplicationData)
            + "\\Mikheeva\\ContactsApp";
        }
    }
}
