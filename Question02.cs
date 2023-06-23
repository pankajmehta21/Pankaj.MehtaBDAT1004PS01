using System;

class Program
{
    static void Main()
    {
        string word1 = "Supercalifragilisticexpialidocious";
        string word2 = "Honorificabilitudinitatibus";
        string word3 = "Bababadalgharaghtakamminarronnkonn";

        // a. How many letters are there in 'Supercalifragilisticexpialidocious'?
        int letterCount = word1.Length;
        Console.WriteLine("Letter count: " + letterCount);

        // b. Does 'Supercalifragilisticexpialidocious' contain 'ice' as a substring?
        bool containsIce = word1.Contains("ice");
        Console.WriteLine("Contains 'ice': " + containsIce);

        // c. Which of the following words is the longest?
        string longestWord = "";
        if (word1.Length > word2.Length && word1.Length > word3.Length)
        {
            longestWord = word1;
        }
        else if (word2.Length > word3.Length)
        {
            longestWord = word2;
        }
        else
        {
            longestWord = word3;
        }
        Console.WriteLine("Longest word: " + longestWord);

        // d. Which composer comes first and last in the dictionary?
        string[] composers = { "Berlioz", "Borodin", "Brian", "Bartok", "Bellini", "Buxtehude", "Bernstein" };
        Array.Sort(composers); // Sort the array in ascending order
        string firstComposer = composers[0];
        string lastComposer = composers[composers.Length - 1];
        Console.WriteLine("First composer: " + firstComposer);
        Console.WriteLine("Last composer: " + lastComposer);
    }
}
