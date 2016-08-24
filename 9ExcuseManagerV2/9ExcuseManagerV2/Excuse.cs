using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

//文件的打开保存
namespace ExcuseManagerV2
{
    [Serializable]
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
            string[] fileNames = Directory.GetFiles(folder,"*.excuse");
            OpenFile(fileNames[random.Next(fileNames.Length)]);
        }

        public void OpenFile(string path)
        {
            this.Path = path;
            using (Stream input = File.OpenRead(path))
            {
                BinaryFormatter bf = new BinaryFormatter();
                Excuse excuseRead = (Excuse)bf.Deserialize(input);
                Description = excuseRead.Description;
                Results = excuseRead.Results;
                LastUsed = excuseRead.LastUsed;
            }
        }

        public void SaveFile(string fileName)
        {
            using (Stream output = File.Create(fileName))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(output, this);
            }
        }

    }
}
