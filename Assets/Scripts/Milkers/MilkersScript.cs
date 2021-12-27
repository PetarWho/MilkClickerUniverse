using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class MilkersScript : MonoBehaviour
{
    public GameObject uiDisplayCost;
    public GameObject uiDisplayCost2;

    private int timesUpgraded;
    public static double cost;
    public static double cost2;

    //milkers int///

    public static int milker1 = 0;

    /// //// ///
    public void Milkers(int milker)
    {
        if (cost != 0)
        {
            switch (milker)
            {
                case 1:
                    if (ClickTheMilk.liters >= cost)
                    {
                        ClickTheMilk.liters -= cost;
                        cost *= 1.5;
                        MilkersMechanics.milkIncrease += 1;
                        milker1 = 1;
                    }

                    break;
                case 2:
                    if (ClickTheMilk.liters >= cost2)
                    {
                        ClickTheMilk.liters -= cost2;
                        cost2 *= 1.5;
                    }

                    break;
            }
        }
    }

    private double MilkersPrice(double price)
    {
        if (ClickTheMilk.liters >= price)
        {
            ClickTheMilk.liters -= price;
            price *= 1.66;
            return price;
        }
        return 0;
    }


    void Update()
        {
            uiDisplayCost.GetComponent<Text>().text = Math.Round(cost).ToString();
            uiDisplayCost2.GetComponent<Text>().text = Math.Round(cost2).ToString();
        }
    }