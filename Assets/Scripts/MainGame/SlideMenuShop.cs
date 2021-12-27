using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class SlideMenuShop : MonoBehaviour
{
    public GameObject PanelMenu;

    public GameObject peridotsDisplay;

    public static int peridots;

    public void ShowHideMenu()
    {
        Animator animator = PanelMenu.GetComponent<Animator>();
        if (animator != null)
        {
            bool isOpen = animator.GetBool("show");
            animator.SetBool("show", !isOpen);
        }
    }

    private void Update()
    {
        if (peridots < 1000)
        {peridotsDisplay.GetComponent<Text>().text = peridots.ToString();}
        else if (peridots >= 1000 && peridots <1000000)
        {peridotsDisplay.GetComponent<Text>().text = Math.Round(((double)peridots/1000),2) + "K";}
        else if (peridots >= 1000000 && peridots <1000000000)
        {peridotsDisplay.GetComponent<Text>().text = Math.Round(((double)peridots/1000000),2) + "M";}
        else if (peridots >= 1000000000 && peridots <1000000000000)
        {peridotsDisplay.GetComponent<Text>().text = Math.Round(((double)peridots/1000000000),2) + "B";}
        else if (peridots >= 1000000000000 && peridots <1000000000000000)
        {peridotsDisplay.GetComponent<Text>().text = Math.Round(((double)peridots/1000000000000),2) + "T";}
        else if (peridots >= 1000000000000000 && peridots <1000000000000000000)
        {peridotsDisplay.GetComponent<Text>().text = Math.Round(((double)peridots/1000000000000000),2) + "q";}
        else if (peridots >= 1000000000000000000 && (double)peridots < 9999999999999999999)
        {peridotsDisplay.GetComponent<Text>().text = Math.Round(((double)peridots/1000000000000000000),2) + "Q";}
        else
        {peridotsDisplay.GetComponent<Text>().text = "No way!";}
    }

}
