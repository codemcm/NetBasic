using LibFiles;
using System;

namespace FileReadWrite
{
    class Program
    {
        static void Main(string[] args)
        {
            Archivo archivo = new Archivo();

            //string rutaArchivo = @"C:\\Archivos\\Hola.txt";
            //archivo.CreateArchivo(rutaArchivo, "texto de prueba");
            //string rutaACrear= @"C:\\Archivos\\Inner";
            ////archivo.CreateDirectory(rutaACrear);
            //if (!archivo.ExisteCarpeta(rutaACrear))
            //{
            //    archivo.CreateDirectory(rutaACrear);
            //}

            //crear nombreArchivoLog
            string fileNameLog = archivo.CreateNameForLog("Log", archivo.GetActualDate());
            //crear LogFile
            archivo.CreateArchivo(fileNameLog, "texto del log");
            //archivo.LeerArchivo(rutaArchivo);
            //archivo.EscribeAlFinal(rutaArchivo);
            Console.WriteLine("Hello World!");
        }
    }
}
