
int contador = 0;
object Bloqueo = new object();

Thread[] hilos = new Thread[5];

for (int i = 0; i < 5; i++)
{
    hilos[i] = new Thread(IncrementarContador);
    hilos[i].Start();
}

foreach (Thread hilo in hilos)
{
    hilo.Join();
}

Console.WriteLine($"Valor al final del contador {contador}");
void IncrementarContador(object? obj)
{
    for(int i = 0; i < 1000; i++)
    {
        lock (Bloqueo)
        {
            contador++;
        }
    }
}