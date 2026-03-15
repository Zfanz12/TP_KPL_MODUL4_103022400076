using System;

class Program
{
    static void Main(string[] args)
    {
        KodePos kp = new KodePos();
        string[] daftarKelurahan = {
            "Batununggal", "Kujangsari", "Mengger", "Wates", "Cijaura",
            "Jatisari", "Margasari", "Sekejati", "Kebonwaru", "Maleer"
        };

        Console.WriteLine("=== Kode Pos Kelurahan ===");
        foreach (string kel in daftarKelurahan)
        {
            Console.WriteLine($"{kel}: {kp.getKodePos(kel)}");
        }
    }
}