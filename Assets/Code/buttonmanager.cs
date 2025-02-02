using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro; // Importerar TMP för att kunna använda dess komponenter i unity

public class buttonmanager : MonoBehaviour
{
    //Referenser till buttons, moviemanager och panelen
    public Button africanKungFuButton;
    public Button killerBeanButton;
    public Button spiceBoisButton;

    public moviemanager movieManager;
    public GameObject movieInfoPanel; 
    public TMP_Text movieInfoText; 
    public Button closeButton; 

    void Start()
    {
    //Kopplar knapparna till respektive funktioner
        africanKungFuButton.onClick.AddListener(() => ShowMovieInfo(0)); //När knappen klickas visas informationen om första filmen och så vidare
        killerBeanButton.onClick.AddListener(() => ShowMovieInfo(1));
        spiceBoisButton.onClick.AddListener(() => ShowMovieInfo(2));

        closeButton.onClick.AddListener(CloseMovieInfoPanel); //När "closebutton" klickas stängs informationen för filmerna ner
    }

    void ShowMovieInfo(int movieIndex) // Metod för att informationen för den film man klickat på ska visas
    {
        movieInfoText.text = movieManager.GetMovieInfo(movieIndex); // Hämtar och visar information om den valda filmen

        movieInfoPanel.SetActive(true); //Gör infopanelen synlig
    }

    // Metod för att stänga panelen
    void CloseMovieInfoPanel()
    {
        movieInfoPanel.SetActive(false);
    }
}