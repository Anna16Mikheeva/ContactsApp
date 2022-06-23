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
        private Stream _stream;

        private string textFile = "\\userdata.json";

        // <summary>
        /// Путь до папки, в которую сохраняется текстовый файл.
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// Сохраняет данные из экземпляра класса в userdata.json.
        /// </summary>
        public void SaveToFile(Project project)
        {
            if (!(Directory.Exists(FileName)))
            {
                Directory.CreateDirectory(FileName);
                if (!File.Exists(FileName + textFile))
                {
                    File.Create(FileName + textFile);
                }
            }
            //Создаём экземпляр сериализатора.
            JsonSerializer serializer = new JsonSerializer();
            //Открываем поток для записи в файл с указанием пути.
            using (_stream = File.Open(@FileName + textFile, FileMode.OpenOrCreate, FileAccess.Write))
            {
                StreamWriter _streamWriter = new StreamWriter(_stream);
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
            if (!(Directory.Exists(FileName)))
            {
                Directory.CreateDirectory(FileName);
                if (!File.Exists(FileName + textFile))
                {
                    File.Create(FileName + textFile);
                }
            }
            try
            {
                //Создаём экземпляр сериализатора.
                JsonSerializer serializer = new JsonSerializer();
                //Открываем поток для чтения из файла с указанием пути.
                using (_stream = File.Open(@FileName + textFile, FileMode.OpenOrCreate, FileAccess.Read))
                {
                    StreamReader _streamReader = new StreamReader(_stream);
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
