namespace Book.Interfaces
{
    internal interface IDamage
    {
        int Roll { get; set; }
        int Damage { get; }
        bool Flaming { get; set; }
        bool Magic { get; set; }
    }
}