public class Arrays
{
   public void Start()
    {
            
    Console.Write("Ingrese una oracion: ");
        string oracion = Console.ReadLine();

    Console.WriteLine(oracion.Length);

        Console.Write("Ingrese una letra: ");
        char letra = Console.ReadKey().KeyChar;
    Console.WriteLine();

        int CantidadLetra = oracion.Count(c => c == letra);
    Console.WriteLine($"La letra '{letra}' se repite {CantidadLetra} veces.");

        int CantidadVocales = oracion.Count(c => "aeiouAEIOU".Contains(c));
    Console.WriteLine($"Cantidad de vocales: {CantidadVocales}");

        var palabras = oracion.Split(' ');
    Console.WriteLine("Largo de cada palabra: " + string.Join(" - ", palabras.Select(p => p.Length)));

        string OracionReversa = new string(oracion.Reverse().ToArray());
    Console.WriteLine($"Oracion al reves: {OracionReversa}");

        string PalabraReversa = string.Join(" ", palabras.Select(p => new string(p.Reverse().ToArray())));
    Console.WriteLine($"Palabras al reves:{PalabraReversa}");

        string SinVocales = new string(oracion.Where(c => !"aeiouAEIOU".Contains(c)).ToArray());
    Console.WriteLine($"Oracion sin vocales: {SinVocales}");

        string Mayusculas = oracion.ToUpper();
    Console.WriteLine($"Oracion en mayusculas: {Mayusculas}");

        string cifradoCesar = CifradoCesar(oracion, 3);
    Console.WriteLine($"Cifrado Cesar: {cifradoCesar}");

        string cifradoXOR = CifradoXOR(oracion, 'k');
    Console.WriteLine($"Cifrado XOR: {cifradoXOR}");

    }

    
static string CifradoCesar(string input, int shift)
    {
        return new string(input.Select(c => (char)(c + shift)).ToArray());
    }
    static string CifradoXOR(string input, char key)
    {
        return new string(input.Select(c => (char)(c ^ key)).ToArray());
    }
}

