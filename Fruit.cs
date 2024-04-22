namespace Klausur_lernen
{
    internal class Fruit : IFruit
    {
        public string Name { get; protected set; } = "Fruit";

        public Fruit()
        {

        }

        public Fruit(string name) : this()
        {
            Name = name;
        }
    }
}
