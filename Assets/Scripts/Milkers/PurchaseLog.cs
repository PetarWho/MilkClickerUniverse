using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurchaseLog : MonoBehaviour
{
    public GameObject AutoMilk;

    public void StartAutoMilk(int num)
    {
        switch (num)
        {
        case 1:
            AutoMilk.SetActive(true);
            break;
        case 2:
            AutoMilk.SetActive(true);
            break;
        }
        
    }
}
