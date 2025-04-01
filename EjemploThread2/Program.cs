
Thread t2 = new(new ParameterizedThreadStart(FuncionHilo));

t2.Start(5);

t2.Join();
void FuncionHilo(object? obj)
{
    int numero = (int)obj;
    Console.WriteLine("Este es un hilo secundario" + "Con parametro {0}" + obj);
}