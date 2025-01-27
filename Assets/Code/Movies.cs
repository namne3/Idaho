using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Code : MonoBehaviour
{
    class movies
    {
        string title;
        int year;
        string director;

        public movies(string_title, int_year, string_director)
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
}
//Code by Johan