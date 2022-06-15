using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Environment;

namespace ContactsApp.Model
{
    public class ProjectSerializer
    {
        public string Filename{ get; set; } = 
            Environment.GetFolderPath(SpecialFolder.ApplicationData) + "\\Mikheeva\\ContsctsApp";

        public void SaveToFile(Project project)
        {

        }
        public Project LoadFromFile()
        {
            Project p = new Project();
            return p;
        }

        public ProjectSerializer()
        {
            
        }
    }
}
