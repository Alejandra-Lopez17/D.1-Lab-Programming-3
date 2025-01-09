namespace WeeklyLab;

internal class Actividad1
{
    private static void Main(string[] args)
    {
        if (args.Length == 7)
        {
            var listaDeArgumentos = new List<object>();
            
            foreach (var arg in args) listaDeArgumentos.Add(arg);
            
            var mensaje = "Los argumentos que proporcione fueron: ";

            foreach (var arg in listaDeArgumentos) mensaje += arg + " | ";
            
            mensaje = mensaje.TrimEnd('|', ' ');
            
            Console.WriteLine(mensaje);
            
            var i = 0;
            while (i < listaDeArgumentos.Count)
            {
                var argumento = listaDeArgumentos[i];
                switch (i)
                {
                    case 0:
                        if (short.TryParse(argumento.ToString(), out var valorShort))
                        {
                            Console.WriteLine($"El argumento {i + 1} convertido a short es: {valorShort}");
                            Console.WriteLine($"Convertido a long es {(long)valorShort}");
                        }

                        break;
                    case 1:
                        if (float.TryParse(argumento.ToString(), out var valorFloat))
                        {
                            var valor = (int)valorFloat;
                            Console.WriteLine($"El argumento {i + 1} convertido a int es: {valor}");
                            Console.WriteLine($"Convertido de nuevo a float es: {(float)valor}");
                        }

                        break;
                    case 2:
                        if (double.TryParse(argumento.ToString(), out var valorDouble))
                            Console.WriteLine($"El argumento {i + 1} convertido a double es {valorDouble}");

                        break;
                    case 3:
                        Console.WriteLine($"El argumento {i + 1} convertido a string es: {argumento}");

                        break;
                    case 4:
                        Console.WriteLine($"El argumento {i + 1} convertido a string es: {argumento}");

                        break;
                    case 5:
                        var valorBoxeado = argumento;
                        Console.WriteLine($"Valor boxeado (objeto) es: {valorBoxeado}");

                        break;
                    case 6:
                        Console.WriteLine($"Valor desboxeado (string): {(string)argumento}");

                        break;
                }

                i++;
            }
        }
        else
        {
            Console.WriteLine("No se proporcionaron suficientes argumentos.");
        }
    }
}


