using System;
using System.IO;
using System.Text;

namespace LibFiles
{
    public class Archivo
    {

        //Uso de @ en una ruta
        //Usa el @ para interpretar como texto todo el contenido de la cadena, evitas el uso de \\ doble diagonar para caracteres especiales
        public void CreateArchivo(string PathFile, string Text)
        {
            // Create the file, or overwrite if the file exists.
            
            try
            {
                using (FileStream fs = File.Create(PathFile))
                {
                    byte[] info = new UTF8Encoding(true).GetBytes(Text);
                    // Add some information to the file.
                    fs.Write(info, 0, info.Length);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Archivos: " + ex);
            }
        }

        public string LeerArchivo(string PathFile)
        {
            string[] lines = System.IO.File.ReadAllLines(PathFile);
            string Contenido="";
            System.Console.WriteLine("Contents of WriteLines2.txt = ");
            foreach (string line in lines)
            {
                // Use a tab to indent each line of the file.
                Contenido += line;
                Console.WriteLine("\t" + line);
            }
            return Contenido;
        }

        public bool ExisteCarpeta(string Path)
        {
            if (!Directory.Exists(Path))
                return true;
            else
                return false;
        }
        public bool ExisteArchivo(string Path)
        {
            if (File.Exists(Path))
                return true;
            else
                return false;
        }

        public bool CreateDirectory(string Path)
        {
            Directory.CreateDirectory(Path);
            return true;
        }
        public string GetActualDate()
        {
            return DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss");
        }

        public string CreateNameForLog(string prefixName, string IdDate)
        {
            return @"C:\Archivos\log\"+prefixName + IdDate + ".txt";
        }

        public void EscribeAlFinal(string Path)
        {
            using (StreamWriter sw = File.AppendText(Path))
            {
                sw.WriteLine("This");
                sw.WriteLine("is Extra");
                sw.WriteLine("Text");
            }
        }
    }
}
