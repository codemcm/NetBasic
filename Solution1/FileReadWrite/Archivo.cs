using System;
using System.IO;
using System.Text;

namespace FileReadWrite
{
    public class Archivo
    {

        //Uso de @ en una ruta
        //Usa el @ para interpretar como texto todo el contenido de la cadena, evitas el uso de \\ doble diagonar para caracteres especiales
        public void CreateArchivo(string PathFile, string Text)
        {
            try
            {
                //Open the File
                StreamWriter sw = new StreamWriter(PathFile, true, Encoding.ASCII);
                sw.Write(Text);
                //close the file
                sw.Close();
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
            return prefixName + IdDate + ".txt";
        }
    }
}
