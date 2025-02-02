using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Basklass för person som innehåller namn och ålder
public class Person
{
    protected string name;
    protected int age;

    //Konstruktor för person som tar emot namn och ålder för att skapa en person
    public Person(string name, int age)
    {
        this.name = name; //Sätter namnet
        this.age = age; //Sätter åldern
    }

    public virtual string GetInfo() //Metod för att returnera information om personen
    {
        return $"{name}, {age} år"; //Returnerar namn och ålder
    }
}

public class Director : Person //Subklass den Person som representerar regissör
{
    private int moviesDirected; //Antalet filmer regissören har regisserat

    //Konstruktor som tar emot information om regissören samt antal filmer regisserade
    public Director(string name, int age, int moviesDirected) : base(name, age)
    {
        this.moviesDirected = moviesDirected; //Anger antalet filmer som blivit regisserade
    }

    //Override används för att ändra på GetInfo metoden och lägga till hur många filmer regissören regisserat
    public override string GetInfo()
    {
        return base.GetInfo() + $", Regisserat {moviesDirected} filmer"; //Returnerar information om regissören och antalet filmer regisserade
    }
}

public class Actor : Person //Subklass till Person som representerar skådespelare
{
    private int moviesActedIn; //Antalet filmer skådespelaren har medverkat i

    //Konstruktor som tar emot information om regissören samt antal filmer den medverkat i
    public Actor(string name, int age, int moviesActedIn) : base(name, age)
    {
        this.moviesActedIn = moviesActedIn; //Anger antalet filmer den medverkat i
    }

    public override string GetInfo() //Override används för att ändra på GetInfo metoden och lägga till hur många filmer skådespelaren medverkat i
    {
        return base.GetInfo() + $", Medverkat i {moviesActedIn} filmer"; //Returnerar information om skådespelaren och antalet filmer den medverkat i
    }
}