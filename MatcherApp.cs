namespace Klausur_lernen
{
    internal class MatcherApp : IMatcherApp
    {
        public List<IPerson> People { get; } = new List<IPerson>();
        public List<IFruit> Fruits { get; } = new List<IFruit>();
        public List<IPerson> Candidates { get; } = new List<IPerson>();
        public Matcher Matcher { get; } = new Matcher();

        public void AddPerson(IPerson person)
        {
            People.Add(person);
            Match();
        }

        public void AddFruit(IFruit fruit)
        {
            Fruits.Add(fruit);
            Match();
        }

        public void Match()
        {
            foreach (IPerson person in People)
            {
                if (Candidates.Contains(person)) { continue; }

                foreach(IFruit fruit in Fruits)
                {
                    if (Matcher.Match(person, fruit)) {
                        Candidates.Add(person);
                    }
                }
            }
        }
    }
}
