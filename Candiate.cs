internal class Candiate {
  public Pirate Pirate {get; protected set;}
  public Fruit Fruit {get; protected set;}

  public Candidate(Pirate pirate, Fruit fruit) {
    Pirate = pirate;
    Fruit = fruit;
  }
}
