using System;
using System.IO;

class Program
{
    static void Main()
    {
        string sourceFilePath = "test2.txt";
        string targetFilePath = "test3.txt";

        try
        {
            using (FileStream sourceStream = File.OpenRead(sourceFilePath))
            {
                using (FileStream targetStream = File.Create(targetFilePath))
                {
                    sourceStream.CopyTo(targetStream);
                }
            }

            Console.WriteLine("Plik został skopiowany pomyślnie.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Wystąpił błąd podczas kopiowania pliku: {ex.Message}");
        }
    }
}