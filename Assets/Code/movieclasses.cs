using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Movie //Basklass för movie som innehåller information om filmens titel, år den kom ut, regissör och företag som producerat den
{
    protected string title;
    protected string releaseYear;
    protected Director director; //Använder sig av director och production klasserna för att hämta information om regissören och företaget
    protected Production production;
    //De är protected vilket innebär att dessa kan nås av underklasserna men inte utanför denna klass

    //Konstruktor för att skapa ett nytt filmobjekt med titel, år, regissör och företag som producerat filmens
    public Movie(string title, string releaseYear, Director director, Production production)
    {
        this.title = title;
        this.releaseYear = releaseYear;
        this.director = director;
        this.production = production;
    }

    //Denna metod returnerar information om filmen
    public virtual string GetInfo()
    {
        return $"{title} ({releaseYear})\nRegisserad av {director.GetInfo()}\nProducerad av {production.GetInfo()}";
    }
}

//Subklass som ärver från Movie och representerar ActionMovies
public class ActionMovie : Movie
{
    private bool hasTerrorists; //Anger om filmen har terrorister som en del av handlingen

    //Konstruktor som skpar en ActionMovie med titel, releaseår, regissör, företag och om filmen har terrorister
    public ActionMovie(string title, string releaseYear, Director director, Production production, bool hasTerrorists)
        : base(title, releaseYear, director, production) //Anropar basklassens konstruktor
    {
        this.hasTerrorists = hasTerrorists; //Sätter värdet för om filmen har terrorister
    }

    //Override används för att ändra på GetInfo metoden och lägga till information om terrorister
    public override string GetInfo()
    {
        string terroristText = hasTerrorists ? "Ja" : "Nej.";
        return base.GetInfo() + $"\nTerrorister: {terroristText}"; //Retunerar information om filmen och om det finns terrorister med
    }
}

//Subklass som ärver från Movie och representerar AnimatedMovies
public class AnimatedMovie : Movie
{
    private string animationStudio; //Namnet på animationsstudion som gjorde filmen

    //Konstruktor som skapar en AnimatedMovie med titel, releaseår regisssör, företag och animationsstudio
    public AnimatedMovie(string title, string releaseYear, Director director, Production production, string animationStudio)
        : base(title, releaseYear, director, production) //Anropar basklassens konstruktor
    {
        this.animationStudio = animationStudio; //Sätter värdet för animationsstudion
    }

    //Override används för att ändra på GetInfo metoden och lägga till information om animationsstudio
    public override string GetInfo()
    {
        return base.GetInfo() + $"\nAnimerad av: {animationStudio}"; //Returnerar information om filmen och dess animationsstudio
    }
}

//Kod av Felix