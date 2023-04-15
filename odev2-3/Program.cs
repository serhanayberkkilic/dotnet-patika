using System;

class Program {
    static void Main(string[] args) {
        Console.Write("Lütfen bir cümle girin: ");
        string cumle = Console.ReadLine().ToLower();

        char[] sesliHarfler = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };
        char[] bulunanSesliler = new char[0];

        foreach (char harf in cumle) {
            if (Array.IndexOf(sesliHarfler, harf) > -1 && Array.IndexOf(bulunanSesliler, harf) == -1)
            {
                Array.Resize(ref bulunanSesliler, bulunanSesliler.Length + 1);
                bulunanSesliler[bulunanSesliler.Length - 1] = harf;
            }
        }

        Array.Sort(bulunanSesliler);

        Console.Write("Cümledeki sesli harfler: ");
        foreach (char sesli in bulunanSesliler) {
            Console.Write(sesli + " ");
        }
    }
}
