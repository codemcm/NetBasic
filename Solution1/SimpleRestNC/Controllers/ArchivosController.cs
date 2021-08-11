using LibFiles;
using Microsoft.AspNetCore.Mvc;

namespace SimpleRestNC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArchivosController : ControllerBase
    {

        [HttpPost]
        public void CrearArchivo()
        {
            Archivo archivoNuevo = new Archivo();
            string fileName = @"C:\Archivos\archivoRest.txt";
            archivoNuevo.CreateArchivo(fileName, "Archivo creado desde rest");
        }
    }
}
