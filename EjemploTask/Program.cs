Console.WriteLine("Inicio del programa...");

Task tarea = new Task(() =>
{
    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine($"Iteración {i}");
        Task.Delay(1000).Wait();
    }
});
tarea.Wait();

Console.WriteLine("Fin del programa...");