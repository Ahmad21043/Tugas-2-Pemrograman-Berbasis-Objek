class Program
{
    public static void Main(string[] args)
    {
        Konstruk kon = new Konstruk();

        kon.Show();

        Console.WriteLine();
        Console.Write("Press any key to continue . . . ");
        Console.ReadKey(true);
    }
}

class Konstruk
{
    public int A, B;
    public Konstruk()    //  <<--- Construktor
    {
        Console.WriteLine("   ==================================");
        Console.WriteLine("   =            Constructor         =");
        Console.WriteLine("   ==================================");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        //inisialisasi
        A = B = 450;
    }
    ~Konstruk()  //  <<--- Destruktor
    {
        Console.WriteLine("Finalizing");
    }
    public void Show()
    {
        Console.WriteLine("Nilai A = {0}", A);
        Console.WriteLine("Nilai B = {0}", B);
        Console.WriteLine();
        Console.WriteLine("Hasil Perkalian = {0}", A * B);
    }
}
/*
Output:
Nilai A = 450
Nilai B = 450

Hasil Perkalian = 202500
*/
 
