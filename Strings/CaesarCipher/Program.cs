using System;

namespace CaesarCipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var inputText = Console.ReadLine();
            var shiftFactor = int.Parse(Console.ReadLine());
            if (shiftFactor > 26) shiftFactor %= 26;

            for (int i = 0; i < inputText.Length; i++)
            {
                var asciiCode = (int)inputText[i];
                if (asciiCode <= 122 && asciiCode > 96)
                {
                    // small alphabets
                    if (asciiCode + shiftFactor <= 122)
                    {
                        // we are withing range so we can replace the char
                        Console.Write((char)(((int)inputText[i]) + shiftFactor));
                    }
                    else
                    {
                        var offset = shiftFactor - (122 - asciiCode);
                        Console.Write((char)(96 + offset));
                    }
                }
                else if (asciiCode <= 90 && asciiCode > 64)
                {
                    // upper case alphabets
                    if (asciiCode + shiftFactor <= 90)
                    {
                        // we are withing range so we can replace the char
                        Console.Write((char)(((int)inputText[i]) + shiftFactor));
                    }
                    else
                    {
                        var offset = shiftFactor - (90 - asciiCode);
                        Console.Write((char)(64 + offset));
                    }
                }
                else
                {
                    Console.Write(inputText[i]);
                }
            }
        }
    }
}