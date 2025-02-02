using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro; // Importerar TMP f�r att kunna anv�nda dess komponenter i unity

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
        africanKungFuButton.onClick.AddListener(() => ShowMovieInfo(0)); //N�r knappen klickas visas informationen om f�rsta filmen och s� vidare
        killerBeanButton.onClick.AddListener(() => ShowMovieInfo(1));
        spiceBoisButton.onClick.AddListener(() => ShowMovieInfo(2));

        closeButton.onClick.AddListener(CloseMovieInfoPanel); //N�r "closebutton" klickas st�ngs informationen f�r filmerna ner
    }

    void ShowMovieInfo(int movieIndex) // Metod f�r att informationen f�r den film man klickat p� ska visas
    {
        movieInfoText.text = movieManager.GetMovieInfo(movieIndex); // H�mtar och visar information om den valda filmen

        movieInfoPanel.SetActive(true); //G�r infopanelen synlig
    }

    // Metod f�r att st�nga panelen
    void CloseMovieInfoPanel()
    {
        movieInfoPanel.SetActive(false);
    }
}