namespace Klausur_lernen
{
    internal class MatcherApp : IMatcherApp
    {
        public List<IPerson> People { get; } = new List<IPerson>();
        public List<IFruit> Fruits { get; } = new List<IFruit>();
        public Matcher Matcher { get; } = new Matcher();

        public void AddPerson(IPerson person)
        {
            People.Add(person);
        }

        public void AddFruit(IFruit fruit)
        {
            Fruits.Add(fruit);
        }

        public void Match()
        {
            foreach (IPerson person in People)
            {
                foreach(IFruit fruit in Fruits)
                {
                    bool matched = Matcher.Match(person, fruit);
                    if (matched)
                    {
                        Console.WriteLine("Matched " + person.Name + ": " + fruit.Name);
                    }
                }
            }
        }
    }
}
