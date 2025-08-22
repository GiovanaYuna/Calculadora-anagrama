using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite a primeira palavra:");
        string palavra1 = Console.ReadLine().ToLower();

        Console.WriteLine("Digite a segunda palavra:");
        string palavra2 = Console.ReadLine().ToLower();

        if (EhAnagrama(palavra1, palavra2))
        {
            Console.WriteLine("São anagramas!");
        }
        else
        {
            Console.WriteLine("Não são anagramas.");
        }
    }

    static bool EhAnagrama(string a, string b)
    {
        if (a.Length != b.Length)
            return false;

        char[] arrA = a.ToCharArray();
        char[] arrB = b.ToCharArray();

        Array.Sort(arrA);
        Array.Sort(arrB);

        for (int i = 0; i < arrA.Length; i++)
        {
            if (arrA[i] != arrB[i])
                return false;
        }

        return true;
    }
}
