namespace Clase19;

class Program
{
    static void Main(string[] args)
    {
            // Console.WriteLine("Los argumentos que ha ingresado son: ");
            // foreach (var arg in args)
            // {
            //     Console.WriteLine("* - " + arg);
            // }
            
             Console.WriteLine($"Contador de parámetros = {args.Length}");

            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine($"Arg[{i}] = [{args[i]}]");
            }
    }
}
