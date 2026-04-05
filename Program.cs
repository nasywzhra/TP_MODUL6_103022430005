using System;
using System.Diagnostics;

class SayaMusicTrack
{
    private int id;
    private string title;
    private int playCount;

    public SayaMusicTrack(string title)
    {
        Debug.Assert(title != null, "Judul tidak boleh kosong");
        Debug.Assert(title.Length <= 100, "Judul maksimal 100 karakter.");

        Random rand = new Random();
        this.id = rand.Next(10000, 99999);
        this.title = title;
        this.playCount = 0;
    }

    public void IncreasePlayCount(int count)
    {
        Debug.Assert(count <= 10000000, "Input penambahan maksimal 10.000.000.");
        try
        {
            checked { this.playCount += count; }
        }
        catch (OverflowException)
        {
            Console.WriteLine("Error: terjadi overflow pada playcount! Angka terlalu besar.");
        }
    }

    public void PrintTrackDetails()
    {
        Console.WriteLine($"id: {this.id} | Title: {this.title} | Play Count: {this.playCount}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<SayaMusicTrack> playlist = new List<SayaMusicTrack>();

        playlist.Add(new SayaMusicTrack("Goodnight"));
        playlist.Add(new SayaMusicTrack("Best Part"));
        playlist.Add(new SayaMusicTrack("Apple Cider"));
        playlist.Add(new SayaMusicTrack("Glue Song"));

        Console.WriteLine(" === DAFTAR PLAYLIST AWAL === ");
        foreach (var track in playlist)
        {
            track.PrintTrackDetails();

        }

        Console.WriteLine("\n === UPDATE PLAY COUNT === ");

        playlist[0].IncreasePlayCount(500000);

        playlist[1].IncreasePlayCount(400000);

        playlist[2].IncreasePlayCount(700000);

        playlist[3].IncreasePlayCount(10000000);

        Console.WriteLine("\n === SIMULASI OVERFLOW PADA: " + playlist[3].GetType().Name + " === ");
        for (int i = 0; i < 220; i++)
        { 
               playlist[3].IncreasePlayCount(10000000);

        }

        Console.WriteLine("\n === HASIL AKHIR SEMUA TRACK === ");
        foreach (var track in playlist)
        { 
               track.PrintTrackDetails();

        }

        Console.WriteLine("\nTekan tombol apapun untuk keluar.");
        Console.ReadKey();
    }
}