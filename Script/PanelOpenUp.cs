using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PanelOpenUp : MonoBehaviour
{
    public GameObject Panel;
    public GameObject button1,button2,button3;

    public void OpenPanel()
    {
        if(Panel!= null)
        {
            bool isActive = Panel.activeSelf;
            Panel.SetActive(!isActive);
            if(button1 && button2 && button3 != null)
            {
                bool btnactive1 = button1.activeSelf;
                button1.SetActive(!btnactive1);
                bool btnactive2 = button2.activeSelf;
                button2.SetActive(!btnactive2);
                bool btnactive3 = button3.activeSelf;
                button3.SetActive(!btnactive3);
            }
        }
     
    }
}
