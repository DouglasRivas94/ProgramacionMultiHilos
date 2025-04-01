Console.WriteLine("Inicio del programa...");

Task tarea = Task.Factory.StartNew(() =>
{
    Console.WriteLine("Inicio de la tarea...");
    Task.Delay(2000).Wait();
    Console.WriteLine("Fin de la tarea...");
});

tarea.Wait();

Console.WriteLine("Fin de la tarea...");
