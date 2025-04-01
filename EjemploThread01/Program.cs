
Thread t1 = new(new ThreadStart(FuncionHilo));

t1.Start();

t1.Join();
Console.WriteLine("Iniciando hilo");
void FuncionHilo()
{
    Console.WriteLine("Hilo ejecutado");
}