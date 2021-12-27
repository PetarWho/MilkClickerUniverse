using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeridotShopTrades : MonoBehaviour
{
    public void PeridotTrade(int Trade)
    {
        switch (Trade)
        {
           case 1:
               if (ClickTheMilk.liters >= 100000)
               {
                   SlideMenuShop.peridots++;
                   ClickTheMilk.liters -= 100000;
               }
               break;
           case 2:
                if (ClickTheMilk.liters >= 1000000)
                {
                    SlideMenuShop.peridots += 11;
                    ClickTheMilk.liters -= 1000000;
                }
                break;
           case 3:
               if (ClickTheMilk.liters >= 10000000)
               {
                   SlideMenuShop.peridots += 11;
                   ClickTheMilk.liters -= 10000000;
               }
               break;
        }
    }
        
}
