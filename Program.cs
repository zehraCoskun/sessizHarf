//Verilen string ifade içerisinde yanyana 2 tane sessiz varsa ekrana true, yoksa false yazdıran console uygulamasını yazınız.
internal class Program
{
    private static void Main(string[] args)
    {
    baslangıc:
        Console.WriteLine("\n\nLütfen aralarında boşluk bırakarak kelime giriniz:");
        string[] kelimeler = Console.ReadLine().Split();

        foreach (var harf in kelimeler)
        {
            bool kontrol = false;
            for (int i = 1; i < harf.Length; i++)
            {
                if (sessiz(harf[i]) == sessiz(harf[i - 1])&&sessiz(harf[i])==true)
                    kontrol = true;
            }
            Console.Write(kontrol + " ");
        }

        bool sessiz(char c)
        {
            return !"aeıioöuü".ToCharArray().Contains(c);
        }

        goto baslangıc;
    }

}