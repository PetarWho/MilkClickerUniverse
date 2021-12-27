using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class UpgradePerClickButton : MonoBehaviour
{ 
    //UI
    public GameObject uiDisplayCost;
    public GameObject uiDisplayPerClickUpgrade;
    public GameObject perClickUpgradeTimes;
    
    public GameObject bigMilkBoxUiDisplayCost;
    public GameObject bigMilkBoxUiUpgrade;
    public GameObject BigSipTimesUpgraded;
    
    public GameObject uiDisplayPeridotChanceCost;
    public GameObject uiDisplayPeridotChanceUpgrade;
    public GameObject peridotChanceTimesUpgraded;
    
    //upgrades

    public static double PerClickUpgradeMultiplier;
    public static double cost;
    
    public static double BigMilkBoxUpgradeCost;
    
    public static double chanceForPeridotsOnClickCost;
    
    // times upgraded
    public static int timesUpgradedPerClick;
    public static int timesUpgradedBigSip;
    public static int timesUpgradedPeridotChance;

    //Buttons
    public GameObject buttonBigSip;
    public GameObject buttonPeridotChance;
    public void UpgradePerClick(int upgradeNum)
    {
        switch (upgradeNum)
        {
            case 1 :
            if (ClickTheMilk.liters >= cost)
            {
                ClickTheMilk.perClick += 1;
                ClickTheMilk.liters -= cost;
                cost *= PerClickUpgradeMultiplier;
                timesUpgradedPerClick++;
            }
            break;
            
            case 2:
                if (timesUpgradedBigSip < 100)
                { if (ClickTheMilk.liters >= BigMilkBoxUpgradeCost)
                    {
                        ClickTheMilk.BigMilkBox++;
                        ClickTheMilk.liters -= BigMilkBoxUpgradeCost;
                        BigMilkBoxUpgradeCost *= 2;
                        timesUpgradedBigSip++;
                    }
                }
                else
                {
                    buttonBigSip.GetComponent<Button>().enabled = false;
                }
                break;
            
            case 3:
                if (timesUpgradedPeridotChance < 97)
                { if (ClickTheMilk.liters >= BigMilkBoxUpgradeCost)
                    {
                        ClickTheMilk.BigMilkBox++;
                        ClickTheMilk.liters -= chanceForPeridotsOnClickCost;
                        chanceForPeridotsOnClickCost *= 2;
                        timesUpgradedPeridotChance++;
                    }
                }
                else
                {
                    buttonPeridotChance.GetComponent<Button>().enabled = false;
                }
                break;
            
        }
    }
    void Update()
    {
        ///////////////////////////////////////////////////////////
        ///////////////////// PER CLICK ///////////////////////////
        ///////////////////////////////////////////////////////////
        if (cost < 1000)
        {uiDisplayCost.GetComponent<Text>().text = Math.Round(cost).ToString();}
        else if (cost >= 1000 && cost<1000000)
        {uiDisplayCost.GetComponent<Text>().text = Math.Round((cost/1000) ,2) + "K";}
        else if (cost >= 1000000 && cost<1000000000)
        {uiDisplayCost.GetComponent<Text>().text = Math.Round((cost/1000000) ,2) + "M";}
        else if (cost >= 1000000000 && cost<1000000000000)
        {uiDisplayCost.GetComponent<Text>().text = Math.Round((cost/1000000000) ,2) + "B";}
        else if (cost >= 1000000000000 && cost<1000000000000000)
        {uiDisplayCost.GetComponent<Text>().text = Math.Round((cost/1000000000000) ,2) + "T";}
        else if (cost >= 1000000000000000 && cost<1000000000000000000)
        {uiDisplayCost.GetComponent<Text>().text = Math.Round((cost/1000000000000000) ,2) + "q";}
        else if (cost >= 1000000000000000000 && cost<9999999999999999999)
        {uiDisplayCost.GetComponent<Text>().text = Math.Round((cost/1000000000000000000) ,2) + "Q";}
        else
        {uiDisplayCost.GetComponent<Text>().text = "GG!";}
        
        ///////////////////////////////////////////////////////////
        
        uiDisplayPerClickUpgrade.GetComponent<Text>().text = "+" + 1 + "L Per Click";
        
        ///////////////////////////////////////////////////////////
        
        if (timesUpgradedPerClick < 1000)
        {perClickUpgradeTimes.GetComponent<Text>().text = " x" + timesUpgradedPerClick;}
        else if (timesUpgradedPerClick >= 1000 && timesUpgradedPerClick<1000000)
        {perClickUpgradeTimes.GetComponent<Text>().text = " x" + Math.Round(((double)timesUpgradedPerClick/1000) , 2) + "K";}
        else if (timesUpgradedPerClick >= 1000000 && timesUpgradedPerClick<1000000000)
        {perClickUpgradeTimes.GetComponent<Text>().text = " x" + Math.Round(((double)timesUpgradedPerClick/1000000) , 2) + "M";}
        else if (timesUpgradedPerClick >= 1000000000 && timesUpgradedPerClick<1000000000000)
        {perClickUpgradeTimes.GetComponent<Text>().text = " x" + Math.Round(((double)timesUpgradedPerClick/1000000000) , 2) + "B";}
        else if (timesUpgradedPerClick >= 1000000000000 && timesUpgradedPerClick<1000000000000000)
        {perClickUpgradeTimes.GetComponent<Text>().text = " x" + Math.Round(((double)timesUpgradedPerClick/1000000000000) , 2) + "T";}
        else if (timesUpgradedPerClick >= 1000000000000000 && timesUpgradedPerClick<1000000000000000000)
        {perClickUpgradeTimes.GetComponent<Text>().text = " x" + Math.Round(((double)timesUpgradedPerClick/1000000000000000) , 2) + "q";}
        else if (timesUpgradedPerClick >= 1000000000000000000 && (double)timesUpgradedPerClick<9999999999999999999)
        {perClickUpgradeTimes.GetComponent<Text>().text = " x" + Math.Round(((double)timesUpgradedPerClick/1000000000000000000) , 2) + "Q";}
        else
        {perClickUpgradeTimes.GetComponent<Text>().text = "No Life? ";}
        
        ///////////////////////////////////////////////////////////
        ///////////////////// BIG SIP /////////////////////////////
        ///////////////////////////////////////////////////////////

        if (timesUpgradedBigSip < 100)
        {
            if (BigMilkBoxUpgradeCost < 1000)
            {bigMilkBoxUiDisplayCost.GetComponent<Text>().text = BigMilkBoxUpgradeCost.ToString();}
            else if (BigMilkBoxUpgradeCost >= 1000 && BigMilkBoxUpgradeCost<1000000) 
            {bigMilkBoxUiDisplayCost.GetComponent<Text>().text = Math.Round(BigMilkBoxUpgradeCost/1000, 2) + "K";}
            else if (BigMilkBoxUpgradeCost >= 1000000 && BigMilkBoxUpgradeCost<1000000000) 
            {bigMilkBoxUiDisplayCost.GetComponent<Text>().text = Math.Round(BigMilkBoxUpgradeCost/1000000, 2) + "M";}
            else if (BigMilkBoxUpgradeCost >= 1000000000 && BigMilkBoxUpgradeCost<1000000000000) 
            {bigMilkBoxUiDisplayCost.GetComponent<Text>().text = Math.Round(BigMilkBoxUpgradeCost/1000000000, 2) + "B";}
            else if (BigMilkBoxUpgradeCost >= 1000000000000 && BigMilkBoxUpgradeCost<1000000000000000) 
            {bigMilkBoxUiDisplayCost.GetComponent<Text>().text = Math.Round(BigMilkBoxUpgradeCost/1000000000000, 2) + "T";}
            else if (BigMilkBoxUpgradeCost >= 1000000000000000 && BigMilkBoxUpgradeCost<1000000000000000000) 
            {bigMilkBoxUiDisplayCost.GetComponent<Text>().text = Math.Round(BigMilkBoxUpgradeCost/1000000000000000, 2) + "q";}
            else if (BigMilkBoxUpgradeCost >= 1000000000000000000 && BigMilkBoxUpgradeCost < 9999999999999999999)
            {bigMilkBoxUiDisplayCost.GetComponent<Text>().text = Math.Round(BigMilkBoxUpgradeCost / 1000000000000000000, 2) + "Q";}
            else
            {bigMilkBoxUiDisplayCost.GetComponent<Text>().text = "Too much";}
            
            /////////////////////////////////////////////
            
            bigMilkBoxUiUpgrade.GetComponent<Text>().text = "More chance for Big Sip";
            BigSipTimesUpgraded.GetComponent<Text>().text = " x" + timesUpgradedBigSip;
        }
        else
        {
            bigMilkBoxUiDisplayCost.GetComponent<Text>().text = "";
            bigMilkBoxUiUpgrade.GetComponent<Text>().text = "MAX";
        }
        
        ///////////////////////////////////////////////////////////
        ///////////////////// PERIDOTS CHANCE /////////////////////
        ///////////////////////////////////////////////////////////
        
        if (timesUpgradedPeridotChance < 97)
        { 
        if (chanceForPeridotsOnClickCost < 1000)
        {uiDisplayPeridotChanceCost.GetComponent<Text>().text = Math.Round(chanceForPeridotsOnClickCost).ToString();}
        else if (chanceForPeridotsOnClickCost >= 1000 && chanceForPeridotsOnClickCost<1000000)
        {uiDisplayPeridotChanceCost.GetComponent<Text>().text = Math.Round((chanceForPeridotsOnClickCost/1000) ,2) + "K";}
        else if (chanceForPeridotsOnClickCost >= 1000000 && chanceForPeridotsOnClickCost<1000000000)
        {uiDisplayPeridotChanceCost.GetComponent<Text>().text = Math.Round((chanceForPeridotsOnClickCost/1000000) ,2) + "M";}
        else if (chanceForPeridotsOnClickCost >= 1000000000 && chanceForPeridotsOnClickCost<1000000000000)
        {uiDisplayPeridotChanceCost.GetComponent<Text>().text = Math.Round((chanceForPeridotsOnClickCost/1000000000) ,2) + "B";}
        else if (chanceForPeridotsOnClickCost >= 1000000000000 && chanceForPeridotsOnClickCost<1000000000000000)
        {uiDisplayPeridotChanceCost.GetComponent<Text>().text = Math.Round((chanceForPeridotsOnClickCost/1000000000000) ,2) + "T";}
        else if (chanceForPeridotsOnClickCost >= 1000000000000000 && chanceForPeridotsOnClickCost<1000000000000000000)
        {uiDisplayPeridotChanceCost.GetComponent<Text>().text = Math.Round((chanceForPeridotsOnClickCost/1000000000000000) ,2) + "q";}
        else if (chanceForPeridotsOnClickCost >= 1000000000000000000 && chanceForPeridotsOnClickCost<9999999999999999999)
        {uiDisplayPeridotChanceCost.GetComponent<Text>().text = Math.Round((chanceForPeridotsOnClickCost/1000000000000000000) ,2) + "Q";}
        else
        {uiDisplayPeridotChanceCost.GetComponent<Text>().text = "GG!";}

        /////////////////////////////////////////////////////
        uiDisplayPeridotChanceUpgrade.GetComponent<Text>().text = "+Chance for peridot on click";
        peridotChanceTimesUpgraded.GetComponent<Text>().text = " x" + timesUpgradedPeridotChance;
    }
        else
        {
            bigMilkBoxUiDisplayCost.GetComponent<Text>().text = "";
            bigMilkBoxUiUpgrade.GetComponent<Text>().text = "MAX";
        }
}
}