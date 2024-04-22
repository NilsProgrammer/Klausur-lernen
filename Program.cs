namespace Klausur_lernen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MatcherApp matcherApp = new MatcherApp();
            for (int i = 0; i < 5; i++)
            {
                Person person = new Person("Person" + i, "Fruit" + (5 - i));
                Fruit fruit = new Fruit("Fruit" + i);

                matcherApp.AddPerson(person);
                matcherApp.AddFruit(fruit);
            }

            Console.ReadLine();
        }
    }
}
