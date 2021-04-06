using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoC : MonoBehaviour
{
    public GameObject panel;
    public GameObject button1;

    public void BukaPanel()
    {
        if(panel != null)
        {
            bool IsActive = panel.activeSelf;
            panel.SetActive(!IsActive);
        }
    }


}
