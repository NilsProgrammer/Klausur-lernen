namespace Klausur_lernen
{
    internal class MatcherApp : IMatcherApp
    {
        public List<IPerson> People { get; } = new List<IPerson>();
        public List<IFruit> Fruits { get; } = new List<IFruit>();
        public List<ICandidate> Candidates { get; } = new List<ICandidate>();
        public Matcher Matcher { get; } = new Matcher();

        public void AddPerson(IPerson person)
        {
            People.Add(person);
            Match(person);
        }

        public void AddFruit(IFruit fruit)
        {
            Fruits.Add(fruit);
            foreach (IPerson person in People) {
                Match(person);
            }
        }

        public void Match(IPerson person)
        {
            foreach (ICandidate candidate in Candidates)
            {
                ICandidate candidate = Candidates[i];
                if (candidate.Person == person) {continue;}

                foreach (IFruit fruit in Fruits) {
                    if (Matcher.Match(person, fruit)) {
                        Candidates.Add(person);
                    }
                }
            }
        }
    }
}
