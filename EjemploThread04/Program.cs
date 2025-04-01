using EjemploThread04;

IFileRepository repository = new ThreadSafeFileRepository("files");

//Crear hilos para realizar operaciones concurrentes de lectura y escritura de archivos

Thread WriteThread = new Thread(() =>
{
    for (int i = 0; i < 10; i++)
    {
        string fileName = $"file{i}.txt";
        string fileContent = $"Content of file {i}";
        repository.SaveFile(new FileData { FileName = fileName, FileContent = fileContent });
        Console.WriteLine($"File {fileName} saved");
        Thread.Sleep(100);
    }
});
Thread ReadThread = new Thread(() =>
{
    for (int i = 0; i < 10; i++)
    {
        string fileName = $"file{i}.txt";
        FileData fileData = repository.ReadFile(fileName);
        Console.WriteLine($"File {fileName} read: {fileData.FileContent}");
        Thread.Sleep(100);
    }
});

//iniciar los hilos
WriteThread.Start();

//Esperar a que el hilo termine
WriteThread.Join();