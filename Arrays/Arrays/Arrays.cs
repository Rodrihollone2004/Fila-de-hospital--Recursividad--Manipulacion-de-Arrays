public class Arrays
{
    char[] chars;
    int repeat = 0;
    int contVowel = 0;
    char[] letter = new char[0];


    public void Start(string word)
    {
        chars = word.ToCharArray();

        Console.Write($"Largo: {chars.Length} \n");

        Console.WriteLine("Introduzca una letra: ");
        Console.Write($"La letra se repitio {Letter()} veces. \n");

        Console.WriteLine($"Hay {Vowels()} vocales.");
    }

    public int Letter(int index = 0)
    {
        while (letter.Length == 0) {
            string input = Console.ReadLine();
            if (input.Length == 1 && Char.IsLetter(input[0]))
                letter = input.ToCharArray();
            else
                Console.WriteLine("Solo se acepta 1 letra");
        }


        if (index > chars.Length - 1)
        {
            return repeat;
        }

        if (Array.Exists(letter, v => v == chars[index]))
        {
            repeat++;
        }

        return Letter(index + 1);
    }

    public int Vowels(int index = 0, int repeat = 0)
    {
        char[] vowels = { 'A', 'E', 'I', 'O', 'U', 'a', 'e', 'i', 'o', 'u' };  // Incluí minúsculas también

        if (index >= chars.Length)  // Si ya revisamos todos los caracteres
        {
            return contVowel;
        }

        if (Array.Exists(vowels, v => v == chars[index]))  // Si el carácter actual es una vocal
        {
            contVowel++;
        }

        return Vowels(index + 1);  // Avanzar al siguiente carácter
    }
}
