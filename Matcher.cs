namespace Klausur_lernen
{
    internal class Matcher : IMatcher
    {
        public bool Match(IPerson person, IFruit fruit)
        {
            return person.FavoriteFruit.Equals(fruit.Name);
        }
    }
}
