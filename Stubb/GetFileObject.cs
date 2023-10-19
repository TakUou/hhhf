using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace Stubb
{
    public class GetFileObject
    {
        public List<string> GetFiles()
        {
            List<string> hF = new List<string>();
            using (var folderBrowserDialog = new FolderBrowserDialog())
            {
                DialogResult result = folderBrowserDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string selectedFolderPath = folderBrowserDialog.SelectedPath;
                    // Получаем список файлов в выбранной папке
                    string[] files = Directory.GetFiles(selectedFolderPath);
                    hF.Add(selectedFolderPath);


                    // Добавляем файлы в ListBox
                    foreach (string file in files)
                    {
                        hF.Add(file);
                    }
                }
            }
            return hF;
        }
    }
}
