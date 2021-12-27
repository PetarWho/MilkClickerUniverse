using System.Collections;
using System;
using UnityEngine;
using UnityEngine.UI;

public class PerSecPerClick : MonoBehaviour
{
    public GameObject PerClickDisplay;
    public GameObject PerSecDisplay;


    void Update()
    {
        ///////////////////////////////////////////////////////////
        ///////////////////// PER CLICK ///////////////////////////
        ///////////////////////////////////////////////////////////
        
        if (ClickTheMilk.perClick < 1000)
        {PerClickDisplay.GetComponent<Text>().text = Math.Round(ClickTheMilk.perClick, 1) + "L/c";}
        else if (ClickTheMilk.perClick >=1000 && ClickTheMilk.perClick<1000000)
        {PerClickDisplay.GetComponent<Text>().text = Math.Round(ClickTheMilk.perClick/1000, 2) +"K L/c";}
        else if (ClickTheMilk.perClick >=1000000 && ClickTheMilk.perClick<10000000)
        {PerClickDisplay.GetComponent<Text>().text = Math.Round(ClickTheMilk.perClick/1000000, 2) + "M L/c";}
        else if (ClickTheMilk.perClick >=1000000000 && ClickTheMilk.perClick<10000000000)
        {PerClickDisplay.GetComponent<Text>().text = Math.Round(ClickTheMilk.perClick/1000000000, 2) + "B L/c";}
        else if (ClickTheMilk.perClick >=1000000000000 && ClickTheMilk.perClick<1000000000000000)
        {PerClickDisplay.GetComponent<Text>().text = Math.Round(ClickTheMilk.perClick / 1000000000000, 2) + "T L/c";}
        else if (ClickTheMilk.perClick >=1000000000000000 && ClickTheMilk.perClick<1000000000000000000)
        {PerClickDisplay.GetComponent<Text>().text = Math.Round(ClickTheMilk.perClick/1000000000000000, 2) + "q L/c";}
        else if (ClickTheMilk.perClick >=1000000000000000000 && ClickTheMilk.perClick<9999999999999999999)
        {PerClickDisplay.GetComponent<Text>().text = Math.Round(ClickTheMilk.perClick/1000000000000000000, 2) + "Q L/c";}
        else
        {PerClickDisplay.GetComponent<Text>().text = "Too Much Milk!";}
        
        ///////////////////////////////////////////////////////////
        ///////////////////// PER SEC /////////////////////////////
        ///////////////////////////////////////////////////////////
        
        if (ClickTheMilk.perSec < 1000)
        {
            PerSecDisplay.GetComponent<Text>().text = Math.Round(ClickTheMilk.perSec, 1) + "L/s";
        }
    }
}
