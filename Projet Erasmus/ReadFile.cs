using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Projet_Erasmus
{
    class ReadFile
    {
        public string ReadFiles()
        {
             string fileName = null;
            using (OpenFileDialog openFileDialog1 = new OpenFileDialog())
            {
                openFileDialog1.InitialDirectory = "c:\\";
                openFileDialog1.Filter = "CSV Files(*.csv) | *.csv";
                openFileDialog1.FilterIndex = 2;
                openFileDialog1.RestoreDirectory = true;

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    fileName = openFileDialog1.FileName;
                }
            }
            //verifier les ;
            //verifier que chaque nom est unique
            if (fileName != null)
            {
                //Do something with the file, for example read text from it
                string texte = File.ReadAllText(fileName);
                return texte;
            }
            throw new Exception("error");

        }
       
    }
}
