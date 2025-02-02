using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moviemanager : MonoBehaviour
{
    //Listan lagrar alla filmer
    private List<Movie> movies = new List<Movie>();

    void Start()
    {
        //Skapar objekt f�r regiss�rer, produktionerna och filmerna
        Director nkansah = new Director("Samuel K. Jackson", 80, 50);
        Director jeffLew = new Director("Johan Kallert", 12, 10);
        Director ivarSk�nberg = new Director("Globby", 20, 4);

        Production africanKungFuProduction = new HollywoodProduction("African Productions", "Ghana", 150);
        Production killerBeanProduction = new IndieProduction("Killer Beans", "USA", "Oscar-galan");
        Production spiceBoisProduction = new HollywoodProduction("Spice Bois Studios", "Sweden", 20);

        movies.Add(new ActionMovie("African Kung-Fu Nazis", "2019", nkansah, africanKungFuProduction, false));
        movies.Add(new AnimatedMovie("Killer Bean Forever", "2008", jeffLew, killerBeanProduction, "123Movies"));
        movies.Add(new ActionMovie("Spice Bois: Da Movie", "2025", ivarSk�nberg, spiceBoisProduction, true));
    }

    //H�mtar och returnerar information om en film utifr�n dess index i listan
    public string GetMovieInfo(int movieIndex)
    {
        if (movieIndex >= 0 && movieIndex < movies.Count) //Kollar om indexet �r korrekt
        {
            return movies[movieIndex].GetInfo(); //H�mtar och returnerar information p� det valda indexet
        }
        else
        {
            return "Fel: Ingen film hittades."; //Felmeddelande skickas ut ifall indexet inte �r korrekt
        }
    }
}
