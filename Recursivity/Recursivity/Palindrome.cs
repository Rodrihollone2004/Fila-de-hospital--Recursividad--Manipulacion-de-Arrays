public class Palindrome
{
    public void Start()
    {
        string exitKey = "0";
        string word = "";

        while (word != exitKey)
        {
            word = Console.ReadLine();

            if (IsPalindrome(word))
                Console.WriteLine("The word is palindrome. Write another word");
        }
    }

    public bool IsPalindrome(string word, int index = 0)
    {
        while (index <= word.Length / 2)
        {
            if (word[index] == word[word.Length - 1 - index])
            {
                return IsPalindrome(word, index + 1);
            }
            else
            {
                Console.WriteLine("The word is not palindrome. Try another");
                return false;
            }
        }

        return true;
    }
}



