using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

//GC垃圾回收
namespace DisposeAndGC
{
    [Serializable]
    class Clone:IDisposable
    {
        public int Id { get; private set; }

        public Clone(int id)
        {
            this.Id = id;
        }

        public void Dispose()
        {
            string filename = @"..\Test\Clone.dat";
            string dirname = @"..\Test";
            if (File.Exists(filename) == false)
            {
                Directory.CreateDirectory(dirname);
            }

            BinaryFormatter bf = new BinaryFormatter();
            using (Stream output = File.OpenWrite(filename))
            {
                bf.Serialize(output, this);
            }

            MessageBox.Show("I've been disposed!", "Clone #" + Id + "says...");
        }

        ~Clone()
        {
            MessageBox.Show("Aaargh! You got me!", "Clone #" + Id + "says...");
        }
    }
}
