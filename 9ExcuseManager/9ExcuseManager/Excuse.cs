using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

//文件的打开保存
namespace _9ExcuseManager
{
    class Excuse
    {
        public string Description { get; set; }
        public string Results { get; set; }
        public DateTime LastUsed { get; set; }
        public string Path { get; set; }

        public Excuse()
        {
            Path = "";
        }

        public Excuse(string path)
        {
            OpenFile(path);
        }

        public Excuse(Random random, string folder)
        {
            string[] fileNames = Directory.GetFiles(folder,"*.txt");
            OpenFile(fileNames[random.Next(fileNames.Length)]);
        }

        public void OpenFile(string path)
        {
            this.Path = path;
            using (StreamReader reader = new StreamReader(path))
            {
                Description = reader.ReadLine();
                Results = reader.ReadLine();
                LastUsed = Convert.ToDateTime(reader.ReadLine());
            }
        }

        public void SaveFile(string fileName)
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                writer.WriteLine(Description);
                writer.WriteLine(Results);
                writer.WriteLine(LastUsed);
            }
        }

    }
}
