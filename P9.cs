using System;
 
public class vowels
{
    static void Main(string[] args)
    {
        char Alphabet;
 
        Console.WriteLine("Enter any Alphabet : ");
        Alphabet= Convert.ToChar(Console.ReadLine());
 

        if (Alphabet == 'a' ||  Alphabet == 'e' || Alphabet  == 'i' || Alphabet  == 'o' || Alphabet  == 'u');
        {
 
            Console.WriteLine( " Alphabet is Vowel.");
 
        }
        else 
        {
            Console.WriteLine(" Alphabet  is Consonant.");            
        }
 
        Console.ReadLine();
    }
}
