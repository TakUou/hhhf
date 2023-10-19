using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stubb
{
    public class FileManager
    {
        public List<string> FindHeaviestFile()
        {
            
            List<string> hF = new List<string>();

            /*GetFileObject gfo = new GetFileObject();
            List<string> list = gfo.GetFiles();*/ //основная
            TestFileObject tfo = new TestFileObject();
            List<string> list = tfo.GetFiles();  //заглушка
            long f = 0;
            string r = "";
            foreach (var file in list)
            {
                if (f < file.Length)
                {
                    r = file;
                    f = file.Length;
                }
            }

            hF.Add(r);
            hF.Add(f.ToString());

            return hF;
        }
    }
}
