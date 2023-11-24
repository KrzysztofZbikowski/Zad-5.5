class zad
{
    static void Rysuj(int a, int b, char znak)
    {
        for (int i = 0; i < a; i++)
        {
            for (int j = 0; j < b; j++)
            {
                Console.Write(znak);
            }
            Console.WriteLine();
        }
    }
    static void Main(string[] args)
    {
        int a, b;
        char znak;
        Console.WriteLine("Podaj wysokość twojej figury: ");
        a = int.Parse(Console.ReadLine());
        Console.WriteLine("Podaj długość twojej figury: ");
        b = int.Parse(Console.ReadLine());
        Console.WriteLine("Podaj znak wypełnienia twojej figury: ");
        znak = char.Parse(Console.ReadLine());
        Rysuj(a, b, znak);
        Console.ReadLine();
        Rysuj(b, a, znak);
        Console.ReadKey();
    }
}