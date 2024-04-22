namespace Klausur_lernen
{
    internal class Person : IPerson
    {
        public string Name { get; protected set; } = "Person";
        public string FavoriteFruit { get; protected set; } = "None";

        public Person() { }

        public Person(string name) : this()
        {
            Name = name;
        }

        public Person(string name, string favoriteFruit) : this(name)
        {
            FavoriteFruit = favoriteFruit;
        }
    }
}
