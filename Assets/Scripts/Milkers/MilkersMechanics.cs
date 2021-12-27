using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class MilkersMechanics : MonoBehaviour
{
    public static int generatingMilkBool;
    public static double milkIncrease;
    public static double internalIncrease;

    private void Update()
    {
        internalIncrease = milkIncrease;
    }

    
    public static IEnumerator MilkGenerating()
       {
           ClickTheMilk.liters = ClickTheMilk.liters + Math.Round((internalIncrease),2);
           yield return new WaitForSeconds(1);
           generatingMilkBool = 0;
       }
}
