using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movies : MonoBehaviour
{
    class Movie
    {
        protected string title;
        protected int year;
        protected string director;

        public Movie(string _title, int _year, string _director)
        {
            title = _title;
            year = _year;
            director = _director;
        }

        public string GetInfo()
        {
            return $"{title} by {director} - {year}";
        }
    }

    void Start()
    {
        Movie movie1 = new Movie("Killerbean", 2025, "Gud");

        Debug.Log(movie1.GetInfo());
    }
}

//Kod av Johan