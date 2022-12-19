using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Utilities
{
    public class FilesIO
    {
        private string path; //המחרוזרת שאיתה נעבוד

        public FilesIO(string path) //הקונסטרקטור מקבל משתנה מבחוץ ואנחנו רוצים שהוא יהיה שווה למשתנה שלנו
        {
            this.path = path;
        }

        public string ReadText(string file)
        {
            using (TextReader reader = File.OpenText(path + file))
            {
                return reader.ReadToEnd();
            }

        }

        public void WriteText(string file, string texst) //המטודה הזאת היא וויד הכוונה שאין לה מה להחזיר
        {
            using (TextWriter writer = File.CreateText(path + file))
            {
                writer.Write(texst);
            }
        }

    }
}
