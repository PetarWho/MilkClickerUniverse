using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveSystem : MonoBehaviour
{
    public static void Save()
    {
        PlayerPrefs.SetString("liters", ClickTheMilk.liters.ToString());
        PlayerPrefs.SetString("multiplier", ClickTheMilk.multiplier.ToString());
        PlayerPrefs.SetString("perClick", ClickTheMilk.perClick.ToString());
        PlayerPrefs.SetString("costPerClick", UpgradePerClickButton.cost.ToString());
        PlayerPrefs.SetString("perClickUpgradeMultiplier", UpgradePerClickButton.PerClickUpgradeMultiplier.ToString());
        PlayerPrefs.SetString("perSec", ClickTheMilk.perSec.ToString());
        PlayerPrefs.SetString("bigMilkBox", ClickTheMilk.BigMilkBox.ToString());
        PlayerPrefs.SetString("bigMilkBoxCost", UpgradePerClickButton.BigMilkBoxUpgradeCost.ToString());
        PlayerPrefs.SetString("timesUpgradedPerClick", UpgradePerClickButton.timesUpgradedPerClick.ToString());
        PlayerPrefs.SetString("timesUpgradedBigSip", UpgradePerClickButton.timesUpgradedBigSip.ToString());
        PlayerPrefs.SetString("peridots", SlideMenuShop.peridots.ToString());
        PlayerPrefs.SetString("MilkersCost", MilkersScript.cost.ToString());
        PlayerPrefs.SetString("MilkersCost2", MilkersScript.cost2.ToString());
        PlayerPrefs.SetString("peridotChanceCost", UpgradePerClickButton.chanceForPeridotsOnClickCost.ToString());
        PlayerPrefs.SetString("timesUpgradedPeridotChance", UpgradePerClickButton.timesUpgradedPeridotChance.ToString());
        PlayerPrefs.SetString("milkIncrease", MilkersMechanics.milkIncrease.ToString());
        PlayerPrefs.SetString("internalCookie", MilkersMechanics.internalIncrease.ToString());
        PlayerPrefs.SetString("generatingMilkBool", MilkersMechanics.generatingMilkBool.ToString());
        PlayerPrefs.SetString("milker1", MilkersScript.milker1.ToString());

    }
    public static void Load()
     {
         ClickTheMilk.liters = double.Parse(PlayerPrefs.GetString("liters", "0"));
         ClickTheMilk.multiplier = double.Parse(PlayerPrefs.GetString("multiplier", "1")); 
         ClickTheMilk.perClick = double.Parse(PlayerPrefs.GetString("perClick", "1"));
         UpgradePerClickButton.cost = double.Parse(PlayerPrefs.GetString("costPerClick", "25"));
         UpgradePerClickButton.PerClickUpgradeMultiplier = double.Parse(PlayerPrefs.GetString("perClickUpgradeMultiplier", "1.5"));
         ClickTheMilk.perSec = double.Parse(PlayerPrefs.GetString("perSec", "0"));
         ClickTheMilk.BigMilkBox = int.Parse(PlayerPrefs.GetString("bigMilkBox", "0"));
         UpgradePerClickButton.BigMilkBoxUpgradeCost = int.Parse(PlayerPrefs.GetString("bigMilkBoxCost", "300"));
         UpgradePerClickButton.timesUpgradedPerClick = int.Parse(PlayerPrefs.GetString("timesUpgradedPerClick", "1"));
         UpgradePerClickButton.timesUpgradedBigSip = int.Parse(PlayerPrefs.GetString("timesUpgradedBigSip", "0"));
         SlideMenuShop.peridots = int.Parse(PlayerPrefs.GetString("peridots", "0"));
         MilkersScript.cost = double.Parse(PlayerPrefs.GetString("MilkersCost", "100"));
         MilkersScript.cost2 = double.Parse(PlayerPrefs.GetString("MilkersCost2", "500"));
         UpgradePerClickButton.chanceForPeridotsOnClickCost = int.Parse(PlayerPrefs.GetString("peridotChanceCost", "700"));
         UpgradePerClickButton.timesUpgradedPeridotChance = int.Parse(PlayerPrefs.GetString("timesUpgradedPeridotChance", "0"));
         UpgradePerClickButton.timesUpgradedPeridotChance = int.Parse(PlayerPrefs.GetString("timesUpgradedPeridotChance", "0"));
         MilkersMechanics.milkIncrease = double.Parse(PlayerPrefs.GetString("milkIncrease", "0"));
         MilkersMechanics.internalIncrease = double.Parse(PlayerPrefs.GetString("internalCookie", "0"));
         MilkersMechanics.generatingMilkBool = int.Parse(PlayerPrefs.GetString("generatingMilk", "0"));
         MilkersScript.milker1 = int.Parse(PlayerPrefs.GetString("milker1", "0"));

     }
}
    