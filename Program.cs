using System;

class SayaMusicTrack
{
    private int id;
    private string title;
    private int playCount;

    public SayaMusicTrack(string title)
    {
        Random rand = new Random();
        this.id = rand.Next(10000, 99999);
        this.title = title;
        this.playCount = 0;
    }

    public void IncreasePlayCount(int count)
    {
        playCount += count;
    }

    public void PrintTrackDetails()
    {
        Console.WriteLine($"ID:  {this.id}");
        Console.WriteLine($"Title: {this.title}");
        Console.WriteLine($"Play Count: {this.playCount}");
        Console.WriteLine($"__________________________");
    }

    static void Main(string[] args)
    {
        SayaMusicTrack lagu1 = new SayaMusicTrack("Goodnight");
        lagu1.IncreasePlayCount(100);
        lagu1.PrintTrackDetails();

        SayaMusicTrack lagu2 = new SayaMusicTrack("Best Part");
        lagu2.IncreasePlayCount(100);
        lagu2.PrintTrackDetails();

        SayaMusicTrack lagu3 = new SayaMusicTrack("Apple Cider");
        lagu3.IncreasePlayCount(100);
        lagu3.PrintTrackDetails();

        SayaMusicTrack lagu4 = new SayaMusicTrack("Glue Song");
        lagu4.IncreasePlayCount(100);
        lagu4.PrintTrackDetails();
    }
}