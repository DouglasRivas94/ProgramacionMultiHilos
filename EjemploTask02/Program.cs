
Console.WriteLine("Inicio del programa...");

Task tarea1 = Task.Run(() => EjecutarTarea("Tarea1", 2));
Task tarea2 = Task.Run(() => EjecutarTarea("Tarea2", 3));
Task tarea3 = Task.Run(() => EjecutarTarea("Tarea3", 1));

void EjecutarTarea(string Nombre, int Segundo)
{
    Console.WriteLine($"{Nombre}Inicio de la tarea...");
    Task.Delay(Segundo * 1000).Wait();
    Console.WriteLine($"{Nombre}Fin de la tarea...");
}