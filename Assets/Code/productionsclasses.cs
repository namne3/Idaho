using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Production //Basklass för production som innehåller information om bolagets namn och land
{
    protected string companyName;
    protected string country;

    public Production(string companyName, string country) //Konstruktorn används för att tilldela värden till companyName och country när objekt av production skapas
    {
        this.companyName = companyName;
        this.country = country;
    }

    public virtual string GetInfo() //Denna metod returnerar information om företaget
    {
        return $"{companyName}, {country}";
    }
}


//Subklass som ärver från Production
public class HollywoodProduction : Production
{
    private int budgetInMillions; //Budgeten till filmen i miljoner

    //Konstruktor som tar emot namn, land och budget
    public HollywoodProduction(string companyName, string country, int budgetInMillions)
        : base(companyName, country) //Anropar basklassens konstruktor
    {
        this.budgetInMillions = budgetInMillions; //Detta anger budgeten
    }

    //Override används för att ändra på GetInfo metoden och lägga till information om budget
    public override string GetInfo()
    {
        return base.GetInfo() + $", Budget: {budgetInMillions} miljoner USD"; //Returnerar information om produktionen av filmen och dess budget
    }
}

//Subklass som ärver från Production
public class IndieProduction : Production
{
    private string festivalName; //Namnet på festivalen där filmen visades

    //Konstruktor som tar emot namn, land och festival
    public IndieProduction(string companyName, string country, string festivalName)
        : base(companyName, country) //Anropar basklassens konstruktor
    {
        this.festivalName = festivalName; //Anger festivalens namn
    }


    //Override används för att ändra på GetInfo medtoden och lägga till information om festivalen
    public override string GetInfo()
    {
        return base.GetInfo() + $", Visad på {festivalName}"; //Returnerar information om produktionen av filmen samt festivalen
    }
}
