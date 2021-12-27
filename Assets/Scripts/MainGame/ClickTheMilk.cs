using System;
using UnityEngine;
using UnityEngine.UI;

public class ClickTheMilk : MonoBehaviour
{
    public GameObject litersDisplay;
    public GameObject bigSipAnim;

    
    public static double liters;
    public static double perClick;
    public static double perSec;
    public static double multiplier;
    public static int BigMilkBox;
    public static int PeridotChancePerClick;
    

    public void Start()
    {
        SaveSystem.Load();
    }

    public void Clicker()
    {
        //Big sip and Main//
        int randomNumber = UnityEngine.Random.Range(BigMilkBox, 100);
        if (randomNumber == 100)
        {
            bigSipAnim.GetComponent<Text>().enabled = true;
            bigSipAnim.GetComponent<Animation>().Play("BigSipAnim");
            liters += 2 * perClick;
        }
        else
        {
            liters += perClick;
        }
        
        //peridotChance//
        int randomNumberPeridots = UnityEngine.Random.Range(PeridotChancePerClick, 100);
        if (randomNumber == BigMilkBox && randomNumber != 0)
        {
            bigSipAnim.GetComponent<Text>().enabled = true;
            bigSipAnim.GetComponent<Animation>().Play("BigSipAnim");
            SlideMenuShop.peridots++;

        }
        
    }

    void Update()
    {
        MilkersMechanics.internalIncrease = MilkersMechanics.milkIncrease;
        if (MilkersScript.milker1 == 1)
        {
            if (MilkersMechanics.generatingMilkBool == 0)
            {
                MilkersMechanics.generatingMilkBool = 1;
                StartCoroutine(MilkersMechanics.MilkGenerating());
            }
        }
        if(liters<1000)
        {litersDisplay.GetComponent<Text>().text = Math.Round(liters).ToString();}
        else if (liters >= 1000&&liters<1000000)
        {litersDisplay.GetComponent<Text>().text = Math.Round(liters/1000, 2) + "K";}
        else if (liters >= 1000000&&liters<1000000000)
        {litersDisplay.GetComponent<Text>().text = Math.Round(liters/1000000, 2) + "M";}
        else if (liters >= 1000000000&&liters<1000000000000)
        {litersDisplay.GetComponent<Text>().text = Math.Round(liters/1000000000, 2) + "B";}
        else if (liters >= 1000000000000&&liters<1000000000000000)
        {litersDisplay.GetComponent<Text>().text = Math.Round(liters/1000000000000, 2) + "T";}
        else if (liters >= 1000000000000000 && liters < 1000000000000000000)
        {litersDisplay.GetComponent<Text>().text = Math.Round(liters / 1000000000000000, 2) + "q";}
        else if (liters >= 1000000000000000000&&liters<9999999999999999999)
        {litersDisplay.GetComponent<Text>().text = Math.Round(liters/1000000000000000000, 2) + "Q";}
        else
        {litersDisplay.GetComponent<Text>().text = "You are milked! GG!";}
        
        if(Input.GetKeyDown(KeyCode.R))
        {
            PlayerPrefs.DeleteAll();
            SaveSystem.Load();
        }
        else
        {
            SaveSystem.Save();
        }
    }
}
