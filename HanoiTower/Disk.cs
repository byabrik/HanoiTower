namespace HanoiTower
{
    public sealed class Disk
    {
        public Disk(int size)
        {
            Size = size;
        }
        public int Size { get; private set; }
    }
}