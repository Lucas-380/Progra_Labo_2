using Entidades.Exceptions;
using Entidades.Interfaces;
using Entidades.Modelos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Entidades.Files
{
    public static class FileManager
    {
        static string path;

        static FileManager()
        {
            FileManager.path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            FileManager.path += "\\20230622_Dure\\";
            FileManager.ValidaExistenciaDeDirectorio();
        }

        public static void Guardar(string data, string nombreArchivo, bool append)
        {
            using (StreamWriter sw = new StreamWriter(path+nombreArchivo, append))
            {
                sw.WriteLine(data);
            }
        }


        public static bool Serializar<T>(T elemento, string nombreArchivo) where T : class
        {
            string json = JsonSerializer.Serialize<T>(elemento);
            if(json is not null)
            {
                FileManager.Guardar(json, nombreArchivo, true);
                return true;
            }
            return false;
        }


        private static void ValidaExistenciaDeDirectorio()
        {
            if (!Directory.Exists(FileManager.path))
            {
                try
                {
                    Directory.CreateDirectory(path);
                }
                catch (Exception)
                {
                    throw new FileManagerException("Error al crear el directorio");
                }
            }
        }

    }
}
