using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploThread04
{
    public class ThreadSafeFileRepository : IFileRepository
    {
        private readonly string _path;
        private readonly object _lock = new object();

        public ThreadSafeFileRepository(string path)
        {
            _path = path;
            if (!Directory.Exists(_path))
            {
                Directory.CreateDirectory(_path);
            }
        }
        public FileData ReadFile(string fileName)
        {
            string filePath = Path.Combine(_path, fileName);

            lock (_lock)
            {
                if (!File.Exists(filePath))
                {
                    return new FileData
                    {
                        FileName = filePath,
                        FileContent = File.ReadAllText(filePath)
                    };
                }
                else
                {
                    return null;
                }
            }
        }

        public void SaveFile(FileData fileData)
        {
            string filePath = Path.Combine(_path, fileData.FileName);
            lock (_lock)
            {
                File.WriteAllText(filePath, fileData.FileContent);
            }
        }
    }
}
