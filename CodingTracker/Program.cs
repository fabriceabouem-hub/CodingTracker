namespace CodingTracker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Welt!");
            Ghost ghost = new Ghost("Spooky");
            ghost.Haunt();
            SlimeGhost slimeghost = new SlimeGhost("Slimey");
            Console.WriteLine($"Der Name von Slime ist : {slimeghost.Name}");
            slimeghost.Haunt();
        }
    }
    class Ghost
    {
        public string Name { get; set; }

        public Ghost(string name)
        {
            Name = name;
        }   
        public virtual void Haunt()
        {
            Console.WriteLine($"Der Ghost {Name} sagt : Buh ");
        }

    }
    class SlimeGhost : Ghost
    {
        public SlimeGhost(string name) : base(name)
        {

        }
        public override void Haunt()
        {
            this.Slime();
            base.Haunt();
        }
        public void Slime()
        {
            Console.WriteLine($"Der SlimeGhost {Name} hinterlässt eine Schleimspur!");
        }
    }
}
