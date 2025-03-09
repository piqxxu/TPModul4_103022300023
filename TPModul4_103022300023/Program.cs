using System;
using TPModul4_103022300023;

class Program
{
    static void Main()
    {
        Console.Write("Kelurahan: ");
        string kelurahan = Console.ReadLine();

        string kodePos = KodePos.GetKodePos(kelurahan);
        Console.WriteLine($"Kode pos: {kodePos}");
    }
}
